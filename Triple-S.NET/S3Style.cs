using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {

	/// <summary>
	///  One or more style elements are used to introduce internal style definitions written in 
	///  CSS or to reference an external file whose contents define styles in CSS.
	/// </summary>
	public class S3Style {

		/// <summary>
		/// The optional href attribute can be used to explicitly specify the name of a CSS file.
		/// </summary>
		[XmlAttribute("href")]
		public string Href { get; set; }

		/// <summary>
		/// Optional inline CSS styles
		/// </summary>
		[XmlText()]
		public string Value { get; set; }
	}
}