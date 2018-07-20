using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	public class S3Position {

		[XmlAttribute("start")]
		public string Start { get; set; }

		[XmlAttribute("finish")]
		public string Finish { get; set; }
	}
}