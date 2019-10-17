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
        zolder2,
        //keuze3
        keuze3,
        //blijft zitten
        kloppen,
        probeertOpenTeDoen,
        Dood2,
        //zolderraam
        dak,
        lichten,
        //keuze4
        keuze4,
        //dood3
        valt,
        dood3,
        //einde
        agenten,
        roept,
        beneden,
        einde,


        

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
        Terminal.WriteLine("Type start om te beginnen....");
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
            keuze3();
            
        
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
                wakker();
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
                zolder();
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
        //begin dood1
         case States.dood1:

        if(input == "begin")
            {
                StartIntro();
            }
            else
        {
            Terminal.WriteLine("type begin om naar het begin te gaan");
        }
            break;
        //begin zolder
         case States.zolder:

        if(input == "verder")
            {
                zolder2();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin zolder2
         case States.zolder2:

        if(input == "verder")
            {
                keuze3();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin keuze3
        case States.keuze3:

            if (input == "door het raam klimmen")
            {
                dak();
            }
            else if (input == "blijven zitten")
            {
                kloppen();
            }
            else
        {
            Terminal.WriteLine("je moet: door het raam klimmen of      blijven zitten intypen.");
        }
            break;
        //begin kloppen
         case States.kloppen:

        if(input == "verder")
            {
                probeertOpenTeDoen();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin probeertOpenTeDoen
         case States.probeertOpenTeDoen:

        if(input == "verder")
            {
                dood2();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin dood2
         case States.Dood2:

        if(input == "begin")
            {
                StartIntro();
            }
            else
        {
            Terminal.WriteLine("type begin om naar het begin te gaan");
        }
            break;
        //begin dak
         case States.dak:

        if(input == "verder")
            {
                lichten();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin lichten
         case States.lichten:

        if(input == "verder")
            {
                keuze4();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin keuze4
        case States.keuze4:

            if (input == "naar beneden")
            {
                valt();
            }
            else if (input == "blijf zitten")
            {
                agenten();
            }
            else
        {
            Terminal.WriteLine("je moet: naar beneden of blijf zitten  intypen.");
        }
            break;
        //begin dood3
        //begin valt
         case States.valt:

        if(input == "verder")
            {
                dood3();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin dood3
         case States.dood3:

        if(input == "begin")
            {
                StartIntro();
            }
            else
        {
            Terminal.WriteLine("type begin om naar het begin te gaan");
        }
            break;
        //begin agentenn
         case States.agenten:

        if(input == "verder")
            {
                roept();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin roept
         case States.roept:

        if(input == "verder")
            {
                beneden();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin beneden
         case States.beneden:

        if(input == "verder")
            {
                einde();
            }
            else
        {
            Terminal.WriteLine("je moet verder intypen");
        }
            break;
        //begin EINDE
         case States.einde:

        if(input == "begin")
            {
                StartIntro();
            }
            else
        {
            Terminal.WriteLine("type begin om naar het begin te gaan");
        }
            break;




      

      //probeertOpenTeDoen
    }
    //start
    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is vrijdag avond,");
        Terminal.WriteLine("Je bent helemaal alleen thuis.");
        Terminal.WriteLine("Je ouders en broertjes zijn weg.");
        Terminal.WriteLine("Na het eten begin je lekker te gamen.");

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
        Terminal.WriteLine("Met verbazing loopt de man langzaam weg....");

        currentState = States.deelja;
    }
    //deelnee
    void deelnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Het zou wel een vogel zijn, dacht je.");
        Terminal.WriteLine("Met die gedachten ging je weer         rustig slapen");
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
        Terminal.WriteLine("Je bent na de avond nooit meer terug   gezien...");
        

        Terminal.WriteLine("GAME OVER!");

        currentState = States.dood1;
    }

                //zolder
        void zolder()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Terwijl de man de andere kamers checkt sluip je snel naar het zolderluik.");
        Terminal.WriteLine("Je doet het zolderluik open, maar de   man hoort dat!");
        Terminal.WriteLine("Snel klim je de trap op en doe je het  zolderluik dicht.");
        Terminal.WriteLine("Net optijd!");

        currentState = States.zolder;
    }
                    //zolder
        void zolder2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Terwijl je op zolder zit probeer je de politie te bellen.");
        Terminal.WriteLine("Je hebt net genoeg bereik om ze te     bellen!");
        Terminal.WriteLine("Ze komen er zo snel mogelijk aan!");

        currentState = States.zolder2;
    }
        //keuzen3
        void keuze3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet dat het zolderaam open staat.");
        Terminal.WriteLine("Je bent net groot genoeg om er doorheen te klimmen.");
        Terminal.WriteLine("Je kan ook binnen blijven zitten.");
        Terminal.WriteLine("Ga je blijven zitten of ga je door het raam heen klimmen?");

        currentState = States.keuze3;
    }
        //kloppen
        void kloppen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De man begint opeens heel hard op het   zolderluik te kloppen!");
        Terminal.WriteLine("Hij stopt gelukig even, hij heeft het  volgensmij opgegeven.");

        currentState = States.kloppen;
    }
        //probeertOpenTeDoen
        void probeertOpenTeDoen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Opeens begint de man heel hard aan het zolderluik te trekken!");
        Terminal.WriteLine("Ik probeer het luik zo goed mogelijk   dicht te houden.");
        Terminal.WriteLine("Zo ga ik het niet lang vol houden.");

        currentState = States.probeertOpenTeDoen;
    }
            //dood2
        void dood2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Na een tijdje krijgt de man het luik   toch open!");
        Terminal.WriteLine("De man klimt naar boven...");
        Terminal.WriteLine("Je bent na de avond nooit meer terug   gezien...");
        Terminal.WriteLine("GAME OVER!");

        currentState = States.Dood2;
    }
            //dak
        void dak()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je klimt snel door het krappezolderraam");
        Terminal.WriteLine("het past gelukkig net!");
        Terminal.WriteLine("Het raam is net te klein voor de man om er doorheen te komen.");
        Terminal.WriteLine("Terwijl je op het dak zit hoor je in de verte de politie al!");

        currentState = States.dak;
    }
               //lichten
        void lichten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet ook al snel de lichten van de  politewagen");
        Terminal.WriteLine("alleen hoe kom ik van het dak af?");

        currentState = States.lichten;
    }
                   //keuze4
        void keuze4()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Blijf je op het dak zitten?");
        Terminal.WriteLine("Of probeer je er af te gaan?");
        Terminal.WriteLine("Het is wel 3 verdiepingen hoog...");
        Terminal.WriteLine("Ga je naar beneden of blijf je zitten?");

        currentState = States.keuze4;
    }
                   //valt
        void valt()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je probeert naar beneden te klimmen...");
        Terminal.WriteLine("Omdat het donker is weet je niet goed  waar je je voeten neer moet zetten.");
        Terminal.WriteLine("Bij de 2e stap gaat het al fout!");
        Terminal.WriteLine("Je valt hard naar beneden....");

        currentState = States.valt;
    }
            //dood3
        void dood3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je valt hard op de grond.");
        Terminal.WriteLine("Er gaat opeens een heftige pijnscheut  door je been heen...");
        Terminal.WriteLine("Door de heftige pijn val je            buitenwesten.");
        Terminal.WriteLine("Je bent na de avond nooit meer terug   gezien...");
        Terminal.WriteLine("GAME OVER!");

        currentState = States.dood3;
    }
                //agenten
        void agenten()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je ziet dat de de politiewagen steeds dichterbij komen.");
        Terminal.WriteLine("Je ziet dat er 2 politie agenten naar de deur lopen.");

        currentState = States.agenten;
    }
                //roept
        void roept()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Je fluistert naar de agenten maar ze   horen je niet!");
        Terminal.WriteLine("Uitijndelijk schreeuw je naar de       agenten.");
        Terminal.WriteLine("Ze kijken je eerst een beetje vreemd   aan,");
         Terminal.WriteLine("maar uitijndelijk proberen ze je te    helpen.");

        currentState = States.roept;
    }
                //beneden
        void beneden()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("De agenten helpen je veilig naar       beneden.");
        Terminal.WriteLine("Er stont toevallig een ladder tegen het huis aan.");

        currentState = States.beneden;
    }
            //einde
        void einde()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Eenmaal veilig beneden aangekomen,");
        Terminal.WriteLine("Vertel je de agenten het hele veraal.");
        Terminal.WriteLine("Dierect stormen de agenten het huis    binnen en");
        Terminal.WriteLine("arresteren ze de man!!");
        Terminal.WriteLine("GEFELICITEERD!");
        Terminal.WriteLine("JE HEBT DE GAME UITGESPEELD!");

        currentState = States.einde;
    }



} 
}
