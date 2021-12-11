using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCatamaran
{
    class BoatComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Catamaran catamaranX && y is Catamaran catamaranY)
            {
                return ComparerCatamaran(catamaranX, catamaranY);
            }
            if (!(x is Catamaran))
            {
                return 1;
            }
            if (!(y is Catamaran))
            {
                return -1;
            }
            if (x is Boat boatX && y is Boat boatY)
            {
                return ComparerBoat(boatX, boatY);
            }
            return 0;
        }

        private int ComparerBoat(Boat x, Boat y)
        {
            if (x.MaxSpeed != y.MaxSpeed) 
            { 
                return x.MaxSpeed.CompareTo(y.MaxSpeed); 
            }
            if (x.Weight != y.Weight) 
            { 
                return x.Weight.CompareTo(y.Weight); 
            }
            if (x.MainColor != y.MainColor) 
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name); 
            }
            return 0;
        }

        private int ComparerCatamaran(Catamaran x, Catamaran y)
        {
            var res = ComparerBoat(x, y); 
            if (res != 0) 
            { 
                return res; 
            }
            if (x.DopColor != y.DopColor) 
            { 
                return x.DopColor.Name.CompareTo(y.DopColor.Name); 
            }
            if (x.Body != y.Body) 
            { 
                return x.Body.CompareTo(y.Body); 
            }
            if (x.LeftCorpus != y.LeftCorpus) 
            { 
                return x.LeftCorpus.CompareTo(y.LeftCorpus); 
            }
            if (x.RightCorpus != y.RightCorpus) 
            { 
                return x.RightCorpus.CompareTo(y.RightCorpus); 
            }
            if (x.Seat != y.Seat)
            {
                return x.Seat.CompareTo(y.Seat);
            }
            return 0;
        }
    }
}
