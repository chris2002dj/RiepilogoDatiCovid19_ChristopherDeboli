using RiepilogoDatiCovid19_ChristopherDeboli.Model;
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
using System.Xml.Linq;

namespace RiepilogoDatiCovid19_ChristopherDeboli
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_CercaRegione_Click(object sender, RoutedEventArgs e)
        {
            Lst_RiepilogoDati.Items.Clear();

            if (Txt_Regione.Text != "") // Controllo se è stato inserita una regione
            {

            }
            else
            {
                MessageBox.Show("Devi inserire una regione", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Warning); // Avverto all'utente che deve inserire una regione
            }
        }

        // Metodo che carica i dati dal file xml e stampa le informazione di una regione richiesta
        private void CaricaDatiXML()
        {
            string path = @"RegioniCovid19.xml";
            XDocument xmlLoad = XDocument.Load(path);
            XElement xmlRoot = xmlLoad.Element("root");
            var xmlRow = xmlRoot.Elements("row");

            foreach (var item in xmlRow)
            {
                XElement xmlData = item.Element("data");
                XElement xmlStato = item.Element("stato");
                XElement xmlCodiceRegione = item.Element("codice_regione");
                XElement xmlDenominazioneRegione = item.Element("denominazione_regione");
                XElement xmlLat = item.Element("lat");
                XElement xmlLong = item.Element("long");
                XElement xmlRicoverati = item.Element("ricoverati_con_sintomi");
                XElement xmlTerapiaIntensiva = item.Element("terapia_intensiva");
                XElement xmlOspedalizzati = item.Element("totale_ospedalizzati");
                XElement xmlIsolamentoDomiciliare = item.Element("isolamento_domiciliare");
                XElement xmlPositivi = item.Element("totale_positivi");
                XElement xmlVariazionePositivi = item.Element("variazione_totale_positivi");
                XElement xmlNuoviPositivi = item.Element("nuovi_positivi");
                XElement xmlDimessiGuariti = item.Element("dimessi_guariti");
                XElement xmlDeceduti = item.Element("deceduti");
                XElement xmlTotaleCasi = item.Element("totale_casi");
                XElement xmlTamponi = item.Element("tamponi");

                Regione regione = new Regione();
                {
                    regione.Data = Convert.ToDateTime(xmlData.Value);
                    regione.Stato = xmlStato.Value;
                    regione.CodiceRegione = Convert.ToInt32(xmlCodiceRegione.Value);
                    regione.Denominazione_Regione = xmlDenominazioneRegione.Value;
                    regione.Latitudine = Convert.ToSingle(xmlLat.Value);
                    regione.Longitudine = Convert.ToSingle(xmlLong.Value);
                    regione.Ricoverati = Convert.ToInt32(xmlRicoverati.Value);
                    regione.Terapia_Intensiva = Convert.ToInt32(xmlTerapiaIntensiva.Value);
                    regione.Ospedalizzati = Convert.ToInt32(xmlOspedalizzati.Value);
                    regione.Isolamento_Domicìlianare = Convert.ToInt32(xmlIsolamentoDomiciliare.Value);
                    regione.Positivi = Convert.ToInt32(xmlPositivi.Value);
                    regione.Variazione_Positivi = Convert.ToInt32(xmlVariazionePositivi.Value);
                    regione.Nuovi_Positivi = Convert.ToInt32(xmlNuoviPositivi.Value);
                    regione.Dimessi_Guariti = Convert.ToInt32(xmlDimessiGuariti.Value);
                    regione.Deceduti = Convert.ToInt32(xmlDeceduti.Value);
                    regione.Totale_Casi = Convert.ToInt32(xmlTotaleCasi.Value);
                    regione.Tamponi = Convert.ToInt32(xmlTamponi.Value);
                }

                // Controllo se esiste la regione ricercata
                if (Txt_Regione.Text.Contains(regione.Denominazione_Regione))
                    Lst_RiepilogoDati.Items.Add(regione); // Stampo i dati della regione ricercata
            }
        }
    }
}
