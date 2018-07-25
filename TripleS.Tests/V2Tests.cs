using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TripleS.NET;

namespace TripleS.Tests {
	[TestClass]
	public class V2Tests {
		S3Root example1;
		S3Root example2;

		[TestInitialize()]
		public void Initialize() {
			var assembly = Assembly.GetExecutingAssembly();
			var resource = assembly.GetManifestResourceStream("TripleS.Tests.v20.example1.sss");
			example1 = S3Serializer.FromStream(resource);

			resource = assembly.GetManifestResourceStream("TripleS.Tests.v20.example2.sss");
			example2 = S3Serializer.FromStream(resource);
		}

		[TestMethod]
		public void TestMetadata() {
			// Testing the following section of XML
			//<sss version="2.0" modes="interview analysis">
			//<!-- introducing modes used to specialise texts at Q2 -->
			//<date>14 April 2005</date>
			//<time>16:00</time>
			//<origin>SurveyProg v1.3.05</origin>
			//<user>User Site</user>

			Assert.AreEqual("2.0", example1.Version);
			Assert.AreEqual("interview analysis", example1.Modes);
			Assert.AreEqual("14 April 2005", example1.Date);
			Assert.AreEqual("16:00", example1.Time);
			Assert.AreEqual("SurveyProg v1.3.05", example1.Origin);
			Assert.AreEqual("User Site", example1.User);
		}

		[TestMethod]
		public void TestSurvey() {
			// <name>SP5201-1</name>
			// <title>Historic House Exit Survey<br/>First Wave</title>

			var survey = example1.Survey;
			Assert.AreEqual("SP5201-1", survey.Name);
			Assert.AreEqual("Historic House Exit Survey First Wave", survey.Title.GetText());
		}

		[TestMethod]
		public void TestRecord() {
			var record = example1.Survey.Record;
			Assert.AreEqual("V", record.ID);

			record = example2.Survey.Record;
			Assert.AreEqual("V", record.ID);
			Assert.AreEqual(S3Format.CSV, record.DataFormat);
			Assert.AreEqual(1, record.Skip);
		}

		[TestMethod]
		public void TestVariables() {
			var record = example1.Survey.Record;
			Assert.AreEqual(12, record.Variables.Count);

			var v1 = record.Variables[0];
			Assert.AreEqual("RESPONDENT_ID", v1.Name);
			Assert.AreEqual("Respondent ID", v1.Label.GetText());
			Assert.AreEqual(1, v1.Position.Start);
			Assert.AreEqual(6, v1.Position.Finish);

			Assert.AreEqual(S3Type.Quantity, v1.Type);
			Assert.AreEqual(S3Use.Serial, v1.Use);

			var range = v1.Values[0] as S3Range;
			Assert.AreEqual("000001", range.From);
			Assert.AreEqual("999999", range.To);
			
			var v4 = record.Variables[3];
			Assert.AreEqual(S3Type.Single, v4.Type);
			var values = v4.Values;
			Assert.AreEqual(3, values.Count);
			var val1 = values[0] as S3Value;
			Assert.AreEqual("0", val1.Code);

			var v6 = record.Variables[5];
			Assert.AreEqual(30, v6.Size);

			var v8 = record.Variables[7];
			Assert.AreEqual(2, v8.Spread.Subfields);
		}

		[TestMethod]
		public void TestSerialization() {
			string xml = S3Serializer.ToString(example1);

			Assert.IsTrue(xml.Length > 0);
		}

		[TestMethod]
		public void TestCreateSurvey() {
			var s3 = new S3Root() {
				Origin = "Triple-S.Net",
				Date = DateTime.Now.ToShortDateString(),
				Time = DateTime.Now.ToShortTimeString(),
			};

			var survey = s3.Survey;
			survey.Name = "Triple-S Tests";
			survey.Version = "1;";

			var record = survey.Record;
			record.ID = "A";

			var variable = record.AddVariable("1", "Q1", S3Type.Single);
			variable.AddValue("1", "Red");
			variable.AddValue("2", "blue");
			variable.AddValue("3", "Green");

			string xml = S3Serializer.ToString(s3);

			File.WriteAllText(@"C:\dev\surveys\S3Test.xml", xml);

			Assert.IsTrue(xml.Length > 0);

			// Get a copy of the survey from the serialized string and check some random properties.
			var s3import = S3Serializer.FromString(xml);
			Assert.AreEqual("A", s3import.Survey.Record.ID);

			// Does the xml rountrip to the same xml?
			var xmlCopy = S3Serializer.ToString(s3import);
			Assert.AreEqual(xml, xmlCopy);
		}

		[TestMethod]
		public void DataReadTests() {

			var file = @"C:\Dev\Triple-S.NET\TripleS.NET\v20\Examples\example1.asc";
			S3FixedFormatReader dataReader = new S3FixedFormatReader(example1, file);

			int recordCount = 0;
			SortedList<string, string> record;
			while ((record = dataReader.ReadNextRecord()) != null) {
				recordCount++;
			}

			Assert.AreEqual(3, recordCount);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "Triple-S data format must be fixed")]
		public void InvalidFormatExceptionTest() {
			var file = @"C:\Dev\Triple-S.NET\TripleS.NET\v20\Examples\example1.asc";
			S3FixedFormatReader dataReader = new S3FixedFormatReader(example2, file);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException), "Triple-S data file not found")]
		public void MissingFileExceptionTest() {
			var file = @"C:\Dev\Triple-S.NET\TripleS.NET\v20\Examples\test.asc";
			S3FixedFormatReader dataReader = new S3FixedFormatReader(example1, file);
		}
	}
}