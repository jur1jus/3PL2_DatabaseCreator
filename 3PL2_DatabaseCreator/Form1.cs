using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3PL2_DatabaseCreator
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLenteliųGeneravimas_Click(object sender, EventArgs e)
		{
			Lentelės lentelės = new Lentelės();
			lentelės.ShowDialog();
		}
	}
}
