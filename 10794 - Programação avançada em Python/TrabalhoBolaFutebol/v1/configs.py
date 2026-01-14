import pygame

pygame.init()
pygame.mixer.init()

class window:
    WIDTH = 600
    HEIGHT = 450
    TITLE = "NetSoccer"

class general:
    BOLA_START_X = 265
    BOLA_START_Y = 350
    BALIZA_X_MIN = 270
    BALIZA_X_MAX = 320
    BALIZA_Y = 30
    BOLA_SPEED = 5 
    
class font:
    ...

class skin:
    BOLA = pygame.image.load("imgs/bola.png")
    CAMPO = pygame.image.load("imgs/campo.jpg")



class sound:
    BACKGROUND = pygame.mixer.Sound("sounds/stadium.wav")
    BACKGROUND.set_volume(0.05)
    GOAL = pygame.mixer.Sound("sounds/goal.mp3")
    GOAL.set_volume(0.10)
    APITO = pygame.mixer.Sound("sounds/apito.wav")
    APITO.set_volume(0.10)
