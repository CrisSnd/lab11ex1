
using lab11ex1.Autovehicule;
using lab11ex1.Statii;
using System;



namespace lab11ex1
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Scrieti un program care va modela statii de pompare.
O statie de pompare poate pune la dispozitia clientilor mai multe tipuri de combustibil
• Benzina
• Diesel
• GPL
• Electricitate
Autovehiculele
Autovehiculele sunt caracterizate de model, id si o metoda ce va produce descrierea completa a
autovehiculului. Ele pot fi de mai multe tipuri
• Benzina - capabile sa fie alimentate doar cu benzina
• Diesel - capabile sa fie alimentate doar cu diesel
• GPL - capabile sa fie alimentate atat cu benzina cat si cu GPL
• Electrice - capabile sa fie alimentate doar cu electricitate
• Plug-in hybrid- capabile sa fie alimentate atat cu benzina cat si cu electricitate
Statiile de pompare
Statiile de pompare sunt de mai multe tipuri
• Clasice
o Pot alimenta doar Benzina, Diesel si GPL
• Hibride
o Pot alimenta toate tipurile de combustibil
Statiile de pompare vor detine mai multe metode specifice fiecarui tip de combustibil suportat.
Metodele vor simula alimentarea unui autovehicul cu un combustibilul specific.
Aceste metode vor primi ca parametru atat autovehiculul cat si cantitatea de combustibil dorita.
Apelul metodelor va afisa pe ecran descrierea completa a autovehiculului si cantitatea alimentata.
Statiile de pompare vor avea o cantitate infinita de combustibil.
Instantiati statii de pompare, creați auovehicule si alimentati-le la statiile de pompare instantiate.
   
         Suplimentar
Un camion este un autovehicul caracterizat de un cap tractor si o cisterna. Capul tractor este un
autovehicul diesel.
Cisterna
Incarcarea
• Cisterna poate fi incarcata cu oricare dintre combustibilii clasici nepresurizati (benzina, diesel).
Aceasta va memora atat cantitatea de combustibil incarcata cat si tipul acestuia.
• Daca se va incerca alimentarea cisternei cu un alt tip de combustibil decat cel gata incarcat, atunci
aceasta va refuza incarcarea, si va afisa un mesaj corespunzator.
Alimentarea
• Asemenea unei statii de incarcare clasice, cisterna va putea alimenta orice autovehicul compatibil.
• La alimentarea unui autovehicul, cisterna va tine cont de tipul combustibilului precum si de
cantitatea existenta.
• Metoda va afisa mesajele corespunzatoare.
Instantiati camionul, alimentati-l, incarcati-i cisterna. Alimentati autovehicule folosind cisterna. Alimentati
camionul folosind propria cisterna. */

            var masina1 = new AutovehiculBenzina("Logan");
            var masina2 = new AutovehiculDiesel("Skoda");
            var masina3 = new AutovehiculElectric("Toyota");

            var statieClasica = new StatieClasica();
            var statieHibrida = new StatieHibrida();

            statieClasica.AlimenteazaBenzina(masina1, 20);
            statieHibrida.AlimenteazaElectric(masina3, 20);


            var camion1 = new Camion("Volvo");
         
            statieClasica.AlimenteazaDiesel(camion1,200);
            statieClasica.AlimenteazaDiesel(camion1.Cisterna, 2000);

            var camion2 = new Camion("Scania");
            statieHibrida.AlimenteazaBenzina(camion2.Cisterna, 500);

            camion1.Cisterna.AlimenteazaDiesel(camion2, 600);
        }

    }

}


