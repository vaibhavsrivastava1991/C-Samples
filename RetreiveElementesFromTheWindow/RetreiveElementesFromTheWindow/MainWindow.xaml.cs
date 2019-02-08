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

namespace RetreiveElementesFromTheWindow
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			RetreiveElementFromTheWindow(this);
		}
		private void RetreiveElementFromTheWindow(DependencyObject thisObject)
		{
			// Get all available TextBoxes from object(Window, UserControl Or Pages)
			foreach (TextBox txtBox in ExtensionMethods.FindLogicalChildren<TextBox>(thisObject))
			{
				
			}
			// Get all available TextBlocks from object(Window, UserControl Or Pages)
			foreach (TextBlock txtBox in ExtensionMethods.FindLogicalChildren<TextBlock>(thisObject))
			{

			}
		}
	}
}
