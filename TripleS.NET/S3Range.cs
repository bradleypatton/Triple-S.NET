using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	/// <summary>
	/// The range indicates an overall range of	legal values for the variable. The To value must be equal to or 
	/// greater	than the start_value.
	/// </summary>
	public class S3Range {

		/// <summary>
		/// Start location of the range
		/// </summary>
		[XmlAttribute("from")]
		public string From { get; set; }

		/// <summary>
		/// End location of the range
		/// </summary>
		[XmlAttribute("to")]
		public string To { get; set; }
	}
}