using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator6___Exercitiu3
{
    class Student
    {
        private string nume;
        private string prenume;

        public Student(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }

        public void TiparesteStudent()
        {
            Console.WriteLine($"Studentul: Nume: {nume} Prenume: {prenume}");
            Console.WriteLine($"Notele Studentului Sunt: {TiparesteNota()}");
        }

        public void TiparesteNota()
        {
            Console.WriteLine("Introduceti Numarul Notelor");
            int numarNote = int.Parse(Console.ReadLine());
            int[] note = new int[numarNote];
            Console.WriteLine("Introduceti Notele");
            for (var i = 0; i < note.Length; i++)
            {
                Console.WriteLine("Introduceti Notele");
            }

        }

        public void MediaElevului()
        {
            double suma = 0, media = 0;
            int[] note = new int[100];
            for (int i = 0; i < note.Length; i++)
            {
                suma += note[i];
            }
            media = suma / note.Length;
            Console.WriteLine("Media Elevului este:" + media);
        }
    }
}