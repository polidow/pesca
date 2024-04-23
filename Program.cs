Console.Clear();

int mar;
int Kg;

Console.WriteLine("------------Pesca Amadora------------");

Console.WriteLine("Você esta em águas continentais e estuarinas: 1/sim 2/não");

Console.ReadLine();

if(mar = 1);{
Console.WriteLine("Você esta em águas continentais e estuarinas. Insira o Kg do peixe:");
Kg = Convert.ToInt32(Console.ReadLine());

if (Kg > 10);{
Console.ForegroundColor = ConsoleColor . Red;
Console.WriteLine("Pescaria excede os limites legais em águas continentais e estuarinas de 10kg. Sujeito a multa de R$ 1000,00.");
}

else { 
Console.ForegroundColor = ConsoleColor . Blue;
Console.WriteLine("Pescaria dentro dos limites legais");
    }
}

else if (mar = 2);{
Console.WriteLine("Você esta em águas marinhas. Insira o Kg do peixe:");
Kg = Convert.ToInt32(Console.ReadLine());

if (Kg > 15);{
Console.ForegroundColor = ConsoleColor . Red;
Console.WriteLine("Pescaria excede os limites legais em águas continentais e estuarinas de 10kg. Sujeito a multa de R$ 1000,00.");
}

else { 
Console.ForegroundColor = ConsoleColor . Blue;
Console.WriteLine("Pescaria dentro dos limites legais");
}
}
