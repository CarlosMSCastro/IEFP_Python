import pygame
from configs import *
from direction import *
from world import *
from random import *

class Enemy:
    WALKING = 1
    FLYING = 2

    def __init__(self, x):
        self.__x = x
        self.__type = None
        self.__skin = None
        self.__y = None
        
        if randint(0, 100) < 50:
            self.__type = Enemy.WALKING
            self.__skin = choice(skin.ENEMIES["WALKING_TYPE"])
            self.__y = general.GROUND_LOCATION - self.__skin.get_height()
        else:
            self.__type = Enemy.FLYING
            self.__skin = choice(skin.ENEMIES["FLYING_TYPE"])

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])