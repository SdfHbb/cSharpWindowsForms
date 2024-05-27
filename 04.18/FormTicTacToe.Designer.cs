namespace cSharpWindowsForms._04._18
{
  partial class FormTicTacToe
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTicTacToe));
      this.btn1 = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btn2 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.btn4 = new System.Windows.Forms.Button();
      this.btn5 = new System.Windows.Forms.Button();
      this.btn6 = new System.Windows.Forms.Button();
      this.btn7 = new System.Windows.Forms.Button();
      this.btn8 = new System.Windows.Forms.Button();
      this.btn9 = new System.Windows.Forms.Button();
      this.lblResult = new System.Windows.Forms.Label();
      this.btnNewgame = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn1
      // 
      this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btn1.ForeColor = System.Drawing.Color.White;
      this.btn1.Location = new System.Drawing.Point(197, 32);
      this.btn1.Name = "btn1";
      this.btn1.Size = new System.Drawing.Size(300, 300);
      this.btn1.TabIndex = 0;
      this.btn1.UseVisualStyleBackColor = true;
      this.btn1.Click += new System.EventHandler(this.button_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "buchstabe-o.png");
      this.imageList1.Images.SetKeyName(1, "x-taste.png");
      // 
      // btn2
      // 
      this.btn2.ForeColor = System.Drawing.Color.White;
      this.btn2.Location = new System.Drawing.Point(503, 32);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(300, 300);
      this.btn2.TabIndex = 1;
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.button_Click);
      // 
      // btn3
      // 
      this.btn3.ForeColor = System.Drawing.Color.White;
      this.btn3.Location = new System.Drawing.Point(809, 32);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(300, 300);
      this.btn3.TabIndex = 2;
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.button_Click);
      // 
      // btn4
      // 
      this.btn4.ForeColor = System.Drawing.Color.White;
      this.btn4.Location = new System.Drawing.Point(197, 338);
      this.btn4.Name = "btn4";
      this.btn4.Size = new System.Drawing.Size(300, 300);
      this.btn4.TabIndex = 3;
      this.btn4.UseVisualStyleBackColor = true;
      this.btn4.Click += new System.EventHandler(this.button_Click);
      // 
      // btn5
      // 
      this.btn5.ForeColor = System.Drawing.Color.White;
      this.btn5.Location = new System.Drawing.Point(503, 338);
      this.btn5.Name = "btn5";
      this.btn5.Size = new System.Drawing.Size(300, 300);
      this.btn5.TabIndex = 4;
      this.btn5.UseVisualStyleBackColor = true;
      this.btn5.Click += new System.EventHandler(this.button_Click);
      // 
      // btn6
      // 
      this.btn6.ForeColor = System.Drawing.Color.White;
      this.btn6.Location = new System.Drawing.Point(809, 338);
      this.btn6.Name = "btn6";
      this.btn6.Size = new System.Drawing.Size(300, 300);
      this.btn6.TabIndex = 5;
      this.btn6.UseVisualStyleBackColor = true;
      this.btn6.Click += new System.EventHandler(this.button_Click);
      // 
      // btn7
      // 
      this.btn7.ForeColor = System.Drawing.Color.White;
      this.btn7.Location = new System.Drawing.Point(197, 644);
      this.btn7.Name = "btn7";
      this.btn7.Size = new System.Drawing.Size(300, 300);
      this.btn7.TabIndex = 6;
      this.btn7.UseVisualStyleBackColor = true;
      this.btn7.Click += new System.EventHandler(this.button_Click);
      // 
      // btn8
      // 
      this.btn8.ForeColor = System.Drawing.Color.White;
      this.btn8.Location = new System.Drawing.Point(503, 644);
      this.btn8.Name = "btn8";
      this.btn8.Size = new System.Drawing.Size(300, 300);
      this.btn8.TabIndex = 7;
      this.btn8.UseVisualStyleBackColor = true;
      this.btn8.Click += new System.EventHandler(this.button_Click);
      // 
      // btn9
      // 
      this.btn9.ForeColor = System.Drawing.Color.White;
      this.btn9.ImageList = this.imageList1;
      this.btn9.Location = new System.Drawing.Point(809, 644);
      this.btn9.Name = "btn9";
      this.btn9.Size = new System.Drawing.Size(300, 300);
      this.btn9.TabIndex = 8;
      this.btn9.UseVisualStyleBackColor = true;
      this.btn9.Click += new System.EventHandler(this.button_Click);
      // 
      // lblResult
      // 
      this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblResult.Location = new System.Drawing.Point(1150, 32);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(606, 300);
      this.lblResult.TabIndex = 9;
      this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnNewgame
      // 
      this.btnNewgame.Location = new System.Drawing.Point(1447, 656);
      this.btnNewgame.Name = "btnNewgame";
      this.btnNewgame.Size = new System.Drawing.Size(309, 288);
      this.btnNewgame.TabIndex = 10;
      this.btnNewgame.Text = "New Game";
      this.btnNewgame.UseVisualStyleBackColor = true;
      this.btnNewgame.Click += new System.EventHandler(this.btnNewgame_Click);
      // 
      // FormTicTacToe
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(1866, 1177);
      this.Controls.Add(this.btnNewgame);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.btn9);
      this.Controls.Add(this.btn8);
      this.Controls.Add(this.btn7);
      this.Controls.Add(this.btn6);
      this.Controls.Add(this.btn5);
      this.Controls.Add(this.btn4);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btn1);
      this.Location = new System.Drawing.Point(15, 15);
      this.Name = "FormTicTacToe";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tic Tac Toe";
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label lblResult;
    private System.Windows.Forms.Button btnNewgame;

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn1;

    #endregion
  }
}