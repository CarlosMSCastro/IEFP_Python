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
    print(f"O peixe {self._nome} está a comer {alimento}.\n")

  def dormir(self):
    print(f"O peixe {self._nome} está a dormir.\n")

  def nadar(self, agua):
    if agua not in ("doce", "salgada", "ambas"):
      print("Tipo de água inválido.\n")
      return
    
    if self._tipo_agua != "ambas" and agua != self._tipo_agua:
      print("Não posso nadar nesta água.\n")
      return
    
    print(f"Estou a nadar em água {agua}.\n")
  
  def sair_da_agua(self):
    if not self._esta_na_agua:
      print("Já estou fora de água.\n")
      return
  
    if not self._sobrevive_fora:
      self.__vivo = False
      print("Não devia ter saído da água. Morri.\n")
      return
    
    self._esta_na_agua = False
    print("Saí da água.\n")