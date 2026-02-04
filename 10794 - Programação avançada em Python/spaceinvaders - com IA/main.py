import pygame
import random
from pygame.locals import *
from configs import *
from direction import *
from projectile import *
from ship import *
from enemy import *
from random import choice, randint
import neat 
import os


pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)
gen = 0

sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()

def eval_game(genomes, config):
    global gen, screen, clock 

    gen =+ 1 

    projectile = Projectile(5, skin.PROJECTILE)
    enemy_projectile = Projectile(-3, skin.PROJECTILE_ENEMY)
    ships = []

    for genome_id, genome in genomes:
        genome.fitness = 0
        net = neat.nn.FeedForwardNetwork.create(genome, config)
        ships.append(
            Ship(
                randint(
                    20,
                    int(window.WIDTH / 2 - skin.SPACE_SHIP.get_width())
                ),
                genome,
                net
            )
        )
            
    enemies = [
        Enemy(280),
        Enemy(430),
        Enemy(560),
        Enemy(700)
    ]
  
    while len(ships) > 0:
        dt = clock.tick(window.FPS)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                exit()

        screen.blit(skin.BACKGROUND, [0, 0])

        projectile.draw(screen)
                
        if len(ships) > 0:
            if not enemy_projectile.is_shooting():
                enemy_projectile.shoot(random.choice(enemies).get_x() + skin.ALIEN_1.get_width() / 2, 500)
            
            enemy_projectile.follow_ship(ships[0].get_x(), ships[0].skin())
            enemy_projectile.update_shoot() 
            enemy_projectile.draw(screen)

        if enemy_projectile.colides(projectile):
            projectile.reset()
            enemy_projectile.reset()

        Enemy.check_movement(enemies)

        for enemy in enemies:
            enemy.draw(screen)
            enemy.move()
            if enemy.colides(projectile):
                enemies.remove(enemy)
                projectile.reset()

        for ship in ships:
            output = ship.get_net().activate(
                (
                    ship.get_x(),
                )
            )
            
            move_left = output[0] > 0
            move_right = output[1] > 0

            if move_left:
                ship.move(direction.LEFT)

            if move_right:
                ship.move(direction.RIGHT)

            if not ship.colides(enemy_projectile):
                ship.add_fitness(10)
            
            if not ship.move(direction.RIGHT):
                ship.add_fitness(-2)

            if enemy_projectile.get_y() <= window.HEIGHT:
                ship.reset_to_fitness()
            
            if ship.colides(enemy_projectile):
                ship.add_fitness(-20)
                ships.remove(ship)
            

            ship.draw(screen)

        result = ship.check_game_over()

        if len(ships) == 0:
                result = "LOSE"

        if result == "LOSE":
            texto = font.FONT_GRANDE.render("GAME OVER!", True, "gray56")
            sound.BACKGROUND.play(loops=0)
            sound.LOSING.play()
            screen.blit(texto, [skin.BACKGROUND.get_width() / 2 - texto.get_width() / 2, 630])
            pygame.display.update()
            pygame.time.wait(2000)
            break

        pygame.display.update()

config_file = os.path.join(os.path.dirname(__file__), 'neat-config.txt')

# Definir o que preciso das configurações (do ficheiro importado)
config = neat.config.Config(
    neat.DefaultGenome, # Importar dados da secção [DefaultGenome]
    neat.DefaultReproduction, # Importar dados da secção [DefaultReproduction]
    neat.DefaultSpeciesSet, # Importar dados da secção [DefaultSpeciesSet]
    neat.DefaultStagnation, # Importar dados da secção [DefaultStagnation]
    config_file # Local do ficheiro
)

# Definir as regras (configs) dos indivíduos
population = neat.Population(config)

# Reports de como as gerações etão a evoluir
population.add_reporter(neat.StdOutReporter(True))
stats = neat.StatisticsReporter()
population.add_reporter(stats)

winner = population.run(eval_game, 999)
print(f"O melhor genoma:\n{winner}")
