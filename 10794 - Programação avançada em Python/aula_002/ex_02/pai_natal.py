import pygame
from configs import *

class PaiNatal:
  def __init__(self, x, y):
    self.__x = x
    self.__y = y
    self.__speed = 4
    self.__skin = skin.PAI_NATAL

  def move(self):
    self.__x += self.__speed

    if self.__x > window.WIDTH:
      self.__x = -self.__skin.get_width()

  def draw(self, screen):
    screen.blit(self.__skin, [self.__x, self.__y])
