using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructeurs
{
    class Building
    {

		private double _hauteurBatiment;
		private int _nombreEtages;

		public Building(double hauteurBatiment, int nombreEtages)
		{
			_hauteurBatiment = hauteurBatiment;
			_nombreEtages = nombreEtages;
		}

		public Building(int nombreEtages)
		{
			_hauteurBatiment =3* nombreEtages;
		}


		public double GetFloorMaxSize()
        {
			if (_nombreEtages != 0)
				return _hauteurBatiment / _nombreEtages;

			else
			{
				Console.WriteLine("Le nombre d'etage ne peux pas être 0");
				return 0;
			}
        }

		public double GetFloorCount()
        {
			return _nombreEtages;
        }

		public double GetSize()
        {
			return _hauteurBatiment;
        }

		/*		public Building(double etage)
				{
					hauteurBatiment = 3 * etage;
				}
		*/






	}
}
