class Caneta:
    def __init__(self, marca, cor):
        self.__usos = 0
        self.__tinta = 100
        self.__marca = marca
        self.__cor = cor

caneta1 = Caneta("Uniball", "Preto")
caneta2 = Caneta("BIC", "Azul")

print(caneta1.__cor)

