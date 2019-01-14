using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	/// <summary>
	/// This class defines values inside of a <c>S3Variable</c>
	/// </summary>
	public class S3Value {

		/// <summary>
		/// The code_value for a variable of type single depend on whether the attribute format="literal" 
		/// is specified on the variable element. If this attribute is not present or format="numeric" is 
		/// specified, then these codes must all be positive integers or the value zero. However when 
		/// format="literal" is specified, all code_values (even those that look like numbers) are treated as
		/// case-sensitive characters, and the &lt;range> element cannot be used. 
		/// </summary>
		[XmlAttribute("code")]
		public string Code { get; set; }

		/// <summary>
		/// The optional score attribute can be used for variables of type single and type multiple.
		/// It allows score values to be assigned to the individual code values to be used for computing 
		/// statistics such as Mean, Standard Deviation etc. The score_value must be a number, and may be 
		/// positive, negative or zero, with or without a decimal point and decimal places. The omission 
		/// of a score, on both single and multiple variables, implies that records having that value code 
		/// and no other value codes might be omitted from the base for any statistical computation for 
		/// that variable. 
		/// </summary>
		[XmlAttribute("score")]
		public string Score { get; set; }

		/// <summary>
		/// There can be any number of optional elements that are used to give labels to specific values 
		/// of the variable. The value_text may optionally include any number of text formatting elements
		/// (see the Reference Section item Formatted Texts). The label may also contain language-specific 
		/// and modespecific texts(see the Reference Section item Triple-S Texts). 
		/// </summary>
		[XmlText()]
		public string Text { get; set; }
	}
}