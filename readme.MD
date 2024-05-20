# EJERCICIO-4 TP6-TL1-2024

## **¿String es una tipo por valor o un tipo por referencia?**

Un string es un tipo por referencia, es decir que si a una variable del tipo **_string_** es utilizada como parametro en un funcion/metodo todo cambio realizado dentro de la misma se vera reflejado en la variable origin de entrada como paramatro, es decir el valor almacenado en la direccion de memoria a la hora de declarar la variable **_string_** se ve modificado aun cuando se lo trabaja/modifica dentro de un metodo/funcion.

## **¿Qué secuencias de escape tiene el tipo string?**

La secuncias de escape del tipo string es:

1. \'	Comilla simple	0x0027
2. \"	Comilla doble	0x0022
3. \	Barra diagonal inversa	0x005C
4. \0	Null	0x0000
5. \a	Alerta	0x0007
6. \b	Retroceso	0x0008
7. \f	Avance de página	0x000C
8. \n	Nueva línea	0x000A
9. \r	Retorno de carro	0x000D
10. \t	Tabulación horizontal	0x0009
11. \v	Tabulación vertical	0x000B
12. \u	Secuencia de escape Unicode (UTF-16)	\uHHHH (intervalo: 0000 - FFFF ejemplo: \u00E7 = "ç")
13. \U	Secuencia de escape Unicode (UTF-32)	\U00HHHHHH (intervalo: 000000 - 10FFFF; ejemplo: \U0001F47D = "👽")
14. \x	Secuencia de escape Unicode similar a "\u" excepto con longitud variable	\xH[H][H][H] (intervalo: 0 - FFFF; ejemplo: \x00E7 o \x0E7 o \xE7 = "ç")

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

El carácter **_$_** identifica un literal de cadena como una cadena interpolada. Una cadena interpolada es un literal de cadena que puede contener expresiones de interpolación. Cuando una cadena interpolada se resuelve en una cadena de resultado, los elementos con expresiones de interpolación se reemplazan por las representaciones de cadena de los resultados de la expresión. Por ejemplo:

    Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

La interpolación de cadenas proporciona una sintaxis más legible y conveniente de dar formato a las cadenas. Es más fácil de leer que el formato compuesto de cadenas.

El carácter especial **_@_** actúa como un identificador textual. Se usa de distintas formas, ahora solo desarrollaremos un caso:
Para indicar que un literal de cadena se debe interpretar literalmente. El carácter @ de esta instancia define un literal de cadena textual. Las secuencias de escape sencillas (como "\\", que es una barra diagonal inversa), las secuencias de escape hexadecimales (como "\x0041", que es una A mayúscula) y las secuencias de escape Unicode (como "\u0041" que es una A mayúscula) se interpretan literalmente. Solo las secuencias de escape de comillas ("") no se interpretan literalmente, sino que generan comillas dobles. De igual modo, en el caso de una cadena interpolada literal, las secuencias de escape de llave ({{ y }}) no se interpretan literalmente, sino que generan caracteres de llave simple. En el siguiente ejemplo se definen dos rutas de archivo idénticas, una mediante un literal de cadena normal y otra mediante el uso de un literal de cadena textual. Este es uno de los usos más comunes de los literales de cadena textual.

    string s1 = "He said, \"This is the last \u0063hance\x0021\"";
    string s2 = @"He said, ""This is the last \u0063hance\x0021""";
    Console.WriteLine(s1);
    Console.WriteLine(s2);
    // The example displays the following output:
    //     He said, "This is the last chance!"
    //     He said, "This is the last \u0063hance\x0021"








