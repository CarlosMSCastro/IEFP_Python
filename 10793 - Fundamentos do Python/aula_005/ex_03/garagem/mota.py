from veiculo import *

class Mota(Veiculo):
    def __init__(self, peso, cor, marca):
        super().__init__(cor, marca)
        self.__peso = peso

    def receber_combustivel(self, qt):
        self.__peso += 0.01 * qt
        print("Recebi combustível")