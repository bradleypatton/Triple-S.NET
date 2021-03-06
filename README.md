# Triple-S.NET

[![NuGet](https://img.shields.io/nuget/v/Triple-S.NET.svg)](https://www.nuget.org/packages/Triple-S.NET/)  [![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE.md)

A .NET Library to support Triple-S Survey serialization.

The library consists of a set of C# classes to aid in serialization and deserialization of Triple-S XML. The class names and properties match the Triple-S specficiation but with C# styles applied.

Install it with NuGet:

    PM> Install-Package Triple-S.NET
    
Then add the following using declaration where you want to use the classes:
```C#
using TripleS.NET;
``` 

## Usage Examples

Load a survey from a file and iterate over the variables:
```C#
var filename = "TripleS.Tests.v20.example1.sss";
S3Root root = S3Serializer.FromFile(filename);
foreach (var s3Var in root.Survey.Record.Variables) {
  // Do something
}
```

Create a Triple-S Survey and serialize to a XML string:
```C#
var s3 = new S3Root() {
  Origin = "Triple-S.Net",
  Date = DateTime.Now.ToShortDateString(),
  Time = DateTime.Now.ToShortTimeString(),
};

var survey = s3.Survey;
survey.Name = "Triple-S Tests";
survey.Version = "1";

var record = survey.Record;
record.ID = "A";

var variable = record.AddVariable("1", "Q1", S3Type.Single);
variable.AddValue("1", "Red");
variable.AddValue("2", "blue");
variable.AddValue("3", "Green");
string xml = S3Serializer.ToString(s3);
```

Read a fixed format data file and dump to screen (using [LINQPad](https://www.linqpad.net/))
```C#
var xml = @"C:\Surveys\180215\180215.xml";
var data = @"C:\Surveys\180215\180215.dat";
int count = 0;
var s3root = S3Serializer.FromFile(xml);
using (var reader = new S3FixedFormatReader(s3root, data)) {
	SortedList<string, string> record;
	
	while ((record = reader.ReadNextRecord()) != null) {
		foreach (var s3var in s3root.Survey.Record.Variables) {
			var value = record[s3var.ID];
			$"{s3var.ID} = {value}".Dump();
		}
		count++;
	}	
}
count.Dump();
```

## References
* [Triple-S Specification](http://www.triple-s.org/)
