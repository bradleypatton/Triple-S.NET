using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace TripleS.NET {
	/// <summary>
	/// Helper class for serializing/deserializing Triple-S to and from XML.
	/// </summary>
	public static class S3Serializer {

		/// <summary>
		/// Return a S3MetaData object loaded from a file.
		/// </summary>
		/// <param name="filename">Full filepath to a Triple-S XML file.</param>
		/// <returns>S3MetaData</returns>
		public static S3MetaData FromFile(string filename) {
			using (var stream = File.Open(filename, FileMode.Open)) {
				return FromStream(stream);
			}
		}

		/// <summary>
		/// Return a S3MetaData object loaded from a string.
		/// </summary>
		/// <param name="xml">Complete Triple-S XML string</param>
		/// <returns>S3MetaData</returns>
		public static S3MetaData FromString(string xml) {
			using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml))) {
				return FromStream(stream);
			}
		}

		/// <summary>
		/// Return a S3MetaData object loaded from a stream.
		/// </summary>
		/// <param name="stream">Stream open on Triple-S XML</param>
		/// <returns>S3MetaData</returns>
		public static S3MetaData FromStream(Stream stream) {
			var xs = new XmlSerializer(typeof(S3MetaData));
			using (var rd = new StreamReader(stream)) {
				return (S3MetaData)xs.Deserialize(rd);
			}
		}

		/// <summary>
		/// Serialize a Triple-S survey to XML and save it to a file.
		/// </summary>
		/// <param name="filename">Fully qualified file to save the XML to</param>
		/// <param name="metaData">S3MetatData object to serialize</param>
		public static void ToFile(string filename, S3MetaData metaData) {
			using (var writer = new StreamWriter(filename)) {
				ToWriter(writer, metaData);
			}
		}

		/// <summary>
		/// Serialize a Triple-S survey to XML and return that as a string
		/// </summary>
		/// <param name="metaData">S3MetatData object to serialize</param>
		/// <returns>String of XML</returns>
		public static string ToString(S3MetaData metaData) {
			using (var writer = new StringWriter()) {
				ToWriter(writer, metaData);
				return writer.ToString();
			}
		}

		/// <summary>
		/// Serialize a Triple-S survey to XML and save it to a stream.
		/// </summary>
		/// <param name="stream">Open stream to save the XML to. 
		/// Caller is responsible for closing the stream.</param>
		/// <param name="metaData">S3MetatData object to serialize</param>
		public static void ToWriter(TextWriter stream, S3MetaData metaData) {
			var xs = new XmlSerializer(typeof(S3MetaData));
			xs.Serialize(stream, metaData);
		}
	}
}