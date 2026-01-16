import pygame

pygame.init()
pygame.mixer.init()

class window:
    WIDTH = 710
    HEIGHT = 400
    TITLE = "DVD Screensaver"

class skin:
    DVD_LOGO = pygame.image.load("imgs/dvd_logo.webp")
    BACKGROUND = pygame.image.load("imgs/background.png")

class sound:
    BACKGROUND = pygame.mixer.Sound("sounds/somfundo.mp3")
    BACKGROUND.set_volume(0.05)
    BOUNCE = pygame.mixer.Sound("sounds/bounce.wav")
    BOUNCE.set_volume(0.2)
