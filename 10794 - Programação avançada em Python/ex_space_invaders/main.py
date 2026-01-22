import pygame
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
projectile = Projectile(ship.get_x() + skin.SPACE_SHIP.get_width() / 2)

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
        
    projectile.update_shoot()
    projectile.draw(screen)

    # N/ao deixar aqui fora
    if enemies[0].get_x() <= 208 or enemies[3].get_x() >= 755:
        enemy_speed *= -1

    ship.draw(screen)

    for enemy in enemies:
        enemy.draw(screen)
        enemy.move(enemy_speed)

        if enemy.colides(projectile):
            enemy.is_killed()
            projectile.reset()
            # remover enemy da lista para ter WIN?

    result = projectile.check_game_over()

    if result == "LOSE":
        texto = font.FONT_GRANDE.render("GAME OVER!", True, "gray56")
        sound.BACKGROUND.play(loops=0)
        sound.LOSING.play()
        screen.blit(texto, [skin.BACKGROUND.get_width() / 2 - texto.get_width() / 2, 630])
        pygame.display.update()
        pygame.time.wait(5000)
        break
   
 
    pygame.display.update()

