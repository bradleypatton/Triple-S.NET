using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	public class br {
	}

	public class S3Text {

		[XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
		public string lang { get; set; }

		/// <summary>
		/// The use of specialised texts for interviewing and/or analysis within the specification must be 
		/// signalled by a modes="mode_identifier_list" attribute on the initial 'sss' element. Text for specified
		/// modes is then indicated by this property on Text elements.
		/// </summary>
		[XmlAttribute("mode")]
		public string Mode { get; set; }

		[XmlElement("br")]
		public br[] Items { get; set; }

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