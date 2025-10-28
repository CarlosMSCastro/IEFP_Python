import datetime

print("--- Calculadora da idade---")
ano = int(input("\nInsira o seu ano de nascimento: "))
ano_atual = datetime.datetime.now().year
print(f"\nSe já fez anos este ano, tem { ano_atual - ano }. Se ainda não fez, imagine que idade terá.")

