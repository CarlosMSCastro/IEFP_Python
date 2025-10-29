desejo = input("O que seja hoje? ")

if desejo == "nata" or desejo == "bola" or desejo == "trança":
  quer_canela = input(f"Temos {desejo}. Quer canela (s/n) ?").lower()
  
  if quer_canela == "s" and desejo == "nata":
    print("A servir...")
  elif quer_canela == "s" and desejo == "bola":
    print("Sem jeito nenhum...")
  elif quer_canela == "s" and desejo == "trança":
    print("A servir...")
  else:
    print(f"A servir {desejo} sem canela.")
else:
  print("Não temos essa opção.")

