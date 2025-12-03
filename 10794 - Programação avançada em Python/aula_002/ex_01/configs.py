import pygame

pygame.init()

class window:
  WIDTH = 404
  HEIGHT = 316
  TITLE = "Exercicio 2"


class font:
  ROBOTO_20 = pygame.font.Font("10794 - Programação avançada em Python/aula_001/ex_04/fonts/Roboto-Regular.ttf", 20)

class skin:
  SONIC = pygame.image.load("10794 - Programação avançada em Python/aula_002/ex_01/imgs/Classic_Sonic.webp")
  BACKGROUND = pygame.image.load("10794 - Programação avançada em Python/aula_002/ex_01/imgs/background.jpg")
