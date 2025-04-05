Console.Clear();

//Quando usado dinheiro usamos DECIMAL
decimal salario, fgts;

Console.Write("Digite o seu salário: ");
salario = Convert.ToDecimal(Console.ReadLine()!);
fgts = salario * 0.08m;

Console.WriteLine($"Salário (R$)..: {salario}");
Console.WriteLine($"FGTS: R$ {fgts:F2}");