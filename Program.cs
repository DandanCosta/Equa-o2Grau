double a, b, c, x1 , x2 , delta;

Console.Write("Insira o coeficiente a: ");
a = double.Parse(Console.ReadLine()!);

Console.Write("Insira o coeficiente b: ");
b = double.Parse(Console.ReadLine()!);

Console.Write("Insira o coeficiente c: ");
c = double.Parse(Console.ReadLine()!);

if (a == 0){
    Console.WriteLine("Os valores tem que ser diferentes de 0 para que seja uma equação de 2º  grau");
}
else{

}
delta = b * b - 4 * a * c;

if (delta < 0){
    Console.WriteLine("Essa equação não possui raizes reais. Ela possui raizes complexas ");
}
else if(delta > 0){
    x1 = (-b + Math.Sqrt(delta) / 2 * a);  
    x2 = (-b - Math.Sqrt(delta) / 2 * a);
    Console.WriteLine($"O valor de x1 é {x1}");
    Console.WriteLine($"O valor de x2 é {x2}");   
}
else if (delta == 0){
    x1 = -b / 2 * a;
    Console.WriteLine($"O valor de x1 é {x1}");
}


