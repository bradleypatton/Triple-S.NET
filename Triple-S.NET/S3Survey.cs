using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {

	/// <summary>
	/// Mandatory element. Introduces details of the Data File for a flat survey, or of a Data
	/// File that forms part of a hierarchical survey.
	/// </summary>
	public class S3Survey {

		/// <summary>
		/// Optional. See the section on Triple-S Names for the definition of the 
		/// survey_name. For those systems with no specific survey naming convention
		/// this element could be used to hold the filename. 
		/// </summary>
		[XmlElement("name")]
		public string Name { get; set; }

		/// <summary>
		/// Optional. The content of the survey_version is not defined, but some local 
		/// conventions would be required if it is to be anything more than just descriptive.		
		/// </summary>
		[XmlElement("version")]
		public string Version { get; set; }

		/// <summary>
		/// Optional. The survey_title_text should represent the survey title.
		/// </summary>
		/// <remarks>
		/// The title may optionally include any number of text formatting elements 
		/// (see the Reference Section item Triple-S Texts). The title may also contain
		/// language-specific and mode-specific texts(see the Reference Section item
		/// Triple-S Texts). 
		/// </remarks>
		[XmlElement("title")]
		public S3Text Title { get; set; } = new S3Text();

		/// <summary>
		/// Mandatory. One <record> element starts after <survey> (or any survey description 
		/// elements if present). It is used to introduce the definition of the variables 
		/// that are held in the Data File.
		/// </summary>
		[XmlElement("record")]
		public S3Record Record { get; set; } = new S3Record();
	}
}