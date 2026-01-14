import pygame
from pygame.locals import *
from configs import *
from bola import *
from direction import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

sound.BACKGROUND.play(loops=-1) 
clock = pygame.time.Clock()
bola = Bola()

while True:
  clock.tick(60)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      exit()
    elif event.type == pygame.KEYDOWN:
      if event.key == pygame.K_SPACE:
        bola.shoot()

  key = pygame.key.get_pressed()
  if not bola._shooting:   
    if key[pygame.K_LEFT]:
      bola.move("left")
    elif key[pygame.K_RIGHT]:
      bola.move("right")
    elif key[pygame.K_UP]:
      bola.move("up")
    elif key[pygame.K_DOWN]:
      bola.move("down")

  bola.move(dir)

  screen.blit(skin.CAMPO, (0, 0))
  bola.draw(screen)

  pygame.display.update()
