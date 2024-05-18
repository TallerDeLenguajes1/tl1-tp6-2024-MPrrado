
Console.WriteLine("----------INGRESE UNA CADENA DE TEXTO----------");

// string cadena1 = Console.ReadLine(); //para que no aparezca lo de null tenemos que comentar la linea del .proj
string cadena1 = "Hola como estas?";
System.Console.WriteLine(cadena1);
System.Console.WriteLine();
System.Console.WriteLine("La longitud de la cadena1 ingresada es:" + cadena1.Length + "\n"); //cadena1.Length nos devuelve la longitud de la cadena

System.Console.WriteLine("----------Ahora ingrese otra cadena para concatenar con la anterior----------");
System.Console.WriteLine();
// string cadena2 = Console.ReadLine();
string cadena2 = "todo bien?";
// string concatenado1 = string.Concat(cadena1, cadena2);

string concatenadas2 = $"{cadena1} {cadena2}"; //misma forma que la de arriba pero solo que abreviada. Es importante el espacio del medio
System.Console.WriteLine("las cadenas ingresadas concatenadas son: " + concatenadas2 + "\n");

string subcadenaBuscada = "todo";
int indiceInicio = concatenadas2.IndexOf(subcadenaBuscada, 0, concatenadas2.Length); //obtengo el indice del comienzo de la primera ocurrencia de mi subcadena buscada

System.Console.WriteLine("una sub cadena de la cadena ingreseda es:" + concatenadas2.Substring(indiceInicio, subcadenaBuscada.Length)); //cuando muestro por pantalla con el metodo .substring(indiceInicio, subcadenaBuscada.Length) hago que solo se imprima una subcadena de la cadena original hasta determinada longitud de la cadena misma
System.Console.WriteLine();


//FUNCIONES

// static bool operacionCalculadora(bool salir, int opcion)
// {
//     string resultado;
//     switch (opcion)
//     {
//         case 1:
//             resultado = sumar();
//             Console.WriteLine(resultado);
//             break;

//         case 2:
//             resultado = restar();
//             Console.WriteLine(resultado);
//             break;

//         case 3:
//             resultado = multiplicar();
//             Console.WriteLine(resultado);
//             break;

//         case 4:
//             resultado = dividir();
//             Console.WriteLine(resultado);
//             break;

//         case 5:
//             MejorasCalculadora();
//             break;

//         default:
//             Console.WriteLine("saliendo....");
//             salir = false;
//             break;
//     }
//     Console.WriteLine("Desea seguir operando ([s]:'si' [n]:'no'):");
//     string seguir = Console.ReadLine();
//     if (seguir == "N" || seguir == "n")
//     {
//         Console.WriteLine("saliendo....");
//         salir = false;
//     }

//     return salir;
// }

// static string sumar()
// {
//     float suma;
//     Console.WriteLine("Ingrese el primero numero a sumar");
//     float.TryParse(Console.ReadLine(), out float a);
//     Console.WriteLine("Ingrese el segundo numero a sumar");
//     float.TryParse(Console.ReadLine(), out float b);
//     suma = a + b;
//     string resultado = "La suma de " + a + " y de " + b + " es igual a: " + suma;
//     return resultado;
// }

// static string restar()
// {
//     float resta;
//     Console.WriteLine("Ingrese el primero numero a restar");
//     float.TryParse(Console.ReadLine(), out float a);
//     Console.WriteLine("Ingrese el segundo numero a restar");
//     float.TryParse(Console.ReadLine(), out float b);
//     resta = a - b;
//     string resultado = "";
//     return resultado;
// }

// static string multiplicar()
// {
//     float producto;
//     Console.WriteLine("Ingrese el primero numero a multiplicar");
//     float.TryParse(Console.ReadLine(), out float a);
//     Console.WriteLine("Ingrese el segundo numero a multiplicar");
//     float.TryParse(Console.ReadLine(), out float b);
//     producto = a * b;
//     string resultado = "";
//     return resultado;
// }

// static string dividir()
// {
//     float division;
//     Console.WriteLine("Ingrese el dividendo");
//     float.TryParse(Console.ReadLine(), out float a);
//     Console.WriteLine("Ingrese el divisor");
//     float.TryParse(Console.ReadLine(), out float b);
//     division = a / b;
//     string resultado = "";
//     return resultado;
// }

// static void MejorasCalculadora()
// {
//     System.Console.WriteLine("----------Funcion Mejoradas--------\n");
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
// bool salir = true;
// while (salir)
// {
//     Console.WriteLine("--------MENU CALCUADORA V1.0.0-------");
//     Console.WriteLine("1- SUMAR");
//     Console.WriteLine("2- RESTAR");
//     Console.WriteLine("3- MULTIPLICAR");
//     Console.WriteLine("4- DIVIDIR");
//     Console.WriteLine("5- OPERACIONES MEJORADAS");
//     Console.WriteLine("0- SALIR");
//     Console.WriteLine("Ingrese una opcion: ");
//     if (int.TryParse(Console.ReadLine(), out int opcion))
//     {
//         if (opcion > 5 || opcion < 0)
//         {
//             Console.WriteLine("ERROR LA OPCION INGRESADA NO ES VALIDA");
//         }
//         else
//         {
//             salir = operacionCalculadora(salir, opcion);
//         }
//     }
// }

System.Console.WriteLine("a continuacion se imprime la segunda cadena ingresada caracter a caracter:");
foreach (char c in cadena2)
{
    System.Console.WriteLine(c);
}

System.Console.WriteLine("La cadena concatenada en mayusculas es: "+ concatenadas2.ToUpper());
System.Console.WriteLine("La cadena concatenada en minisculas es: "+ concatenadas2.ToLower());