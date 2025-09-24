# Programa para determinar si un número es impar y múltiplo de 5

print("===== Cálculo de un número si es impar y múltiplo de 5 =====\n")

# Entrada
numero = int(input("Ingrese un número: "))

# Proceso + Salida
if numero % 2 != 0 and numero % 5 == 0:
    print("El número es impar y múltiplo de 5.")
else:
    print("El número NO es impar y múltiplo de 5.")

input("\nPresione Enter para salir...")