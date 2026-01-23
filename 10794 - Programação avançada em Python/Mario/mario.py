import pygame
from configs import *
from direction import *
from world import *

class Mario:
    def __init__(self, x):
        self.__skin = skin.MARIO.convert_alpha()
        self.__x = x
        self.__y = general.GROUND_LOCATION - self.__skin.get_height()
        self.__jump_direction = None
        self.__life = 100
        self.__invicible_timeout = 0
        self.__score = 0

    def draw(self, screen):   
        if self.is_invincible():
            if self.__invicible_timeout % 20 == 0:
                self.__skin.set_alpha(10)
            elif self.__invicible_timeout % 10 == 0:
                self.__skin.set_alpha(255)

            self.__invicible_timeout -= 1
                
        screen.blit(self.__skin, [self.__x, self.__y])

    def draw_life(self, screen):
        pygame.draw.rect(screen, "black", [10, 10, 252, 17], 1)
        pygame.draw.rect(screen, "white", [11, 11, self.__life * 2.5, 15])

    def lose_life(self):
        self.__life -= 5
        self.__invicible_timeout = window.FPS * 2
    
    def is_invincible(self):
        return self.__invicible_timeout > 0

    def is_dead(self):
        return self.__life <= 0

    def move(self, dir):
        if dir == direction.LEFT:
            self.__x -= World.speed * 3
        elif dir == direction.RIGHT:
            self.__x += World.speed * 2

        if self.__x < 20:
            self.__x = 20
        elif self.__x > window.WIDTH / 1.5 - self.__skin.get_width():
            self.__x = window.WIDTH / 1.5 - self.__skin.get_width()
    
    def jump(self):
        if self.__jump_direction is not None:
            return
        
        self.__jump_direction = direction.RISING

    def update_jump(self):
        if self.__jump_direction is None:
            return
        
        if self.__jump_direction == direction.RISING:
            self.__y -= World.speed * 3
            if self.__y < window.HEIGHT / 3:
                self.__jump_direction = direction.FALLING
        else:  # direction.FALLING
            self.__y += World.speed * 3
            if self.__y > general.GROUND_LOCATION - self.__skin.get_height():
                self.__y = general.GROUND_LOCATION - self.__skin.get_height()
                self.__jump_direction = None
        
    def increase_score(self):
        self.__score += 1
        print(self.__score)
    
    #get area de sobreposição
    def get_overlaping_area(self, skin, offset_x, offset_y):
        self_mask = pygame.mask.from_surface(self.__skin)
        target_mask = pygame.mask.from_surface(skin)
        return target_mask.overlap_area(self_mask, [self.__x - offset_x, self.__y - offset_y])
    
    #Verificar colisão
    def colides(self, target):
        return target.get_overlaping_area(self.__skin, self.__x, self.__y) > 0