import pygame
from configs import *
from direction import *
from ship import *
from enemy import *

class Projectile:

    def __init__(self, vy, skin):
        self.__skin = skin
        self.__x = -20 
        self.__y = -20
        self.__vy = vy
        self.__shooting = False

#apagar parametros

    def get_x(self):
        return self.__x
    
    def get_y(self):
        return self.__y

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def update_shoot(self):
        if not self.__shooting:
            return
        
        self.__y -= self.__vy
        if self.__y <= 450:
            self.reset()

        if self.__y >= 830:
            self.reset()

    def shoot(self, x, y): 
        if self.__shooting == True:
            return
        else:
            self.__shooting = True
            self.__x = x
            self.__y = y
        
        if self.__vy > 0:
            sound.SHOOTING_1.play()
        else:
            sound.SHOOTING_2.play()
    
    def reset(self):
        self.__y = -20
        self.__x = -20
        self.__shooting = False

    def is_shooting(self):

        return self.__shooting

    def follow_ship(self, target_x, target_y, target_skin):
        if not self.__shooting:
            return
        
        centro_x = self.__x + self.__skin.get_width() / 2
        center_target_x = target_x + target_skin.get_width() / 2

        dx = center_target_x - centro_x

        if abs(dx) > 5:
            dx = dx / abs(dx) if dx != 0 else 0  
            self.__x += dx * 3 

    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0