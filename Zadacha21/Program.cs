// Напишите программу, которая принимает на вход координаты
//  двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Введите координату X1: ");
    double x1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите координату Y1: ");
    double y1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите координату Z1: ");
    double z1 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите координату X2: ");
    double x2 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите координату Y2: ");
    double y2 = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите координату Z2: ");
    double z2 = int.Parse(Console.ReadLine());

        double resalt = Math.Sqrt((x2 - x1) * (x2-x1) + (y2-y1)*(y2-y1) + (z2 - z1) * (z2 - z1));

        System.Console.WriteLine($"Растояние между точками ({x1}, {y1}) и ({x2}, {y2}) состовляет: {resalt}");
