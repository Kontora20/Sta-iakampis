using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PirmaUzduotis
{
    class Rectangle
    {
        //atributai
        public double ilgis;
        public double aukstis;
        public double koord1, koord2;
       

        //metodai
        public void ivedimas()
        {
            Console.WriteLine("Iveskite staciakampio ilgi: ");
            ilgis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio auksti: ");
            aukstis = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio tasko A x koordinate (skacius , skaicius): ");
            koord1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite staciakampio tasko A y koordinate (skacius , skaicius): ");
            koord2 = Convert.ToDouble(Console.ReadLine());
        }

        public double plotas()
        {
            return ilgis * aukstis;
        }

        public double perimetras()
        {
            return ilgis * 2 + aukstis * 2;
        }

        public double istrizaine()
        {

            double ist = ilgis * ilgis + aukstis * aukstis;
            ist = Math.Sqrt(ist);
            ist = Math.Round(ist,2);
            return ist;
        }
            
        public void koordinates()
        {
            double koord3 = koord1 + ilgis;             // B tasko koord x
            double koord4 = koord2; 
            Console.WriteLine("Staciakampio tasko B koordinates: {0}, {1} ", koord3, koord4);

            double koord5 = koord3;                     // C tasko koord x
            double koord6 = koord4 - aukstis; 
            Console.WriteLine("Staciakampio tasko C koordinates: {0}, {1} ", koord5, koord6);

            double koord7 = koord1;                     //D tasko koord x
            double koord8 = koord2 - aukstis; 
            Console.WriteLine("Staciakampio tasko D koordinates: {0}, {1} ", koord7, koord8);

            double koord9 = (ilgis /2 ) + koord1;
            double koord10 = koord2 - (aukstis / 2);
            Console.WriteLine("Staciakampio istrizainiu susikirtimo taskas: {0}, {1} ", koord9, koord10);
                  

        } 

        public void isvedimas()
        {
            Console.WriteLine("Staciakampio plotas lygus: {0} ", plotas());
            Console.WriteLine("Staciakampio perimetras lygus: {0} ", perimetras());
            Console.WriteLine("Staciakampio istrizaine lygi: {0} ", istrizaine());
            Console.WriteLine("Staciakampio tasko A koordinates: {0}, {1} ", koord1,koord2);

        }
    }

}
