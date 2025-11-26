class Livro:
  def __init__(self, titulo, autor, qt_max_pag):
    self.__titulo = titulo
    self.__autor = autor
    self.__qt_max_pag = qt_max_pag
    self.__usado = False
    self.__pag_atual = 0
  
  def folhear(self):
    if self.__pag_atual < self.__qt_max_pag:
      self.__pag_atual += 1
      self.__usado = True
      print(f"Página {self.__pag_atual} de {self.__qt_max_pag}")
    else:
      print("Chegou ao fim do livro.")
  
  def ir_pag_especifica(self, pagina):
    if pagina >= self.__qt_max_pag or pagina < 0:
      ("Impossivel ir para a página pretendida")
    else:
      self.__pag_atual = pagina
      self.__usado = True
      print(f"Foi para a página {self.__pag_atual} de {self.__qt_max_pag}")

  def consultar_dados(self):
    print(f"Nome: {self.__titulo}")
    print(f"Autor: {self.__autor}")

  def fechar_livro(self):
    print("O livro foi fechado.")
    self.__pag_atual = 0


livro1 = Livro("Modern Poker Theory","Michael Acevedo",250)
livro2 = Livro("Jurassic Park","Michael Crichton",250)

livro1.folhear()
livro1.ir_pag_especifica(153)
livro1.folhear()
livro1.consultar_dados()
livro1.fechar_livro()