using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using cSharpWindowsForms._04._18;
using cSharpWindowsForms._04._19;
using cSharpWindowsForms._04._22.Views;


namespace cSharpWindowsForms
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormTicTacToe());
      Application.Run(new FormUserContent());
      Application.Run(new MaterialDesign());
    }
  }
}