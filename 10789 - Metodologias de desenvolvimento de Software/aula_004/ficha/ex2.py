negativos=0
positivos=0
for i in range(20):
  num = int(input(f"Digite o {i+1}º numero: "))
  if num > 0:
    positivos += 1
  elif num < 0:
    negativos += 1

print(f"Negativos: {negativos}")
print(f"Positivos: {positivos}")