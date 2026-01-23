import pygame

pygame.init()
pygame.mixer.init()

class window:
    WIDTH = 1024
    HEIGHT = 683
    TITLE = "Super Mario Runner"
    FPS = 60

class general:
    GROUND_LOCATION = 595

class font:
    ...

class skin:
    MARIO = pygame.image.load("imgs/super_mario_1.png")
    SKY = pygame.image.load("imgs/sky.png")
    GROUND = pygame.image.load("imgs/ground.png")
    CLOUDS = [
        pygame.image.load("imgs/cloud_1.png"),
        pygame.image.load("imgs/cloud_2.png"),
        pygame.image.load("imgs/cloud_3.png")
    ]
    WOODS = [
        pygame.image.load("imgs/bush_1.png"),
        pygame.image.load("imgs/bush_2.png"),
        pygame.image.load("imgs/bush_3.png"),
        pygame.image.load("imgs/mountain_1.png"),
        pygame.image.load("imgs/mountain_2.png"),
        pygame.image.load("imgs/mountain_3.png")
    ]
    TUBES = [
        pygame.image.load("imgs/mountain_1.png"),
        pygame.image.load("imgs/mountain_2.png")
    ]
    ENEMIES = {
        "FLYING_TYPE": [
            pygame.image.load("imgs/bullet.png"),
            pygame.image.load("imgs/cannonball.png"),
            pygame.image.load("imgs/squid.png"),
        ],
        "WALKING_TYPE": [
            pygame.image.load("imgs/kiwi.png"),
            pygame.image.load("imgs/rice.png"),
            pygame.image.load("imgs/spike.png"),
            pygame.image.load("imgs/turtle.png"),
        ]
    }


class sound:
    BACKGROUND = pygame.mixer.Sound("sounds/background.mp3")
    BACKGROUND.set_volume(0.05)

