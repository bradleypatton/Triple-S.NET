﻿using System.Xml.Serialization;

namespace TripleS.NET {
	public class S3Spread {

		/// <summary>
		/// The num_subfields attribute must be a positive integer, and denotes the number 
		/// of subfields within the overall field that is defined by the position element.
		/// The subfield_width is also a positive integer and denotes the width of each subfield.
		/// For fixed Data Files, the position element must define a width of at least
		/// (num_subfields * subfield_width). The subfield_width must be large enough to hold 
		/// the largest category value specified for the multiple.
		/// </summary>
		[XmlAttribute("subfields")]
		public int Subfields { get; set; }

		/// <summary>
		/// The width attribute may be omitted when used in conjunction with fixed Data Files if 
		/// the num_subfields exactly fills the area defined by the position element. In this case 
		/// the subfield_width is determined by dividing the width derived from the position element 
		/// by num_subfields. Note that for csv Data Files the width attribute must always be 
		/// specified as it cannot be determined from the overall width defined in the position element. 
		/// </summary>
		[XmlAttribute("width")]
		public int Width { get; set; }
	}
}