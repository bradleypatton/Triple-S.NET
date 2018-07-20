using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {

	/// <summary>
	/// Mandatory. One <record> element starts after <survey> (or any survey description 
	/// elements if present). It is used to introduce the definition of the variables 
	/// that are held in the Data File.
	/// </summary>
	public class S3Record {
		/// <summary>
		/// The record_id is any single character A to Z or a to z. The record_id can be 
		/// used in conjunction with the variable_id(see the <variable> element later) to 
		/// generate a unique variable name on import.
		/// </summary>
		[XmlAttribute("ident")]
		public string ID { get; set; }

		/// <summary>
		/// The optional data_format can be used to declare the format of the Data File 
		/// that corresponds to this specification. The default format is fixed format fields
		/// </summary>
		[XmlAttribute("format")]
		[DefaultValue(S3Format.Fixed)]
		public S3Format DataFormat { get; set; }

		/// <summary>
		/// The optional data_encoding can be used to declare the encoding method used for the 
		/// Data File. The default encoding is “Windows-1252”, but if specified then it must 
		/// be one of S3Encoding
		/// </summary>
		[XmlAttribute("encoding")]
		[DefaultValue(S3Encoding.Windows1252)]
		public S3Encoding DataEncoding { get; set; }

		/// <summary>
		/// The optional href attribute can be used to explicitly specify the name of the
		/// Data File that is described by this Triple-S XML specification.Note that using
		/// an href attribute ties the specification to the Data File and may cause
		/// problems if the specification and Data Files are moved
		/// </summary>
		[XmlAttribute("href")]
		public string Href { get; set; }

		/// <summary>
		/// The optional skip attribute can be used to ignore one or more initial records in 
		/// the Data File.This will be most useful for csv Data Files where the first line is 
		/// often used as documentation(e.g.names for the columns/fields) for the succeeding values.
		/// </summary>
		[XmlAttribute("skip")]
		[DefaultValue(0)]
		public int Skip { get; set; }

		/// <summary>
		/// Elements describing the data fields of a survey.
		/// </summary>
		[XmlElement("variable")]
		public List<S3Variable> Variables { get; set; } = new List<S3Variable>();

		/// <summary>
		/// Add a new variable to the record. 
		/// </summary>
		/// <param name="id">Id of the variable</param>
		/// <param name="name">Variable name</param>
		/// <param name="varType">Type one of S3Type</param>
		/// <returns>New S3Variable</returns>
		public S3Variable AddVariable(string id, string name, S3Type varType) {
			var field = new S3Variable {
				ID = id,
				Name = name,
				Type = varType
			};
			Variables.Add(field);
			return field;
		}
	}
}