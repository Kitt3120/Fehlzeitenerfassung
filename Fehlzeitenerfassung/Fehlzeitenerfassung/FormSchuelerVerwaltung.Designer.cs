namespace Fehlzeitenerfassung
{
    partial class FormSchuelerVerwaltung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSchuelerVerwaltung));
            this.labelBereichsleiter = new System.Windows.Forms.Label();
            this.comboBoxBereichsleiter = new System.Windows.Forms.ComboBox();
            this.groupBoxSchuelerVerwaltung = new System.Windows.Forms.GroupBox();
            this.buttonSchuelerVerwaltenSchuelerAnlegen = new System.Windows.Forms.Button();
            this.checkBoxSchuelerVerwaltenBusfahrkarte = new System.Windows.Forms.CheckBox();
            this.labelSchuelerVerwaltenBusfahrkarte = new System.Windows.Forms.Label();
            this.textBoxSchuelerVerwaltenAnfahrt = new System.Windows.Forms.TextBox();
            this.labelSchuelerVerwaltenAnfahrt = new System.Windows.Forms.Label();
            this.labelSchuelerVerwaltenGeburtsdatum = new System.Windows.Forms.Label();
            this.labelSchuelerVerwaltenVorname = new System.Windows.Forms.Label();
            this.labelSchuelerVerwaltenName = new System.Windows.Forms.Label();
            this.textBoxSchuelerVerwaltenGeburtsdatum = new System.Windows.Forms.TextBox();
            this.textBoxSchuelerVerwaltenName = new System.Windows.Forms.TextBox();
            this.textBoxSchuelerVerwaltenVorname = new System.Windows.Forms.TextBox();
            this.groupBoxFehlzeitenVerwalten = new System.Windows.Forms.GroupBox();
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen = new System.Windows.Forms.Button();
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt = new System.Windows.Forms.TextBox();
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt = new System.Windows.Forms.Label();
            this.comboBoxFehlzeitenVerwaltenSchueler = new System.Windows.Forms.ComboBox();
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden = new System.Windows.Forms.TextBox();
            this.textBoxFehlzeitenVerwaltenDatum = new System.Windows.Forms.TextBox();
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden = new System.Windows.Forms.Label();
            this.labelFehlzeitenVerwaltenDatum = new System.Windows.Forms.Label();
            this.labelFehlzeitenVerwaltenSchueler = new System.Windows.Forms.Label();
            this.groupBoxFehlzeitenAnzeigen = new System.Windows.Forms.GroupBox();
            this.buttonBeenden = new System.Windows.Forms.Button();
            this.buttonFehlzeitenAnzeigenDatenSichern = new System.Windows.Forms.Button();
            this.buttonFehlzeitenAnzeigenDatenLaden = new System.Windows.Forms.Button();
            this.textBoxFehlzeitenAnzeigenAusgabe = new System.Windows.Forms.TextBox();
            this.comboBoxFehlzeitenAnzeigenSchueler = new System.Windows.Forms.ComboBox();
            this.labelFehlzeitenAnzeigenSchueler = new System.Windows.Forms.Label();
            this.checkBoxFehlzeitenAnzeigenDetails = new System.Windows.Forms.CheckBox();
            this.groupBoxSchuelerVerwaltung.SuspendLayout();
            this.groupBoxFehlzeitenVerwalten.SuspendLayout();
            this.groupBoxFehlzeitenAnzeigen.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBereichsleiter
            // 
            this.labelBereichsleiter.AutoSize = true;
            this.labelBereichsleiter.Location = new System.Drawing.Point(12, 9);
            this.labelBereichsleiter.Name = "labelBereichsleiter";
            this.labelBereichsleiter.Size = new System.Drawing.Size(126, 13);
            this.labelBereichsleiter.TabIndex = 0;
            this.labelBereichsleiter.Text = "Name des Bereichsleiters";
            // 
            // comboBoxBereichsleiter
            // 
            this.comboBoxBereichsleiter.FormattingEnabled = true;
            this.comboBoxBereichsleiter.Location = new System.Drawing.Point(144, 6);
            this.comboBoxBereichsleiter.Name = "comboBoxBereichsleiter";
            this.comboBoxBereichsleiter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBereichsleiter.TabIndex = 0;
            // 
            // groupBoxSchuelerVerwaltung
            // 
            this.groupBoxSchuelerVerwaltung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.buttonSchuelerVerwaltenSchuelerAnlegen);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.checkBoxSchuelerVerwaltenBusfahrkarte);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.labelSchuelerVerwaltenBusfahrkarte);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.textBoxSchuelerVerwaltenAnfahrt);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.labelSchuelerVerwaltenAnfahrt);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.labelSchuelerVerwaltenGeburtsdatum);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.labelSchuelerVerwaltenVorname);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.labelSchuelerVerwaltenName);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.textBoxSchuelerVerwaltenGeburtsdatum);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.textBoxSchuelerVerwaltenName);
            this.groupBoxSchuelerVerwaltung.Controls.Add(this.textBoxSchuelerVerwaltenVorname);
            this.groupBoxSchuelerVerwaltung.Location = new System.Drawing.Point(15, 33);
            this.groupBoxSchuelerVerwaltung.Name = "groupBoxSchuelerVerwaltung";
            this.groupBoxSchuelerVerwaltung.Size = new System.Drawing.Size(250, 165);
            this.groupBoxSchuelerVerwaltung.TabIndex = 2;
            this.groupBoxSchuelerVerwaltung.TabStop = false;
            this.groupBoxSchuelerVerwaltung.Text = "Schüler verwalten";
            // 
            // buttonSchuelerVerwaltenSchuelerAnlegen
            // 
            this.buttonSchuelerVerwaltenSchuelerAnlegen.Location = new System.Drawing.Point(7, 129);
            this.buttonSchuelerVerwaltenSchuelerAnlegen.Name = "buttonSchuelerVerwaltenSchuelerAnlegen";
            this.buttonSchuelerVerwaltenSchuelerAnlegen.Size = new System.Drawing.Size(116, 23);
            this.buttonSchuelerVerwaltenSchuelerAnlegen.TabIndex = 6;
            this.buttonSchuelerVerwaltenSchuelerAnlegen.Text = "Schüler anlegen";
            this.buttonSchuelerVerwaltenSchuelerAnlegen.UseVisualStyleBackColor = true;
            this.buttonSchuelerVerwaltenSchuelerAnlegen.Click += new System.EventHandler(this.buttonSchuelerVerwaltenSchuelerAnlegen_Click);
            // 
            // checkBoxSchuelerVerwaltenBusfahrkarte
            // 
            this.checkBoxSchuelerVerwaltenBusfahrkarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSchuelerVerwaltenBusfahrkarte.AutoSize = true;
            this.checkBoxSchuelerVerwaltenBusfahrkarte.Enabled = false;
            this.checkBoxSchuelerVerwaltenBusfahrkarte.Location = new System.Drawing.Point(204, 105);
            this.checkBoxSchuelerVerwaltenBusfahrkarte.Name = "checkBoxSchuelerVerwaltenBusfahrkarte";
            this.checkBoxSchuelerVerwaltenBusfahrkarte.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSchuelerVerwaltenBusfahrkarte.TabIndex = 5;
            this.checkBoxSchuelerVerwaltenBusfahrkarte.UseVisualStyleBackColor = true;
            // 
            // labelSchuelerVerwaltenBusfahrkarte
            // 
            this.labelSchuelerVerwaltenBusfahrkarte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSchuelerVerwaltenBusfahrkarte.AutoSize = true;
            this.labelSchuelerVerwaltenBusfahrkarte.Location = new System.Drawing.Point(131, 106);
            this.labelSchuelerVerwaltenBusfahrkarte.Name = "labelSchuelerVerwaltenBusfahrkarte";
            this.labelSchuelerVerwaltenBusfahrkarte.Size = new System.Drawing.Size(67, 13);
            this.labelSchuelerVerwaltenBusfahrkarte.TabIndex = 8;
            this.labelSchuelerVerwaltenBusfahrkarte.Text = "Busfahrkarte";
            // 
            // textBoxSchuelerVerwaltenAnfahrt
            // 
            this.textBoxSchuelerVerwaltenAnfahrt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchuelerVerwaltenAnfahrt.Location = new System.Drawing.Point(85, 103);
            this.textBoxSchuelerVerwaltenAnfahrt.Name = "textBoxSchuelerVerwaltenAnfahrt";
            this.textBoxSchuelerVerwaltenAnfahrt.Size = new System.Drawing.Size(40, 20);
            this.textBoxSchuelerVerwaltenAnfahrt.TabIndex = 4;
            this.textBoxSchuelerVerwaltenAnfahrt.TextChanged += new System.EventHandler(this.textBoxSchuelerVerwaltenAnfahrt_TextChanged);
            // 
            // labelSchuelerVerwaltenAnfahrt
            // 
            this.labelSchuelerVerwaltenAnfahrt.AutoSize = true;
            this.labelSchuelerVerwaltenAnfahrt.Location = new System.Drawing.Point(6, 106);
            this.labelSchuelerVerwaltenAnfahrt.Name = "labelSchuelerVerwaltenAnfahrt";
            this.labelSchuelerVerwaltenAnfahrt.Size = new System.Drawing.Size(64, 13);
            this.labelSchuelerVerwaltenAnfahrt.TabIndex = 6;
            this.labelSchuelerVerwaltenAnfahrt.Text = "Anfahrt (km)";
            // 
            // labelSchuelerVerwaltenGeburtsdatum
            // 
            this.labelSchuelerVerwaltenGeburtsdatum.AutoSize = true;
            this.labelSchuelerVerwaltenGeburtsdatum.Location = new System.Drawing.Point(6, 80);
            this.labelSchuelerVerwaltenGeburtsdatum.Name = "labelSchuelerVerwaltenGeburtsdatum";
            this.labelSchuelerVerwaltenGeburtsdatum.Size = new System.Drawing.Size(73, 13);
            this.labelSchuelerVerwaltenGeburtsdatum.TabIndex = 5;
            this.labelSchuelerVerwaltenGeburtsdatum.Text = "Geburtsdatum";
            // 
            // labelSchuelerVerwaltenVorname
            // 
            this.labelSchuelerVerwaltenVorname.AutoSize = true;
            this.labelSchuelerVerwaltenVorname.Location = new System.Drawing.Point(6, 54);
            this.labelSchuelerVerwaltenVorname.Name = "labelSchuelerVerwaltenVorname";
            this.labelSchuelerVerwaltenVorname.Size = new System.Drawing.Size(49, 13);
            this.labelSchuelerVerwaltenVorname.TabIndex = 4;
            this.labelSchuelerVerwaltenVorname.Text = "Vorname";
            // 
            // labelSchuelerVerwaltenName
            // 
            this.labelSchuelerVerwaltenName.AutoSize = true;
            this.labelSchuelerVerwaltenName.Location = new System.Drawing.Point(6, 28);
            this.labelSchuelerVerwaltenName.Name = "labelSchuelerVerwaltenName";
            this.labelSchuelerVerwaltenName.Size = new System.Drawing.Size(35, 13);
            this.labelSchuelerVerwaltenName.TabIndex = 3;
            this.labelSchuelerVerwaltenName.Text = "Name";
            // 
            // textBoxSchuelerVerwaltenGeburtsdatum
            // 
            this.textBoxSchuelerVerwaltenGeburtsdatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchuelerVerwaltenGeburtsdatum.Location = new System.Drawing.Point(85, 77);
            this.textBoxSchuelerVerwaltenGeburtsdatum.Name = "textBoxSchuelerVerwaltenGeburtsdatum";
            this.textBoxSchuelerVerwaltenGeburtsdatum.Size = new System.Drawing.Size(160, 20);
            this.textBoxSchuelerVerwaltenGeburtsdatum.TabIndex = 3;
            // 
            // textBoxSchuelerVerwaltenName
            // 
            this.textBoxSchuelerVerwaltenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchuelerVerwaltenName.Location = new System.Drawing.Point(85, 25);
            this.textBoxSchuelerVerwaltenName.Name = "textBoxSchuelerVerwaltenName";
            this.textBoxSchuelerVerwaltenName.Size = new System.Drawing.Size(160, 20);
            this.textBoxSchuelerVerwaltenName.TabIndex = 1;
            // 
            // textBoxSchuelerVerwaltenVorname
            // 
            this.textBoxSchuelerVerwaltenVorname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSchuelerVerwaltenVorname.Location = new System.Drawing.Point(85, 51);
            this.textBoxSchuelerVerwaltenVorname.Name = "textBoxSchuelerVerwaltenVorname";
            this.textBoxSchuelerVerwaltenVorname.Size = new System.Drawing.Size(160, 20);
            this.textBoxSchuelerVerwaltenVorname.TabIndex = 2;
            // 
            // groupBoxFehlzeitenVerwalten
            // 
            this.groupBoxFehlzeitenVerwalten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.buttonFehlzeitenVerwaltenFehlzeitAnlegen);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.labelFehlzeitenVerwaltenAnzahlEntschuldigt);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.comboBoxFehlzeitenVerwaltenSchueler);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.textBoxFehlzeitenVerwaltenDatum);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.labelFehlzeitenVerwaltenAnzahlFehlstunden);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.labelFehlzeitenVerwaltenDatum);
            this.groupBoxFehlzeitenVerwalten.Controls.Add(this.labelFehlzeitenVerwaltenSchueler);
            this.groupBoxFehlzeitenVerwalten.Location = new System.Drawing.Point(271, 33);
            this.groupBoxFehlzeitenVerwalten.Name = "groupBoxFehlzeitenVerwalten";
            this.groupBoxFehlzeitenVerwalten.Size = new System.Drawing.Size(235, 165);
            this.groupBoxFehlzeitenVerwalten.TabIndex = 3;
            this.groupBoxFehlzeitenVerwalten.TabStop = false;
            this.groupBoxFehlzeitenVerwalten.Text = "Fehlzeiten verwalten";
            // 
            // buttonFehlzeitenVerwaltenFehlzeitAnlegen
            // 
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.Location = new System.Drawing.Point(103, 129);
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.Name = "buttonFehlzeitenVerwaltenFehlzeitAnlegen";
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.Size = new System.Drawing.Size(116, 23);
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.TabIndex = 11;
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.Text = "Fehlzeit eintragen";
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.UseVisualStyleBackColor = true;
            this.buttonFehlzeitenVerwaltenFehlzeitAnlegen.Click += new System.EventHandler(this.buttonFehlzeitenVerwaltenFehlzeitAnlegen_Click);
            // 
            // textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt
            // 
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt.Location = new System.Drawing.Point(204, 77);
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt.Name = "textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt";
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt.Size = new System.Drawing.Size(25, 20);
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt.TabIndex = 10;
            // 
            // labelFehlzeitenVerwaltenAnzahlEntschuldigt
            // 
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.AutoSize = true;
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.Location = new System.Drawing.Point(108, 80);
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.Name = "labelFehlzeitenVerwaltenAnzahlEntschuldigt";
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.Size = new System.Drawing.Size(97, 13);
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.TabIndex = 7;
            this.labelFehlzeitenVerwaltenAnzahlEntschuldigt.Text = "davon entschuldigt";
            // 
            // comboBoxFehlzeitenVerwaltenSchueler
            // 
            this.comboBoxFehlzeitenVerwaltenSchueler.FormattingEnabled = true;
            this.comboBoxFehlzeitenVerwaltenSchueler.Location = new System.Drawing.Point(103, 25);
            this.comboBoxFehlzeitenVerwaltenSchueler.Name = "comboBoxFehlzeitenVerwaltenSchueler";
            this.comboBoxFehlzeitenVerwaltenSchueler.Size = new System.Drawing.Size(126, 21);
            this.comboBoxFehlzeitenVerwaltenSchueler.TabIndex = 7;
            // 
            // textBoxFehlzeitenVerwaltenAnzahlFehlstunden
            // 
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden.Location = new System.Drawing.Point(77, 77);
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden.Name = "textBoxFehlzeitenVerwaltenAnzahlFehlstunden";
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden.Size = new System.Drawing.Size(25, 20);
            this.textBoxFehlzeitenVerwaltenAnzahlFehlstunden.TabIndex = 9;
            // 
            // textBoxFehlzeitenVerwaltenDatum
            // 
            this.textBoxFehlzeitenVerwaltenDatum.Location = new System.Drawing.Point(103, 51);
            this.textBoxFehlzeitenVerwaltenDatum.Name = "textBoxFehlzeitenVerwaltenDatum";
            this.textBoxFehlzeitenVerwaltenDatum.Size = new System.Drawing.Size(126, 20);
            this.textBoxFehlzeitenVerwaltenDatum.TabIndex = 8;
            // 
            // labelFehlzeitenVerwaltenAnzahlFehlstunden
            // 
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.AutoSize = true;
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.Location = new System.Drawing.Point(6, 80);
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.Name = "labelFehlzeitenVerwaltenAnzahlFehlstunden";
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.Size = new System.Drawing.Size(65, 13);
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.TabIndex = 2;
            this.labelFehlzeitenVerwaltenAnzahlFehlstunden.Text = "Fehlstunden";
            // 
            // labelFehlzeitenVerwaltenDatum
            // 
            this.labelFehlzeitenVerwaltenDatum.AutoSize = true;
            this.labelFehlzeitenVerwaltenDatum.Location = new System.Drawing.Point(6, 54);
            this.labelFehlzeitenVerwaltenDatum.Name = "labelFehlzeitenVerwaltenDatum";
            this.labelFehlzeitenVerwaltenDatum.Size = new System.Drawing.Size(38, 13);
            this.labelFehlzeitenVerwaltenDatum.TabIndex = 1;
            this.labelFehlzeitenVerwaltenDatum.Text = "Datum";
            // 
            // labelFehlzeitenVerwaltenSchueler
            // 
            this.labelFehlzeitenVerwaltenSchueler.AutoSize = true;
            this.labelFehlzeitenVerwaltenSchueler.Location = new System.Drawing.Point(6, 28);
            this.labelFehlzeitenVerwaltenSchueler.Name = "labelFehlzeitenVerwaltenSchueler";
            this.labelFehlzeitenVerwaltenSchueler.Size = new System.Drawing.Size(43, 13);
            this.labelFehlzeitenVerwaltenSchueler.TabIndex = 0;
            this.labelFehlzeitenVerwaltenSchueler.Text = "Schüler";
            // 
            // groupBoxFehlzeitenAnzeigen
            // 
            this.groupBoxFehlzeitenAnzeigen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.checkBoxFehlzeitenAnzeigenDetails);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.buttonBeenden);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.buttonFehlzeitenAnzeigenDatenSichern);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.buttonFehlzeitenAnzeigenDatenLaden);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.textBoxFehlzeitenAnzeigenAusgabe);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.comboBoxFehlzeitenAnzeigenSchueler);
            this.groupBoxFehlzeitenAnzeigen.Controls.Add(this.labelFehlzeitenAnzeigenSchueler);
            this.groupBoxFehlzeitenAnzeigen.Location = new System.Drawing.Point(15, 204);
            this.groupBoxFehlzeitenAnzeigen.Name = "groupBoxFehlzeitenAnzeigen";
            this.groupBoxFehlzeitenAnzeigen.Size = new System.Drawing.Size(491, 214);
            this.groupBoxFehlzeitenAnzeigen.TabIndex = 10;
            this.groupBoxFehlzeitenAnzeigen.TabStop = false;
            this.groupBoxFehlzeitenAnzeigen.Text = "Fehlzeiten anzeigen";
            // 
            // buttonBeenden
            // 
            this.buttonBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBeenden.Location = new System.Drawing.Point(356, 185);
            this.buttonBeenden.Name = "buttonBeenden";
            this.buttonBeenden.Size = new System.Drawing.Size(129, 23);
            this.buttonBeenden.TabIndex = 15;
            this.buttonBeenden.Text = "Beenden";
            this.buttonBeenden.UseVisualStyleBackColor = true;
            this.buttonBeenden.Click += new System.EventHandler(this.buttonBeenden_Click);
            // 
            // buttonFehlzeitenAnzeigenDatenSichern
            // 
            this.buttonFehlzeitenAnzeigenDatenSichern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFehlzeitenAnzeigenDatenSichern.Location = new System.Drawing.Point(144, 185);
            this.buttonFehlzeitenAnzeigenDatenSichern.Name = "buttonFehlzeitenAnzeigenDatenSichern";
            this.buttonFehlzeitenAnzeigenDatenSichern.Size = new System.Drawing.Size(129, 23);
            this.buttonFehlzeitenAnzeigenDatenSichern.TabIndex = 14;
            this.buttonFehlzeitenAnzeigenDatenSichern.Text = "Schülerdaten sichern...";
            this.buttonFehlzeitenAnzeigenDatenSichern.UseVisualStyleBackColor = true;
            this.buttonFehlzeitenAnzeigenDatenSichern.Click += new System.EventHandler(this.buttonFehlzeitenAnzeigenDatenSichern_Click);
            // 
            // buttonFehlzeitenAnzeigenDatenLaden
            // 
            this.buttonFehlzeitenAnzeigenDatenLaden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonFehlzeitenAnzeigenDatenLaden.Location = new System.Drawing.Point(9, 185);
            this.buttonFehlzeitenAnzeigenDatenLaden.Name = "buttonFehlzeitenAnzeigenDatenLaden";
            this.buttonFehlzeitenAnzeigenDatenLaden.Size = new System.Drawing.Size(129, 23);
            this.buttonFehlzeitenAnzeigenDatenLaden.TabIndex = 13;
            this.buttonFehlzeitenAnzeigenDatenLaden.Text = "Schülerdaten laden...";
            this.buttonFehlzeitenAnzeigenDatenLaden.UseVisualStyleBackColor = true;
            this.buttonFehlzeitenAnzeigenDatenLaden.Click += new System.EventHandler(this.buttonFehlzeitenAnzeigenDatenLaden_Click);
            // 
            // textBoxFehlzeitenAnzeigenAusgabe
            // 
            this.textBoxFehlzeitenAnzeigenAusgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFehlzeitenAnzeigenAusgabe.Location = new System.Drawing.Point(6, 49);
            this.textBoxFehlzeitenAnzeigenAusgabe.Multiline = true;
            this.textBoxFehlzeitenAnzeigenAusgabe.Name = "textBoxFehlzeitenAnzeigenAusgabe";
            this.textBoxFehlzeitenAnzeigenAusgabe.ReadOnly = true;
            this.textBoxFehlzeitenAnzeigenAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFehlzeitenAnzeigenAusgabe.Size = new System.Drawing.Size(479, 130);
            this.textBoxFehlzeitenAnzeigenAusgabe.TabIndex = 0;
            this.textBoxFehlzeitenAnzeigenAusgabe.TabStop = false;
            // 
            // comboBoxFehlzeitenAnzeigenSchueler
            // 
            this.comboBoxFehlzeitenAnzeigenSchueler.FormattingEnabled = true;
            this.comboBoxFehlzeitenAnzeigenSchueler.Location = new System.Drawing.Point(55, 22);
            this.comboBoxFehlzeitenAnzeigenSchueler.Name = "comboBoxFehlzeitenAnzeigenSchueler";
            this.comboBoxFehlzeitenAnzeigenSchueler.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFehlzeitenAnzeigenSchueler.TabIndex = 12;
            this.comboBoxFehlzeitenAnzeigenSchueler.SelectedIndexChanged += new System.EventHandler(this.comboBoxFehlzeitenAnzeigenSchueler_SelectedIndexChanged);
            // 
            // labelFehlzeitenAnzeigenSchueler
            // 
            this.labelFehlzeitenAnzeigenSchueler.AutoSize = true;
            this.labelFehlzeitenAnzeigenSchueler.Location = new System.Drawing.Point(6, 25);
            this.labelFehlzeitenAnzeigenSchueler.Name = "labelFehlzeitenAnzeigenSchueler";
            this.labelFehlzeitenAnzeigenSchueler.Size = new System.Drawing.Size(43, 13);
            this.labelFehlzeitenAnzeigenSchueler.TabIndex = 3;
            this.labelFehlzeitenAnzeigenSchueler.Text = "Schüler";
            // 
            // checkBoxFehlzeitenAnzeigenDetails
            // 
            this.checkBoxFehlzeitenAnzeigenDetails.AutoSize = true;
            this.checkBoxFehlzeitenAnzeigenDetails.Location = new System.Drawing.Point(182, 24);
            this.checkBoxFehlzeitenAnzeigenDetails.Name = "checkBoxFehlzeitenAnzeigenDetails";
            this.checkBoxFehlzeitenAnzeigenDetails.Size = new System.Drawing.Size(58, 17);
            this.checkBoxFehlzeitenAnzeigenDetails.TabIndex = 16;
            this.checkBoxFehlzeitenAnzeigenDetails.Text = "Details";
            this.checkBoxFehlzeitenAnzeigenDetails.UseVisualStyleBackColor = true;
            this.checkBoxFehlzeitenAnzeigenDetails.CheckedChanged += new System.EventHandler(this.checkBoxFehlzeitenAnzeigenDetails_CheckedChanged);
            // 
            // FormSchuelerVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 430);
            this.Controls.Add(this.groupBoxFehlzeitenAnzeigen);
            this.Controls.Add(this.groupBoxFehlzeitenVerwalten);
            this.Controls.Add(this.groupBoxSchuelerVerwaltung);
            this.Controls.Add(this.comboBoxBereichsleiter);
            this.Controls.Add(this.labelBereichsleiter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(534, 469);
            this.Name = "FormSchuelerVerwaltung";
            this.Text = "Schülerverwaltung";
            this.Load += new System.EventHandler(this.FormSchuelerVerwaltung_Load);
            this.groupBoxSchuelerVerwaltung.ResumeLayout(false);
            this.groupBoxSchuelerVerwaltung.PerformLayout();
            this.groupBoxFehlzeitenVerwalten.ResumeLayout(false);
            this.groupBoxFehlzeitenVerwalten.PerformLayout();
            this.groupBoxFehlzeitenAnzeigen.ResumeLayout(false);
            this.groupBoxFehlzeitenAnzeigen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBereichsleiter;
        private System.Windows.Forms.ComboBox comboBoxBereichsleiter;
        private System.Windows.Forms.GroupBox groupBoxSchuelerVerwaltung;
        private System.Windows.Forms.Button buttonSchuelerVerwaltenSchuelerAnlegen;
        private System.Windows.Forms.CheckBox checkBoxSchuelerVerwaltenBusfahrkarte;
        private System.Windows.Forms.Label labelSchuelerVerwaltenBusfahrkarte;
        private System.Windows.Forms.TextBox textBoxSchuelerVerwaltenAnfahrt;
        private System.Windows.Forms.Label labelSchuelerVerwaltenAnfahrt;
        private System.Windows.Forms.Label labelSchuelerVerwaltenGeburtsdatum;
        private System.Windows.Forms.Label labelSchuelerVerwaltenVorname;
        private System.Windows.Forms.Label labelSchuelerVerwaltenName;
        private System.Windows.Forms.TextBox textBoxSchuelerVerwaltenGeburtsdatum;
        private System.Windows.Forms.TextBox textBoxSchuelerVerwaltenName;
        private System.Windows.Forms.TextBox textBoxSchuelerVerwaltenVorname;
        private System.Windows.Forms.GroupBox groupBoxFehlzeitenVerwalten;
        private System.Windows.Forms.Label labelFehlzeitenVerwaltenAnzahlEntschuldigt;
        private System.Windows.Forms.ComboBox comboBoxFehlzeitenVerwaltenSchueler;
        private System.Windows.Forms.TextBox textBoxFehlzeitenVerwaltenAnzahlFehlstunden;
        private System.Windows.Forms.TextBox textBoxFehlzeitenVerwaltenDatum;
        private System.Windows.Forms.Label labelFehlzeitenVerwaltenAnzahlFehlstunden;
        private System.Windows.Forms.Label labelFehlzeitenVerwaltenDatum;
        private System.Windows.Forms.Label labelFehlzeitenVerwaltenSchueler;
        private System.Windows.Forms.TextBox textBoxFehlzeitenVerwaltenAnzahlFehlstundenEntschuldigt;
        private System.Windows.Forms.Button buttonFehlzeitenVerwaltenFehlzeitAnlegen;
        private System.Windows.Forms.GroupBox groupBoxFehlzeitenAnzeigen;
        private System.Windows.Forms.Label labelFehlzeitenAnzeigenSchueler;
        private System.Windows.Forms.ComboBox comboBoxFehlzeitenAnzeigenSchueler;
        private System.Windows.Forms.TextBox textBoxFehlzeitenAnzeigenAusgabe;
        private System.Windows.Forms.Button buttonBeenden;
        private System.Windows.Forms.Button buttonFehlzeitenAnzeigenDatenSichern;
        private System.Windows.Forms.Button buttonFehlzeitenAnzeigenDatenLaden;
        private System.Windows.Forms.CheckBox checkBoxFehlzeitenAnzeigenDetails;
    }
}

