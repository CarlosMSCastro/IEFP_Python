import pygame
from configs import *
from direction import *
from world import *

class Mario:
    def __init__(self, x):
        self.__skin = skin.MARIO
        self.__x = x
        self.__y = general.GROUND_LOCATION - self.__skin.get_height()

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def move(self, dir):
        if dir == direction.LEFT:
            self.__x -= World.speed * 2
        elif dir == direction.RIGHT:
            self.__x += World.speed

        if self.__x < 20:
            self.__x = 20
        elif self.__x > window.WIDTH / 2 - self.__skin.get_width():
            self.__x = window.WIDTH / 2 - self.__skin.get_width()