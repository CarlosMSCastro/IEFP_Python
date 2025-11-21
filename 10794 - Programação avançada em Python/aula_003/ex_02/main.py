from bola import *

bola_1 = Bola("Adidas")

try:
    bola_1.init(1, 50, 200)
except ErroPressaoNegativa as ex:
    print(f"Erro pressão negativa, detalhes: {ex}")
except ErroIntervaloInvalido as ex:
    print(f"Erro pressão invalida perante o intervalo, detalhes: {ex}")
except ErroForaIntervalo as ex:
    print(f"Erro fora do intervalo, detalhes: {ex}")
except Exception as ex:
    print(f"Erro inesperado, detalhes: {ex}")

try:
    bola_1.saltar()
    bola_1.saltar()
    bola_1.saltar()
except ErroPressaoBaixa as ex:
    print(f"A bola não consegue saltar, detalhes: {ex}")
except Exception as ex:
    print(f"Erro inesperado, detalhes: {ex}")