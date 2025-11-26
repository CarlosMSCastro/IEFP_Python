from veiculo import *

class Bicicleta(Veiculo):
    def __init__(self, tipo, material, cor, marca):
        super().__init__(cor, marca)
        self.__tipo = tipo
        self.__material = material