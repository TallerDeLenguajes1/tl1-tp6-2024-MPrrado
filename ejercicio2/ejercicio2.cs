//EJERCICIO 2 CALCULADORAV1

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

bool salir = true;
while (salir)
{
    Console.WriteLine("--------MENU CALCUADORA V1.0.0-------");
    Console.WriteLine("1- SUMAR");
    Console.WriteLine("2- RESTAR");
    Console.WriteLine("3- MULTIPLICAR");
    Console.WriteLine("4- DIVIDIR");
    Console.WriteLine("0- SALIR");
    Console.WriteLine("Ingrese una opcion: ");
    if (int.TryParse(Console.ReadLine(), out int opcion))
    {
        if (opcion > 4 || opcion < 0)
        {
            Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
        }
        else
        {
            salir = operacionCalculadora(salir, opcion);
        }
    }
}


