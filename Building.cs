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
			return _hauteurBatiment / _nombreEtages;
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
