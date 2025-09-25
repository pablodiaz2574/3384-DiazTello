print("Ingrese la cantidad de alumnos: ")
n = int(input())
print()

menor12 = 0
mayor = 0
menor = 0

print("Ingrese la nota del alumno 1:")
nota = int(input())

mayor = nota
menor = nota

for i in range(2, n + 1):
    print(f"Ingrese la nota del alumno {i}")
    nota = int(input())

    if nota < 12:
        menor12 += 1
    if nota > mayor:
        mayor = nota
    if nota < menor:
        menor = nota

print()
print("===== RESULTADOS =====")
print()
print(f"Cantidad de alumnos con notas menor a 12: {menor12}")
print(f"Nota mayor: {mayor}")
print(f"Nota menor: {menor}")