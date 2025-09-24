import math

# Cálculo de la Hipotenusa de un Triángulo Rectángulo

print("===== Cálculo de la Hipotenusa de un Triángulo Rectángulo =====\n")

# Entrada de datos
cateto1 = float(input("Ingrese el valor del cateto 1: "))
cateto2 = float(input("Ingrese el valor del cateto 2: "))

# Proceso
hipotenusa = math.sqrt(cateto1 ** 2 + cateto2 ** 2)

# Salida de datos
print("\nLa hipotenusa del triángulo rectángulo es: ")
print(f"{hipotenusa:.2f} unidades")

input("\nPresione Enter para salir...")