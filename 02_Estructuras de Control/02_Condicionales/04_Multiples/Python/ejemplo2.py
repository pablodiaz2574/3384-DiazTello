# Programa: Mostrar mes y número de días

print("===== Mostrar mes y número de días =====\n")

# Entrada
numero = int(input("Ingrese un número del 1 al 12: "))

# Proceso + Salida
if numero == 1:
    print("Enero - 31 días")
elif numero == 2:
    print("Febrero - 28 días (29 en bisiesto)")
elif numero == 3:
    print("Marzo - 31 días")
elif numero == 4:
    print("Abril - 30 días")
elif numero == 5:
    print("Mayo - 31 días")
elif numero == 6:
    print("Junio - 30 días")
elif numero == 7:
    print("Julio - 31 días")
elif numero == 8:
    print("Agosto - 31 días")
elif numero == 9:
    print("Septiembre - 30 días")
elif numero == 10:
    print("Octubre - 31 días")
elif numero == 11:
    print("Noviembre - 30 días")
elif numero == 12:
    print("Diciembre - 31 días")
else:
    print("Número fuera de rango (1-12)")

input("\nPresione Enter para salir...")