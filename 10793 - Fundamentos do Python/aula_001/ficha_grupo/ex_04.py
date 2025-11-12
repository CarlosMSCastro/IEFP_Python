cartao = [11, 17, 75, 44, 68]
hits = []
print("--- Bingo ---")
while len(hits) < len(cartao):
  num = int(input("Numéro que saiu: "))
  if num in cartao:
    hits.append(num)
    print("Acertou!")
  
print("BINGOOO!!")
