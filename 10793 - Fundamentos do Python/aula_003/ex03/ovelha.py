class Ovelha:
  def __init__(self, nome, cor, criador):
    self.nome = nome
    self.idade = 0
    self.cor = cor
    self.criador = criador

  def comer(self, comida):
    self.comida = comida
    print(f"Sou a ovelha {self.nome} e estou a comer {comida}")
    

ovelha_1 = Ovelha("Dolly", "Branca", "Pedro")
ovelha_2 = Ovelha("Sherk", "Castanha", "Fernando")

ovelha_1.comer("Erva")
ovelha_2.comer("Pão")