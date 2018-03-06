using Amazon.DynamoDBv2.DocumentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schulverwaltung
{
    class Schueler
    {
        private int sSchuelerId;

        public int SchuelerId
        {
            get { return sSchuelerId; }
            set
            {
                if (value > lastSchuelerId)
                {
                    lastSchuelerId = value;
                }
                sSchuelerId = value;
            }
        }

        private static int lastSchuelerId = 0;

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

        private String dtGebDatum;

        public String GebDatum
        {
            get { return dtGebDatum; }
            set { dtGebDatum = value; }
        }
        
        public Schueler() // used for deserializer
        {

        }

        public Schueler(String aName, String aVorname, String aStrasse, String aHNr, 
                uint aPLZ, String aOrt, String aTelNr, String aGebDatum)
        {
            SchuelerId = getNextSchuelerId();
            Name = aName;
            Vorname = aVorname;
            Strasse = aStrasse;
            Hausnummer = aHNr;
            PLZ = aPLZ;
            Ort = aOrt;
            Telefon = aTelNr;
            GebDatum = aGebDatum;
        }

        private static int getNextSchuelerId()
        {
            lastSchuelerId++;
            return lastSchuelerId;
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

        public Document toDoc()
        {
            var json = new System.Web.Script.Serialization.JavaScriptSerializer().Serialize(this);
            Document doc = Document.FromJson(json);
            return doc;
        }
    }
}
