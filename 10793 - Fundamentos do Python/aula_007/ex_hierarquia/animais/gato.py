class Gato:
  def __init__(self, nome, pelagem):
    self._nome = nome
    self._pelagem = pelagem

    self.__idade = 0
    self.__peso = 0
    self.__vivo = True

  def comer(self, alimento):
    print(f"O gato {self._nome} está a comer {alimento}.\n")

  def dormir(self):
    print(f"O gato {self._nome} está a dormir.\n")

  def ronronar(self):
    print(f"O gato {self._nome} está a ronronar.\n")
