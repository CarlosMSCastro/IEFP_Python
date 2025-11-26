class ErroPressaoNegativa(Exception): ...
class ErroIntervaloInvalido(Exception): ...
class ErroForaIntervalo(Exception): ...
class ErroPressaoBaixa(Exception): ...
class ErroBolaPorInicializar(Exception): ...

class Bola:
    def __init__(self, marca):
        self.__initialized = False

        self.__marca = marca
        self.__pressao_min = None
        self.__pressao_max = None
        self.__pressao_atual = None

    def init(self, pressao_min, pressao_max, pressao_atual):
        if pressao_min < 0:
            raise ErroPressaoNegativa("A pressão mínima tem que ser positiva.")

        if pressao_min > pressao_max:
            raise ErroIntervaloInvalido("Pressão mínima tem que ser menor que a máxima.")

        if pressao_atual < pressao_min or pressao_atual > pressao_max:
            raise ErroForaIntervalo("Pressão atual está fora dos limites máximo e mínimo.")

        self.__initialized = True
        self.__pressao_min = pressao_min
        self.__pressao_max = pressao_max
        self.__pressao_atual = pressao_atual

    def saltar(self):
        if not self.__initialized:
            raise ErroBolaPorInicializar("É necessário incializar a classe!!!")

        if self.__pressao_atual < self.__pressao_min:
            raise ErroPressaoBaixa("A Bola está com a pressão muito baixa.")

        self.__pressao_atual -= 10
        print("A saltar!")