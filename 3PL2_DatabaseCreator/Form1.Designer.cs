
namespace _3PL2_DatabaseCreator
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
			if (disposing && (components != null)) {
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
			this.btnLenteliųGeneravimas = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLenteliųGeneravimas
			// 
			this.btnLenteliųGeneravimas.Location = new System.Drawing.Point(13, 13);
			this.btnLenteliųGeneravimas.Name = "btnLenteliųGeneravimas";
			this.btnLenteliųGeneravimas.Size = new System.Drawing.Size(131, 23);
			this.btnLenteliųGeneravimas.TabIndex = 0;
			this.btnLenteliųGeneravimas.Text = "Lentelių generavimas";
			this.btnLenteliųGeneravimas.UseVisualStyleBackColor = true;
			this.btnLenteliųGeneravimas.Click += new System.EventHandler(this.btnLenteliųGeneravimas_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 378);
			this.Controls.Add(this.btnLenteliųGeneravimas);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLenteliųGeneravimas;
	}
}

