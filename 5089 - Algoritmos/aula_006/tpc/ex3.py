print("--- Calculadora de Troco ---")
preco = float(input("Insira o preco do produto: "))
numerario = int(input("Insira o valor entregue em numerario: "))
troco = numerario - preco
print(f"\nTem que dar de troco o valor de {troco:.2f}!")
