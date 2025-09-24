# Programa para identificar si un número es par

print("===== Verificación si un número es par =====\n")

# Entrada de datos
numero = int(input("Ingrese un número: "))

# Proceso + Salida de datos
if numero % 2 == 0:
    print("\033[92mEl número es par\033[0m")  # Verde

input("\nPresione Enter para salir...")