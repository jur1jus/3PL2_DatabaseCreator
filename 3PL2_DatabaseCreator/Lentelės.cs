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
	public partial class Lentelės : Form
	{
		private List<Laukas> _laukai;

		public Lentelės()
		{
			_laukai = new List<Laukas>();
			InitializeComponent();
		}

		private void btnPridėti_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtLaukoPavadinimas.Text)) {
				MessageBox.Show("Lauko pavadinimas privalomas.");
				return;
			}

			if (string.IsNullOrEmpty(cmbxLaukoTipas.SelectedItem.ToString())) {
				MessageBox.Show("Lauko tipas privalomas.");
				return;
			}

			var arPirminisRaktas = chxPirminisRaktas.Checked;
			var laukoIlgis = string.IsNullOrEmpty(txtLaukoIlgis.Text) ? null : txtLaukoIlgis.Text;

			var laukas = new Laukas(txtLaukoPavadinimas.Text, cmbxLaukoTipas.SelectedItem.ToString(), laukoIlgis, arPirminisRaktas);

			listBoxLaukai.Items.Add(laukas);
			_laukai.Add(laukas);
			NustatykLaukųReikšmesĮDefault();
		}

		private void cmbxLaukoTipas_SelectedIndexChanged(object sender, EventArgs e)
		{
			var itemsWithLength = new List<string> { "varchar" };

			var cmbx = (ComboBox)sender;
			var item = cmbx.SelectedItem.ToString();

			if (!string.IsNullOrEmpty(item) && itemsWithLength.Contains(item)) {
				txtLaukoIlgis.Show();
			} else {
				txtLaukoIlgis.Clear();
				txtLaukoIlgis.Hide();
			}
		}

		private void NustatykLaukųReikšmesĮDefault()
		{
			txtLaukoPavadinimas.Clear();
			cmbxLaukoTipas.SelectedItem = "";
			txtLaukoIlgis.Clear();
			txtLaukoIlgis.Hide();
			chxPirminisRaktas.Checked = false;
		}

		private void listBoxLaukai_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete) {
				var lisbox = (ListBox)sender;
				var item = lisbox.SelectedItem;
				var itemIndex = listBoxLaukai.SelectedIndex;

				lisbox.Items.Remove(item);
				_laukai.RemoveAt(itemIndex);
			}
		}

		private void btnGeneruoti_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtLentelėsPavadinimas.Text)) {
				MessageBox.Show("Nurodykite lentelės pavadinimą.");
				return;
			}

			if (!_laukai.Any(m => m.ArPirminisRaktas == true)) {
				MessageBox.Show("Nenurodytas pirminis raktas.");
				return;
			}

			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine($"CREATE TABLE {txtLentelėsPavadinimas.Text} (");

			//CREATE TABLE Prekės (

			foreach (var laukas in _laukai) {
				stringBuilder.AppendLine(GeneruokLauką(laukas));
			}

			//CREATE TABLE Prekės (
			//Id int,
			//Pavadinimas varchar(255),

			stringBuilder.AppendLine(GeneruokPirminįRaktą());
			stringBuilder.AppendLine(")");

			var scriptas = stringBuilder.ToString();
		}

		private string GeneruokLauką(Laukas laukas)
		{
			switch (laukas.Tipas) {
				case "int":
				case "datetime":
				case "double": {
						return $"{laukas.Pavadinimas} {laukas.Tipas},";
					}
				case "varchar": {
						if (laukas.Ilgis != null) {
							return $"{laukas.Pavadinimas} {laukas.Tipas}({laukas.Ilgis}),";
						} else {
							return $"{laukas.Pavadinimas} {laukas.Tipas}(255),";
						}
					}
				default:
					return "";
			}
		}

		private string GeneruokPirminįRaktą()
		{
			var pirminisRaktas = "PRIMARY KEY (";

			var pirminioRaktoLaukai = _laukai.Where(m => m.ArPirminisRaktas == true).ToList();

			foreach (var pirminioRaktoLaukas in pirminioRaktoLaukai) {
				pirminisRaktas += pirminioRaktoLaukas.Pavadinimas + ", ";
			}

			pirminisRaktas = pirminisRaktas.TrimEnd(',', ' ');

			pirminisRaktas += ")";

			return pirminisRaktas;
		}
	}
}
