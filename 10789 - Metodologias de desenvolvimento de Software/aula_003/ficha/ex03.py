nota = float(input("Insira a nota da prova: "))

while nota < 0 or nota > 20:
  print("Valor de Nota inválido.\n")
  nota = float(input("Insira novamente a nota da prova: "))
else:
  if nota < 9.5:
    print("\nNão-satisfaz")
  elif nota < 15:
    print("\nSatisfaz")
  elif nota < 20:
    print("\nSatisfaz-muito")
  elif nota == 20:
    print("\nExcelente")

