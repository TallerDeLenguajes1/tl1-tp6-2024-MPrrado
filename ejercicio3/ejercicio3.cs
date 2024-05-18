//EJERCICIO 3 CALCULADORAV2

//FUNCIONES

static bool operacionCalculadora(bool salir, int opcion)
{
    float resultado;
    switch (opcion)
    {
        case 1:
            resultado = sumar();
            Console.WriteLine("El resultado de la suma es: " + resultado + "\n");
            break;

        case 2:
            resultado = restar();
            Console.WriteLine("El resultado de la resta es: " + resultado + "\n");
            break;

        case 3:
            resultado = multiplicar();
            Console.WriteLine("El resultado del producto es: " + resultado + "\n");
            break;

        case 4:
            resultado = dividir();
            Console.WriteLine("El resultado de la division es: " + resultado + "\n");
            break;

        case 5:
            MejorasCalculadora();
            break;

        default:
            Console.WriteLine("saliendo....");
            salir = false;
            break;
    }
    Console.WriteLine("Desea seguir operando ([s]:'si' [n]:'no'):");
    if (Console.ReadLine() == "n")
    {
        Console.WriteLine("saliendo....");
        salir = false;
    }

    return salir;
}


static float sumar()
{
    float suma;
    Console.WriteLine("Ingrese el primero numero a sumar");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("Ingrese el segundo numero a sumar");
    float.TryParse(Console.ReadLine(), out float b);
    suma = a + b;
    return suma;
}

static float restar()
{
    float resta;
    Console.WriteLine("Ingrese el primero numero a restar");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("Ingrese el segundo numero a restar");
    float.TryParse(Console.ReadLine(), out float b);
    resta = a - b;
    return resta;
}

static float multiplicar()
{
    float producto;
    Console.WriteLine("Ingrese el primero numero a multiplicar");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("Ingrese el segundo numero a multiplicar");
    float.TryParse(Console.ReadLine(), out float b);
    producto = a * b;
    return producto;
}

static float dividir()
{
    float division;
    Console.WriteLine("Ingrese el dividendo");
    float.TryParse(Console.ReadLine(), out float a);
    Console.WriteLine("Ingrese el divisor");
    float.TryParse(Console.ReadLine(), out float b);
    division = a / b;
    return division;
}

static void MejorasCalculadora()
{
    System.Console.WriteLine("----------Funcion Mejoradas--------\n");
    Console.WriteLine("Ingrese un numero: ");
    if (float.TryParse(Console.ReadLine(), out float num))
    {
        Console.WriteLine("---El valor absoluto del numero es:" + Math.Abs(num));
        float cuadrado = (float)Math.Pow(num, 2);
        Console.WriteLine("---El cuadrado del numero es:" + Math.Round(cuadrado, 2));
        if (num < 0)
        {
            Console.WriteLine("---No se puede calcular la raiz cuadrada del numero");
        }
        else
        {
            float raiz = (float)Math.Sqrt(num);
            Console.WriteLine("---La raiz cuadrada del numero es:" + Math.Round(raiz, 2));
        }
        float seno = (float)Math.Sin(num);
        float coseno = (float)Math.Cos(num);
        Console.WriteLine("---El seno del numero es:" + Math.Round(seno, 2));
        Console.WriteLine("---El coseno del numero es:" + Math.Round(coseno, 2));
        Console.WriteLine("---La parte entera del numero es:" + Math.Truncate(num));
        Console.WriteLine("------Calculo de maximo y minimo entre dos numeros------");
        Console.WriteLine("Ingrese el primer numero: ");
        if (float.TryParse(Console.ReadLine(), out float num1))
        {
            Console.WriteLine("Ingrese el segundo numero: ");
            if (float.TryParse(Console.ReadLine(), out float num2))
            {
                Console.WriteLine("---El maximo entre los dos numeros es:" + Math.Max(num1, num2));
                Console.WriteLine("---El minimo entre los dos numeros es:" + Math.Min(num1, num2));
            }
            else
            {
                Console.WriteLine("ERROR EL SEGUNDO NUMERO NO ES VALIDO");
            }
        }
        else
        {
            Console.WriteLine("ERROR EL PRIMER NUMERO NO ES VALIDO");
        }

    }
    else
    {
        Console.WriteLine("ERROR EL DATO DE ENTRADA TIENE QUE SER UN NUMERO VALIDO");
    }

}
bool salir = true;
while (salir)
{
    Console.WriteLine("--------MENU CALCUADORA V1.0.0-------");
    Console.WriteLine("1- SUMAR");
    Console.WriteLine("2- RESTAR");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    Console.WriteLine("5- OPERACIONES MEJORADAS");
    Console.WriteLine("0- SALIR");
    Console.WriteLine("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion > 5 || opcion < 0)
        {
            Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
        }
        else
        {
            salir = operacionCalculadora(salir, opcion);
        }
    }
}


