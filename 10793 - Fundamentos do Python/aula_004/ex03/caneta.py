class Caneta:
    def __init__(self, marca, cor):
        self.__usos = 0
        self.__tinta = 100
        self.__marca = marca
        self.__cor = cor

    def set_cor(self, cor):
        self.__cor = cor

    def get_cor(self):
        return self.__cor
        
    def get_marca(self):
        return self.__marca
        
caneta1 = Caneta("Uniball", "Preto")
caneta1 = Caneta("BIC", "Azul")
caneta1.set_cor("Vermelho")

print(f"A cor da caneta é {caneta1.get_cor()} e a marca é {caneta1.get_marca()}")

