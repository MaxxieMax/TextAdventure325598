using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myadventure : MonoBehaviour
{
    //lijstje met alle states
    private enum States
    {
        start,
        intro,
        sloten,
        reactie,
        deelja,
        deelnee,
        slapen,
        wakker,
        gaatkijken,
        //keuze 2
        keuze2,
        //verstoppen
        mankomt,
        gevonden,
        dood1,
        //politie
        zolder,

        

    }
    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        print("hello world");
        Terminal.WriteLine("Druk een knop in om te typen.");
        ShowMainMenu();
    }
        void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welkom bij De engste nacht van je leven");
        Terminal.WriteLine("Dit is gebaseerd op een waargebeurd    verhaal.");
        Terminal.WriteLine("je moet na elke de vraag verder typen.");        
        Terminal.WriteLine("Typ start om te beginnen....");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {

            //begin start
            case States.start:
                      
             if (input == "start")
        
             StartIntro();
        else if (input == "1507")
        
            Terminal.WriteLine("leuk toch!");
            
            //shortcut
        else if (input == "save")
            gevonden();
            
        
        else
        
            Terminal.WriteLine("je moet start intypen!");
         
            break;
            //einde start
            //begin intro
            case States.intro:
        
            if (input == "verder")
            {
               sloten();
            }
             else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
            //einde intro
            //begin reactie
            case States.sloten:

            if (input == "verder" )
            {
                reactie();
            }
             else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
            //einde sloten
            //begin reactie
            case States.reactie:

            if (input == "ja")
            {
                deelja();
            }
            else if (input == "nee")
            {
                deelnee();
            }
            else
        {
            Terminal.WriteLine("je moet ja of nee intypen");
        }
            break;
            //einde reactie
            //begin deelja
            case States.deelja:

            if(input == "verder")
            {
                slapen();
            }
            else
        {
            Terminal.WriteLine("je moet ja of nee intypen");
        }
            break;
            //einde
            //begin deelnee
        case States.deelnee:

        if(input == "verder")
            {
                slapen();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //beging slapen
         case States.slapen:

        if(input == "verder")
            {
                wakker();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
         //beging wakker
         case States.wakker:

        if(input == "verder")
            {
                gaatkijken();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //beging gaatkijken
         case States.gaatkijken:

        if(input == "verder")
            {
                keuze2();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin keuze2
        case States.keuze2:

            if (input == "verstoppen")
            {
                mankomt();
            }
            else if (input == "politie bellen")
            {
                //politie();
            }
            else
        {
            Terminal.WriteLine("je moet verstoppen of politie bellen intypen");
        }
            break;
        //beging mankomt
         case States.mankomt:

        if(input == "verder")
            {
                gevonden();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //beging gevonden
         case States.gevonden:

        if(input == "verder")
            {
                dood1();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //beging einde 1
         case States.dood1:

        if(input == "begin")
            {
                StartIntro();
            }
            else
        {
            Terminal.WriteLine("typ begin om naar het begin te gaan");
        }
            break;


      
    }
    //start
    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("het is vrijdag avond,");
        Terminal.WriteLine("je bent helemaal alleen thuis.");
        Terminal.WriteLine("je ouders en broertjes zijn weg.");
        Terminal.WriteLine("na het eten begin je lekker te gamen.");

        currentState = States.intro;
    }
    //reactie
    void sloten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Een tijdje later kijk je op de klok");
        Terminal.WriteLine("Het was al 1 uur in de ochten! ");
        Terminal.WriteLine("Je dacht: laat ik maar naar bed gaan.");
        Terminal.WriteLine("Je checkt of de deuren en ramen dicht  zitten");
        Terminal.WriteLine("Daarna ging je lekker naar bed");

        currentState = States.sloten;
    }
    //reactie
    void reactie()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je schrikt opeens wakker!");
        Terminal.WriteLine("Je honden blaffen heel hard!");
        Terminal.WriteLine("Je krijgt de keuze om te gaan kijken:");
        Terminal.WriteLine("Ga je kijken: ja of nee?");

        currentState = States.reactie;
    }
    //deelje
    void deelja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je gaat naar beneden,");
        Terminal.WriteLine("je schrikt!");
        Terminal.WriteLine("er staat een man voor de deur!.");
        Terminal.WriteLine("je doet voorzichtig de deur open,");
        Terminal.WriteLine("de man kijkt je een beetje vaag aan.");
        Terminal.WriteLine("je vraagt of de man weg wilt gaan.");
        Terminal.WriteLine("met verbazing loopt de man langzaam weg....");
       // Terminal.WriteLine("met een verwarde gedachten ga je weer  slapen.");

        currentState = States.deelja;
    }
    //deelnee
    void deelnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("het zou wel een vogel zijn, dacht je.");
        Terminal.WriteLine("met die gedachten ging je weer         rustig slapen");
        Terminal.WriteLine("maar later zou je anders denken.....");

        currentState = States.deelnee;
    }
    //slapen
    void slapen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Met een verbaast gezicht ga je weer ");
        Terminal.WriteLine("naar je kamer.");
        Terminal.WriteLine("Na een tijdje lig je weer lekker te    slapen");

        currentState = States.slapen;
    }
    //wakker
        void wakker()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je wordt weer wakker!");
        Terminal.WriteLine("Je kijkt op de klok: het is pas 3 uur!");
        Terminal.WriteLine("Je hoort opeens beneden een hard       geluid!");

        currentState = States.wakker;
    }
    //gaatkijken
        void gaatkijken()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Voorzichtig ga je kijken.");
        Terminal.WriteLine("Wanneer je om het hoekje van de deur   kijkt,");
        Terminal.WriteLine("zie je de man van daarnet staan!");
        Terminal.WriteLine("Je schrikt!");
        Terminal.WriteLine("Je doet snel de deur weer dicht.");

        currentState = States.gaatkijken;
    }
        //keuzen2
        void keuze2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Ik had laatst nog een film gezien waar er een inbreker invoor kwam.");
        Terminal.WriteLine("Daar ging de hoofdpersoon verstoppen   voor de inbreker.");
        Terminal.WriteLine("Je kan ook de politie gaan bellen.");
        Terminal.WriteLine("Ga je verstoppen of de politie bellen?.");

        currentState = States.keuze2;
    }
            //mankomt
        void mankomt()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat snel onder je bed liggen.");
        Terminal.WriteLine("Terwijl je onder je bed ligt hoor");
        Terminal.WriteLine("je de man in de kamer naast je lopen.");
        Terminal.WriteLine("Plotseling stormt de man jouw kamer    binnen.");

        currentState = States.mankomt;
    }
            //gevonden
        void gevonden()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De man checkt alles in je kamer!");
        Terminal.WriteLine("De kast, onder je bureau en zelf achterje boekenkast!"); //achterje staan aan elkaar omdat het beter in de gamer eruit ziet.
        Terminal.WriteLine("Uitijndelijkt kijkt hij ook onder het  bed...");
        Terminal.WriteLine("Hij haalt je onder het bed en slaat je buitenwesten.");

        currentState = States.gevonden;
    }
            //dood1
        void dood1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("je bent na de avond nooit meer terug gezien...");
        

        Terminal.WriteLine("GAME OVER!");

        currentState = States.dood1;
    }


} 
}
