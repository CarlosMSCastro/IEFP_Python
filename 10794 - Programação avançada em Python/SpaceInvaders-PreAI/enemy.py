import pygame
from configs import *
from direction import *
import random

class Enemy:
    speed = 2

    def __init__(self, x):
        self.__skin = random.choice(skin.ALIENS)
        self.__x = x 
        self.__y = 460
        self.__shoot = False


    def get_x(self):
        return self.__x
    
    def get_y(self):
        return self.__y

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])
    
    # def check_movement():
    #     if self.__x <= 208:
    #         self.__x = 208
    #         Enemy.speed = abs(Enemy.speed)

    #     if self.__x >= 755:
    #         self.__x = 755
    #         Enemy.speed = -abs(Enemy.speed)

    def move(self):
        self.__x += Enemy.speed

    @classmethod
    def increase_speed(cls, amount):
        if ...: #somar ou subtrair
            ...

    @classmethod
    def check_movement(cls, enemies):
        x_pos_aliens = []

        for enemy in enemies:
            x_pos_aliens.append(enemy.get_x())

        if min(x_pos_aliens) <= 208:
            #min(x_pos_aliens) = 208
            Enemy.speed = abs(Enemy.speed)
        
        if max(x_pos_aliens) >= 755:
            #max(x_pos_aliens) = 755
            Enemy.speed = -abs(Enemy.speed)




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

