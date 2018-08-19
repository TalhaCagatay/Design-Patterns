using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var ucakFabrikasi = new UcakFabrikasi();

            IUcak boing = ucakFabrikasi.UcakUret(UcakTipi.Boing);
            boing.UcakFiyati();

            IUcak f16 = ucakFabrikasi.UcakUret(UcakTipi.F16);
            f16.UcakFiyati();
        }
    }

    public interface IUcak
    {
        void UcakFiyati();
    }

    public class Boing : IUcak
    {
        public void UcakFiyati()
        {
            string s = "Boing uçağının fiyati 11";
            Console.WriteLine(s);
        }
    }
    public class F16 : IUcak
    {
        public void UcakFiyati()
        {
            string s = "F16 uçağının fiyatı 23";
            Console.WriteLine(s);
        }
    }

    public enum UcakTipi
    {
        Boing,F16
    }

    public interface IUcakFabrikasi
    {
        IUcak UcakUret(UcakTipi tip);
    }

    public class UcakFabrikasi : IUcakFabrikasi
    {
        public IUcak UcakUret(UcakTipi tip)
        {
            IUcak ucak = null;
            switch (tip)
            {
                case UcakTipi.Boing:
                    ucak = new Boing();
                    break;
                case UcakTipi.F16:
                    ucak = new F16();
                    break;
            }
            return ucak;
        }
    }

}
