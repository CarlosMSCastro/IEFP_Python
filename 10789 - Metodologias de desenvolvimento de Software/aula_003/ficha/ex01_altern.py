
for _ in range(9999999):
  numref = 0
  total_nums = 0

  for total_nums in range(1, 9):
    num = int(input(f"Insira o {total_nums}º numero: "))
    
    if total_nums == 1:
      numref = num
      continue

    if numref != num:
      if total_nums > 2:
        print(f"Existe {total_nums} numeros repetidos")
      else:
        print("Não existem números repetidos.")

      break

  if total_nums == 8:
    print("Todos os números são iguais.")  