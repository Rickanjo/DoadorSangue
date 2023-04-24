// Solicite a idade do usuário. Avalie se ele pode ser doador de sangue (i.e. possui idade entre 18 e 67 anos). Informe o resultado da avaliação.
Console.WriteLine("--- Doador de Sangue ---");

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

if (idade >= 18 && idade <= 67) {
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Você pode ser um doador de sangue.");

} else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não pode ser um doador de sangue.");
}
Console.ResetColor();