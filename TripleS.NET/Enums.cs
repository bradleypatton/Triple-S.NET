using System.Xml.Serialization;

namespace TripleS.NET {
	public enum S3Encoding {
		/// <summary>
		/// The Data File consists of 8-bit characters from the Windows-1252 character set. 
		/// This is closely related to ASCII and ISO-8859-1. Every 8-bit byte represents a
		/// printable character or a control code. 
		/// </summary>
		[XmlEnum("Windows-1252")]
		Windows1252,

		/// <summary>
		/// The Data File consists of Unicode characters using the UTF-8 encoding. The encoding 
		/// is variable length and uses one to four 8-bit code units. Note that positions in
		/// the Data File are Unicode character positions, not byte positions. 
		/// </summary>
		[XmlEnum("UTF-8")]
		UTF8
	}

	public enum S3Format {
		/// <summary>
		/// The data representation is fixed format fields. For data in fixed format 
		/// the position element refers to the character number. 
		/// </summary>
		[XmlEnum("fixed")]
		Fixed,

		/// <summary>
		/// The data representation is comma-separated values, using one field for each
		/// variable, with data values similar to the fixed format. Note that for data 
		/// in csv format the <position> element refers to the field number. 
		/// </summary>
		[XmlEnum("csv")]
		CSV
	}

	public enum S3Type {
		/// <summary>
		/// Categorical with at most one response allowed
		/// </summary>
		[XmlEnum("single")]
		Single,

		/// <summary>
		/// Categorical with any number of responses allowed
		/// </summary>
		[XmlEnum("multiple")]
		Multiple,

		/// <summary>
		/// Numeric value (integer or real)
		/// </summary>
		[XmlEnum("quantity")]
		Quantity,

		/// <summary>
		/// Character value
		/// </summary>
		[XmlEnum("character")]
		Character,

		/// <summary>
		/// Yes/No or True/False value
		/// </summary>
		[XmlEnum("logical")]
		Logical,

		/// <summary>
		/// Date value. The value must be stored in the YYYYMMDD basic ISO 8601 format.
		/// </summary>
		[XmlEnum("date")]
		Date,

		/// <summary>
		/// Time value. The value must be stored in the HHMMSS basic ISO 8601 format. 
		/// </summary>
		[XmlEnum("time")]
		Time
	}

	public enum S3Use {
		/// <summary>
		/// This variable contains the serial number (or other identification field) for the record. 
		/// There can be at most one serial variable and it must be either a character or a positive
		/// integer quantity. The data values must be unique and should not be missing. 
		/// </summary>
		[XmlEnum("serial")]
		Serial,

		/// <summary>
		/// This variable contains a record weight. There can be at most one weight variable and it 
		/// must be a quantity. The data values should be non-negative and not be missing.
		/// </summary>
		[XmlEnum("weight")]
		Weight
	}

	public enum S3VariableFormat {
		/// <summary>
		/// All the codes for this variable are to be treated as characters, rather than numbers. 
		/// Literal codes are casesensitive (i.e. “a” and “A” are different).
		/// </summary>
		[XmlEnum("literal")]
		Literal,

		/// <summary>
		/// All the codes for this variable are to be treated as numbers. 
		/// </summary>
		[XmlEnum("numeric")]
		Numeric
	}
}