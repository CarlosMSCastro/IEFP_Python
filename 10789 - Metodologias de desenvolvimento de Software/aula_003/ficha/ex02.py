temp = float(input("Insira a temperatura em Celsius: "))

if temp < 5:
  print("Muito Frio")
elif temp < 10:
  print("Frio")
elif temp < 20:
  print("Ameno")
elif temp < 30:
  print("Calor")
else:
  print("Muito Calor")