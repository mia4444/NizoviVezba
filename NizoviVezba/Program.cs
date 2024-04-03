using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NizoviVezba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Mia Nedeljković IM 21/2021
            
            Zadatak 1
            Neka korisnik unese proizvoljan broj. Uneseni broj pomnožiti sa 5.
            Proveriti da li je novonastali broj broj između 10 i 50.
            Ukoliko jeste ispisati ISPIS 1. Ukoliko je tačno 10 ili tačno 50 ispisati ISPIS 2.
            Ukoliko je broj manji od 10 ili veći od 50 ispisati ISPIS 3.
             */

            int m, n;

            Console.WriteLine("Unesite vrednost.");
            m = int.Parse(Console.ReadLine());

            n = m * 5;
            //Console.WriteLine(b);


            if (m>10 && m < 50)
            {

                Console.WriteLine("ISPIS1");
            }
            else if (m == 10 || m == 50)
            {
                Console.WriteLine("ISPIS2");
            }
            else if (m<10 || m > 50)
            {
                Console.WriteLine("ISPIS3");
            }
            else
            {
                Console.WriteLine("Nema validnog ispisa.");
            }
            {

            }

            /*Zadatak 2
                Proizvoljno definisati niz sa konkretnim vrednostima.
                Proveriti za svaki broj da li je deljiv sa dva. Ukoliko
                jeste, ispisati konkretan broj je deljiv sa dva, a
                ukoliko nije, ispisati konkretan broj nije deljiv sa dva.
             */
            int i = 0;
            int[] mojNiz = new int[] { 1, 2, 3, 4 }; //dala sam mu konkretne vrednosti odmah prilikom deklaracije
            Console.WriteLine("Ispod su dati parni elementi niza.");
            for (i = 0; i < mojNiz.Length; i++) //od nultog indeksa skoro uvek, sve dok je indeks manji od duzine samog niza (nema poente preko ici, to je nemoguce jer je vec propisana duzina niza, uvecavam brojac i za 1, tj prelazim na sledeci indeks
            {
                if (mojNiz[i] % 2 == 0)//dakle to i je element u nizu, a krecemo od nultog indeksa, odnosno sad konkretno od broja 1
                {
                    
                    Console.WriteLine(mojNiz[i]);
                }
            }



            //Zadatak 3: Kalkulator; Poslato Maši prošle nedelje, ali ću copy-paste ovde

            float a, b, rezultat; //da bi bilo što manje varijabli radi memorijskog prostora, koristiću case i imati jedan rezultat
            //char '+', '*','-','/'; ne može ovako
            //char plus, minus, puta, podeljeno;//posle čitanja šta je korisnik uneo u konzolu, namestiću da prepozna char i rezultat koji sledi za njim
            string symbol; //očekujem simbol, ne broj

            Console.WriteLine("Unesi vrednost a");
            a = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesi vrednost b");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Unesi simbol (+,*,-,/)");
            symbol = Console.ReadLine();

            rezultat = 0; //moj rezultat je float, jer su oba inputa isto i realističnije je da imamo float decimal point jer se radi o kalkulatoru

            switch (symbol)
            {
                case "+":
                    rezultat = a + b;
                    Console.WriteLine("Rezultat iznosi " + rezultat);
                    break;

                case "*":
                    rezultat = a * b;
                    Console.WriteLine("Rezultat iznosi " + rezultat);
                    break;

                case "/":
                    if (b != 0)
                    { //želim da dodam i da delioc, tj b ne sme biti 0
                        rezultat = a / b;
                        Console.WriteLine("Rezultat iznosi " + rezultat);
                    }
                    else
                    {
                        Console.WriteLine("Nemoguće je izvršiti operaciju deljenja. Delioc ne sme biti 0.");
                    }
                    break;

                case "-":
                    if (a > b)
                    {
                        rezultat = a - b;
                        Console.WriteLine("Rezultat iznosi " + rezultat);
                    }
                    else
                    {
                        Console.WriteLine("Broj neće biti pozitivan ili će biti 0.");
                    }
                    break;

                default: //u slucaju da korisnik nije uneo ni +, ni -, ni *, ni /
                    Console.WriteLine("Unesti simbol ne odgovara nijednoj operaciji. Unesite novi simbol.");
                    break;

            }   //Console.WriteLine("Rezultat iznosi", rezultat);
                //auto format document prečica: Ctrl+K, Ctrl+D





        }
    }
}
