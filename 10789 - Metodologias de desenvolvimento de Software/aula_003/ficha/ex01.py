
nums = []
repetidos = 0

for i in range (1, 9):
  numero = int(input(f"Insira o {i}º número: "))
  if numero in nums:
    repetidos += 1
  nums.append(numero)
  
if repetidos == 0:
  print("Não existem números repetidos.")
else:
  print(f"Existem {repetidos} números repetidos.")