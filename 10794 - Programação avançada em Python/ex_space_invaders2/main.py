import pygame
import random
from pygame.locals import *
from configs import *
from direction import *
from projectile import *
from projectileEnemy import *
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

enemy_projectiles = []
last_enemy_shot_time = pygame.time.get_ticks()  # guarda o tempo do último disparo
enemy_shoot_interval = 2000  # 2 segundos em milissegundos

enemy_speed = 2


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
        current_time = pygame.time.get_ticks()
        if current_time - last_enemy_shot_time >= enemy_shoot_interval:
            shooting_enemy = random.choice(enemies)
            new_projectile = ProjectileEnemy(shooting_enemy.get_x() + skin.ALIEN_1.get_width() / 2)
            new_projectile.shoot(shooting_enemy.get_x() + skin.ALIEN_1.get_width() / 2, 500)
            enemy_projectiles.append(new_projectile)
            last_enemy_shot_time = current_time 
    
    for projetile in enemy_projectiles:
        projetile.update_shoot()
        projetile.draw(screen)

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

