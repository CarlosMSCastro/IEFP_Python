from relogio import Relogio

try:
    rel = Relogio()
    print("Relógio iniciado com sucesso.")
except Exception as ex:
    print(f"Ocorreu um erro: {ex}")




rel.mostrar_horas()
rel.tick()
rel.mostrar_horas()
rel.tick()
rel.mostrar_horas()
rel.tick()  
rel.mostrar_horas()


rel.mostrar_horas_ampm()