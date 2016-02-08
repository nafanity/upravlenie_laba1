using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба10_прога
{
    class Program
    {
        public class Klient
        {
            public string FIO;
            public int Age;
            public Student UnspecifiedType1;
            public Prepodavatel UnspecifiedType2;
            public Bibliotekar UnspecifiedType3;
            public bool Find()
            {
                Console.WriteLine("Klient was finded!");
                return true;
            }
        }

        public class Student
        {
            public int Kurs;
            public int Nomer_zach;
            public string Special;
            public Klient UnspecifiedType1;
            Student()
            {
            }
            ~Student()
            {
            }
            public void Zapros_electronnoi_versii()
            {
            }
            public void Zapros_spravki()
            {
            }
            public void Vozvrat_knigi()
            {
            }
        }

        public class Prepodavatel
        {
            public string Kafedra;
            public Klient UnspecifiedType1;
            Prepodavatel()
            {
            }
            ~Prepodavatel()
            {
            }
            public void Zakaz_na_zakaz()
            {
            }
        }

        public class Bibliotekar
        {
            public string FIO;
            public Klient UnspecifiedType1;
            Bibliotekar()
            {
            }
            ~Bibliotekar()
            {
            }
            public void Vnesenie_zapisei_v_BD()
            {
            }
            public void Vydacha_knig()
            {
            }
        }

        public class BD
        {
            public int ID;
            public Hudojestvennaya_literatura UnspecifiedType1;
            public Pereodicheskie_izdaniya UnspecifiedType2;
            BD()
            {
            }
            ~BD()
            {
            }
        }

        public class Client
        {

        }

        public class Hudojestvennaya_literatura
        {
            public string Type;
            public string Name;
            public string Autor;
            public int God_vypuska;
            public string Janr;
            public string Izdatelstvo;
            public bool v_biblioteke;
            public BD UnspecifiedType1;
            Hudojestvennaya_literatura()
            {
            }
            ~Hudojestvennaya_literatura()
            {
            }
        }

        public class Pereodicheskie_izdaniya
        {
            public string Type;
            public string Name;
            public int Nomer_vypuska;
            public bool v_bibliotele;
            public BD UnspecifiedType1;
            Pereodicheskie_izdaniya()
            {
            }
            ~Pereodicheskie_izdaniya()
            {
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Worked!");
                Console.WriteLine("Start!");
				Console.WriteLine("Start v2!");
                Console.ReadLine();
            }
        }
    }
}
