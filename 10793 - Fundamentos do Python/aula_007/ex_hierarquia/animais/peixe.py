class Peixe:
  def __init__(self, nome, sobrevive_fora, tipo_agua):
    self._nome = nome
    self._sobrevive_fora = sobrevive_fora
    self._tipo_agua = tipo_agua 

    self.__idade = 0
    self.__peso = 0
    self.__vivo = True

    self._esta_na_agua = True 

  def comer(self, alimento):
    print(f"O peixe {self._nome} está a comer {alimento}.")

  def dormir(self):
    print(f"O peixe {self._nome} está a dormir.")
