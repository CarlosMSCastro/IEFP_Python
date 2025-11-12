frutas = []

for i in range (1,11):
  fruta = input(f"Insira a {i}ª fruta nova: ")
  quantidade = int(input("Quantidade da fruta nova: "))
  frutas.append({
                "nome": fruta,
                "quantidade": quantidade
                }
              )
  sair = input(f"Quer inserir outra fruta ?(S/N)").upper()
  if sair == "N":
    break

print("\nLista de Frutas")
for i in range(len(frutas)):
  print(f"- {frutas[i]["nome"]} - {frutas[i]["quantidade"]}")


