import pygame
from pygame.locals import *
from configs import *
from ball import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)


sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()

while True:
    dt = clock.tick(60)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()

    screen.blit(skin.BACKGROUND, [0, 0])
    


    pygame.display.update()
