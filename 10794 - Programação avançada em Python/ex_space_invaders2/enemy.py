import pygame
from configs import *
from direction import *
import random

class Enemy:

    def __init__(self, x):
        self.__skin = random.choice(skin.ALIENS)
        self.__x = x 
        self.__y = 460
        self.__is_alive = True
        self.__shoot = False

    def get_x(self):
        return self.__x

    def draw(self, screen):
        if self.__is_alive:
            screen.blit(self.__skin, [self.__x, self.__y])
        
    def is_killed(self):
        self.__is_alive = False
    
    def move(self, enemy_speed):
        self.__x += enemy_speed

    def shoot(self):
        self.__shoot = True

    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0

