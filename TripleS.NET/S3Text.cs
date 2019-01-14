using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	/// <summary>
	/// Class to hold the parsed br elements
	/// </summary>
	public class br {
	}

	/// <summary>
	/// Represents text elements in a <c>S3Survey</c> (eg title or variable labels). 
	/// </summary>
	public class S3Text {

		/// <summary>
		/// Language code of the text string.
		/// </summary>
		[XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang { get; set; }

		/// <summary>
		/// The use of specialised texts for interviewing and/or analysis within the specification must be 
		/// signalled by a modes="mode_identifier_list" attribute on the initial 'sss' element. Text for specified
		/// modes is then indicated by this property on Text elements.
		/// </summary>
		[XmlAttribute("mode")]
		public string Mode { get; set; }

		/// <summary>
		/// Any br elements
		/// </summary>
		[XmlElement("br")]
		public br[] Items { get; set; }

		/// <summary>
		/// Raw text string array. GetText() is the recommended method to use.
		/// </summary>
		[XmlText()]
		public string[] Text { get; set; }

		/// <summary>
		/// Return the all of the text items as one string.
		/// </summary>
		/// <returns>String</returns>
		public string GetText() {
			return Text == null ? "" : string.Join(" ", Text);
		}
	}
}