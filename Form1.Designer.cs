namespace seminarski.inf
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label imeLabel;
            System.Windows.Forms.Label prezimeLabel;
            System.Windows.Forms.Label šifraLabel;
            System.Windows.Forms.Label datum_rodenjaLabel;
            System.Windows.Forms.Label naziv_sportaLabel;
            System.Windows.Forms.Label datum_mjerenjaLabel;
            System.Windows.Forms.Label rezultatLabel;
            System.Windows.Forms.Label pusacLabel;
            this.kraj6 = new System.Windows.Forms.Button();
            this.obrisi5 = new System.Windows.Forms.Button();
            this.spremi4 = new System.Windows.Forms.Button();
            this.dodaj3 = new System.Windows.Forms.Button();
            this.prethodni2 = new System.Windows.Forms.Button();
            this.sljedeci1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDUcenikaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.šifraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumrodenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pusacDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nazivsportaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datummjerenjaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rezultatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uceniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spirometrija_DataSet = new seminarski.inf.Spirometrija_DataSet();
            this.uceniciTableAdapter = new seminarski.inf.Spirometrija_DataSetTableAdapters.UceniciTableAdapter();
            this.tableAdapterManager = new seminarski.inf.Spirometrija_DataSetTableAdapters.TableAdapterManager();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.šifraTextBox = new System.Windows.Forms.TextBox();
            this.datum_rodenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.naziv_sportaComboBox = new System.Windows.Forms.ComboBox();
            this.datum_mjerenjaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rezultatTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pusacCheckBox = new System.Windows.Forms.CheckBox();
            imeLabel = new System.Windows.Forms.Label();
            prezimeLabel = new System.Windows.Forms.Label();
            šifraLabel = new System.Windows.Forms.Label();
            datum_rodenjaLabel = new System.Windows.Forms.Label();
            naziv_sportaLabel = new System.Windows.Forms.Label();
            datum_mjerenjaLabel = new System.Windows.Forms.Label();
            rezultatLabel = new System.Windows.Forms.Label();
            pusacLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spirometrija_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // imeLabel
            // 
            imeLabel.AutoSize = true;
            imeLabel.Location = new System.Drawing.Point(304, 180);
            imeLabel.Name = "imeLabel";
            imeLabel.Size = new System.Drawing.Size(27, 13);
            imeLabel.TabIndex = 13;
            imeLabel.Text = "Ime:";
            // 
            // prezimeLabel
            // 
            prezimeLabel.AutoSize = true;
            prezimeLabel.Location = new System.Drawing.Point(304, 216);
            prezimeLabel.Name = "prezimeLabel";
            prezimeLabel.Size = new System.Drawing.Size(47, 13);
            prezimeLabel.TabIndex = 14;
            prezimeLabel.Text = "Prezime:";
            // 
            // šifraLabel
            // 
            šifraLabel.AutoSize = true;
            šifraLabel.Location = new System.Drawing.Point(304, 252);
            šifraLabel.Name = "šifraLabel";
            šifraLabel.Size = new System.Drawing.Size(31, 13);
            šifraLabel.TabIndex = 15;
            šifraLabel.Text = "Šifra:";
            // 
            // datum_rodenjaLabel
            // 
            datum_rodenjaLabel.AutoSize = true;
            datum_rodenjaLabel.Location = new System.Drawing.Point(304, 283);
            datum_rodenjaLabel.Name = "datum_rodenjaLabel";
            datum_rodenjaLabel.Size = new System.Drawing.Size(79, 13);
            datum_rodenjaLabel.TabIndex = 16;
            datum_rodenjaLabel.Text = "Datum rodenja:";
            // 
            // naziv_sportaLabel
            // 
            naziv_sportaLabel.AutoSize = true;
            naziv_sportaLabel.Location = new System.Drawing.Point(304, 362);
            naziv_sportaLabel.Name = "naziv_sportaLabel";
            naziv_sportaLabel.Size = new System.Drawing.Size(69, 13);
            naziv_sportaLabel.TabIndex = 17;
            naziv_sportaLabel.Text = "Naziv sporta:";
            // 
            // datum_mjerenjaLabel
            // 
            datum_mjerenjaLabel.AutoSize = true;
            datum_mjerenjaLabel.Location = new System.Drawing.Point(304, 402);
            datum_mjerenjaLabel.Name = "datum_mjerenjaLabel";
            datum_mjerenjaLabel.Size = new System.Drawing.Size(83, 13);
            datum_mjerenjaLabel.TabIndex = 18;
            datum_mjerenjaLabel.Text = "Datum mjerenja:";
            // 
            // rezultatLabel
            // 
            rezultatLabel.AutoSize = true;
            rezultatLabel.Location = new System.Drawing.Point(304, 433);
            rezultatLabel.Name = "rezultatLabel";
            rezultatLabel.Size = new System.Drawing.Size(49, 13);
            rezultatLabel.TabIndex = 19;
            rezultatLabel.Text = "Rezultat:";
            // 
            // kraj6
            // 
            this.kraj6.Location = new System.Drawing.Point(154, 311);
            this.kraj6.Name = "kraj6";
            this.kraj6.Size = new System.Drawing.Size(75, 38);
            this.kraj6.TabIndex = 12;
            this.kraj6.Text = "Kraj";
            this.kraj6.UseVisualStyleBackColor = true;
            this.kraj6.Click += new System.EventHandler(this.kraj6_Click);
            // 
            // obrisi5
            // 
            this.obrisi5.Location = new System.Drawing.Point(154, 269);
            this.obrisi5.Name = "obrisi5";
            this.obrisi5.Size = new System.Drawing.Size(75, 36);
            this.obrisi5.TabIndex = 11;
            this.obrisi5.Text = "Obriši";
            this.obrisi5.UseVisualStyleBackColor = true;
            this.obrisi5.Click += new System.EventHandler(this.obrisi5_Click);
            // 
            // spremi4
            // 
            this.spremi4.Location = new System.Drawing.Point(154, 224);
            this.spremi4.Name = "spremi4";
            this.spremi4.Size = new System.Drawing.Size(75, 41);
            this.spremi4.TabIndex = 10;
            this.spremi4.Text = "Spremi";
            this.spremi4.UseVisualStyleBackColor = true;
            this.spremi4.Click += new System.EventHandler(this.spremi4_Click);
            // 
            // dodaj3
            // 
            this.dodaj3.Location = new System.Drawing.Point(33, 313);
            this.dodaj3.Name = "dodaj3";
            this.dodaj3.Size = new System.Drawing.Size(75, 38);
            this.dodaj3.TabIndex = 9;
            this.dodaj3.Text = "Dodaj";
            this.dodaj3.UseVisualStyleBackColor = true;
            this.dodaj3.Click += new System.EventHandler(this.dodaj3_Click);
            // 
            // prethodni2
            // 
            this.prethodni2.Location = new System.Drawing.Point(33, 271);
            this.prethodni2.Name = "prethodni2";
            this.prethodni2.Size = new System.Drawing.Size(75, 36);
            this.prethodni2.TabIndex = 8;
            this.prethodni2.Text = "Prethodni";
            this.prethodni2.UseVisualStyleBackColor = true;
            this.prethodni2.Click += new System.EventHandler(this.prethodni2_Click);
            // 
            // sljedeci1
            // 
            this.sljedeci1.Location = new System.Drawing.Point(33, 224);
            this.sljedeci1.Name = "sljedeci1";
            this.sljedeci1.Size = new System.Drawing.Size(75, 41);
            this.sljedeci1.TabIndex = 7;
            this.sljedeci1.Text = "Sljedeći";
            this.sljedeci1.UseVisualStyleBackColor = true;
            this.sljedeci1.Click += new System.EventHandler(this.sljedeci1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUcenikaDataGridViewTextBoxColumn,
            this.imeDataGridViewTextBoxColumn,
            this.prezimeDataGridViewTextBoxColumn,
            this.šifraDataGridViewTextBoxColumn,
            this.datumrodenjaDataGridViewTextBoxColumn,
            this.pusacDataGridViewCheckBoxColumn,
            this.nazivsportaDataGridViewTextBoxColumn,
            this.datummjerenjaDataGridViewTextBoxColumn,
            this.rezultatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uceniciBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-9, 1);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(963, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // iDUcenikaDataGridViewTextBoxColumn
            // 
            this.iDUcenikaDataGridViewTextBoxColumn.DataPropertyName = "IDUcenika";
            this.iDUcenikaDataGridViewTextBoxColumn.HeaderText = "IDUcenika";
            this.iDUcenikaDataGridViewTextBoxColumn.Name = "iDUcenikaDataGridViewTextBoxColumn";
            this.iDUcenikaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imeDataGridViewTextBoxColumn
            // 
            this.imeDataGridViewTextBoxColumn.DataPropertyName = "Ime";
            this.imeDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.imeDataGridViewTextBoxColumn.Name = "imeDataGridViewTextBoxColumn";
            this.imeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prezimeDataGridViewTextBoxColumn
            // 
            this.prezimeDataGridViewTextBoxColumn.DataPropertyName = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.prezimeDataGridViewTextBoxColumn.Name = "prezimeDataGridViewTextBoxColumn";
            this.prezimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // šifraDataGridViewTextBoxColumn
            // 
            this.šifraDataGridViewTextBoxColumn.DataPropertyName = "Šifra";
            this.šifraDataGridViewTextBoxColumn.HeaderText = "Šifra";
            this.šifraDataGridViewTextBoxColumn.Name = "šifraDataGridViewTextBoxColumn";
            this.šifraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumrodenjaDataGridViewTextBoxColumn
            // 
            this.datumrodenjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.HeaderText = "Datum_rodenja";
            this.datumrodenjaDataGridViewTextBoxColumn.Name = "datumrodenjaDataGridViewTextBoxColumn";
            this.datumrodenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pusacDataGridViewCheckBoxColumn
            // 
            this.pusacDataGridViewCheckBoxColumn.DataPropertyName = "Pusac";
            this.pusacDataGridViewCheckBoxColumn.HeaderText = "Pusac";
            this.pusacDataGridViewCheckBoxColumn.Name = "pusacDataGridViewCheckBoxColumn";
            this.pusacDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nazivsportaDataGridViewTextBoxColumn
            // 
            this.nazivsportaDataGridViewTextBoxColumn.DataPropertyName = "Naziv_sporta";
            this.nazivsportaDataGridViewTextBoxColumn.HeaderText = "Naziv_sporta";
            this.nazivsportaDataGridViewTextBoxColumn.Name = "nazivsportaDataGridViewTextBoxColumn";
            this.nazivsportaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datummjerenjaDataGridViewTextBoxColumn
            // 
            this.datummjerenjaDataGridViewTextBoxColumn.DataPropertyName = "Datum_mjerenja";
            this.datummjerenjaDataGridViewTextBoxColumn.HeaderText = "Datum_mjerenja";
            this.datummjerenjaDataGridViewTextBoxColumn.Name = "datummjerenjaDataGridViewTextBoxColumn";
            this.datummjerenjaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rezultatDataGridViewTextBoxColumn
            // 
            this.rezultatDataGridViewTextBoxColumn.DataPropertyName = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.HeaderText = "Rezultat";
            this.rezultatDataGridViewTextBoxColumn.Name = "rezultatDataGridViewTextBoxColumn";
            this.rezultatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uceniciBindingSource
            // 
            this.uceniciBindingSource.DataMember = "Ucenici";
            this.uceniciBindingSource.DataSource = this.spirometrija_DataSet;
            // 
            // spirometrija_DataSet
            // 
            this.spirometrija_DataSet.DataSetName = "Spirometrija_DataSet";
            this.spirometrija_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uceniciTableAdapter
            // 
            this.uceniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UceniciTableAdapter = this.uceniciTableAdapter;
            this.tableAdapterManager.UpdateOrder = seminarski.inf.Spirometrija_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imeTextBox
            // 
            this.imeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uceniciBindingSource, "Ime", true));
            this.imeTextBox.Location = new System.Drawing.Point(422, 180);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(100, 20);
            this.imeTextBox.TabIndex = 14;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uceniciBindingSource, "Prezime", true));
            this.prezimeTextBox.Location = new System.Drawing.Point(422, 216);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(100, 20);
            this.prezimeTextBox.TabIndex = 15;
            // 
            // šifraTextBox
            // 
            this.šifraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uceniciBindingSource, "Šifra", true));
            this.šifraTextBox.Location = new System.Drawing.Point(422, 252);
            this.šifraTextBox.MaxLength = 4;
            this.šifraTextBox.Name = "šifraTextBox";
            this.šifraTextBox.Size = new System.Drawing.Size(100, 20);
            this.šifraTextBox.TabIndex = 16;
            // 
            // datum_rodenjaDateTimePicker
            // 
            this.datum_rodenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uceniciBindingSource, "Datum_rodenja", true));
            this.datum_rodenjaDateTimePicker.Location = new System.Drawing.Point(422, 287);
            this.datum_rodenjaDateTimePicker.Name = "datum_rodenjaDateTimePicker";
            this.datum_rodenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datum_rodenjaDateTimePicker.TabIndex = 17;
            // 
            // naziv_sportaComboBox
            // 
            this.naziv_sportaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uceniciBindingSource, "Naziv_sporta", true));
            this.naziv_sportaComboBox.FormattingEnabled = true;
            this.naziv_sportaComboBox.Items.AddRange(new object[] {
            "Nije sportaš",
            "trčanje/aerobno",
            "plivanje/aerobno",
            "šah/anaerobno",
            "tenis/anaerobno",
            "pikado/anaerobno"});
            this.naziv_sportaComboBox.Location = new System.Drawing.Point(422, 361);
            this.naziv_sportaComboBox.Name = "naziv_sportaComboBox";
            this.naziv_sportaComboBox.Size = new System.Drawing.Size(121, 21);
            this.naziv_sportaComboBox.TabIndex = 18;
            // 
            // datum_mjerenjaDateTimePicker
            // 
            this.datum_mjerenjaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.uceniciBindingSource, "Datum_mjerenja", true));
            this.datum_mjerenjaDateTimePicker.Location = new System.Drawing.Point(422, 396);
            this.datum_mjerenjaDateTimePicker.Name = "datum_mjerenjaDateTimePicker";
            this.datum_mjerenjaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.datum_mjerenjaDateTimePicker.TabIndex = 19;
            // 
            // rezultatTextBox
            // 
            this.rezultatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.uceniciBindingSource, "Rezultat", true));
            this.rezultatTextBox.Location = new System.Drawing.Point(422, 430);
            this.rezultatTextBox.Name = "rezultatTextBox";
            this.rezultatTextBox.Size = new System.Drawing.Size(100, 20);
            this.rezultatTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(712, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 21;
            this.button1.Text = "Izvješće1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 41);
            this.button2.TabIndex = 22;
            this.button2.Text = "Izvješće2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 41);
            this.button3.TabIndex = 23;
            this.button3.Text = "Izvješće3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pusacLabel
            // 
            pusacLabel.AutoSize = true;
            pusacLabel.Location = new System.Drawing.Point(304, 324);
            pusacLabel.Name = "pusacLabel";
            pusacLabel.Size = new System.Drawing.Size(40, 13);
            pusacLabel.TabIndex = 24;
            pusacLabel.Text = "Pusac:";
            // 
            // pusacCheckBox
            // 
            this.pusacCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.uceniciBindingSource, "Pusac", true));
            this.pusacCheckBox.Location = new System.Drawing.Point(422, 319);
            this.pusacCheckBox.Name = "pusacCheckBox";
            this.pusacCheckBox.Size = new System.Drawing.Size(104, 24);
            this.pusacCheckBox.TabIndex = 25;
            this.pusacCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(954, 472);
            this.Controls.Add(pusacLabel);
            this.Controls.Add(this.pusacCheckBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(rezultatLabel);
            this.Controls.Add(this.rezultatTextBox);
            this.Controls.Add(datum_mjerenjaLabel);
            this.Controls.Add(this.datum_mjerenjaDateTimePicker);
            this.Controls.Add(naziv_sportaLabel);
            this.Controls.Add(this.naziv_sportaComboBox);
            this.Controls.Add(datum_rodenjaLabel);
            this.Controls.Add(this.datum_rodenjaDateTimePicker);
            this.Controls.Add(šifraLabel);
            this.Controls.Add(this.šifraTextBox);
            this.Controls.Add(prezimeLabel);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(imeLabel);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.kraj6);
            this.Controls.Add(this.obrisi5);
            this.Controls.Add(this.spremi4);
            this.Controls.Add(this.dodaj3);
            this.Controls.Add(this.prethodni2);
            this.Controls.Add(this.sljedeci1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uceniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spirometrija_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kraj6;
        private System.Windows.Forms.Button obrisi5;
        private System.Windows.Forms.Button spremi4;
        private System.Windows.Forms.Button dodaj3;
        private System.Windows.Forms.Button prethodni2;
        private System.Windows.Forms.Button sljedeci1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Spirometrija_DataSet spirometrija_DataSet;
        private System.Windows.Forms.BindingSource uceniciBindingSource;
        private Spirometrija_DataSetTableAdapters.UceniciTableAdapter uceniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUcenikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn šifraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumrodenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pusacDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivsportaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datummjerenjaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rezultatDataGridViewTextBoxColumn;
        private Spirometrija_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox šifraTextBox;
        private System.Windows.Forms.DateTimePicker datum_rodenjaDateTimePicker;
        private System.Windows.Forms.ComboBox naziv_sportaComboBox;
        private System.Windows.Forms.DateTimePicker datum_mjerenjaDateTimePicker;
        private System.Windows.Forms.TextBox rezultatTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox pusacCheckBox;
    }
}

