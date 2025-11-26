class Veiculo:
    def __init__(self, cor, marca):
        self.__cor = cor
        self.__marca = marca
        self.__mudanca = 1

    def andar(self, km):
        print(f"Percorri {km} km")

    def travar(self):
        print("XIIIIIIIIIIIIIIIIIIIIHHHH")

    def alterar_mudanca(self, mudanca):
        print(f"Alterei para a mudança {mudanca}")
        self.__mudanca = mudanca