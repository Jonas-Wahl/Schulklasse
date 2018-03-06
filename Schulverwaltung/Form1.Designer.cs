namespace Schulverwaltung
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbVorname = new System.Windows.Forms.TextBox();
            this.tbStrasse = new System.Windows.Forms.TextBox();
            this.tbPLZ = new System.Windows.Forms.TextBox();
            this.tbOrt = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbGeburtsdatum = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbHausnummer = new System.Windows.Forms.TextBox();
            this.lvSchueler = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Vorname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Strasse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PLZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TelefonNr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GebDatum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ts_Export = new System.Windows.Forms.ToolStripLabel();
            this.ts_Import = new System.Windows.Forms.ToolStripLabel();
            this.tsCloudSave = new System.Windows.Forms.ToolStripLabel();
            this.tsCloudLoad = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schülerdaten bearbeiten";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vorname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "TelefonNr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Geb.-Datum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(83, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Straße";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(75, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "PLZ";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(129, 71);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 8;
            // 
            // tbVorname
            // 
            this.tbVorname.Location = new System.Drawing.Point(129, 93);
            this.tbVorname.Name = "tbVorname";
            this.tbVorname.Size = new System.Drawing.Size(100, 20);
            this.tbVorname.TabIndex = 9;
            // 
            // tbStrasse
            // 
            this.tbStrasse.Location = new System.Drawing.Point(129, 114);
            this.tbStrasse.Name = "tbStrasse";
            this.tbStrasse.Size = new System.Drawing.Size(100, 20);
            this.tbStrasse.TabIndex = 10;
            // 
            // tbPLZ
            // 
            this.tbPLZ.Location = new System.Drawing.Point(129, 135);
            this.tbPLZ.Name = "tbPLZ";
            this.tbPLZ.Size = new System.Drawing.Size(100, 20);
            this.tbPLZ.TabIndex = 12;
            // 
            // tbOrt
            // 
            this.tbOrt.Location = new System.Drawing.Point(129, 156);
            this.tbOrt.Name = "tbOrt";
            this.tbOrt.Size = new System.Drawing.Size(100, 20);
            this.tbOrt.TabIndex = 13;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(129, 177);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(100, 20);
            this.tbTelefon.TabIndex = 14;
            // 
            // tbGeburtsdatum
            // 
            this.tbGeburtsdatum.Location = new System.Drawing.Point(129, 198);
            this.tbGeburtsdatum.Name = "tbGeburtsdatum";
            this.tbGeburtsdatum.Size = new System.Drawing.Size(100, 20);
            this.tbGeburtsdatum.TabIndex = 15;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(316, 114);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(160, 30);
            this.btnDel.TabIndex = 16;
            this.btnDel.Text = "Schüler löschen";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(316, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 30);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Daten übernehmen";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(316, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 30);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Neuen Schüler anlegen";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbHausnummer
            // 
            this.tbHausnummer.Location = new System.Drawing.Point(235, 114);
            this.tbHausnummer.Name = "tbHausnummer";
            this.tbHausnummer.Size = new System.Drawing.Size(28, 20);
            this.tbHausnummer.TabIndex = 11;
            // 
            // lvSchueler
            // 
            this.lvSchueler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Vorname,
            this.Strasse,
            this.PLZ,
            this.Ort,
            this.TelefonNr,
            this.GebDatum});
            this.lvSchueler.FullRowSelect = true;
            this.lvSchueler.GridLines = true;
            this.lvSchueler.HideSelection = false;
            this.lvSchueler.Location = new System.Drawing.Point(20, 250);
            this.lvSchueler.MultiSelect = false;
            this.lvSchueler.Name = "lvSchueler";
            this.lvSchueler.Size = new System.Drawing.Size(642, 245);
            this.lvSchueler.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvSchueler.TabIndex = 19;
            this.lvSchueler.UseCompatibleStateImageBehavior = false;
            this.lvSchueler.View = System.Windows.Forms.View.Details;
            this.lvSchueler.SelectedIndexChanged += new System.EventHandler(this.lvSchueler_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 80;
            // 
            // Vorname
            // 
            this.Vorname.Text = "Vorname";
            this.Vorname.Width = 80;
            // 
            // Strasse
            // 
            this.Strasse.Text = "Straße/HNr";
            this.Strasse.Width = 80;
            // 
            // PLZ
            // 
            this.PLZ.Text = "PLZ";
            this.PLZ.Width = 80;
            // 
            // Ort
            // 
            this.Ort.Text = "Ort";
            this.Ort.Width = 80;
            // 
            // TelefonNr
            // 
            this.TelefonNr.Text = "TelefonNr";
            this.TelefonNr.Width = 80;
            // 
            // GebDatum
            // 
            this.GebDatum.Text = "Geb.-Datum";
            this.GebDatum.Width = 160;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Export,
            this.ts_Import,
            this.tsCloudSave,
            this.tsCloudLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ts_Export
            // 
            this.ts_Export.Name = "ts_Export";
            this.ts_Export.Size = new System.Drawing.Size(66, 22);
            this.ts_Export.Text = "CSV-Export";
            this.ts_Export.Click += new System.EventHandler(this.ts_Export_Click);
            // 
            // ts_Import
            // 
            this.ts_Import.Name = "ts_Import";
            this.ts_Import.Size = new System.Drawing.Size(69, 22);
            this.ts_Import.Text = "CSV-Import";
            this.ts_Import.Click += new System.EventHandler(this.ts_Import_Click);
            // 
            // tsCloudSave
            // 
            this.tsCloudSave.Name = "tsCloudSave";
            this.tsCloudSave.Size = new System.Drawing.Size(106, 22);
            this.tsCloudSave.Text = "In Cloud speichern";
            this.tsCloudSave.Click += new System.EventHandler(this.tsCloudSave_Click);
            // 
            // tsCloudLoad
            // 
            this.tsCloudLoad.Name = "tsCloudLoad";
            this.tsCloudLoad.Size = new System.Drawing.Size(94, 22);
            this.tsCloudLoad.Text = "Von Cloud laden";
            this.tsCloudLoad.Click += new System.EventHandler(this.tsCloudLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 507);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lvSchueler);
            this.Controls.Add(this.tbHausnummer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.tbGeburtsdatum);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbOrt);
            this.Controls.Add(this.tbPLZ);
            this.Controls.Add(this.tbStrasse);
            this.Controls.Add(this.tbVorname);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Text = " Schulverwaltung";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbVorname;
        private System.Windows.Forms.TextBox tbStrasse;
        private System.Windows.Forms.TextBox tbPLZ;
        private System.Windows.Forms.TextBox tbOrt;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbGeburtsdatum;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbHausnummer;
        private System.Windows.Forms.ListView lvSchueler;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Vorname;
        private System.Windows.Forms.ColumnHeader Strasse;
        private System.Windows.Forms.ColumnHeader PLZ;
        private System.Windows.Forms.ColumnHeader Ort;
        private System.Windows.Forms.ColumnHeader TelefonNr;
        private System.Windows.Forms.ColumnHeader GebDatum;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ts_Export;
        private System.Windows.Forms.ToolStripLabel ts_Import;
        private System.Windows.Forms.ToolStripLabel tsCloudSave;
        private System.Windows.Forms.ToolStripLabel tsCloudLoad;
    }
}

