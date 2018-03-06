using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulverwaltung
{
    class Schueler
    {
        private String sName;

        public String Name
        {
            get { return sName; }
            set { sName = value; }
        }

        private String sVorname;

        public String Vorname
        {
            get { return sVorname; }
            set { sVorname = value; }
        }

        private String sStrasse;

        public String Strasse
        {
            get { return sStrasse; }
            set { sStrasse = value; }
        }

        private String sHNr;

        public String Hausnummer
        {
            get { return sHNr; }
            set { sHNr = value; }
        }

        private uint uiPLZ;

        public uint PLZ
        {
            get { return uiPLZ; }
            set { uiPLZ = value; }
        }

        private String sOrt;

        public String Ort
        {
            get { return sOrt; }
            set { sOrt = value; }
        }

        private String sTelefon;

        public String Telefon
        {
            get { return sTelefon; }
            set { sTelefon = value; }
        }

        private DateTime dtGebDatum;

        public DateTime GebDatum
        {
            get { return dtGebDatum; }
            set { dtGebDatum = value; }
        }
        
        public Schueler(String aName, String aVorname, String aStrasse, String aHNr, 
                uint aPLZ, String aOrt, String aTelNr, DateTime aGebDatum)
        {
            Name = aName;
            Vorname = aVorname;
            Strasse = aStrasse;
            Hausnummer = aHNr;
            PLZ = aPLZ;
            Ort = aOrt;
            Telefon = aTelNr;
            GebDatum = aGebDatum;
        }

        public String toCSV()
        {
            String csv = "";
            String seperator = ",";
            foreach(var prop in this.GetType().GetProperties())
            {
                csv += prop.GetValue(this, null) + seperator;
            }
            return csv;
            //return Name + seperator + Vorname + seperator + Strasse + seperator + Hausnummer + seperator + PLZ.ToString() + seperator + Ort + seperator + Telefon + seperator + GebDatum.ToString();
        }

    }
}
