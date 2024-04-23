Console.Clear();

int mar;
int Kg;


void loop(){
Console.WriteLine("------------Pesca Amadora------------");
Console.WriteLine("Você esta em águas continentais e estuarinas: 1/sim 2/não");
mar= Convert.ToInt32(Console.ReadLine());

        if(mar == 1)
        {
            Console.WriteLine("Você esta em águas continentais e estuarinas. Insira o Kg do peixe:");
            Kg = Convert.ToInt32(Console.ReadLine());

        if (Kg > 10 )
        {
            Console.ForegroundColor = ConsoleColor . Red;
            Console.WriteLine("Pescaria excede os limites legais em águas continentais e estuarinas de 10kg. Sujeito a multa de R$ 1000,00., com acréscimo de R$20,00 por quilo excedido.");
            int multa = 1000 + (20 * (Kg - 10));
            Console.WriteLine($"Sujeito a multa de R$: {multa}");
        }

        else 
        { 
            Console.ForegroundColor = ConsoleColor . Blue;
            Console.WriteLine("Pescaria dentro dos limites legais");
        }
        }
   
        else if (mar == 2)
        {
            Console.WriteLine("Você esta em águas marinhas. Insira o Kg do peixe:");
            Kg = Convert.ToInt32(Console.ReadLine());

        if (Kg > 15)
        {
            Console.ForegroundColor = ConsoleColor . Red;
            Console.WriteLine("Pescaria excede os limites legais em águas marinhas de 15kg. Sujeito a multa de R$ 1000,00.");
            int multa = 1000 + (20 * (Kg - 15));
            Console.WriteLine($"Sujeito a multa de R$: {multa}");
        }

        else 
        { 
            Console.ForegroundColor = ConsoleColor . Blue;
            Console.WriteLine("Pescaria dentro dos limites legais");
        }
        }
    Console.WriteLine("Você quer recomeçar o programa? [S/N]");
    string reposta = Console.ReadLine()!;
    if(reposta.ToUpper() == "S")
    {
    Console.ResetColor();
        loop();
    }
    else{

    }
}
loop();
