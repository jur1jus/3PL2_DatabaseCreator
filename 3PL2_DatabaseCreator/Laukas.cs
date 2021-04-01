namespace _3PL2_DatabaseCreator
{
	public class Laukas
	{
		public string Pavadinimas { get; set; }

		public string Tipas { get; set; }

		public string Ilgis { get; set; }

		public bool ArPirminisRaktas { get; set; }

		public Laukas(string pavadinimas, string tipas, string ilgis, bool arPirminisRaktas)
		{
			Pavadinimas = pavadinimas;
			Tipas = tipas;
			Ilgis = ilgis;
			ArPirminisRaktas = arPirminisRaktas;
		}

		public override string ToString()
		{
			return $"{Pavadinimas} {Tipas} {Ilgis} Ar piminis raktas {ArPirminisRaktas}";
		}
	}
}
