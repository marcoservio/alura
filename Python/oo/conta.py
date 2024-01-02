class Conta:
    def __init__(self, numero, titular, saldo, limite):
        self._numero = numero
        self._titular = titular
        self._saldo = saldo
        self._limite = limite

    def extrato(self):
        print(f"Saldo de {self._saldo} do titular {self._titular}")

    def deposita(self, valor):
        self._saldo += valor

    def _pode_sacar(self, valor):
        valor_disponivel_para_sacar = self._saldo + self._limite
        return valor <= valor_disponivel_para_sacar

    def saca(self, valor):
        if self._pode_sacar():
            self._saldo -= valor
        else:
            print(f"O valor {valor} passou do limite")

    def transfere(self, valor, conta_destino):
        self.saca(valor)
        conta_destino.deposita(valor)

    @property
    def saldo(self):
        return self._saldo

    @property
    def titular(self):
        return self._titular

    @property
    def limite(self):
        return self._limite

    @limite.setter
    def limite(self, limite):
        self._limite = limite

    @staticmethod
    def codigo_banco():
        return "001"

    @staticmethod
    def codigos_bancos():
        return {"BB": "001", "Caixa": "104", "Bradesco": "237"}
