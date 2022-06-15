using System;

namespace Laborator6___Exercitiu3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Laborator6 - Exercitiu 3 & 3.1

            //Catalog 
            //Un catalog contine:
            // -numele clasei
            // -lista(vector) a elevilor. 
            // - O functie “Tipareste” care va afisa numele clasei si care va tipari fiecare elev in parte.
            // - O functie “GetPremiantul” care va determina elevul cu media cea mai mare.

            //Elevii vor avea:
            // - nume, prenume
            // - o lista(vector) de note specifica fiecarui elev.
            // - O functie care va calcula media elevului
            // - O functie ”Tipareste” care va afisa informatiile elevului sub forma
            // - nume, prenume
            // - nota0 nota1 nota2…. Notam

            // In functia “Main”
            // Initializati 3 elevi
            // Initializati un catalog adaugandu-I elevii
            // - Afisati catalogul chemand metoda “Tipareste”
            // - Apelati metoda GetPremiantul a catalogului si afisati elevul cu media cea mai mare
            // - Realiazti diagrama UML a clasei
            // - Atentie la : constructori, modificatori de acces, clase

            Student student1 = new Student("George","Danciu");
            Student student2 = new Student("Alex","Vladeasa");
            Student student3 = new Student("Mihai","Popescu");

            Catalog studenti = new Catalog();
            studenti.DetaliiStudent();

            studenti.Tipareste();




        }
    }
}
