using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace cSharpWindowsForms._04._18
{
  public partial class FormTicTacToe : Form
  {
    private bool player = false;
    List<Button> buttonList = new List<Button>();

    public FormTicTacToe()
    {
      InitializeComponent();
      buttonList.Add(btn1);
      buttonList.Add(btn2);
      buttonList.Add(btn3);
      buttonList.Add(btn4);
      buttonList.Add(btn5);
      buttonList.Add(btn6);
      buttonList.Add(btn7);
      buttonList.Add(btn8);
      buttonList.Add(btn9);
    }

    public void DisableButton()
    {
      foreach (var button in buttonList)
      {
        button.Enabled = false;
      }
    }

    public void ActivateButton()
    {
      foreach (var button in buttonList)
      {
        button.Enabled = true;
        button.Tag = "";
        button.BackgroundImage = null;
      }

      lblResult.Text = "";
    }

    private void button_Click(object sender, EventArgs e)
    {
      Button button = (Button)sender;

      if (player == false)
      {
        button.BackgroundImage = global::cSharpWindowsForms.Properties.Resources.o;
        button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        button.Tag = "O";
      }
      else
      {
        button.BackgroundImage = global::cSharpWindowsForms.Properties.Resources.x;
        button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
        button.Tag = "X";
      }

      player = !player;
      button.Enabled = false;
      CheckWinner();
    }

    public void CheckWinner()
    {
      if (btn1.Tag == btn2.Tag && btn1.Tag == btn3.Tag && !btn2.Enabled)
      {
        lblResult.Text = ((string)btn1.Tag) + " wins";
        DisableButton();
      }
      else if (btn4.Tag == btn5.Tag && btn4.Tag == btn6.Tag && !btn4.Enabled)
      {
        lblResult.Text = ((string)btn3.Tag) + " wins";
        DisableButton();
      }
      else if (btn7.Tag == btn8.Tag && btn7.Tag == btn9.Tag && !btn7.Enabled)
      {
        lblResult.Text = ((string)btn7.Tag) + " wins";
        DisableButton();
      }
      else if (btn1.Tag == btn5.Tag && btn1.Tag == btn9.Tag && !btn1.Enabled)
      {
        lblResult.Text = ((string)btn1.Tag) + " wins";
        DisableButton();
      }
      else if (btn3.Tag == btn5.Tag && btn3.Tag == btn7.Tag && !btn3.Enabled)
      {
        lblResult.Text = ((string)btn3.Tag) + " wins";
        DisableButton();
      }
      else if (btn1.Tag == btn4.Tag && btn1.Tag == btn7.Tag && !btn1.Enabled)
      {
        lblResult.Text = ((string)btn1.Tag) + " wins";
        DisableButton();
      }
      else if (btn2.Tag == btn5.Tag && btn2.Tag == btn8.Tag && !btn2.Enabled)
      {
        lblResult.Text = ((string)btn2.Tag) + " wins";
        DisableButton();
      }
      else if (btn3.Tag == btn6.Tag && btn3.Tag == btn9.Tag && !btn3.Enabled)
      {
        lblResult.Text = ((string)btn3.Tag) + " wins";
        DisableButton();
      }
      else if (CheckDraw() == 9)
      {
        lblResult.Text = "Draw";
      }
    }

    public int CheckDraw()
    {
      int draw = 0;

      foreach (var button in buttonList)
      {
        if (button.Enabled == false)
        {
          draw++;
        }
      }

      return draw;
    }

    private void btnNewgame_Click(object sender, EventArgs e)
    {
      ActivateButton();
    }
  }
}