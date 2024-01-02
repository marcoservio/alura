from modelos.avaliacao import Avaliacao
from modelos.cardapio.item_cardapio import ItemCardapio


class Restaurante:
    restaurantes = []

    def __init__(self, nome, categoria):
        self._nome = nome.title()
        self.categoria = categoria.upper()
        self._ativo = False  # -> Atributo protegido não dever se mexido fora da classe
        self._avaliacoes = []
        self._cardapio = []
        Restaurante.restaurantes.append(self)

    def __str__(self):
        return f"{self._nome.ljust(25)} | {self.categoria.ljust(25)} | {str(self.media_avaliacoes).ljust(25)} | {self.ativo}"

    @classmethod
    def listar_restaurantes(cls):
        print(
            f"{'Nome Restaurante'.ljust(25)} | {'Categoria'.ljust(25)} | {'Avaliação'.ljust(25)} | {'Status'}"
        )
        for restaurante in cls.restaurantes:
            print(restaurante)

    @property
    def ativo(self):
        return "☒" if self._ativo else "☐"

    def alternar_estado(self):
        self._ativo = not self._ativo

    def receber_avaliacao(self, cliente, nota):
        if 0 < nota <= 5:
            avaliacao = Avaliacao(cliente, nota)
            self._avaliacoes.append(avaliacao)

    @property
    def media_avaliacoes(self):
        if not self._avaliacoes:
            return "-"

        soma_notas = sum(avaliacao._nota for avaliacao in self._avaliacoes)
        quantidade_notas = len(self._avaliacoes)
        media = round(soma_notas / quantidade_notas, 1)

        return media

    def adicionar_item_cardapio(self, item):
        if isinstance(item, ItemCardapio):
            self._cardapio.append(item)

    @property
    def exibir_cardapio(self):
        print(f"Cardapio do restaurante {self._nome}\n")
        for i, item in enumerate(self._cardapio, start=1):
            if hasattr(item, "_descricao"):
                mensagem_prato = f"{i}. Nome: {item._nome.ljust(25)} | Preço: R${str(item._preco).ljust(25)} | Descricao: {item._descricao}"
                print(mensagem_prato)
            elif hasattr(item, "_tipo"):
                mensagem_sobremesa = f"{i}. Nome: {item._nome.ljust(25)} | Preço: R${str(item._preco).ljust(25)} | Descricao: {item._descricao.ljust(25)} | Tipo: {item._tipo.ljust(25)} | Tamanho: {item._tamanho}"
                print(mensagem_sobremesa)
            else:
                mensagem_bebida = f"{i}. Nome: {item._nome.ljust(25)} | Preço: R${str(item._preco).ljust(25)} | Tamanho: {item._tamanho}"
                print(mensagem_bebida)


# restaurante_praca = Restaurante("praça", "Gourmet")
# restaurante_praca.alternar_estado()
# restaurante_pizza = Restaurante("pizza Express", "Italiano")

# mostra todos os atributos da classe com os valores deles
# print(vars(restaurante_praca))
# print(vars(restaurante_pizza))
# print()

# Restaurante.listar_restaurantes()
