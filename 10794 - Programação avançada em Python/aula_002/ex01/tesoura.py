class Tesoura:
    def __init__(self, cor):
        self.cor = cor
        self.usos = 100

    def cortar(self, material):
        gasto = 0
        match(material.lower()):
            case "papel":
                gasto = 1
            case "plastico" | "plástico":
                gasto = 20
            case "metal":
                gasto = 70
            case _:
                print(f"Erro: o material '{material}' é desconhecido")
                return
        
        if self.usos < gasto:
            print(f"A tesoura não tem capacidade para cortar o material '{material}'")
            return

        self.usos -= gasto
        print(f"Corte realiado com sucesso!")
        self.mostrar_usos()

    def cortar_2(self, material):
        usos = self.usos
        if usos > 0:
            if material == "papel" and usos >= 1:
                self.usos -= 1
            elif (material == "plastico" or material == "plástico") and usos >= 20:
                self.usos -= 20
            elif material ==  "metal" and usos >= 70:
                self.usos -= 70
            else:
                print(f"Erro: o material '{material}' é desconhecido")
            
            print(f"Corte realiado com sucesso!\nRestam {self.usos} usos")
        else:
            print(f"A tesoura não tem capacidade para cortar o material '{material}'")

    def cortar_3(self, material):
        usos = self.usos

        if usos <= 0:
            print(f"A tesoura não tem capacidade para cortar o material '{material}'")
            return
        
        if material not in ("papel", "plastico", "metal"):
            print(f"Erro: o material '{material}' é desconhecido")
            return
        
        if material == "papel" and usos >= 1:
            self.usos -= 1
        elif material == "plastico" and usos >= 20:
            self.usos -= 20
        elif usos >= 70:
            self.usos -= 70

        print(f"Corte realiado com sucesso!\nRestam {self.usos} usos")

    def mostrar_usos(self):
        print(f"Restam {self.usos} usos")

tesoura = Tesoura("amarela")
tesoura.cortar("Parede")
tesoura.cortar("papel")
tesoura.cortar("plastico")
tesoura.cortar("ar")
tesoura.cortar("metal")
tesoura.cortar("metal")