convidados = ["Cristiano", "Ruben", "Pedro", "Bernardo", "Diogo"]


print("---Bem-Vindo---")
nome = input("Insira o seu nome: ").capitalize()
if nome in convidados:
  print(f"O seu nome está na lista {nome}, parabéns!")
else:
  print("Não está na lista de presenças.")

