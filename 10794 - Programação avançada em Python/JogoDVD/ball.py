import pygame
from configs import *

class Ball:
    def __init__(self, x, y):
        self.__skin = skin.DVD_LOGO
        self.__x = x
        self.__y = y

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])
