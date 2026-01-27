import pygame
from configs import *
from direction import *
from world import *
from random import *

class Enemy:
    WALKING = 1
    FLYING = 2

    def __init__(self):
        self.__type = None
        self.__skin = None
        self.__x = None
        self.__y = None
        self.__speed_h = None
        self.__speed_v = None

        self.reset()

    def get_x(self):
        return self.__x

    def get_y(self):
        return self.__y

    def get_speed_h(self):
        return self.__speed_h

    def get_speed_v(self):
        return self.__speed_v

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def move(self):
        self.__x -= self.__speed_h
        if self.__x < - self.__skin.get_width():
            self.reset() 

        if self.__type == Enemy.WALKING:
            return
        
        self.__y += self.__speed_v
        limit_top = window.HEIGHT / 2.5
        limit_bottom = general.GROUND_LOCATION - self.__skin.get_height()

        if self.__y >= limit_bottom:
            self.__y = limit_bottom
            self.__speed_v *= -1
        elif self.__y <= limit_top:
            self.__y = limit_top
            self.__speed_v *= -1
            

    def reset(self):        
        if randint(0, 100) < 50:
            self.__type = Enemy.WALKING
            self.__skin = choice(skin.ENEMIES["WALKING_TYPE"])
        else:
            self.__type = Enemy.FLYING
            self.__skin = choice(skin.ENEMIES["FLYING_TYPE"])

        self.__x = window.WIDTH
        self.__y = general.GROUND_LOCATION - self.__skin.get_height() + 4

        self.__speed_h = randint(4, 6)
        self.__speed_v = randint(4, 6)

    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0

