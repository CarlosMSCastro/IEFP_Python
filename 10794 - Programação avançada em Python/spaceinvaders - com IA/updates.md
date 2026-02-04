1) Limitar tiro dos inimigos em y           ✅

2) Limpar Main                              ✅

3) Corrigir colisao projectile.Enemy        ✅

4) Condição de WIN quando lista vazia       ✅

5) Machine Learning (kkkkk)

6) Colisao Tiro com Tiro                    ✅

ATUALIZAÇÕES:

1) Add o metodo check_movement na classe Enemy usando @classmethod ja que como eu havia previsto o as declaraçoes dos limites nao poderiam ser feitas para cada alien no ciclo "for".

Busquei ajuda no chat gpt nao com o codigo em si, mas em entender o porque nao funcionava, a resposta do chat foi que eu tinha um codigo individual mas o pensamento "global", entao entendi que precisava tirar do "for" e fazer um metodo que movesse a lista enemies. Por tentativa e erro cheguei ao @classmethod e usei manipulaçao de listas, minha proxima ideia era fazer o metodo direto no main fora do ciclo while.

Nao entendi o porque da erro ao usar:

    if min(x_pos_aliens) <= 208:
        # min(x_pos_aliens) = 208 <----------------
        Enemy.speed = abs(Enemy.speed)


2) Add colisao entre os projectiles no main.

3) Apaguei o ficheiro projectileEnemy.py

