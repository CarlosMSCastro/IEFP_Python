import pygame
from pygame.locals import * 
from configs import *

pygame.init()

screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

clock = pygame.time.Clock()

texto_nome = font.MACONDO_25.render("Bem-Vindo", True, "white")

while True:
  dt = clock.tick(60)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      exit()
  
  screen.fill("blue")
  screen.blit(texto_nome, [75, 75])
  

  pygame.display.update()

pygame.quit()