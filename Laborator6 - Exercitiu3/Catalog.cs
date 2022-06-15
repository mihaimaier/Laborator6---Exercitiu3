using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu3
{
    class Catalog
    {
        public string numeleClasei = "Clasa 8A";
        public Student[] vectorStudenti = new Student[3];

        public void DetaliiStudent()
        {
            Student[] vectorStudenti = new Student[3];
            for (var i = 0; i < vectorStudenti.Length; i++)
            {
                vectorStudenti[i] = Student.TiparesteStudent();
            }
        }

        public void Tipareste()
        {
            Console.WriteLine($"Numele clasei este: {numeleClasei}");
            Console.WriteLine($"Numele elevilor sunt: {DetaliiStudent()}");
        }

        public void GetPremiantul(double[] notaElevi)
        {
            string rezultat = String.Empty;
            double mediaMare = 0;
            for (int i = 0; i < notaElevi.Length; i++)
            {
                double mediaCurenta = 0;
                for (int j = 0; j < notaElevi[i].Length; j++)
                {
                    mediaCurenta += notaElevi[i][j];
                    if (j == notaElevi[i].Length - 1)
                    {
                        mediaCurenta = mediaCurenta / notaElevi[i].Length;
                    }
                }
                if (mediaCurenta > mediaMare)
                {
                    mediaMare = mediaCurenta;
                    rezultat = String.Empty;
                    rezultat = ($"Elevul {DetaliiStudent()} are nota cea mai mare respectiv {mediaMare.ToString("n2")}.").ToString();
                }
            }
            return rezultat;
        }
    }
}
