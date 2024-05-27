using System.ComponentModel;

namespace cSharpWindowsForms._04._19
{
  partial class FormUserContent
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnUserControl = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(247, 138);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1348, 1121);
      this.panel1.TabIndex = 0;
      // 
      // btnUserControl
      // 
      this.btnUserControl.Location = new System.Drawing.Point(604, 1109);
      this.btnUserControl.Name = "btnUserControl";
      this.btnUserControl.Size = new System.Drawing.Size(638, 242);
      this.btnUserControl.TabIndex = 1;
      this.btnUserControl.Text = "load UserControl";
      this.btnUserControl.UseVisualStyleBackColor = true;
      this.btnUserControl.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1845, 1392);
      this.Controls.Add(this.btnUserControl);
      this.Controls.Add(this.panel1);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "UserControl";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnUserControl;

    private System.Windows.Forms.Panel panel1;

    #endregion
  }
}