using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TripleS.NET {

	/// <summary>
	/// This class takes a Triple-S survey and a fixed format data file and parses each line into
	/// a dictionary where the keys are the variable ids and the values are field values at the 
	/// specified positions.
	/// </summary>
	public class S3FixedFormatReader : IDisposable {
		private readonly S3Root s3Root;
		private readonly string filename;
		private readonly StreamReader fileReader;

		/// <summary>
		/// Initialize the reader with a Triple-S survey and the full path to the data file.
		/// </summary>
		/// <param name="root">Triple-S survey with the variables specifying fixed field positions</param>
		/// <param name="filepath"></param>
		public S3FixedFormatReader(S3Root root, string filepath) {

			if (root.Survey.Record.DataFormat != S3Format.Fixed) {
				throw new ArgumentException("Triple-S survey data format must be fixed field");
			}
			if (!File.Exists(filepath)) {
				throw new ArgumentException($"Specified file {filepath} does not exist");
			}

			s3Root = root;
			filename = filepath;
			fileReader = new StreamReader(filepath);
		}

		/// <summary>
		/// Release all resources associated with the reader.
		/// </summary>
		public void Dispose() {
			fileReader.Dispose();
		}

		/// <summary>
		/// Read the next record in the data file and return that as a Dictionary.
		/// Return null if at the end of file.
		/// </summary>
		/// <returns>Dictionary or null</returns>
		public SortedList<string, string> ReadNextRecord() {
			
			if (fileReader.EndOfStream) return null;

			string line = fileReader.ReadLine();
			if (line == null) {
				fileReader.Close();
				return null;
			}

			return ParseLine(line);
		}

		// Parse the string into a Dictionary of fields and their value
		private SortedList<string, string> ParseLine(string line) {
			var record = new SortedList<string, string>();

			var fields = s3Root.Survey.Record.Variables;
			var maxLength = fields.Max(f => f.Position.Finish);

			foreach (var field in fields) {
				// Get the value at the specified postion. 
				// TODO: add error checking if line is shorter than fields maxlength
				var finish = field.Position.Finish == 0 ? field.Position.Start + 1 : field.Position.Finish;
				var length = finish - field.Position.Start;
				var value = line.Substring(field.Position.Start-1, length);
				record.Add(field.ID, value);
			}
			return record;
		}
	}
}