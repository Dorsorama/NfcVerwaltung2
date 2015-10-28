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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NfcVerwaltung
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void cmbProfil_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			ZugangsProfil zp = new ZugangsProfil();
			zp.Show();
		}

		private void cmbTag_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			//NFCTag nt = new NFCTag();
			//nt.Show();
		}

		private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
		{
			NFCTag nt = new NFCTag();
			nt.Show();
		}
	}
}
