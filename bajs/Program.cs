string namn;
string eat;
string fight;
string direction;
string finalShowdown;
string sistaOrd;

do{
    Console.WriteLine("Vad heter du?");
    namn = Console.ReadLine();

    if (String.IsNullOrWhiteSpace(namn)){
        Console.WriteLine("Skriv ett riktigt namn gawad");
    }
} while (String.IsNullOrWhiteSpace(namn));


if (namn.ToUpper() == "ADAM"){
    Console.WriteLine("inte välkommen hejdå");
    Console.ReadLine();
    System.Environment.Exit(0);
}

do{
    Console.WriteLine("WAow wilken fin dag.! du känner dig hungrig, äta mat?? det finns spaghetti :)))");
    eat = Console.ReadLine().ToUpper();
} while (eat.ToUpper() != "NEJ" && eat.ToUpper() != "JA");


if (eat == "NEJ"){
    Console.WriteLine("ok gå o lägg dig bror hejdå hejdå");
}
else{
    Console.WriteLine($"{namn}: mmmmmmm va gott \n*explosion* \nNEEEJ varför sprängs min speghetti????!!?! \n\n???: VAR HÄLSAD {namn}. Det är jag, det store mäkte spagheti monstret");

    do{
        Console.WriteLine("\n\nSka jag försöka döda honom?");
        fight = Console.ReadLine().ToUpper();
    } while (fight.ToUpper() != "JA" && fight.ToUpper() != "NEJ");

    if (fight == "JA"){
        Console.WriteLine($"{namn}: JAG SKA DÖDA DIG BROR \n\nMONSTER: NEJ du vågar inte!!. \n\n{namn}: JOOOO det gör jag!1!! aj varför slog du mig? :( \n\nMONSTER: jag kände för det XAXAAXA зубчатое яблоко!! \n\n din kropp börjar förvandlas till spaghetti, du får panik. \n\n{namn}: NEEEJ JAG dör!1!!! \n\n du dog");
    }
    else{
        Console.WriteLine($"Du springer! Monstret jagar dig! Han suger upp alla object i sin väg, som ett svart hål \n\n{namn}: MIG FÅNGAR DU ALDRIG HORUNGE!!! \n\nMONSTER: nej vad taskig du är :(((( \n\nVägen kommer till ett slut. Du kan springa vänster eller höger.");
        
        do{
            Console.WriteLine("Vilket håll väljer du?");
            direction = Console.ReadLine().ToUpper();
        } while (direction.ToUpper() != "VÄNSTER" && direction.ToUpper() != "HÖGER");

        if (direction == "VÄNSTER"){
            Console.WriteLine($"Du springer vänster. Vägen fortsätter en bra bit. Monstret verkar bli snabbare för varje objekt han suger upp, han kommer närmare. \n\n{namn}: SAKtA NER GAWAD! \n\nMONSTER: nej:) \n\nDu har råkat springa in i en återvändsgränd. Vägen blockeras av en vägg. Monstrett står framför dig med ett läskigt leende, han är glad över att få döda dig. \nBenen darrar och svett rinner från ansiktet, hur ska du kunna ta dig ut ur det här? Är det här slutet på ditt liv? \nDu får en idé. \"Jag kan spela död. Det skulle kunna fungera\" tänker du för dig själv. \nMen sen får du en till idé. \"Monstrett är ju gjort av spaghetti, då kan jag ju äta upp det\" tänker du.");

            do{
                Console.WriteLine("\n\nSka du spela död eller försöka äta upp monstrett?");
                finalShowdown = Console.ReadLine();
            } while (finalShowdown.ToUpper().Contains("ÄT") != true && finalShowdown.ToUpper().Contains("DÖD") != true);

            if (finalShowdown.ToUpper().Contains("ÄT")){
                Console.WriteLine($"\nDu gör din mage redo för den siste kampen mot monstrett. \n\n{namn}: ÄR DU REDO FÖR MIN MÄKTE MAGE? \n\nMONSTER: ?? what gå o lägg dig bror, bered dig på att dö \n\nNi står mittemot varandra, båda redo att döda den andra. Spänningen tar kål på dig, kommer du klara av denna utmaning, eller kommer du avlida som den enda som vågade stå upp emot det mäktige monstrett? \nDu blir en hjälte hur som helst. \n\nDu springer mot monstrett samtidigt som du långsamt öppnar din mun. Monstrett går ner med en tugga. \n\n Hela staden hyllar ditt mod, och du blir kronad som stadens hjälte. \n\n Vad ska du säga till folket? Hela staden lyssnar.");
                sistaOrd = Console.ReadLine();
                Console.WriteLine($"\n\n{namn}: {sistaOrd}");
                Console.WriteLine($"Applåder hörs från alla håll. WAOW {namn}!!! DU HAR RÄDDAT OSS TACK BROR");
            }
            else{
                Console.WriteLine("Du spelar död. Monstret verkar inte gå på det. \n\nMONSTER: hejhej du tror du lura mig???? jag äta upp smaklig måltid!! bon apple tit!! \n\nMonstret åt upp dig. du dog :))))");
            }
        }
        else{
            Console.WriteLine($"Du springer höger. Monstret verkar bli snabbare för varje objekt han suger upp. Han kommer ikapp dig. \n\nMONSTER: JAG KOMMER IKAPP DIG!! DU KAN INTE SPRINGA IFRPN MIG!111!!! \n\n{namn}: NEEEEEEJ \n\n Monstret kommer ikapp dig och äter upp dig.. du dog! :))()()");
        }
    }
}




Console.ReadLine();