import pygame

pygame.init()
pygame.mixer.init()

class window:
    WIDTH = 1024
    HEIGHT = 1000
    TITLE = "Space Invaders"
    FPS = 60

class font:
    FONT = pygame.font.Font("fonts/PressStart2P-Regular.ttf", 20)
    FONT_GRANDE = pygame.font.Font("fonts/PressStart2P-Regular.ttf", 50)

class skin:
    BACKGROUND = pygame.image.load("imgs/background.jpg")
    SPACE_SHIP = pygame.image.load("imgs/player.png")
    PROJECTILE = pygame.image.load("imgs/projectile.png")
    PROJECTILE_ENEMY = pygame.image.load("imgs/projectile_enemy.png")

    ALIEN_1 = pygame.image.load("imgs/enemy_1.png")
    ALIEN_2 = pygame.image.load("imgs/enemy_2.png")
    ALIEN_3 = pygame.image.load("imgs/enemy_3.png")
    ALIEN_4 = pygame.image.load("imgs/enemy_4.png")

    ALIENS = [ALIEN_1, ALIEN_2, ALIEN_3, ALIEN_4]

    

class sound:
    BACKGROUND = pygame.mixer.Sound("sounds/background.mp3")
    LOSING = pygame.mixer.Sound("sounds/losing.wav")
    SHOOTING_1 = pygame.mixer.Sound("sounds/shooting_01.mp3")
    SHOOTING_2 = pygame.mixer.Sound("sounds/shooting_02.mp3")
    WIN = pygame.mixer.Sound("sounds/win.wav")
    BACKGROUND.set_volume(0.05)
    SHOOTING_1.set_volume(0.05)
    SHOOTING_2.set_volume(0.05)
    LOSING.set_volume(0.05)
    WIN.set_volume(0.05)

