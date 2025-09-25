# Programa para Determinar el Estado Académico de un Alumno según su Promedio

print("===== DETERMINACIÓN DEL ESTADO ACADÉMICO DEL ALUMNO =====")
print()

# Entrada de datos
try:
    nota1 = float(input("Ingrese la primera nota: "))
    nota2 = float(input("Ingrese la segunda nota: "))
    nota3 = float(input("Ingrese la tercera nota: "))
except ValueError:
    print("Error: Debe ingresar valores numéricos.")
    exit()

# Proceso: cálculo del promedio
promedio = (nota1 + nota2 + nota3) / 3

# Determinación del estado académico (estructura condicional anidada en cascada)
if promedio >= 10.0:
    estado = "Fuera de rango"
elif promedio >= 7.0:
    estado = "Promocionado"
elif promedio >= 4.0:
    estado = "Regular"
else:
    estado = "Reprobado"

# Salida de resultados
print()
print("Resultados:")
print(f"Nota 1: {nota1}")
print(f"Nota 2: {nota2}")
print(f"Nota 3: {nota3}")
print()
print(f"Promedio: {promedio:.2f}")
print()
print(f"Estado académico: {estado}")