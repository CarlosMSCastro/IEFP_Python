convidados = ["Carlos", "Miguel", "Joana", "Mariana", "Antonio"]

for i in range(3):
  convidado = input(f"Nome do novo {i+1}º convidado: ")
  convidados.append(convidado)

nome = input("Insira o nome a verificar: ")
if nome in convidados:
  print("Convidado na lista.")
else:
  print("Não está na lista.")
