# Elaborar un programa que calcule el IMC

# Entrada
peso = float(input("Ingrese su peso (kg): "))
altura = float(input("Ingrese su altura (m): "))

# Proceso
imc = peso / (altura ** 2)

# Salida
if imc > 30:
    print("OBESO")
elif imc >= 25:
    print("Sobrepeso")
elif imc >= 18.5:
    print("Normal")
else:
    print("Bajo peso")

print("Tu IMC es:", imc)