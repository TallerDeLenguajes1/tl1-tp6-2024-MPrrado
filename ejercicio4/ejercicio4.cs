
using System.Net.WebSockets;

Console.WriteLine("----------INGRESE UNA CADENA DE TEXTO----------");

//INGRESAMOS CADENA Y OBTENEMOS LONGITUD
// string cadena1 = Console.ReadLine(); //para que no aparezca lo de null tenemos que comentar la linea del .proj
string cadena1 = "Hola como estas?";
System.Console.WriteLine(cadena1);
System.Console.WriteLine();
System.Console.WriteLine("La longitud de la cadena1 ingresada es:" + cadena1.Length + "\n"); //cadena1.Length nos devuelve la longitud de la cadena

//INGRESAMOS OTRA CADENA Y CONCATENAMOS A LA PRIMERA
System.Console.WriteLine("----------Ahora ingrese otra cadena para concatenar con la anterior----------");
System.Console.WriteLine();
// string cadena2 = Console.ReadLine();
string cadena2 = "todo bien?todo bien?todo bien?todo bien?";
// string concatenado1 = string.Concat(cadena1, cadena2);
string concatenadas2 = $"{cadena1} {cadena2}"; //misma forma que la de arriba pero solo que abreviada. Es importante el espacio del medio
System.Console.WriteLine("las cadenas ingresadas concatenadas son: " + concatenadas2 + "\n");

//EXTRAEMOS UNA SUBCADENA DE LA CADENA CONCATENADA
string subcadenaBuscada = "todo bien?";
int indiceInicio = concatenadas2.IndexOf(subcadenaBuscada, 0, concatenadas2.Length); //obtengo el indice del comienzo de la primera ocurrencia de mi subcadena buscada
System.Console.WriteLine("una sub cadena de la cadena ingreseda es:" + concatenadas2.Substring(indiceInicio, subcadenaBuscada.Length)); //cuando muestro por pantalla con el metodo .substring(indiceInicio, subcadenaBuscada.Length) hago que solo se imprima una subcadena de la cadena original hasta determinada longitud de la cadena misma
System.Console.WriteLine();

//UTILIZANDO CALCULADORA 

string[] arregloOperandos =  Console.ReadLine().Split("+");
calculadora();


//RECORREMOS CON UN BUCLE FOREACH PARA MOSTRAR CARACTER A CARACTER DE LA CADENA CONCATENADA
System.Console.WriteLine("a continuacion se imprime la segunda cadena ingresada caracter a caracter:");
foreach (char c in cadena2)
{
    System.Console.WriteLine(c);
}

//BUSQUEDA DE OCURRENCIAS DE UNA PALABRA
int inicioPalabra = 0;
int finPalabra = concatenadas2.Length;
int recorrido;
string palabraBuscada = "todo";
int contador = 0;
int indiceOcurrencia = 0;
while (indiceOcurrencia != -1)
{

    recorrido = finPalabra - inicioPalabra;
    indiceOcurrencia = concatenadas2.IndexOf(palabraBuscada, inicioPalabra, recorrido);//busco el indice de la primera letra de la primera ocurrencia partiendo desde el primer caracter de la cadena de caracteres
    if (indiceOcurrencia == -1) break;
    contador = contador + 1;
    inicioPalabra = indiceOcurrencia + 1;
}


System.Console.WriteLine("El numero de ocurrencias de la palabra {0} es: {1}", palabraBuscada, contador);
System.Console.WriteLine();

//MAYUSCULAS Y MINUSCULAS
System.Console.WriteLine("La cadena concatenada en mayusculas es: " + concatenadas2.ToUpper());
System.Console.WriteLine("La cadena concatenada en minisculas es: " + concatenadas2.ToLower());

//ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados
System.Console.WriteLine("------------------------------");
System.Console.WriteLine("INGRESE UNA CADENA SEPARADA POR ALGUN CARACTER: ");
string cadenaSeparada = Console.ReadLine();
System.Console.WriteLine("La cadena ingresada es: " + cadenaSeparada);
string[] cadenaSeparadaArray = cadenaSeparada.Split('?');
System.Console.WriteLine("La cadena ingresada separada por el caracter ? es: ");
foreach (string palabra in cadenaSeparadaArray)
{
    System.Console.WriteLine(palabra);
}
System.Console.WriteLine("------------------------------");







static void calculadora(int numero1, int numero2)
{
    static bool operacionCalculadora(bool salir, int opcion,int numero1, int numero2)
    {
        string resultado;
        switch (opcion)
        {
            case 1:
                resultado = sumar(numero1, numero2);
                Console.WriteLine(resultado);
                break;

            case 2:
                resultado = restar(numero1, numero2);
                Console.WriteLine(resultado);
                break;

            case 3:
                resultado = multiplicar(numero1, numero2);
                Console.WriteLine(resultado);
                break;

            case 4:
                resultado = dividir(numero1, numero2);
                Console.WriteLine(resultado);
                break;

            // case 5:
            //     MejorasCalculadora();
            //     break;

            default:
                Console.WriteLine("saliendo....");
                salir = false;
                break;
        }
        return salir;
    }

    static string sumar(int numero1, int numero2)
    {
        float suma;
        suma = numero1 + numero2;
        string resultado = "La suma de " + numero1 + " y de " +  numero2 + " es igual a: " + suma;
        return resultado;
    }

    static string restar(int numero1, int numero2)
    {
        float resta;
        resta = numero1 + numero2;
        string resultado = "La suma de " + numero1 + " y de " +  numero2 + " es igual a: " + resta;
        return resultado;
    }

    static string multiplicar(int numero1, int numero2)
    {
        float producto;
        producto = numero1 + numero2;
        string resultado = "La suma de " + numero1 + " y de " +  numero2 + " es igual a: " + producto;
        return resultado;
    }

    static string dividir(int numero1, int numero2)
    {
        float division;
        division = numero1 + numero2;
        string resultado = "La suma de " + numero1 + " y de " +  numero2 + " es igual a: " + division;
        return resultado;
    }

    
    // static void MejorasCalculadora()
    // {    //     System.Console.WriteLine("----------Funcion Mejoradas--------\n");
    //     Console.WriteLine("Ingrese un numero: ");
    //     if (float.TryParse(Console.ReadLine(), out float num))
    //     {
    //         Console.WriteLine("---El valor absoluto del numero es:" + Math.Abs(num));
    //         float cuadrado = (float)Math.Pow(num, 2);
    //         Console.WriteLine("---El cuadrado del numero es:" + Math.Round(cuadrado, 2));
    //         if (num < 0)
    //         {
    //             Console.WriteLine("---No se puede calcular la raiz cuadrada del numero");
    //         }
    //         else
    //         {
    //             float raiz = (float)Math.Sqrt(num);
    //             Console.WriteLine("---La raiz cuadrada del numero es:" + Math.Round(raiz, 2));
    //         }
    //         float seno = (float)Math.Sin(num);
    //         float coseno = (float)Math.Cos(num);
    //         Console.WriteLine("---El seno del numero es:" + Math.Round(seno, 2));
    //         Console.WriteLine("---El coseno del numero es:" + Math.Round(coseno, 2));
    //         Console.WriteLine("---La parte entera del numero es:" + Math.Truncate(num));
    //         Console.WriteLine("------Calculo de maximo y minimo entre dos numeros------");
    //         Console.WriteLine("Ingrese el primer numero: ");
    //         if (float.TryParse(Console.ReadLine(), out float num1))
    //         {
    //             Console.WriteLine("Ingrese el segundo numero: ");
    //             if (float.TryParse(Console.ReadLine(), out float num2))
    //             {
    //                 Console.WriteLine("---El maximo entre los dos numeros es:" + Math.Max(num1, num2));
    //                 Console.WriteLine("---El minimo entre los dos numeros es:" + Math.Min(num1, num2));
    //             }
    //             else
    //             {
    //                 Console.WriteLine("ERROR EL SEGUNDO NUMERO NO ES VALIDO");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("ERROR EL PRIMER NUMERO NO ES VALIDO");
    //         }

    //     }
    //     else
    //     {
    //         Console.WriteLine("ERROR EL DATO DE ENTRADA TIENE QUE SER UN NUMERO VALIDO");
    //     }

    // }
    bool salir = true;

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
            salir = operacionCalculadora(salir, opcion, numero1, numero2);
        }
    }
}
