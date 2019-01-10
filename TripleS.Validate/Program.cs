using McMaster.Extensions.CommandLineUtils;
using System;
using TripleS.NET;

namespace TripleS.Validate {
	class Program {
		public static int Main(string[] args)
			=> CommandLineApplication.Execute<Program>(args);

		[Option(Description = "Triple-S file to validate (fullpath)", LongName = "filename", ShortName = "f")]
		public string TripleSFilename { get; }

		[Option(ShortName = "v")]
		public bool Verbose { get; }

		private void OnExecute() {
			var subject = TripleSFilename;
			if (string.IsNullOrEmpty(TripleSFilename)) {
				Console.WriteLine($"Must specify a valid Triple-S file");
				Console.ReadLine();
				return;
			}


			try {
				var data = S3Serializer.FromFile(TripleSFilename);
				Console.WriteLine(data.Survey.Name);
				Console.WriteLine(data.Survey.Version);
				Console.WriteLine(data.Survey.Title.GetText());

				var record = data.Survey.Record;
				foreach (var s3var in record.Variables) {

					var error = S3Validator.ValidateVariable(s3var);

					if (!string.IsNullOrEmpty(error)) {

						Console.WriteLine(s3var.Name + " " + s3var.Label.GetText());

						Console.ForegroundColor = ConsoleColor.Red;
						
						Console.WriteLine(error);

						Console.ResetColor();
					}
				}

				} catch (Exception ex) {
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}

			//Console.ReadLine();
		}
	}

	public class S3Validator {
		public S3Root Root { get; set; }

		public static string ValidateVariable(S3Variable s3var) {

			if (s3var.Type == S3Type.Single || s3var.Type == S3Type.Multiple) {
				if (s3var.Values.Count == 0) {
					return $"Variable: {s3var.Name}. At least one <values> element is required for single or multiple types.";
				}

				if (s3var.Values[0] is S3Range) {
					var range = s3var.Values[0] as S3Range;
					var from = ParseInt(range.From);
					var to = ParseInt(range.To);
					if (from < 0) {
						return $"Variable: {s3var.Name}. Range 'from' value {range.From} is invalid - must be a positive integer when variable is of type 'single' or 'multiple'.";
					}
					if (to < 0) {
						return $"Variable: {s3var.Name}. Range 'to' value {range.To} is invalid - must be a positive integer when variable is of type 'single' or 'multiple'.";
					}
				}

			}

			return "";
		}

		public static Int32 ParseInt(string s, int defaultValue = 0) {
			return Int32.TryParse(s, out int result) ? result : defaultValue;
		}
	}
}
