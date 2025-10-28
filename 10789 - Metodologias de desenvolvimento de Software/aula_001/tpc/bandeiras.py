#bandeiras.py

pais = input("Insira o País que pretende saber as cores da bandeira: ").lower()

if pais == "dinamarca":
  print("Vermelho e Branco")
elif pais == "austria":
  print("Vermelho e Branco")
elif pais == "estonia":
  print("Azul, Preto e Branco")
elif pais == "alemanha":
  print("Preto, Vermelho e Amarelo")
else:
  print(f"Não foi possível reconhecer as cores da bandeira do País em questão ({pais.capitalize()}).")