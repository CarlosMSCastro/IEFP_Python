jovens = []
adultos = []
idosos = []

for i in range (10):
  idade = int(input(f"Digite a idade do {i+1}º funcionário: "))
  salario = float(input(f"Digite o salário do {i+1}º funcionário: "))
  if idade <= 23:
    jovens.append(salario)
  elif idade <= 65:
    adultos.append(salario)
  else:
    idosos.append(salario)

print(f"Média de salários dos jovens: {sum(jovens)/len(jovens):.2f} €")
print(f"Média de salários dos adultos: {sum(adultos)/len(adultos):.2f} €")
print(f"Média de salários dos idosos: {sum(idosos)/len(idosos):.2f}: €")
