1) projectileEnemy.py tinha classe Projectile -> alterado para ProjectileEnemy.

2) adicionado no main antes do while
    enemy_projectiles = []     # Lista de enimigos
    last_enemy_shot_time = pygame.time.get_ticks()  # guarda o tempo do último disparo
    enemy_shoot_interval = 2000  # 2 segundos

3) enemy fica com import random apenas, e chamamos "random.choice"

4) adicionei if current_time no main para disparar novo projetile a cada 2 segundos

5) adicionei um novo for para dar draw a cada projetil