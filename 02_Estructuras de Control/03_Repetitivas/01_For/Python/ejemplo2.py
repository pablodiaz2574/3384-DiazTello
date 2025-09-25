print("  CONTADOR DE NÚMEROS IMPARES Y POSITIVOS")
print()

n = int(input("Ingrese la cantidad de números (n): "))

contador = 0

for i in range(1, n + 1):
    numero = int(input(f"Ingrese el número {i}: "))
    
    # Verificar si es positivo y impar
    if numero > 0 and numero % 2 != 0:
        contador += 1

print()
print("==================================")
print(f"RESULTADO: {contador} número(s) son impares y positivos.")
print("==================================")