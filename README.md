# Clase06

Consigna

1) Generar un n�mero secreto
aleatorio con la siguiente instruccion:

// Genera un numero entero aleatorio de 1 a 20
int numeroSecreto = new
Random(DateTime.Now.Millisecond).Next(1, 21);

2) Pedir al usuario que ingrese un n�mero y que
intente adivinar el n�mero que eligi� la computadora.

3) Si el numero ingresado por el usuario es mayor
al n�mero secreto, avisarle que es muy grande y que intente de nuevo y que
vuelva al paso 2.

4) Si el numero ingresado es menor al n�mero
secreto, avisarle que es muy chico, y que intente de nuevo volviendo al paso 2.

5) Si el n�mero ingresado coincide con el n�mero
secreto, sacar el siguiente mensaje:

"Felicitaciones, has adivinado el n�mero
secreto que era:  [numeroSecreto]"
"Lo has logrado en [n] intentos!!"

Y finalizar el programa.