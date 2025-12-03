import pygame
from pygame.locals import *
from configs import *
from runners import *

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])

runners = [
    Runner("Cavalo Castanho", 10, 70, skin.RUNNER1),
    Runner("Spiderman", 10, 80, skin.RUNNER3),
    Runner("Cavalo Branco", 10, 250, skin.RUNNER2)
]

clock = pygame.time.Clock()

while True:
    dt = clock.tick(60)

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            pygame.quit()
            exit()
    
    screen.blit(skin.BACKGROUND, [0, 0])

    for runner in runners:
        runner.move()
        runner.draw(screen)

        if runner.is_finished():
            nome = runner.get_nome()
            runnerskin = runner.get_skin()
            Runner.stop_group()

            screen.blit(skin.TROPHYSMALL, [215, 20])
            screen.blit(pygame.transform.scale(runnerskin,(120, 120)), [410, 60])
            texto_nome = font.ROBOTOBOLD.render(f"{nome}", True, "#525252")
            screen.blit(texto_nome, [415, 345])

    pygame.display.update()

pygame.quit()
