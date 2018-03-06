using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Schulverwaltung
{
    class Schulklasse
    {
        private int maxSchueler = 3;

        private List<Schueler> liSchueler;

        public int AnzahlSchueler
        {
            get { return liSchueler.Count; }
        }
        

        public Schulklasse()
        {
            liSchueler = new List<Schueler>();
        }

        public void addSchueler(String aName, String aVorname, String aStrasse, String aHNr,
                uint aPLZ, String aOrt, String aTelNr, DateTime aGebDatum)
        {
            if (AnzahlSchueler >= maxSchueler)
            {
                throw new Exception("Klasse kann nicht größer werden als " + maxSchueler.ToString() + " Schüler!");
            }

            Schueler aSchueler = new Schueler(aName, aVorname, aStrasse, aHNr, aPLZ, aOrt, aTelNr, aGebDatum);
            liSchueler.Add(aSchueler);
        }

        public void deleteSchueler(Schueler aSchueler)
        {
            liSchueler.Remove(aSchueler);
        }
        
        public void deleteSchueler(int iIndex)
        {
            if (iIndex < 0 || iIndex >= AnzahlSchueler)
            {
                throw new Exception("Schüler existiert nicht!");
            }
            liSchueler.RemoveAt(iIndex);
        }

        public Schueler getSchueler(int iIndex)
        {
            if (iIndex < 0 || iIndex >= AnzahlSchueler)
            {
                throw new Exception("Schüler existiert nicht!");
            }
            return liSchueler[iIndex];
        }

        public void Export2CSV(String filename)
        {
            FileStream fs = new FileStream(filename,FileMode.Create, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (Schueler s in liSchueler)
            {
                sw.WriteLine(s.toCSV());
            }
            sw.Close();
            fs.Close();
        }

        public void ImportFromCsv(String filename)
        {
            String s;
            String[] ls;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                s = sr.ReadLine();
                ls = s.Split(',');
                addSchueler(ls[0], ls[1], ls[2], ls[3], Convert.ToUInt32(ls[4]), ls[5], ls[6], Convert.ToDateTime(ls[7]));
            }
            sr.Close();
            fs.Close();
        }
    }
}
