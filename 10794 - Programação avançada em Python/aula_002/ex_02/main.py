import pygame
from pygame.locals import * 
from configs import *
from pai_natal import *
from gift import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])

pygame.display.set_caption(window.TITLE)

pai_natal = PaiNatal(-250, 20)
gifts = [
  Gift(10, -50),
  Gift(150, -200),
  Gift(300, -80),
  Gift(400, -150),
  Gift(550, -100),
  Gift(600, -80),
  Gift(650, -310),
  Gift(710, -100),
  Gift(740, -250)
]


clock = pygame.time.Clock()

while True:
  dt = clock.tick(window.FPS)

  for event in pygame.event.get():
    if event.type == pygame.QUIT:
      pygame.quit()
      exit()
  
  screen.blit(skin.BACKGROUND, [0, 0])

  for gift in gifts:
    gift.move()
    gift.draw(screen)

  pai_natal.move()
  pai_natal.draw(screen)

  pygame.display.update()