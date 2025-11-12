produtos = []
produtos_lactose = ["leite","iogurte","queijo"]
produtos_gluten = ["pao","massa","cerveja"]
lactose = input("É intolerante á lactose?(S/N)").upper()
gluten = input("É intolerante ao glutén?(S/N)").upper()

for i in range (1,11):
  produto = input(f"\nNome do {i}º produto: ").lower()
  produtos.append(produto)
  if lactose == "S" and produto in produtos_lactose:
    produtos.remove(produto)
  if gluten == "S" and produto in produtos_gluten:
    produtos.remove(produto)
  sair = input(f"Adicionar outro produto (S/N)?").upper()
  if sair == "N":
    break

print("\nLista de Produtos")
for i in range(len(produtos)):
  print(f"- {produtos[i]}")
print()


