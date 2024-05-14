// See https://aka.ms/new-console-template for more information
// Console.Write("Hello, World!");

static int invertirNumero(int numero)
{
    int aux;
    int numeroInvertido=0;
    while(numero != 0)
    {
        aux = numero % 10;
        numeroInvertido = (numeroInvertido * 10) + aux;
        numero = numero / 10; 
    }
    return numeroInvertido;
}
Console.WriteLine("Ingrese el numero que desea invertir");
string n=Console.ReadLine();
int numero;
if(int.TryParse(n, out numero))
{  
    if(numero > 0)
    {
        int numeroInvertido = invertirNumero(numero);
        Console.WriteLine("El numero invertido es: "+ numeroInvertido);
    }else
    {
        Console.WriteLine("ERROR EL NUMERO INGRESADO NO ES MAYOR A 0");
    }
    
}else
{
    Console.WriteLine("ERROR EL VALOR INGRESADO NO ES UN NUMERO");
}