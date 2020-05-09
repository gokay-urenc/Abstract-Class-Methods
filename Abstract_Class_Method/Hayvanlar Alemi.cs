using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Method
{
    public abstract class Hayvanlar_Alemi
    {
        public string renk { get; set; }
        public int yas { get; set; }
        public abstract string Ses();
        public abstract string Yemek();
    }

    class Kedi : Hayvanlar_Alemi
    {
        public override string Ses()
        {
            return "Miyav";
        }

        public override string Yemek()
        {
            return "Balık";
        }
    }

    class Kopek : Hayvanlar_Alemi
    {
        public override string Ses()
        {
            return "Hav";
        }

        public override string Yemek()
        {
            return "Et";
        }
    }
}