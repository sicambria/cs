/*
 * Készítette a SharpDevelop.
 * Felhasználó: Sicambria
 * Dátum: 2009.07.23.
 * Idő: 13:42
 * 
 * GNU GENERAL PUBLIC LICENSE
 *  Version 3, 29 June 2007
 */
 
using System;
using System.Text;
using System.IO;

namespace sampa
{
	/// <summary>
	/// Description of EncoderClass.
	/// </summary>
	public class EncoderClass
	{
		public EncoderClass()
		{
		}
	static string encoded_filepath;

      

        public static void Encode(string filepath, string source_encoding, string dest_encoding)
        {

            encoded_filepath = filepath + "_" + dest_encoding + ".txt";
            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();

            Encoding inputEnc = Encoding.GetEncoding(source_encoding);
            Encoding outputEnc = Encoding.GetEncoding(dest_encoding);
            byte[] decoded = Encoding.Convert(inputEnc, outputEnc, bytes, 0, bytes.Length);

            FileStream fw = File.OpenWrite(encoded_filepath);
            fw.Write(decoded, 0, (int)decoded.Length);
            fw.Close();
        }

        public static void EncodeWindowsAnsiDefaultToUTF8(string filepath)
        {
            encoded_filepath = filepath + "_utf8.txt";
            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();

            byte[] decoded = Encoding.Convert(Encoding.Default, Encoding.UTF8, bytes, 0, bytes.Length);

            FileStream fw = File.OpenWrite(encoded_filepath);
            fw.Write(decoded, 0, (int)decoded.Length);
            fw.Close();
        }

        public static void EncodeASCIIToUTF8(string filepath)
        {
            encoded_filepath = filepath + "_utf8.txt";

            TextReader EncodeQuery = new StreamReader(filepath);

            FileStream fs = File.OpenRead(filepath);
            byte[] bytes = new byte[fs.Length];
            fs.Read(bytes, 0, (int)fs.Length);
            fs.Close();

            byte[] decoded = Encoding.Convert(Encoding.ASCII, Encoding.UTF8, bytes, 0, bytes.Length);

            FileStream fw = File.OpenWrite(encoded_filepath);
            fw.Write(decoded, 0, (int)decoded.Length);
            fw.Close();

        }

    }
}
