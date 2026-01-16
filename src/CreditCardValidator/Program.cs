using CreditCardValidator.Validators;

class Program
{
    static void Main()
    {
        Console.WriteLine("Validador de Cartão de Crédito - .NET 10.0.2\n");

        while (true)
        {
            Console.Write("Digite o número do cartão (ou 'sair' para encerrar): ");
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input) || input.Trim().ToLower() == "sair")
                break;

            // Agora usamos CardValidator em vez de CreditCardValidator
            var brand = CardValidator.GetBrand(input);
            bool isValid = CardValidator.ValidateNumber(input);

            Console.ForegroundColor = isValid ? ConsoleColor.Green : ConsoleColor.Red;
            Console.WriteLine(isValid
                ? $"VÁLIDO! Bandeira: {brand}"
                : "INVÁLIDO! Número ou formato incorreto");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
