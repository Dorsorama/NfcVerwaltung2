using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NfcVerwaltung
{
	/// <summary>
	/// Interaktionslogik für NFCTag.xaml
	/// </summary>
	public partial class NFCTag : Window
	{
		public NFCTag()
		{
			InitializeComponent();
		}

		private void btnCan_Click(object sender, RoutedEventArgs e)
		{
			Close();

		}

		private void btnOK_Click(object sender, RoutedEventArgs e)
		{
			Close();

		}

		private void btnAdd_Click(object sender, RoutedEventArgs e)
		{
			EnterName en = new EnterName();
			en.Show();
		}

		private void btnDel_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}
