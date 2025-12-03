class Passaro:
  def __init__(self, nome, capacidade_voar):
    self._nome = nome
    self._capacidade_voar = capacidade_voar

    self.__idade = 0
    self.__peso = 0
    self.__vivo = True

  def comer(self, alimento):
    print(f"O passaro {self._nome} está a comer {alimento}.\n")

  def dormir(self):
    print(f"O passaro {self._nome} está a dormir.\n")

  def aprender_a_voar(self):
    if self._capacidade_voar:
      print("Já sei voar.\n")
      return

    self._capacidade_voar = True
    print("Aprendi a voar.")

  def voar(self, local):
    if not self._capacidade_voar:
      print("Não tenho capacidade de voar.\n")
      return

    print(f"Estou a voar para {local}\n.")
