
namespace _3PL2_DatabaseCreator
{
	partial class Lentelės
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtLentelėsPavadinimas = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtLaukoPavadinimas = new System.Windows.Forms.TextBox();
			this.cmbxLaukoTipas = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLaukoIlgis = new System.Windows.Forms.TextBox();
			this.chxPirminisRaktas = new System.Windows.Forms.CheckBox();
			this.btnPridėti = new System.Windows.Forms.Button();
			this.listBoxLaukai = new System.Windows.Forms.ListBox();
			this.btnGeneruoti = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Lentelės pavadinimas";
			// 
			// txtLentelėsPavadinimas
			// 
			this.txtLentelėsPavadinimas.Location = new System.Drawing.Point(127, 6);
			this.txtLentelėsPavadinimas.Name = "txtLentelėsPavadinimas";
			this.txtLentelėsPavadinimas.Size = new System.Drawing.Size(121, 20);
			this.txtLentelėsPavadinimas.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Lauko pavadimas";
			// 
			// txtLaukoPavadinimas
			// 
			this.txtLaukoPavadinimas.Location = new System.Drawing.Point(127, 32);
			this.txtLaukoPavadinimas.Name = "txtLaukoPavadinimas";
			this.txtLaukoPavadinimas.Size = new System.Drawing.Size(121, 20);
			this.txtLaukoPavadinimas.TabIndex = 3;
			// 
			// cmbxLaukoTipas
			// 
			this.cmbxLaukoTipas.FormattingEnabled = true;
			this.cmbxLaukoTipas.Items.AddRange(new object[] {
            "",
            "int",
            "varchar",
            "datetime",
            "double"});
			this.cmbxLaukoTipas.Location = new System.Drawing.Point(127, 59);
			this.cmbxLaukoTipas.Name = "cmbxLaukoTipas";
			this.cmbxLaukoTipas.Size = new System.Drawing.Size(121, 21);
			this.cmbxLaukoTipas.TabIndex = 4;
			this.cmbxLaukoTipas.SelectedIndexChanged += new System.EventHandler(this.cmbxLaukoTipas_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Lauko tipas";
			// 
			// txtLaukoIlgis
			// 
			this.txtLaukoIlgis.Location = new System.Drawing.Point(254, 59);
			this.txtLaukoIlgis.Name = "txtLaukoIlgis";
			this.txtLaukoIlgis.Size = new System.Drawing.Size(32, 20);
			this.txtLaukoIlgis.TabIndex = 6;
			// 
			// chxPirminisRaktas
			// 
			this.chxPirminisRaktas.AutoSize = true;
			this.chxPirminisRaktas.Location = new System.Drawing.Point(127, 87);
			this.chxPirminisRaktas.Name = "chxPirminisRaktas";
			this.chxPirminisRaktas.Size = new System.Drawing.Size(93, 17);
			this.chxPirminisRaktas.TabIndex = 7;
			this.chxPirminisRaktas.Text = "Pirminis raktas";
			this.chxPirminisRaktas.UseVisualStyleBackColor = true;
			// 
			// btnPridėti
			// 
			this.btnPridėti.Location = new System.Drawing.Point(127, 110);
			this.btnPridėti.Name = "btnPridėti";
			this.btnPridėti.Size = new System.Drawing.Size(75, 23);
			this.btnPridėti.TabIndex = 8;
			this.btnPridėti.Text = "Pridėti";
			this.btnPridėti.UseVisualStyleBackColor = true;
			this.btnPridėti.Click += new System.EventHandler(this.btnPridėti_Click);
			// 
			// listBoxLaukai
			// 
			this.listBoxLaukai.FormattingEnabled = true;
			this.listBoxLaukai.Location = new System.Drawing.Point(12, 139);
			this.listBoxLaukai.Name = "listBoxLaukai";
			this.listBoxLaukai.Size = new System.Drawing.Size(274, 212);
			this.listBoxLaukai.TabIndex = 9;
			this.listBoxLaukai.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBoxLaukai_KeyUp);
			// 
			// btnGeneruoti
			// 
			this.btnGeneruoti.Location = new System.Drawing.Point(12, 358);
			this.btnGeneruoti.Name = "btnGeneruoti";
			this.btnGeneruoti.Size = new System.Drawing.Size(274, 23);
			this.btnGeneruoti.TabIndex = 10;
			this.btnGeneruoti.Text = "Generuoti";
			this.btnGeneruoti.UseVisualStyleBackColor = true;
			this.btnGeneruoti.Click += new System.EventHandler(this.btnGeneruoti_Click);
			// 
			// Lentelės
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(296, 403);
			this.Controls.Add(this.btnGeneruoti);
			this.Controls.Add(this.listBoxLaukai);
			this.Controls.Add(this.btnPridėti);
			this.Controls.Add(this.chxPirminisRaktas);
			this.Controls.Add(this.txtLaukoIlgis);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbxLaukoTipas);
			this.Controls.Add(this.txtLaukoPavadinimas);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtLentelėsPavadinimas);
			this.Controls.Add(this.label1);
			this.Name = "Lentelės";
			this.Text = "Lentelės";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtLentelėsPavadinimas;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtLaukoPavadinimas;
		private System.Windows.Forms.ComboBox cmbxLaukoTipas;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLaukoIlgis;
		private System.Windows.Forms.CheckBox chxPirminisRaktas;
		private System.Windows.Forms.Button btnPridėti;
		private System.Windows.Forms.ListBox listBoxLaukai;
		private System.Windows.Forms.Button btnGeneruoti;
	}
}