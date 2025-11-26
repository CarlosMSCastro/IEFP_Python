class Mola:
    def __init__(self, ext_max):
        self.__ext_max = ext_max
        self.__ext_atual = ext_max / 2

    @property
    def ext_atual(self):
        return self.__ext_atual

    @ext_atual.setter
    def ext_atual(self, ext):
        if ext < 0:
            self.__ext_atual = 0
        elif ext > self.__ext_max:
            self.__ext_atual = self.__ext_max
        else:
            self.__ext_atual  = ext

mola_1 = Mola(100)

mola_1.ext_atual = -5
print(mola_1.ext_atual)

mola_1.ext_atual = 1000
print(mola_1.ext_atual)

mola_1.ext_atual = 70
print(mola_1.ext_atual)

