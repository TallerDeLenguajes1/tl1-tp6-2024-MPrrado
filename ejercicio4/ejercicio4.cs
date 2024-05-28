
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
System.Console.WriteLine("Ahora usaremos la calculadora del punto anterior para operar dos numeros ingresados de como string");
System.Console.WriteLine("Ingrese el primer numero para operar");
if (int.TryParse(System.Console.ReadLine(), out int num1))
{
    System.Console.WriteLine("Ingrese el primer numero para operar");
    if (int.TryParse(System.Console.ReadLine(), out int num2))
    {
        Calculadora(num1, num2);
    }
}
System.Console.WriteLine();
System.Console.WriteLine("----------------------------");


//RECORREMOS CON UN BUCLE FOREACH PARA MOSTRAR CARACTER A CARACTER DE LA CADENA CONCATENADA
System.Console.WriteLine("a continuacion se imprime la segunda cadena ingresada caracter a caracter:");
System.Console.WriteLine();
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

//a partir de una ecuacion simple como 543+2 spliteo el string con el operador y sumo sus valores

System.Console.WriteLine("Ingresar una ecuacion simple por ejemplo 321+43");
System.Console.WriteLine();
char[] operadores = { '+', '-', '/', '*' }; //este arreglo de char me permite elegir entre que chars se separara la cadena ingresada
String ecuacion = Console.ReadLine(); //leo la ecuacion simple
string[] arregloOperandos = ecuacion.Split(operadores); //me armo mi arreglo con los operandos de la expresion
int indiceOperador = -1;
int i = 0;
while (indiceOperador == -1)
{
    indiceOperador = ecuacion.IndexOf(operadores[i]);
    if (indiceOperador != -1)
    {
        break;
    }
    else
    {
        i++;
        if (i > ecuacion.Length)
        {
            break;
        }
    }
}
if (indiceOperador == -1)
{
    System.Console.WriteLine("Error la expresion ingresada tiene un operador invalido");

}
else
{
    if (int.TryParse(arregloOperandos[0], out int numeroSplit1))
    {
        if (int.TryParse(arregloOperandos[1], out int numeroSplit2))
        {
            // System.Console.WriteLine($"numero1 = {numeroSplit1}");
            // System.Console.WriteLine($"numero2 = {numeroSplit2}");
            string operador = ecuacion.Substring(indiceOperador, 1);
            switch (operador)
            {
                case "+":
                    string resultado = sumar(numeroSplit1, numeroSplit2);
                    Console.WriteLine(resultado);
                    break;

                case "-":
                    resultado = restar(numeroSplit1, numeroSplit2);
                    Console.WriteLine(resultado);
                    break;

                case "*":
                    resultado = multiplicar(numeroSplit1, numeroSplit2);
                    Console.WriteLine(resultado);
                    break;

                case "/":
                    resultado = dividir(numeroSplit1, numeroSplit2);
                    Console.WriteLine(resultado);
                    break;
            }
        }
        else
        {
            System.Console.WriteLine("El segundo termino de la ecuacion no es un numero valido");
        }
    }
    else
    {
        System.Console.WriteLine("El primer termino de la ecuacion no es un numero valido");
    }
}






//funciones y calculadora
static void Calculadora(int numero1, int numero2)
{
    static bool operacionCalculadora(bool salir, int opcion, int numero1, int numero2)
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

    // NewMethod();

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

static string sumar(int numero1, int numero2)
{
    float suma;
    suma = numero1 + numero2;
    string resultado = "La suma de " + numero1 + " y de " + numero2 + " es igual a: " + suma;
    return resultado;
}

static string restar(int numero1, int numero2)
{
    float resta;
    resta = numero1 - numero2;
    string resultado = "La resta de " + numero1 + " y de " + numero2 + " es igual a: " + resta;
    return resultado;
}

static string multiplicar(int numero1, int numero2)
{
    float producto;
    producto = numero1 * numero2;
    string resultado = "La multiplicacion de " + numero1 + " y de " + numero2 + " es igual a: " + producto;
    return resultado;
}

static string dividir(int numero1, int numero2)
{
    float division;
    division = numero1 / numero2;
    string resultado = "La diviison de " + numero1 + " y de " + numero2 + " es igual a: " + division;
    return resultado;
}
