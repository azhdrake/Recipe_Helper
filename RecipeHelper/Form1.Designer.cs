namespace RecipeHelper
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
      this.buttConvert = new System.Windows.Forms.Button();
      this.txtCtemp = new System.Windows.Forms.TextBox();
      this.txtFtemp = new System.Windows.Forms.TextBox();
      this.txtmL = new System.Windows.Forms.TextBox();
      this.txtCups = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttConvert
      // 
      this.buttConvert.Location = new System.Drawing.Point(162, 275);
      this.buttConvert.Name = "buttConvert";
      this.buttConvert.Size = new System.Drawing.Size(134, 41);
      this.buttConvert.TabIndex = 0;
      this.buttConvert.Text = "Convert";
      this.buttConvert.UseVisualStyleBackColor = true;
      this.buttConvert.Click += new System.EventHandler(this.buttConvert_Click);
      // 
      // txtCtemp
      // 
      this.txtCtemp.Location = new System.Drawing.Point(36, 85);
      this.txtCtemp.Name = "txtCtemp";
      this.txtCtemp.Size = new System.Drawing.Size(100, 31);
      this.txtCtemp.TabIndex = 1;
      // 
      // txtFtemp
      // 
      this.txtFtemp.Location = new System.Drawing.Point(250, 85);
      this.txtFtemp.Name = "txtFtemp";
      this.txtFtemp.ReadOnly = true;
      this.txtFtemp.Size = new System.Drawing.Size(100, 31);
      this.txtFtemp.TabIndex = 2;
      this.txtFtemp.TabStop = false;
      // 
      // txtmL
      // 
      this.txtmL.Location = new System.Drawing.Point(36, 172);
      this.txtmL.Name = "txtmL";
      this.txtmL.Size = new System.Drawing.Size(100, 31);
      this.txtmL.TabIndex = 3;
      // 
      // txtCups
      // 
      this.txtCups.Location = new System.Drawing.Point(250, 172);
      this.txtCups.Name = "txtCups";
      this.txtCups.ReadOnly = true;
      this.txtCups.Size = new System.Drawing.Size(100, 31);
      this.txtCups.TabIndex = 4;
      this.txtCups.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(36, 27);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "Metric";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(245, 27);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(87, 25);
      this.label2.TabIndex = 6;
      this.label2.Text = "Imperial";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(168, 91);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 25);
      this.label3.TabIndex = 7;
      this.label3.Text = "°C";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(168, 178);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(41, 25);
      this.label4.TabIndex = 8;
      this.label4.Text = "mL";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(388, 178);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(62, 25);
      this.label5.TabIndex = 9;
      this.label5.Text = "Cups";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(388, 88);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(33, 25);
      this.label6.TabIndex = 10;
      this.label6.Text = "°F";
      // 
      // Form1
      // 
      this.AcceptButton = this.buttConvert;
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(477, 341);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCups);
      this.Controls.Add(this.txtmL);
      this.Controls.Add(this.txtFtemp);
      this.Controls.Add(this.txtCtemp);
      this.Controls.Add(this.buttConvert);
      this.Name = "Form1";
      this.Text = "Recipe Helper";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttConvert;
    private System.Windows.Forms.TextBox txtCtemp;
    private System.Windows.Forms.TextBox txtFtemp;
    private System.Windows.Forms.TextBox txtmL;
    private System.Windows.Forms.TextBox txtCups;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}

