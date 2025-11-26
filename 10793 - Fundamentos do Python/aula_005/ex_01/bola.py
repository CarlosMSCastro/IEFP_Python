class ErroPressaoNegativa(Exception):
  ...

class ErroIntervaloInvalido(Exception):
  ...

class ErroForaIntervalo(Exception):
  ...

class ErroPressaoBaixa(Exception):
  ...

class Bola:
  def __init__(self, pressao_min, pressao_max, pressao_atual):
    if pressao_min < 0:
      raise ErroPressaoNegativa("A pressão mínima tem que ser positiva.")

    if pressao_min > pressao_max:
      raise ErroIntervaloInvalido("Pressão mínima tem que ser menor que a máxima.")
    
    if pressao_atual < pressao_min or pressao_atual > pressao_max:
      raise ErroForaIntervalo("Pressão atual está fora dos limites máximo e mínimo.")

    self.__pressao_min = pressao_min
    self.__pressao_max = pressao_max
    self.__pressao_atual = pressao_atual
  
  def saltar(self):
    if self.__pressao_atual < self.__pressao_min:
      raise ErroPressaoBaixa("A Bola está com a pressão muito baixa.")
    
    self.__pressao_atual -= 10    
    print("A saltar!")

try:
  bola_1 = Bola(1,50,20)
  bola_1.saltar()
  bola_1.saltar()
  bola_1.saltar()
except ErroPressaoNegativa as ex:
  print(f"Erro pressão negativa, detalhes: {ex}")
except ErroIntervaloInvalido as ex:
  print(f"Erro pressão invalida perante o intervalo, detalhes: {ex}")
except ErroForaIntervalo as ex:
  print(f"Erro fora do intervalo, detalhes: {ex}")
except ErroPressaoBaixa as ex:
  print(f"A bola não consegue saltar, detalhes: {ex}")
except Exception as ex:
  print(f"Erro inesperado, detalhes: {ex}")