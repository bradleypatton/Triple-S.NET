using System;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {

	/// <summary>
	/// The S3Root object represents the root and is used to encapsulate the entire specification document.
	/// It contains a mandatory attribute version and optional xml:lang, languages and modes attributes.
	/// </summary>
	[Serializable]
	[XmlRoot("sss")]
	public class S3Root {

		/// <summary>
		/// The version attribute is used to indicate the version of the Triple-S standard that applies to this specification. 
		/// If the sss_version is 1.1 or 1.2 or 2.0 then only elements and attributes from the Triple-S XML version 1.1, 1.2 or 
		/// 2.0 standard are used.If the sss_version is 3.0 then the definition complies with the version 3.0 standard, and new 
		/// elements and attributes from the Triple-S XML version 3.0 standard may be present.
		/// </summary>
		[XmlAttribute("version")]
		[DefaultValue("3.0")]
		public string Version { get; set; } = "3.0";

		/// <summary>
		/// The xml:lang attribute is optional and is used to indicate the default
		/// language of texts within the remainder of the Metadata File.
		/// </summary>
		//[XmlAttribute(AttributeName = "lang", Namespace = "http://www.w3.org/XML/1998/namespace", DataType = "language")]
		//public string Lang { get; set; }

		/// <summary>
		/// The languages attribute is optional and is used to indicate that there are some multilingual texts within 
		/// the Triple-S definition and to define the language identifiers that are used for those texts.
		/// </summary>
		[XmlAttribute("languages")]
		public string Languages { get; set; }

		/// <summary>
		/// The modes attribute is optional and is used to indicate that there are potentially differing texts within 
		/// the Triple-S definition for interviewing and analysis.
		/// </summary>
		[XmlAttribute("modes")]
		public string Modes { get; set; }

		/// <summary>
		/// Optional. The date value should represent the date the file was created.
		/// </summary>
		[XmlElement("date")]
		public string Date { get; set; }

		/// <summary>
		/// Optional. The time value should represent the time the file was created.		
		/// </summary>
		[XmlElement("time")]
		public string Time { get; set; }

		/// <summary>
		/// Optional. Although optional, the inclusion of an origin specification is
		/// strongly encouraged. The origin value should represent the name and 
		/// version of the software producing the output.
		/// </summary>
		[XmlElement("origin")]
		public string Origin { get; set; }

		/// <summary>
		/// Optional. One or more style elements are used to introduce internal style definitions 
		/// written in css or to reference an external file whose contents define styles in css.
		/// </summary>
		[XmlElement("style")]
		public S3Style[] Style { get; set; }

		/// <summary>
		/// Optional. The user value should indicate the name of the user/company who created the file.		
		/// </summary>
		[XmlElement("user")]
		public string User { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[XmlElement("survey")]
		public S3Survey Survey { get; set; } = new S3Survey();
	}
}