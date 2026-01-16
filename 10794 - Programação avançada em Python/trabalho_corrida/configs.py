import pygame.font

pygame.init()

class window:
    WIDTH = 900
    HEIGHT = 506
    TITLE = "Running Track"

class skin:
    BACKGROUND = pygame.image.load("./10794 - Programação avançada em Python/aula_002/trabalho_corrida/img/background.png")
    RUNNER1 = pygame.image.load("10794 - Programação avançada em Python/aula_002/trabalho_corrida/img/horse1.png")
    RUNNER2 = pygame.image.load("10794 - Programação avançada em Python/aula_002/trabalho_corrida/img/horse2.png")
    RUNNER3 = pygame.image.load("10794 - Programação avançada em Python/aula_002/trabalho_corrida/img/spiderman.png")
    TROPHY = pygame.image.load("10794 - Programação avançada em Python/aula_002/trabalho_corrida/img/trophy.png")
    RUNNER1SMALL = pygame.transform.scale(RUNNER1, (500, 400))
    RUNNER2SMALL = pygame.transform.scale(RUNNER2, (500, 400))
    RUNNER3SMALL = pygame.transform.scale(RUNNER3, (500, 400))

    TROPHYSMALL = pygame.transform.scale(TROPHY, (500, 400))

class font:
    ROBOTOBOLD = pygame.font.Font("10794 - Programação avançada em Python/aula_002/trabalho_corrida/fonts/Roboto-Bold.ttf", 16)
