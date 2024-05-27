using System;
using System.Windows.Forms;

namespace cSharpWindowsForms._04._19
{
  public partial class FormUserContent : Form
  {
    public FormUserContent()
    {
      InitializeComponent();
    }
    
    private void button1_Click(object sender, EventArgs e)
    {
      UcMain ucMain = new UcMain();
      ucMain.Dock = DockStyle.Fill;

      panel1.Controls.Add(ucMain);
    }
  }
}