import pygame
from configs import *
from random import *

class Dvd:
    def __init__(self, x, y):
        self.__skin = choice(skin.DVD_LOGOS)
        self.__x = x  #coordenadas iniciais
        self.__y = y

        velocidade = randint (2, 6) #velocidades
        self.__vx = velocidade
        self.__vy = velocidade 

        self.__width = self.__skin.get_width()   #dimensões logo
        self.__height = self.__skin.get_height()

        self.__bounces = 0

        self.__objetivo = 9
        self.__tempo_limite = 10
        #  https://www.pygame.org/docs/ref/time.html
        self.__start_time = pygame.time.get_ticks()

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])

        texto_bounces = font.FONT.render(f"Bounces: {self.__bounces}/{self.__objetivo}", True, "white")
        screen.blit(texto_bounces, [10, 10])

        tempo_decorrido = (pygame.time.get_ticks() - self.__start_time) // 1000 #dividir por 1000 porque get_ticks vem em ms
        tempo_restante = self.__tempo_limite - tempo_decorrido
        
        if tempo_restante < 0: #evitar tempos menores que 0
            tempo_restante = 0
        
        texto_timer = font.FONT.render(f"Tempo Restante: {tempo_restante}s", True, "white")
        screen.blit(texto_timer, [10, 50])

    def move(self):
        self.__x += self.__vx   # posicao nova = posicao antiga + velocidade
        self.__y += self.__vy
        self.verificar_colisao()
    
    def verificar_colisao(self):
        if (self.__x <= 0 and self.__vx < 0) or (self.__x >= window.WIDTH - self.__width and self.__vx > 0):  # se bateu numa lateral, apenas na ida, não no regresso 
            self.__bounces += 1
            nova_vel = randint(2, 6) #recebe velocidade nova 
            #verificar a direção para evitar duplo bounce
            if self.__vx > 0:      # inverter VX
                self.__vx = -nova_vel
            else:
                self.__vx = nova_vel
            
            if self.__vy > 0:      # NÃO inverter a VY para manter direçao
                self.__vy = nova_vel
            else:
                self.__vy = -nova_vel
            self.__skin = choice(skin.DVD_LOGOS)
            sound.BOUNCE.play()
        
        if (self.__y <= 0 and self.__vy < 0) or (self.__y >= window.HEIGHT - self.__height and self.__vy > 0): # se bateu num topo ou fundo, apenas na ida, não no regresso
            self.__bounces += 1
            nova_vel = randint(2, 6) #recebe velocidade nova 
            
            #verificar a direção para evitar duplo bounce
            if self.__vx > 0:      # NÃO inverter a VX
                self.__vx = nova_vel
            else:
                self.__vx = -nova_vel
            
            if self.__vy > 0:       # Inverter VY  para manter direçao
                self.__vy = -nova_vel
            else:
                self.__vy = nova_vel
            
            self.__skin = choice(skin.DVD_LOGOS)
            sound.BOUNCE2.play()

    def check_game_over(self):
        
        tempo_decorrido = (pygame.time.get_ticks() - self.__start_time) // 1000
        tempo_restante = self.__tempo_limite - tempo_decorrido
        
        if self.__bounces >= self.__objetivo:
            return "WIN"
        
        if tempo_restante <= 0:
            return "LOSE"
        
        return None