import pygame
from pygame.locals import * 
from configs import *
from sonic import *

pygame.init()

screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

clock = pygame.time.Clock()

sonics = [
  Sonic(50, 110),
  Sonic(50, 0),
  Sonic(50, 50),
  Sonic(50, 200)
]

while True:
  dt = clock.tick(60)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      exit()
  
  screen.blit(skin.BACKGROUND, [0,0])

  for sonic in sonics:
    sonic.move()
    sonic.draw(screen)



  pygame.display.update()

pygame.quit()