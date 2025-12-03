import pygame
from pygame.locals import * 
from configs import *

pygame.init()

screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

clock = pygame.time.Clock()

while True:
  dt = clock.tick(60)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      exit()
  
  screen.fill("white")

  pygame.draw.rect(screen, "green", [20,30,70,50])
  pygame.draw.rect(screen, "black", [80,35,50,10])
  pygame.draw.rect(screen, "gray", [80,50,50,30])
  pygame.draw.circle(screen, "black", [45,85], 15)
  pygame.draw.circle(screen, "black", [105,85], 15)


  pygame.display.update()

pygame.quit()