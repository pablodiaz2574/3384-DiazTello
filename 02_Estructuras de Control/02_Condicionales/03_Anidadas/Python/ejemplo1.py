# Programa para Determinar el Nivel de Capacitación de un Postulante según su Porcentaje de Respuestas Correctas

print("===== CLASIFICACIÓN DEL NIVEL DE CAPACITACIÓN =====")
print()

# Entrada de datos
try:
    total_preguntas = int(input("Ingrese la cantidad total de preguntas realizadas: "))
    correctas = int(input("Ingrese la cantidad de preguntas contestadas correctamente: "))
except ValueError:
    print("Error: Debe ingresar números enteros.")
    exit()

# Validación de datos
if total_preguntas <= 0 or correctas < 0 or correctas > total_preguntas:
    print("Error: Datos inválidos. Asegúrese de ingresar valores correctos.")
    exit()

# Cálculo del porcentaje
porcentaje = (correctas / total_preguntas) * 100

# Determinación del nivel (estructura condicional anidada en cascada)
if porcentaje >= 90.0:
    nivel = "Nivel máximo"
elif porcentaje >= 75.0:
    nivel = "Nivel medio"
elif porcentaje >= 50.0:
    nivel = "Nivel regular"
else:
    nivel = "Fuera de nivel"

# Salida de resultados
print()
print("Resultados:")
print(f"Total de preguntas: {total_preguntas}")
print(f"Respuestas correctas: {correctas}")
print(f"Porcentaje obtenido: {porcentaje:.2f}%")
print(f"Nivel asignado: {nivel}")