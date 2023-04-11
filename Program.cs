Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("O que deseja fazer?");
    Console.WriteLine("1 - Soma");
    Console.WriteLine("2 - Subtração");
    Console.WriteLine("3 - Multiplicação");
    Console.WriteLine("4 - Divição");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("----------------");
    Console.WriteLine("Selecione uma opção: ");
    short.TryParse(Console.ReadLine(), out short res);

    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtracao(); break;
        case 3: Multiplicacao(); break;
        case 4: Divisao(); break;
        case 5: System.Environment.Exit(0); break;
        default: Menu(); break;
    }
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor1);
    Console.WriteLine("Segundo Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor2);
    Console.WriteLine("O valor da soma é " + (valor1 + valor2));
    Console.ReadKey();
    Menu();
}
static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor1);
    Console.WriteLine("Segundo Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor2);
    Console.WriteLine("O valor da subtração é " + (valor1 - valor2));
    Console.ReadKey();
    Menu();
}
static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor1);
    Console.WriteLine("Segundo Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor2);
    Console.WriteLine("O valor da multiplicação é " + (valor1 * valor2));
    Console.ReadKey();
    Menu();
}
static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor1);
    Console.WriteLine("Segundo Valor: ");
    Double.TryParse(Console.ReadLine(), out double valor2);
    Console.WriteLine("O valor da divisão é " + (valor1 / valor2));
    Console.ReadKey();
    Menu();
}