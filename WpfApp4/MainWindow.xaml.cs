using System;
using System.Collections.Generic;
using System.IO;
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
using Servicces;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckWeather(object sender, RoutedEventArgs e)
        {
            var service = new WeatherService();
            var weather = service.GetWeather(cityTxtBox.Text);
        }

        private void Save(object sender, RoutedEventArgs e)
        {
    /*       using (FileStream writer = new FileStream(fileURL, FileMode.Create))
            {
                DataContractSerializer ser = new DataContractSerializer(typeof(Army));
                ser.WriteObject(writer, army);
            }
            FileStream fs = new FileStream(fileURL, FileMode.Open);
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
            DataContractSerializer ser = new DataContractSerializer(typeof(Army));
            deserializedArmy = (Army)ser.ReadObject(reader, true);
            reader.Close();
            fs.Close();
            return deserializedArmy;*/

        }

        private void SearchCity(object sender, RoutedEventArgs e)
        {

        }

        private void WatchNearlySaves(object sender, RoutedEventArgs e)
        {

        }
    }
}
