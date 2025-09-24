# Cálculo de Promedio Ponderado

print("=== Cálculo de Promedio Ponderado ===\n")

# Entrada de datos
nota1 = float(input("Ingrese la Nota 1 (20%): "))
nota2 = float(input("Ingrese la Nota 2 (30%): "))
nota3 = float(input("Ingrese la Nota 3 (40%): "))
nota4 = float(input("Ingrese la Nota 4 (10%): "))

# Proceso
promedio_ponderado = (nota1 * 0.20) + (nota2 * 0.30) + (nota3 * 0.40) + (nota4 * 0.10)

# Salida de datos
print(f"\nEl promedio ponderado es: {promedio_ponderado:.2f}")

input("\nPresione Enter para salir...")