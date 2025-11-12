# EXERCÍCIO 1

frutas = []
num = int(input("Número de Frutas: "))

if num >= 1 and num <= 10:
    for x in range(1, num + 1):
        nome_fruta = input(f"Insira a {x}ª fruta: ")
        frutas.append(nome_fruta)
    fruta = input("Nome da fruta a contabilizar: ")
    cont_fruta = 0
    for x in range(num):
        if fruta == frutas[x]:
            cont_fruta += 1
    print(f"Quantidade: {cont_fruta}")
else: 
    print("Número de frutas fora dos limites!")
	
# EXERCÍCIO 2
lista_produtos = []

for x in range(10):
    produto = input("Digite o nome do produto que quer adicionar ao cesto, ou escreva Sair:\n").title()

    if produto == "Sair":
        break

    lista_produtos.append(produto)

gluten = input("É intolerante a gluten?\n").title()
if gluten == "Sim":
    for produto_gluten in reversed (lista_produtos):
        if produto_gluten in ("Pão", "Massa", "Cerveja"):
            lista_produtos.remove(produto_gluten)

gluten = input("É intolerante a lactose?\n").title()
if gluten == "Sim":
    for produto_lactose in reversed (lista_produtos):
        if produto_lactose in ("Leite", "Iogurte", "Queijo"):
            lista_produtos.remove(produto_lactose)

for seleciona_produto in lista_produtos:
    print(seleciona_produto)
	
# EXERCÍCIO 3

lista_convidados = ["Joaquim", "Helena", "Maria", "João", "Joana", "António", "Antónia"]

verificar = input("Insira o nome do convidado a verificar:")
presenca = False

for nome in lista_convidados:
    if verificar == nome:
        pertence = True
        break

if presenca:
    print("Está na lista dos convidados.")
else:
    print("Não está na lista dos convidados.")
   
# Exercício 4

numeros = [10, 12, 16, 9, 8]

while (len(numeros) != 0):
    numero_uti = int(input("Indique um número: "))
    for numero in numeros:
        if numero_uti == numero:
            print("Acertou!!")
            numeros.remove(numero)

print("BINGO!!!")
