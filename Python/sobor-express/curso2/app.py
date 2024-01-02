from modelos.cardapio.sobremesa import Sobremesa
from modelos.restaurante import Restaurante
from modelos.cardapio.bebida import Bebida
from modelos.cardapio.prato import Prato


restaurante_praca = Restaurante("praça", "Gourmet")
bebida_suco = Bebida("Suco de Melancia", 5.0, "grande")
bebida_suco.aplicar_desconto()
prato_paozinho = Prato("Paozinho", 2.00, "O melhor pão da cidade")
prato_paozinho.aplicar_desconto()
sobremesa = Sobremesa("Chocolate", 10.0, "Chocolate Preto", "Doce", "pequeno")
sobremesa.aplicar_desconto()
restaurante_praca.adicionar_item_cardapio(bebida_suco)
restaurante_praca.adicionar_item_cardapio(prato_paozinho)
restaurante_praca.adicionar_item_cardapio(sobremesa)


def main():
    restaurante_praca.exibir_cardapio


if __name__ == "__main__":
    main()
