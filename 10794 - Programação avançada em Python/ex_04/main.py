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

  pygame.draw.circle(screen, "#90cbf3", [45,65], 35)
  pygame.draw.rect(screen, "#90cbf3", [20,20,50,10])
  pygame.draw.rect(screen, "#90cbf3", [30,30,30,10])
  pygame.draw.rect(screen, "#7c3010", [30,10,31,10])
  pygame.draw.polygon(screen, "#616161", [[35,20], [35,30],[45,40], [55,30], [55,20]])
  pygame.draw.circle(screen, "#ffc000", [45,65], 25)
  pygame.draw.rect(screen, "#90cbf3", [20,40,50,25])
  pygame.draw.arc(screen, "white", (20, 40, 50, 50), 2.4, 4.7, 2)

  pygame.draw.circle(screen, "white", [60,45], 5)
  pygame.draw.circle(screen, "white", [65,55], 2.5)
  



  pygame.display.update()

pygame.quit()