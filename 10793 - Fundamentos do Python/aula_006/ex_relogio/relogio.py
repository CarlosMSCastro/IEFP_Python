from erros_relogio import (
  ErroHoraInvalida,
  ErroMinutoInvalido,
  ErroSegundoInvalido,
  ErroAlarmeHoraInvalida,
  ErroAlarmeMinutoInvalido
)

class Relogio:
  def __init__(self):
    self.__horas = 0
    self.__minutos = 0
    self.__segundos = 0
    self.__alarme_ligado = False
    self.__alarme_horas = 0
    self.__alarme_minutos = 0

    if not (0 <= self.__horas <= 23):
      raise ErroHoraInvalida("Horas devem estar entre 0 e 23.")

    if not (0 <= self.__minutos <= 59):
      raise ErroMinutoInvalido("Minutos devem estar entre 0 e 59.")

    if not (0 <= self.__segundos <= 59):
      raise ErroSegundoInvalido("Segundos devem estar entre 0 e 59.")

    if not (0 <= self.__alarme_horas <= 23):
      raise ErroAlarmeHoraInvalida("Horas do alarme devem estar entre 0 e 23.")

    if not (0 <= self.__alarme_minutos <= 59):
      raise ErroAlarmeMinutoInvalido("Minutos do alarme devem estar entre 0 e 59.")
    
  def definir_horas(self, h, m):
    if not (0 <= h <= 23):
      raise ErroHoraInvalida("Horas devem estar entre 0 e 23.")

    if not (0 <= m <= 59):
      raise ErroMinutoInvalido("Minutos devem estar entre 0 e 59.")

    self.__horas = h
    self.__minutos = m
    self.__segundos = 0 
    self.__alarme_ligado = False
    self.__alarme_horas = 0
    self.__alarme_minutos = 0

  def definir_alarme(self, h, m):
    if not (0 <= h <= 23):
      raise ErroAlarmeHoraInvalida("Horas do alarme devem estar entre 0 e 23.")

    if not (0 <= m <= 59):
      raise ErroAlarmeMinutoInvalido("Minutos do alarme devem estar entre 0 e 59.")

    self.__alarme_horas = h
    self.__alarme_minutos = m

  def ligar_alarme(self):
    self.__alarme_ligado = True

  def desligar_alarme(self):
    self.__alarme_ligado = False

  def tick(self):
    self.__segundos += 1

    if self.__segundos == 60:
      self.__segundos = 0
      self.__minutos += 1

    if self.__minutos == 60:
      self.__minutos = 0
      self.__horas += 1

    if self.__horas == 24:
      self.__horas = 0

    if (self.__alarme_ligado and self.__horas == self.__alarme_horas and self.__minutos == self.__alarme_minutos and self.__segundos == 0):
      print("Ti-ti-ti")

  def mostrar_horas(self):
    if self.__horas < 10:
      h = "0" + str(self.__horas)
    else:
      h = str(self.__horas)

    if self.__minutos < 10:
      m = "0" + str(self.__minutos)
    else:
      m = str(self.__minutos)

    if self.__segundos < 10:
      s = "0" + str(self.__segundos)
    else:
      s = str(self.__segundos)

    print(f"{h}:{m}:{s}")

  def mostrar_horas_ampm(self):
    hora_convertida = self.__horas

    if hora_convertida == 0:
      periodo = "AM"
      hora_convertida = 12
    elif 1 <= hora_convertida < 12:
      periodo = "AM"
    elif hora_convertida == 12:
      periodo = "PM"
    else:
      periodo = "PM"
      hora_convertida -= 12

    if hora_convertida < 10:
      h = "0" + str(hora_convertida)
    else:
      h = str(hora_convertida)

    if self.__minutos < 10:
      m = "0" + str(self.__minutos)
    else:
      m = str(self.__minutos)

    if self.__segundos < 10:
      s = "0" + str(self.__segundos)
    else:
      s = str(self.__segundos)

    print(f"{h}:{m}:{s} {periodo}")
