# EJERCICIO-4 TP6-TL1-2024

## **¿String es una tipo por valor o un tipo por referencia?**

Un string es un tipo por referencia, es decir que si a una variable del tipo **_string_** es utilizada como parametro en un funcion/metodo todo cambio realizado dentro de la misma se vera reflejado en la variable origin de entrada como paramatro, es decir el valor almacenado en la direccion de memoria a la hora de declarar la variable **_string_** se ve modificado aun cuando se lo trabaja/modifica dentro de un metodo/funcion.

## **¿Qué secuencias de escape tiene el tipo string?**

La secuncias de escape del tipo string es:
**secuncia de escape** **Nombre del caracter** **Codificacion unicode** 
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