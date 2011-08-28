using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace contactsToFritz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ResourceDictionary formDict = new ResourceDictionary();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            formDict.Source = new Uri("..\\Languages\\Dictionary_EN.xaml", UriKind.Relative);
            this.Resources.MergedDictionaries.Add(formDict);
        }

        public void setDisplayLanguage(string displayLang)
        {
            switch (displayLang)
            {
                case "EN": formDict.Source = new Uri("..\\Languages\\Dictionary_EN.xaml", UriKind.Relative);
                    break;
                case "NL": formDict.Source = new Uri("..\\Languages\\Dictionary_NL.xaml", UriKind.Relative);
                    break;
                default: formDict.Source = new Uri("..\\Languages\\Dictionary_EN.xaml", UriKind.Relative);
                    break;
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            setDisplayLanguage("EN");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            setDisplayLanguage("NL");
        }
    }
}
