from configs import *
from random import randint, choice

class Cloud:
    def __init__(self, x, y):
        self.__x = x
        self.__y = y
        self.__skin = choice(skin.CLOUDS)
        self.__speed = randint(2, 10)

    @classmethod
    def generate_group(cls, quantity):
        clouds = []
        x_position = window.WIDTH + 20

        for x in range(quantity):
            clouds.append(
                Cloud(
                    x_position,
                    randint(0, 440)
                )
            )
            x_position += randint(100, 300)

        return clouds

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])
    
    def move(self):
        self.__x -= self.__speed

        if self.__x < - self.__skin.get_width():
            self.__x = window.WIDTH + randint(200, 600)
            self.__y = randint(0, 440)
            self.__speed = randint(2, 10)
            self.__skin = choice(skin.CLOUDS)


class Wood:
    def __init__(self, x):
        self.__x = x
        self.__skin = choice(skin.WOODS)
        self.__y = general.GROUND_LOCATION - self.__skin.get_height()
        self.__speed = 3

    @classmethod
    def generate_group(cls, quantity):
        woods = []
        x_position = window.WIDTH + 20

        for x in range(quantity):
            woods.append(
                Wood(x_position)
            )
            x_position += randint(50, 600)

        return woods

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, self.__y])
    
    def move(self):
        self.__x -= World.speed

        if self.__x < - self.__skin.get_width():
            self.__x = window.WIDTH + randint(100, 500)
            self.__skin = choice(skin.WOODS)
            self.__y = general.GROUND_LOCATION - self.__skin.get_height()


class Ground:
    def __init__(self):
        self.__skin = skin.GROUND
        self.__x = 0

    def draw(self, screen):
        screen.blit(self.__skin, [self.__x, general.GROUND_LOCATION])
        screen.blit(self.__skin, [self.__x + self.__skin.get_width(), general.GROUND_LOCATION])
        screen.blit(self.__skin, [self.__x + 2 * self.__skin.get_width(), general.GROUND_LOCATION])

    def move(self):
        self.__x -= World.speed

        if self.__x < -self.__skin.get_width():
            self.__x = 0
            print("Reposto")


class World:
    speed = 3

    def __init__(self):
        self.__x = 0
        self.__clouds = Cloud.generate_group(4)
        self.__woods = Wood.generate_group(10)
        self.__ground = Ground()
        self.__sky_skin = skin.SKY

    def draw(self, screen):
        screen.blit(self.__sky_skin, [0, 0])
        
        for cloud in self.__clouds:
            cloud.draw(screen)

        for wood in self.__woods:
            wood.draw(screen)

        self.__ground.draw(screen)
    
    def move(self):
        for cloud in self.__clouds:
            cloud.move()
        
        for wood in self.__woods:
            wood.move()

        self.__ground.move()


