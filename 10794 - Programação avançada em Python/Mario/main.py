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

text_game_over = font.COINY_60.render("GAME OVER", True, "white")
pos_text_game_over = (window.WIDTH / 2 - text_game_over.get_width() / 2, 175)

text_reset = font.COINY_30.render("Prima ENTER para reiniciar...", True, "white")
pos_text_reset = (window.WIDTH / 2 - text_reset.get_width() / 2, pos_text_game_over[1] + text_game_over.get_height() + 20)

while True:
    dt = clock.tick(window.FPS)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()

    key = pygame.key.get_pressed()

    world.draw(screen)

    if mario.is_dead():
        screen.blit(
            skin.SAD_MARIO, 
            (
                window.WIDTH / 2 - skin.SAD_MARIO.get_width() / 2,
                278
            )
        )

        screen.blit(text_game_over, pos_text_game_over)
        screen.blit(text_reset, pos_text_reset)

        if key[pygame.K_RETURN]:
            del(mario)
            del(enemy)
            mario = Mario(20)
            enemy = Enemy()

        pygame.display.update()
        continue

    world.move()

    if key[pygame.K_a] or key[pygame.K_LEFT]:
        mario.move(direction.LEFT)

    if key[pygame.K_d] or key[pygame.K_RIGHT]:   
        mario.move(direction.RIGHT)
    
    if key[pygame.K_SPACE]:
        mario.jump()

    mario.update_jump()
    mario.draw(screen)
    mario.draw_life(screen)

    enemy.move()
    enemy.draw(screen)

    if not mario.is_invincible():
        mario.increase_score()

        if mario.colides(enemy):
            mario.lose_life()

    pygame.display.update()

