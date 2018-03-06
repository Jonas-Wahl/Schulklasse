using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schulverwaltung
{
    public partial class Form1 : Form
    {
        Schueler aktSchueler;
        Schulklasse klasse;
        public Form1()
        {
            InitializeComponent();
            klasse = new Schulklasse();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String aName;
            String aVorname;
            String aStrasse;
            String aHNr; 
            uint aPLZ;
            String aOrt;
            String aTelNr;
            String aGebDatum;
            
            try
            {
                aName = tbName.Text;
                aVorname = tbVorname.Text;
                aStrasse = tbStrasse.Text;
                aHNr = tbHausnummer.Text;
                aPLZ = Convert.ToUInt32(tbPLZ.Text);
                aOrt = tbOrt.Text;
                aTelNr = tbTelefon.Text;
                aGebDatum = tbGeburtsdatum.Text;
                
                klasse.addSchueler(aName, aVorname, aStrasse, aHNr, aPLZ, aOrt, aTelNr, aGebDatum);
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showList()
        {
            Schueler s;
            ListViewItem locLvwItem;
            try
            {
                lvSchueler.BeginUpdate();
                lvSchueler.Items.Clear();
                for(int i = 0; i < klasse.AnzahlSchueler; i++)
                {
                    s = klasse.getSchueler(i);

                    locLvwItem = new ListViewItem(s.Name);
                    locLvwItem.Tag = s;
                    locLvwItem.SubItems.Add(s.Vorname);
                    locLvwItem.SubItems.Add(s.Strasse + " " + s.Hausnummer);
                    locLvwItem.SubItems.Add(s.PLZ.ToString());
                    locLvwItem.SubItems.Add(s.Ort);
                    locLvwItem.SubItems.Add(s.Telefon);
                    locLvwItem.SubItems.Add(s.GebDatum);
                    lvSchueler.Items.Add(locLvwItem);
                }
                lvSchueler.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                aktSchueler.Name = tbName.Text;
                aktSchueler.Vorname = tbVorname.Text;
                aktSchueler.Strasse = tbStrasse.Text;
                aktSchueler.Hausnummer = tbHausnummer.Text;
                aktSchueler.PLZ = Convert.ToUInt32(tbPLZ.Text);
                aktSchueler.Ort = tbOrt.Text;
                aktSchueler.Telefon = tbTelefon.Text;
                aktSchueler.GebDatum = tbGeburtsdatum.Text;
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lvSchueler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSchueler.SelectedIndices.Count > 0)
            {
                aktSchueler = lvSchueler.SelectedItems[0].Tag as Schueler;
                updateDetail();
            }
        }

        private void updateDetail()
        {
            try
            {
                tbName.Text = aktSchueler.Name;
                tbVorname.Text = aktSchueler.Vorname;
                tbStrasse.Text = aktSchueler.Strasse;
                tbHausnummer.Text = aktSchueler.Hausnummer;
                tbPLZ.Text = aktSchueler.PLZ.ToString();
                tbOrt.Text = aktSchueler.Ort;
                tbTelefon.Text = aktSchueler.Telefon;
                tbGeburtsdatum.Text = aktSchueler.GebDatum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                klasse.deleteSchueler(aktSchueler);
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ts_Export_Click(object sender, EventArgs e)
        {
            try
            {
                klasse.Export2CSV("D:\\csv.csv");
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ts_Import_Click(object sender, EventArgs e)
        {
            try
            {
                klasse.ImportFromCsv("D:\\csv.csv");
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsCloudSave_Click(object sender, EventArgs e)
        {
            try
            {
                klasse.SaveSchueler();
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tsCloudLoad_Click(object sender, EventArgs e)
        {
            try
            {
                klasse.loadSchueler();
                showList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
