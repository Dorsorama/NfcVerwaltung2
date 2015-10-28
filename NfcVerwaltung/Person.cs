using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NfcVerwaltung
{
	class Person
	{
		public int iPNummer { get; set; }
		public string sVorname { get; set; }
		public string sNachname { get; set; }
		private int Pwd;
		public int iPwd
		{
			get
			{
				return Pwd;
			}
			set
			{
				if (value>999&&value<10000)
				{
					Pwd = value;
				}
			}
		}
	}
}
