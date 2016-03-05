/*
 * Készítette a SharpDevelop.
 * Felhasználó: Atlantis
 * Dátum: 2009.07.23.
 * Idő: 13:29
 * 
 * A sablon megváltoztatásához használja az Eszközök | Beállítások | Kódolás | Szabvány Fejlécek Szerkesztését.
 */
using System;
using System.Windows.Forms;

namespace sampa
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
