using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiepilogoDatiCovid19_ChristopherDeboli.Model
{
    public class Regione
    {
        public DateTime Data { get; set; }
        public string Stato { get; set; }
        public int CodiceRegione { get; set; }
        public string Denominazione_Regione { get; set; }
        public float Latitudine { get; set; }
        public float Longitudine { get; set; }
        public int Ricoverati { get; set; }
        public int Terapia_Intensiva { get; set; }
        public int Ospedalizzati { get; set; }
        public int Isolamento_Domicìlianare { get; set; }
        public int Positivi { get; set; }
        public int Variazione_Positivi { get; set; }
        public int Nuovi_Positivi { get; set; }
        public int Dimessi_Guariti { get; set; }
        public int Deceduti { get; set; }
        public int Totale_Casi { get; set; }
        public int Tamponi { get; set; }

        public override string ToString()
        {
            return $"Data: {Data}\nStato: {Stato}\nCodice Regione: {CodiceRegione}\n" +
                $"Denominazione Regione: {Denominazione_Regione}\nLatitudine: {Latitudine}\nLongitudine: {Longitudine}\n" +
                $"Ricoverati: {Ricoverati}\nTerapia Intensiva: {Terapia_Intensiva}\nTotale: Ospedalizzati{Ospedalizzati}\n" +
                $"Isolamento Domiciliare: {Isolamento_Domicìlianare}\nPositivi: {Positivi}\nVariazione Positivi{Variazione_Positivi}\n" +
                $"Nuovi Positivi: {Nuovi_Positivi}\nDimessi guariti: {Dimessi_Guariti}\nDeceduti: {Deceduti}\nTotale Casi:{Totale_Casi}\n" +
                $"Tamponi: {Tamponi}";
        }
    }
}
