print("---AUTENTICADOR POR PIN---")
systempin = "1234"
pin_user = input("\nInsira o Pin de segurança: ")
if(pin_user == systempin):
  print("\nPIN CORRETO✅\n")
else:
  print("\nPIN INCORRETO⛔\n")



#Uma vez que é pin podiamos ter usado int direto suponho, e faziamos verificaçao depois.