from modelos.bytebank import Funcionario
import pytest
from pytest import mark


class TestFuncionario:
    def test_quando_idade_recebe_13_03_2000_deve_retornar_o_valor_22(self):
        entrada = "13/03/2000"
        esperado = 24

        funcionario_teste = Funcionario("Teste", entrada, 1111)
        resultado = funcionario_teste.idade()

        assert resultado == esperado

    def test_quando_sobrenome_recebe_Marco_Servio_deve_retornar_apenas_Servio(self):
        entrada = "  Marco Servio  "
        esperado = "Servio"

        marco = Funcionario(entrada, "11/11/2011", 1111)
        resultado = marco.sobrenome()

        assert resultado == esperado

    # @mark.skip
    def test_quando_decrescimo_salario_recebe_100000_deve_retornar_90000(self):
        entrada_salario = 100000
        entrada_nome = "Paulo Bragança"
        esperado = 90000

        funcionario = Funcionario(entrada_nome, "11/11/2000", entrada_salario)
        funcionario.decrescimo_salario()
        resultado = funcionario.salario

        assert resultado == esperado

    # @mark.calcular_bonus
    def test_quando_calcular_bonus_recebe_1000_deve_retornar_100(self):
        entrada = 1000
        esperado = 100

        funcionario = Funcionario("Teste", "11/11/2000", entrada)
        resultado = funcionario.calcular_bonus()

        assert resultado == esperado

    # @mark.calcular_bonus
    def test_quando_calcular_bonus_recebe_1000000_deve_retornar_exception(self):
        with pytest.raises(Exception):
            entrada = 1000000

            funcionario = Funcionario("Teste", "11/11/2000", entrada)
            resultado = funcionario.calcular_bonus()

            assert resultado

    # def test_deve_imprimir_funcionario_com_informacoes_principais(self):
    #     esperado = "Funcionario(Teste, 11/11/2011, 1111)"

    #     funcionario = Funcionario("Teste", "11/11/2011", 1111)

    #     assert str(funcionario) == esperado
