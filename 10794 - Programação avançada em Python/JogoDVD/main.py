import pygame
from pygame.locals import *
from configs import *
from dvd import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)


sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()
dvd = Dvd(10, 10)

while True:
    dt = clock.tick(60)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()
    
    screen.blit(skin.BACKGROUND, [0, 0])
    dvd.move()
    dvd.draw(screen)

    resultado = dvd.check_game_over()
    
    if resultado == "WIN":
        texto = font.FONTGRANDE.render("WIN!", True, "green")
        sound.WIN.play()
        screen.blit(texto, [250,150])
        pygame.display.update()
        pygame.time.wait(4000)
        break
    
    elif resultado == "LOSE":
        texto = font.FONTGRANDE.render("LOSE!", True, "red")
        sound.LOSE.play()
        screen.blit(texto, [250,150])
        pygame.display.update()
        pygame.time.wait(3000)
        break
    
    

    pygame.display.update()


