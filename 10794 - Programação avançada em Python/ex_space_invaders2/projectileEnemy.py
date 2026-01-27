import pygame
from configs import *
from direction import *
from ship import *
from enemy import *

class ProjectileEnemy:
    def __init__(self, x):
        self.__skin = skin.PROJECTILE
        self.__x = x
        self.__y = 500
        self.__vy = -5
        self.__shooting = False
        self.__time_limit = 60
        self.__start_time = pygame.time.get_ticks()

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def update_shoot(self):
        if not self.__shooting:
            return
        
        self.__y -= self.__vy
        if self.__y >= 1000:
            self.reset()

            if self.__y <= 1300 - self.__skin.get_height():
                print("reset")

    def shoot(self, x, y): 
        if self.__shooting == True:
            return
        else:
            self.__shooting = True
            sound.SHOOTING_2.play()
            self.__x = x
            self.__y = y
    
    def reset(self):
        self.__y = -100
        self.__x = -100
        self.__shooting = False

    def check_game_over(self):        
        time = (pygame.time.get_ticks() - self.__start_time) // 1000
        if time == self.__time_limit:
            return "LOSE"
        else:
            return None
        
    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0