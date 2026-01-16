import pygame

pygame.init()
pygame.mixer.init()

class window:
    WIDTH = 710
    HEIGHT = 400
    TITLE = "DVD Screensaver"

class skin:
    DVD_LOGO_BLUE = pygame.image.load("imgs/dvd_logo_blue.png")
    DVD_LOGO_GOLD = pygame.image.load("imgs/dvd_logo_gold.png")
    DVD_LOGO_GREEN = pygame.image.load("imgs/dvd_logo_green.png")
    DVD_LOGO_RED = pygame.image.load("imgs/dvd_logo_red.png")
    DVD_LOGO_SILVER = pygame.image.load("imgs/dvd_logo_silver.png")
    DVD_LOGOS = [DVD_LOGO_BLUE, DVD_LOGO_GOLD, DVD_LOGO_GREEN, DVD_LOGO_RED, DVD_LOGO_SILVER]
    BACKGROUND = pygame.image.load("imgs/background.png")

class sound:
    BACKGROUND = pygame.mixer.Sound("sounds/somfundo.mp3")
    BACKGROUND.set_volume(0.05)
    BOUNCE = pygame.mixer.Sound("sounds/bounce.wav")
    BOUNCE.set_volume(0.2)
    BOUNCE2 = pygame.mixer.Sound("sounds/bounce2.wav")
    BOUNCE2.set_volume(0.05)
    LOSE = pygame.mixer.Sound("sounds/lose.mp3")
    LOSE.set_volume(0.2)
    WIN = pygame.mixer.Sound("sounds/win.mp3")
    WIN.set_volume(0.2)

class font:
    FONT = pygame.font.Font("fonts/PressStart2P-Regular.ttf", 20)
    FONTGRANDE = pygame.font.Font("fonts/PressStart2P-Regular.ttf", 50)
