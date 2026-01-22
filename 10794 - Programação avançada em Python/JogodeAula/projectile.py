import pygame
from configs import *
from direction import *
from ship import *
from enemy import *

class Projectile:
    def __init__(self, x):
        self.__skin = skin.PROJECTILE
        self.__x = x #skin.SPACE_SHIP.get_width() / 2
        self.__y = 1200
        self.__vy = 5
        self.__shooting = False
        self.__tempo_limite = 10
        self.__start_time = pygame.time.get_ticks()

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    # update
    def update_shoot(self):
        if not self.__shooting:
            return
        
        self.__y -= self.__vy
        if self.__y <= 450:
            self.reset()

            if self.__y <= 450 - self.__skin.get_height():
                print("reset")


    def shoot(self, x, y): 
        if self.__shooting == True:
            return
        else:
            self.__shooting = True
            self.__x = x
            self.__y = y
    
    def reset(self):
        self.__y = 1200
        self.__x = -20
        self.__shooting = False

    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0
    
    def check_game_over(self):        
        tempo_decorrido = (pygame.time.get_ticks() - self.__start_time) // 1000
        if tempo_decorrido == self.__tempo_limite:
            return "LOSE"
        else:
            return None
