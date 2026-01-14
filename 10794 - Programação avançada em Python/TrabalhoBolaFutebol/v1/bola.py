import pygame
from configs import *
from direction import *

class Bola:
  def __init__(self):
    self.__skin = skin.BOLA
    self.__x = general.BOLA_START_X
    self.__y = general.BOLA_START_Y
    self.__speed = general.BOLA_SPEED
    self._shooting = False
    self.__dx = 0       #Direcao do Remate em X
    self.__dy = 0       #Direcao do Remate em Y

  def draw(self, screen):
    screen.blit(self.__skin, [self.__x, self.__y])

  def shoot(self):
    if not self._shooting:         #Se quando o shoot() for chamado o self._shooting estiver desligado, ativa-o e dá velocidade ao __dy
      self._shooting = True
      self.__dy = -10 

      target_x = (general.BALIZA_X_MIN + general.BALIZA_X_MAX) / 2  #target definido para ser "Golo"
      if self.__x < target_x:    #Correçao para a direção da baliza
        self.__dx = 2
      elif self.__x > target_x:
        self.__dx = -2
      else:
        self.__dx = 0

  def move(self, dir=None):
    if self._shooting:
      self.__x += self.__dx
      self.__y += self.__dy
    else:
      if dir == direction.LEFT:
        self.__x -= self.__speed
      elif dir == direction.RIGHT:
        self.__x += self.__speed
      elif dir == direction.UP:
        self.__y -= self.__speed
      elif dir == direction.DOWN:
        self.__y += self.__speed

    X_MIN = 15     #medidas do "campo"
    X_MAX = 575
    Y_MIN = 15
    Y_MAX = 430

    golo = False

    if self.__x < X_MIN or self.__x > X_MAX or self.__y < Y_MIN or self.__y > Y_MAX:                  #se sair do campo
      if general.BALIZA_X_MIN <= self.__x <= general.BALIZA_X_MAX and self.__y <= general.BALIZA_Y:  #se sair do campo, mas na baliza
        golo = True
      sound.APITO.play()
      if golo:
        sound.GOAL.play()
      self.__x = general.BOLA_START_X
      self.__y = general.BOLA_START_Y
      self._shooting = False