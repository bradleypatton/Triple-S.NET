using System.Collections.Generic;
using System.ComponentModel;
using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	public partial class S3Variable {

		/// <summary>
		/// Mandatory. The variable_id is a positive number with or without leading 		
		/// zeros.Each variable_id must be unique within the <record>...</record> block.
		/// </summary>
		[XmlAttribute("ident")]
		public string ID { get; set; }

		/// <summary>
		/// The format is optional and can be used to declare the format of the codes for 
		/// this variable. Only variables of type single, or of type multiple with spread 
		/// format data, may have a format attribute.The default format for all variables 
		/// of type single or type multiple is numeric, but if specified, it must be of 
		/// S3VariableFormat
		/// </summary>
		[XmlAttribute("format")]
		[DefaultValue(S3VariableFormat.Literal)]
		public S3VariableFormat Format { get; set; }

		/// <summary>
		/// Describes the type of data the variable represents.
		/// </summary>
		[XmlAttribute("type")]
		public S3Type Type { get; set; }

		/// <summary>
		/// The use_type is optional and describes the role of this variable in the survey.
		/// Only a subset of variable types may have a use attribute, and the use_type
		/// must be of type S3Use
		/// </summary>
		[XmlAttribute("use")]
		[DefaultValue(S3Use.Serial)]
		public S3Use Use { get; set; }

		/// <summary>
		/// Mandatory. The variable_name should represent the name of the variable in 
		/// the survey.See the reference section on Triple-S Names for the definition
		/// of the variable_name.
		/// </summary>
		[XmlElement("name")]
		public string Name { get; set; }

		/// <summary>
		/// Mandatory. The label_text should represent the label or question text for
		/// the original variable.		
		/// </summary>
		[XmlElement("label")]
		public S3Text Label { get; set; }

		/// <summary>
		/// Mandatory. The position element defines the part of the data record that is allocated 
		/// to holding the value of the variable. The size, values and spread elements describe which 
		/// parts of the data record are to be interpreted as the value, and what are the legal values 
		/// of the variable. The interpretation of the position element depends on the format of the
		/// Data File (see the record element): 
		/// </summary>
		[XmlElement("position")]
		public S3Position Position { get; set; }

		/// <summary>
		/// Optional. The filter_name must be the name (as defined by the name element) 
		/// of a previously defined logical variable. The value of this logical variable 
		/// determines if the current variable is available for that record.
		/// </summary>
		/// <remarks>
		/// All variable types, including logical variables, can have a filter element.
		/// However, note that variables used as a serial or weight must have no missing 
		/// values, hence it is inappropriate for these to have a filter specified.		
		/// </remarks>
		[XmlElement("filter")]
		public string Filter { get; set; }

		/// <summary>
		/// Mandatory for character type variables. Defines the maximum number of characters 
		/// in the data for the variable. The size_specification must be a positive integer; 
		/// there is no upper limit to the size_specification.
		/// </summary>
		[XmlAttribute("size")]
		[DefaultValue(0)]
		public int Size { get; set; }

		/// <summary>
		/// Optional and only used with multiple type variables. The <spread> element indicates 
		/// that the data values are coded as a series of category values in consecutive subfields
		/// (rather than the default multiple format of a series of 0/1 characters). 
		/// </summary>
		[XmlElement("spread")]
		public S3Spread Spread { get; set; }

		/// <summary>
		/// Mandatory for single, multiple and quantity types, optional for date and time types.
		/// The values element is used to define the set of legal values and optional text labels for 
		/// values (e.g.categorical codes). A values element contains at most one range element and/or 
		/// one or more value elements. If a range is present then it must be the first element. 
		/// </summary>
		/// <remarks>
		/// The value elements do not need to be in any order, nor need they form a complete set 
		/// with every possible value code present. There is no upper limit to the number of 
		/// value elements which may be specified within a variable definition. 
		/// </remarks>
		[XmlArray("values")]
		[XmlArrayItem(typeof(S3Value), ElementName = "value")]
		[XmlArrayItem(typeof(S3Range), ElementName = "range")]
		public List<object> Values { get; set; } = new List<object>();

		/// <summary>
		/// Add a value to the variable and return the new object.
		/// </summary>
		/// <param name="code"></param>
		/// <param name="label"></param>
		/// <returns>S3Value</returns>
		public S3Value AddValue(string code, string label) {
			var val = new S3Value {
				Code = code,
				Text = label
			};
			Values.Add(val);
			return val;
		}
	}
}