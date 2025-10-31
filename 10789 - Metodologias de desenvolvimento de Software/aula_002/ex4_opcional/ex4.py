temp = float(input("Digite a temperatura em Cº: "))
chuva = input("Está a chover? (S/N) ").strip().lower()
vento = input("Está vento forte? (S/N) ").strip().lower()

if 15 <= temp <= 30 and chuva == "n":
  print("Bom dia para correr")
elif chuva == "s" or vento == "s":
  print("Corrida não recomendada")
else:
  print("Corrida Tolerável. Não está a temperatura perfeita.")