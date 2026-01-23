import pygame
from pygame.locals import *
from configs import *
from world import *
from mario import *
from direction import *
from enemy import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

#sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()
world = World()
mario = Mario(20)
enemy = Enemy()

while True:
    dt = clock.tick(window.FPS)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()

    key = pygame.key.get_pressed()
    
    if key[pygame.K_a] or key[pygame.K_LEFT]:
        mario.move(direction.LEFT)

    if key[pygame.K_d] or key[pygame.K_RIGHT]:   
        mario.move(direction.RIGHT)
    
    if key[pygame.K_SPACE]:
        mario.jump()

    world.move()
    world.draw(screen)

    mario.update_jump()
    mario.draw(screen)
    mario.draw_life(screen)

    enemy.move()
    enemy.draw(screen)
    
    if mario.colides(enemy) and not mario.is_invincible():
        mario.lose_life()

    #todo: ecra gameover
    pygame.display.update()

