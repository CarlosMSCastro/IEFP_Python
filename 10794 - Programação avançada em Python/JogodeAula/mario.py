import pygame
from configs import *
from direction import *
from world import *

class Mario:
    def __init__(self, x):
        self.__skin = skin.MARIO
        self.__x = x
        self.__y = general.GROUND_LOCATION - self.__skin.get_height()
        self.__jump_direction  = None

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def move(self, dir):
        if dir == direction.LEFT:
            self.__x -= World.speed * 3
        elif dir == direction.RIGHT:
            self.__x += World.speed * 2

        if self.__x < 20:
            self.__x = 20
        elif self.__x > window.WIDTH / 2 - self.__skin.get_width():
            self.__x = window.WIDTH / 2 - self.__skin.get_width()

    def jump(self):
        if self.__jump_direction is not None:
            return
        
        self.__jump_direction = direction.RISING
    
    def update_jump(self):
        if self.__jump_direction is None:
            return
        
        if self.__jump_direction == direction.RISING:
            self.__y -= World.speed * 3
            if self.__y < window.HEIGHT / 2.5:
                self.__jump_direction = direction.FALLING
        else: #direction.FALLING
            self.__y += World.speed * 3
            if self.__y > general.GROUND_LOCATION - self.__skin.get_height():
                self.__y = general.GROUND_LOCATION - self.__skin.get_height()
                self.__jump_direction = None