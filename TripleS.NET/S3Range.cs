using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	public class S3Range {

		[XmlAttribute("from")]
		public string From { get; set; }

		[XmlAttribute("to")]
		public string To { get; set; }
	}
}