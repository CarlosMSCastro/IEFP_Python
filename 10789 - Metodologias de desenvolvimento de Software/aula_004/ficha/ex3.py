dormir = input("O utilizador já dorme (s/n) ? ").strip().lower() == "s"
carneiros = 0

while dormir is False:
  carneiros += 1
  print(f"Carneiros até ao momento: {carneiros} 🐏\n")
  dormir = input("O utilizador já dorme (s/n) ? ").strip().lower() == "s"
else:
  print("\nTenha Boa Noite!🌙")


