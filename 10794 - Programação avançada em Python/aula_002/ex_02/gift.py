import pygame
from configs import *
import random

class Gift:
  def __init__(self, x, y):
    self.__x = x
    self.__y = y
    self.__speed = random.randint(2,5)
    self.__skin = skin.GIFT
  
  def move(self):
    self.__y += self.__speed
    
    if self.__y > window.HEIGHT:
      self.__y = -random.randint(self.__skin.get_height(), 500)
      self.__speed = random.randint(2,5)

  def draw(self, screen):
    screen.blit(self.__skin, [self.__x, self.__y])
