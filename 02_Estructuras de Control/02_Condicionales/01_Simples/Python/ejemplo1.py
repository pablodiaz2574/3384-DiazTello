# Programa para Determinar el Impuesto a la Renta si Supera 4000 Soles

print("===== Cálculo del Impuesto a la Renta (5%) =====\n")

# Entrada de datos
renta = float(input("Ingrese el monto de la renta: "))
print()

# Proceso + Salida de datos
if renta > 4000:
    impuesto = renta * 0.05
    print("El impuesto a pagar es:", impuesto)

input("\nPresione Enter para salir...")