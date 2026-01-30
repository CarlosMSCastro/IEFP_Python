import pygame
import random
from pygame.locals import *
from configs import *
from direction import *
from projectile import *
from ship import *
from enemy import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)

sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()
ship = Ship(window.WIDTH / 2 - skin.SPACE_SHIP.get_width() / 2)
projectile = Projectile(5, skin.PROJECTILE)
enemy_projectile = Projectile(-5, skin.PROJECTILE_ENEMY)

enemies = [
    Enemy(280),
    Enemy(430),
    Enemy(560),
    Enemy(700)
]

while True:
    dt = clock.tick(window.FPS)
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()

    screen.blit(skin.BACKGROUND, [0, 0])
    key = pygame.key.get_pressed()
    
    if key[pygame.K_a] or key[pygame.K_LEFT]:
        ship.move(direction.LEFT)

    if key[pygame.K_d] or key[pygame.K_RIGHT]:   
        ship.move(direction.RIGHT)

    if key[pygame.K_SPACE]:
        ship.shoot()
        projectile.shoot(ship.get_x() + skin.SPACE_SHIP.get_width() / 2, 755)

    ship.draw(screen)

    projectile.update_shoot()
    projectile.draw(screen)

    enemy_projectile.shoot(random.choice(enemies).get_x() + skin.ALIEN_1.get_width() / 2, 500)
    enemy_projectile.update_shoot()
    enemy_projectile.draw(screen)

    if enemy_projectile.colides(projectile):
        projectile.reset()
        enemy_projectile.reset()



    Enemy.check_movement(enemies)

    for enemy in enemies:
        enemy.draw(screen)
        enemy.move()
        if enemy.colides(projectile):
            enemies.remove(enemy)
            projectile.reset()

    result = ship.check_game_over()

    if len(enemies) == 0:
        result = "WIN"
    
    if ship.colides(enemy_projectile):
        result = "LOSE"

    if result == "LOSE":
        texto = font.FONT_GRANDE.render("GAME OVER!", True, "gray56")
        sound.BACKGROUND.play(loops=0)
        sound.LOSING.play()
        screen.blit(texto, [skin.BACKGROUND.get_width() / 2 - texto.get_width() / 2, 630])
        pygame.display.update()
        pygame.time.wait(2000)
        break
    elif result == "WIN":
        texto = font.FONT_GRANDE.render("YOU WIN!", True, "green")
        sound.BACKGROUND.play(loops=0)
        sound.WIN.play()
        screen.blit(texto, [skin.BACKGROUND.get_width() / 2 - texto.get_width() / 2, 630])
        pygame.display.update()
        pygame.time.wait(2000)
        break

    pygame.display.update()

