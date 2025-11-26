class Pirilampo:
  def __init__(self, nome, cor):
    self.nome = nome
    self.idade = 0
    self.tamanho = 0
    self.cor = cor.capitalize()
    self.brilho = 0

  def alterar_cor(self, nova_cor):
    if nova_cor == self.cor:
      print("Já tenho essa cor!")
      return
    if nova_cor.capitalize() not in ("Amarelo", "Verde", "Vermelho"):
      print("Cor não permitida")
      return
    
    print(f"Antes, a cor era {self.cor}, e agora é {nova_cor.capitalize()} ")
    self.cor = nova_cor.capitalize()

  def alterar_intensidade(self, nova_intensidade):
    if nova_intensidade not in range(0,101):
      print("Intensidade Inválida.")
      return
    
    self.brilho = nova_intensidade
    print(f"Intensidade alterada para {nova_intensidade}.")

pirilampo_luciferino = Pirilampo("Luciferino", "Verde")
pirilampo_vivido = Pirilampo("Vivido", "Amarelo")

pirilampo_luciferino.alterar_cor("Amarelo")
pirilampo_luciferino.alterar_cor("VERMELHO")
pirilampo_luciferino.alterar_cor("AZUL")
pirilampo_luciferino.alterar_cor("AmarelO")
