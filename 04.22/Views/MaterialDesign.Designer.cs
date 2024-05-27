namespace cSharpWindowsForms._04._22.Views

{
    partial class MaterialDesign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialDesign));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.tabProdukt = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deletToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxAnzahl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxArtikelnummer = new System.Windows.Forms.TextBox();
            this.txtBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxArtikelname = new System.Windows.Forms.TextBox();
            this.txtBoxPreis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabProdukt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabHome);
            this.materialTabControl1.Controls.Add(this.tabProdukt);
            this.materialTabControl1.Controls.Add(this.tabAbout);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(6, 118);
            this.materialTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(2234, 1690);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabHome
            // 
            this.tabHome.BackColor = System.Drawing.Color.White;
            this.tabHome.ImageKey = "home.png";
            this.tabHome.Location = new System.Drawing.Point(12, 58);
            this.tabHome.Margin = new System.Windows.Forms.Padding(6);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(6);
            this.tabHome.Size = new System.Drawing.Size(2210, 1620);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.Resize += new System.EventHandler(this.Form1_Resize);
            // 
            // tabProdukt
            // 
            this.tabProdukt.Controls.Add(this.btnDelete);
            this.tabProdukt.Controls.Add(this.btnUpdate);
            this.tabProdukt.Controls.Add(this.label6);
            this.tabProdukt.Controls.Add(this.txtBoxID);
            this.tabProdukt.Controls.Add(this.btnSpeichern);
            this.tabProdukt.Controls.Add(this.dataGridView);
            this.tabProdukt.Controls.Add(this.txtBoxAnzahl);
            this.tabProdukt.Controls.Add(this.label1);
            this.tabProdukt.Controls.Add(this.label5);
            this.tabProdukt.Controls.Add(this.txtBoxArtikelnummer);
            this.tabProdukt.Controls.Add(this.txtBoxBeschreibung);
            this.tabProdukt.Controls.Add(this.label2);
            this.tabProdukt.Controls.Add(this.label4);
            this.tabProdukt.Controls.Add(this.txtBoxArtikelname);
            this.tabProdukt.Controls.Add(this.txtBoxPreis);
            this.tabProdukt.Controls.Add(this.label3);
            this.tabProdukt.ImageKey = "to-do-list.png";
            this.tabProdukt.Location = new System.Drawing.Point(12, 58);
            this.tabProdukt.Margin = new System.Windows.Forms.Padding(6);
            this.tabProdukt.Name = "tabProdukt";
            this.tabProdukt.Size = new System.Drawing.Size(2210, 1620);
            this.tabProdukt.TabIndex = 2;
            this.tabProdukt.Text = "Produkt";
            this.tabProdukt.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1320, 1283);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(298, 81);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(932, 1283);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(298, 81);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(119, 674);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 56);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID";
            // 
            // txtBoxID
            // 
            this.txtBoxID.Enabled = false;
            this.txtBoxID.Location = new System.Drawing.Point(539, 660);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(298, 44);
            this.txtBoxID.TabIndex = 23;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(539, 1283);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(298, 81);
            this.btnSpeichern.TabIndex = 21;
            this.btnSpeichern.Text = "INSERT";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView.Location = new System.Drawing.Point(45, 27);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(2136, 584);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.deletToolStripMenuItem, this.updateToolStripMenuItem });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(217, 108);
            // 
            // deletToolStripMenuItem
            // 
            this.deletToolStripMenuItem.Name = "deletToolStripMenuItem";
            this.deletToolStripMenuItem.Size = new System.Drawing.Size(216, 52);
            this.deletToolStripMenuItem.Text = "Delete";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(216, 52);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // txtBoxAnzahl
            // 
            this.txtBoxAnzahl.Location = new System.Drawing.Point(539, 1156);
            this.txtBoxAnzahl.Name = "txtBoxAnzahl";
            this.txtBoxAnzahl.Size = new System.Drawing.Size(298, 44);
            this.txtBoxAnzahl.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(119, 774);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 56);
            this.label1.TabIndex = 11;
            this.label1.Text = "Artikelnummer";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(119, 1159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 56);
            this.label5.TabIndex = 19;
            this.label5.Text = "Anzahl";
            // 
            // txtBoxArtikelnummer
            // 
            this.txtBoxArtikelnummer.Location = new System.Drawing.Point(539, 771);
            this.txtBoxArtikelnummer.Name = "txtBoxArtikelnummer";
            this.txtBoxArtikelnummer.Size = new System.Drawing.Size(298, 44);
            this.txtBoxArtikelnummer.TabIndex = 12;
            // 
            // txtBoxBeschreibung
            // 
            this.txtBoxBeschreibung.Location = new System.Drawing.Point(539, 1057);
            this.txtBoxBeschreibung.Name = "txtBoxBeschreibung";
            this.txtBoxBeschreibung.Size = new System.Drawing.Size(298, 44);
            this.txtBoxBeschreibung.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(119, 862);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 56);
            this.label2.TabIndex = 13;
            this.label2.Text = "Artikelname";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(119, 1060);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 56);
            this.label4.TabIndex = 17;
            this.label4.Text = "Beschreibung";
            // 
            // txtBoxArtikelname
            // 
            this.txtBoxArtikelname.Location = new System.Drawing.Point(539, 859);
            this.txtBoxArtikelname.Name = "txtBoxArtikelname";
            this.txtBoxArtikelname.Size = new System.Drawing.Size(298, 44);
            this.txtBoxArtikelname.TabIndex = 14;
            // 
            // txtBoxPreis
            // 
            this.txtBoxPreis.Location = new System.Drawing.Point(539, 954);
            this.txtBoxPreis.Name = "txtBoxPreis";
            this.txtBoxPreis.Size = new System.Drawing.Size(298, 44);
            this.txtBoxPreis.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(119, 957);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 56);
            this.label3.TabIndex = 15;
            this.label3.Text = "Preis";
            // 
            // tabAbout
            // 
            this.tabAbout.ImageKey = "about.png";
            this.tabAbout.Location = new System.Drawing.Point(12, 58);
            this.tabAbout.Margin = new System.Windows.Forms.Padding(6);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(6);
            this.tabAbout.Size = new System.Drawing.Size(2210, 1620);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "about.png");
            this.imageList1.Images.SetKeyName(1, "home.png");
            this.imageList1.Images.SetKeyName(2, "to-do-list.png");
            this.imageList1.Images.SetKeyName(3, "pfeil.png");
            this.imageList1.Images.SetKeyName(4, "plus.png");
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MaterialDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2246, 1814);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MaterialDesign";
            this.Padding = new System.Windows.Forms.Padding(6, 118, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaterialSkin.2";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.materialTabControl1.ResumeLayout(false);
            this.tabProdukt.ResumeLayout(false);
            this.tabProdukt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.Button btnUpdate;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxID;

        private System.Windows.Forms.Button btnSpeichern;

        private System.Windows.Forms.TextBox txtBoxPreis;

        private System.Windows.Forms.TextBox txtBoxBeschreibung;

        private System.Windows.Forms.TextBox txtBoxAnzahl;

        private System.Windows.Forms.TextBox txtBoxArtikelnummer;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxArtikelname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem deletToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.DataGridView dataGridView;

        private System.Windows.Forms.TabPage tabProdukt;

        private System.Windows.Forms.NotifyIcon notifyIcon1;

        private System.Windows.Forms.ImageList imageList1;

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAbout;

        #endregion
    }
}