using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcVerwaltung
{
	class ZuProfil
	{
		public ZuProfil(string name)
		{
			sName = name;
			listSperrZeiten = new List<SperrZeit>();
			SperrZeit DefSperrZeit = new SperrZeit("Default", new DateTime(9999, 7, 1), new DateTime(9999, 7, 15));
			listSperrZeiten.Add(DefSperrZeit);
		}
		public string sName { get; private set; }
		public bool bZugeordnet { get; set; }
		public DateTime DateAblauf { get; set; }
		private int iZeit1S = 8;
		private int iZeit1E = 16;
		private int iZeit2S = 0;
		private int iZeit2E = 0;
		public void setZeit1(int start, int ende)
		{
			iZeit1S = start;
			iZeit1E = ende;
		}
		public int[] getZeit1()
		{
			return new int[2] { iZeit1S, iZeit1E };
		}
		public void setZeit2(int start, int ende)
		{
			iZeit2S = start;
			iZeit2E = ende;
		}
		public int[] getZeit2()
		{
			return new int[2] { iZeit2S, iZeit2E };
		}
		public bool bSchicht { get; set; } = false;
		private List<SperrZeit> listSperrZeiten;
		public void addSperrZeit(List<SperrZeit> sz)
		{
			foreach (var SZeit in sz)
			{
				listSperrZeiten?.Add(SZeit);
			}
		}
		public void remSperrZeit(string name)
		{
			listSperrZeiten?.Remove(listSperrZeiten.Where(X => X.sName == name).FirstOrDefault());
		}
		public bool bMontag { get; set; } = true;
		public bool bDienstag { get; set; } = true;
		public bool bMittwoch { get; set; } = true;
		public bool bDonnerstag { get; set; } = true;
		public bool bFreitag { get; set; } = true;
		public bool bSamstag { get; set; }
		public bool bSonntag { get; set; }
	}
	class SperrZeit
	{
		public SperrZeit(string name, DateTime Start, DateTime Ende)
		{
			sName = name;
			DateStart = Start;
			DateEnde = Ende;
		}
		public string sName { get; private set; }
		public DateTime DateStart { get; private set; }
		public DateTime DateEnde { get; private set; }
	}
}
