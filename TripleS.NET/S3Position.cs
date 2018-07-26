using System.Xml;
using System.Xml.Serialization;

namespace TripleS.NET {
	/// <summary>
	/// Mandatory. The position element defines the part of the data record that is allocated 
	/// to holding the value of the variable. The size, values and spread elements describe 
	/// which parts of the data record are to be interpreted as the value, and what are the legal 
	/// values of the variable.
	/// </summary>
	public class S3Position {

		/// <summary>
		/// For fixed format files, the start_location and finish_location are positive integers, 
		/// which represent the character positions of the corresponding data field. The first 
		/// character in the data record is in position 1. 
		/// </summary>
		[XmlAttribute("start")]
		public int Start { get; set; }

		/// <summary>
		/// The finish_location must be greater than or equal to the start_location. The finish 
		/// attribute may be omitted if the finish_location is the same as the start_location.
		/// Together, they must define a length that is at least as long as that implied by the 
		/// size, values and spread elements. 
		/// </summary>
		[XmlAttribute("finish")]
		public int Finish { get; set; }
	}
}