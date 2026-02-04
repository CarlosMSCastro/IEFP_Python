import pygame
from configs import *
from direction import *
from projectile import *

class Ship:
    def __init__(self, x, genome, net):
        self.__skin = skin.SPACE_SHIP
        self.__x = x
        self.__y = 755
        self.__vx = 6
        self.__shoot = False
        self.__time_limit = 1000
        self.__start_time = pygame.time.get_ticks()
        self.__net = net
        self.__genome = genome
        self.__succeed = False

    def skin(self):
        return self.__skin

    def suceeed_to_fitness(self):
        self.__succeed = True

    def reset_to_fitness(self):
        self.__succeed = False

    def can_evade_fitness(self):
        return self.__succeed

    def get_net(self):
        return self.__net

    def get_x(self):
        return self.__x

    def get_y(self):
        return self.__y

    def add_fitness(self, val):
        self.__genome.fitness += val

    def get_x(self):
        return self.__x

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

    def shoot(self):
        self.__shoot = True

    def move(self, dir):
        self.__set_boundaries()

        if dir == direction.LEFT:
            self.__x -= self.__vx
        elif dir == direction.RIGHT:
            self.__x += self.__vx

    def __set_boundaries(self):
        if self.__x < 215:
            self.__x = 215

        if self.__x > 750:
            self.__x = 750
    
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