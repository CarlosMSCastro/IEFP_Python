import pygame

pygame.init()

class window:
  WIDTH = 854
  HEIGHT = 500
  TITLE = "Exercicio Pai Natal"
  FPS = 60


class font:
  ROBOTO_20 = pygame.font.Font("10794 - Programação avançada em Python/aula_001/ex_04/fonts/Roboto-Regular.ttf", 20)

class skin:
  PAI_NATAL = pygame.image.load("10794 - Programação avançada em Python/aula_002/ex_02/imgs/pai_natal.png")
  BACKGROUND = pygame.image.load("10794 - Programação avançada em Python/aula_002/ex_02/imgs/background.png")
  GIFT = pygame.image.load("10794 - Programação avançada em Python/aula_002/ex_02/imgs/gift.png")
