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
	/// Interaktionslogik für EnterName.xaml
	/// </summary>
	public partial class EnterName : Window
	{
		public EnterName()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			tbName.Focus();
		}

		private void btnOK_Click(object sender, RoutedEventArgs e)
		{
			Close();

		}

		private void btnCan_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
