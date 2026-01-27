import pygame
from pygame.locals import *
from configs import *
from world import *
from mario import *
from direction import *
from enemy import *

import neat # importar biblioteca de IA (NeuroEvolution of Augmenting Topologies)
import os

pygame.init()
screen = pygame.display.set_mode([window.WIDTH, window.HEIGHT])
pygame.display.set_caption(window.TITLE)
gen = 0

#sound.BACKGROUND.play(loops=-1)

clock = pygame.time.Clock()

def eval_game(genomes, config):
    global gen, screen, clock

    gen += 1

    world = World()
    enemy = Enemy()
    marios = []

    for genome_id, genome in genomes:
        genome.fitness = 0
        net = neat.nn.FeedForwardNetwork.create(genome, config)
        marios.append(
            Mario(
                randint( # Nascer num X aleatório (entre 20 e o máximo do meio)
                    20,
                    int(window.WIDTH / 1.5 - skin.MARIO.get_width())
                ),
                genome,
                net
            )
        )

    while len(marios) > 0:
        dt = clock.tick(window.FPS)

        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                exit()

        #key = pygame.key.get_pressed()

        world.draw(screen)

        world.move()
        enemy.move()
        enemy.draw(screen)

        for mario in marios:
            # Tomar uma decisão com base na leitura do mundo
            output = mario.get_net().activate(
                (
                    mario.get_x(), # Leitura do mundo de x do personagem
                    mario.get_y(), # ...
                    enemy.get_x(), # ...
                    enemy.get_y(), # ...
                    enemy.get_speed_h(), # ...
                    enemy.get_speed_v() # ...
                )
            )

            move_left = output[0] > 0
            move_right = output[1] > 0
            jump = output[2] > 0

            if move_left:
                mario.move(direction.LEFT)

            if move_right:
                mario.move(direction.RIGHT)

            if jump:
                mario.jump()

            mario.update_jump()

            if mario.can_get_jump_fitness() and mario.get_x() > enemy.get_x():
                mario.suceeed_to_fitness()
                mario.add_fitness(5)

            if enemy.get_x() >= window.WIDTH:
                mario.reset_to_fitness()

            #if mario.get_x() > enemy.get_x() and jump:
            #    mario.add_fitness(-1)

            if mario.colides(enemy):
                mario.add_fitness(-10)
                marios.remove(mario)

            mario.draw(screen)


        pygame.display.update()

# Obter diretório completo do ficheiro de configs da LIB Neat

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
