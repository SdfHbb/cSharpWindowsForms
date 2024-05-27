using System;
using System.Windows.Forms;
using cSharpWindowsForms._04._22.Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace cSharpWindowsForms._04._22.Views
{
  public partial class MaterialDesign : MaterialForm
  {
    // Attribute
    private MaterialSkinManager materialSkinManager;


    public MaterialDesign()
    {
      InitializeComponent();
      InitMaterialDesign();
      // DBProdukte.Connect();
      DBProdukte.Read(dataGridView);
    }

    public void InitMaterialDesign()
    {
      materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.EnforceBackcolorOnAllComponents = true;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
      materialSkinManager.ColorScheme = new ColorScheme
      (Primary.Indigo500, Primary.Indigo700,
        Primary.Indigo100,
        Accent.Pink200, TextShade.WHITE);
    }


    private void Form1_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        Hide();
        notifyIcon1.Visible = true;
      }
    }

    private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      Show();
      this.WindowState = FormWindowState.Normal;
      notifyIcon1.Visible = false;
    }


    private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
    {
      txtBoxID.Text = dataGridView.CurrentRow.Cells["id"].Value.ToString();
      txtBoxArtikelnummer.Text = dataGridView.CurrentRow.Cells["artikelnummer"].Value.ToString();
      txtBoxArtikelname.Text = dataGridView.CurrentRow.Cells["name"].Value.ToString();
      txtBoxPreis.Text = dataGridView.CurrentRow.Cells["preis"].Value.ToString();
      txtBoxBeschreibung.Text = dataGridView.CurrentRow.Cells["beschreibung"].Value.ToString();
      txtBoxAnzahl.Text = dataGridView.CurrentRow.Cells["anzahl"].Value.ToString();
    }


    private void btnSpeichern_Click(object sender, EventArgs e)
    {
      Produkt produkt;


      int artikelnummer = Convert.ToInt32(txtBoxArtikelnummer.Text);

      string name = txtBoxArtikelname.Text;
      double preis = Convert.ToDouble(txtBoxPreis.Text);
      string beschreibung = txtBoxBeschreibung.Text;
      int anzahl = Convert.ToInt32(txtBoxAnzahl.Text);

      produkt = new Produkt(artikelnummer, name, preis, beschreibung, anzahl);

      DBProdukte.Insert(produkt);
      DBProdukte.Read(dataGridView);
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Produkt produkt;
      int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["id"].Value.ToString());
      int artikelnummer = Convert.ToInt32(txtBoxArtikelnummer.Text);
      string name = txtBoxArtikelname.Text;
      double preis = Convert.ToDouble(txtBoxPreis.Text);
      string beschreibung = txtBoxBeschreibung.Text;
      int anzahl = Convert.ToInt32(txtBoxAnzahl.Text);

      produkt = new Produkt(id, artikelnummer, name, preis, beschreibung, anzahl);

      // MessageBox.Show($"{produkt.Id}\n" +
      //                 $"{produkt.Artikelnummer}\n" +
      //                 $"{produkt.Name}\n" +
      //                 $"{produkt.Preis}\n" +
      //                 $"{produkt.Beschreibung}\n" +
      //                 $"{produkt.Anzahl}\n");

      DBProdukte.Update(produkt);
      DBProdukte.Read(dataGridView);

      txtBoxID.Text = "";
      txtBoxArtikelnummer.Text = "";
      txtBoxArtikelname.Text = "";
      txtBoxPreis.Text = "";
      txtBoxBeschreibung.Text = "";
      txtBoxAnzahl.Text = "";
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      string id = dataGridView.CurrentRow.Cells["id"].Value.ToString();
      DBProdukte.Delete(id);
      DBProdukte.Read(dataGridView);
    }
  }
}