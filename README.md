# Triple-S.NET

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

## References
* [Triple-S Specification](http://www.triple-s.org/)
