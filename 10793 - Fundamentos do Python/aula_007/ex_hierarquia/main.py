from animais.gato import Gato
from animais.peixe import Peixe
from animais.passaro import Passaro

gato_maniche = Gato("Maniche", "curta")
gato_maniche.comer("o que não deve.")
gato_maniche.dormir()
gato_maniche.ronronar()

peixe_dori = Peixe("Dori", sobrevive_fora=False, tipo_agua="doce")
peixe_dori.comer("algas")
peixe_dori.dormir()
peixe_dori.nadar("doce")
peixe_dori.nadar("salgada")
peixe_dori.sair_da_agua()

passaro_radamel = Passaro("Radamel", capacidade_voar=False)
passaro_radamel.comer("sementes")
passaro_radamel.dormir()
passaro_radamel.voar("a árvore")
passaro_radamel.aprender_a_voar()
passaro_radamel.voar("a árvore")