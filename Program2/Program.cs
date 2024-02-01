using Program2;

Bank bank = new Bank();
int menu = 9;

while (menu != 0)
{
    int amount = 0;
    int idClient = 0;
    Console.Write("\n1. Depositar \n2. Extraer \n0. Finalizar Día \nElija la opción deseada");
    try
    {
        menu = int.Parse(Console.ReadLine());

        if (menu == 0)
        {
            Console.WriteLine($"\n{bank.DepositedMoney()} \nPrograma Finalizado...");  
            break;
        }

        if (menu < 1 || menu > 2)
        {
            Console.WriteLine("Ingrese un numero valido");
            continue;
        }

        Console.Write("\nMonto a " + (menu == 1 ? "depositar: " : "extraer: "));
        amount = int.Parse(Console.ReadLine());

        Console.Write("\nIdentificación del cliente: ");
        idClient = int.Parse(Console.ReadLine());
    }
	catch (Exception ex)
	{
		Console.WriteLine("Ingrese un numero valido");
        continue;
	}

    Console.WriteLine(bank.DepositOrExtraction(idClient, amount, (BankTransaction)menu));
}

