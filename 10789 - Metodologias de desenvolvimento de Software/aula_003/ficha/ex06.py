casado = input("Casado ? (s/n):").lower() == "s"
salario_minimo = 870

if casado:
  salario_1 = float(input("Insira o seu salário: "))
  salario_2 = float(input("Insira o salário do conjugue: "))
  rendimento = salario_1 + salario_2
else:
  salario_1 = float(input("Insira o seu salário: "))
  rendimento = salario_1

if rendimento < 2*(salario_minimo):
  print("CLASSE E")
elif rendimento < 4*(salario_minimo):
  print("CLASSE D")
elif rendimento < 10*(salario_minimo):
  print("CLASSE C")
elif rendimento < 20*(salario_minimo):
  print("CLASSE B")
else:
  print("CLASSE A")

