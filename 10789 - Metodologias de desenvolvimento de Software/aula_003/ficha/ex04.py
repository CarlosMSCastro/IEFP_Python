planetas = ["Mercurio","Venus","Terra","Marte","Jupiter","Saturno","Urano","Neptuno"]
planeta = input("Insira o Planeta: ").strip().capitalize()

for i in range(len(planetas)):
  if planetas[i] == planeta:
    if i == 0:
      print(f"Planeta seguinte: {planetas[i+1]}")
    elif i == 7:
      print(f"Planeta anterior: {planetas[i-1]}")
    else:
      print(f"Planeta anterior: {planetas[i-1]}")
      print(f"Planeta seguinte: {planetas[i+1]}")
      
  
