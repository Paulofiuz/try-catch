Console.Clear();

try
{
    int[] numbers = { 1, 2, 3 };
    Console.WriteLine(numbers[5]); // Isso vai gerar uma exceção

    Salver("");
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Erro: Índice fora do intervalo do array.");
}
catch (Exception ex)
{
    Console.WriteLine("Ocorreu um erro: " + ex.Message);
}

static void Salver(String texto)
{

    if (string.IsNullOrEmpty(texto))
    {
        throw new Exception("O texto não pode ser nulo ou vazio");
    }
}