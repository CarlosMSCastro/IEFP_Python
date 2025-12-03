import pygame
from configs import *
import random

class Runner:
    all_stopped = False

    def __init__(self, nome, x, y, skin):
        self.__nome = nome
        self.__x = x
        self.__y = y
        self.__speed = random.randint(2,5)
        self.__skin = skin
    
    def get_nome(self):
        
        return self.__nome
    
    def get_skin(self):
        return self.__skin

    def move(self):
        if Runner.all_stopped:
            return 
        
        self.__x += self.__speed

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    @classmethod
    def stop_group(cls):
        Runner.all_stopped = True

    
    def is_finished(self):
        return self.__x > 580


    def delete(self, screen):
        screen.blit(self.__skin, [0, 0])
