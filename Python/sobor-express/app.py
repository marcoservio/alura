import os


restaurantes = [
    {"nome": "Praça", "categoria": "Japonesa", "ativo": False},
    {"nome": "Pizza Suprema", "categoria": "Pizza", "ativo": True},
    {"nome": "Cantina", "categoria": "Italiano", "ativo": False},
]


def exibir_nome_programa():
    print(
        """
    ░██████╗░█████╗░██████╗░░█████╗░██████╗░  ███████╗██╗░░██╗██████╗░██████╗░███████╗░██████╗░██████╗
    ██╔════╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗  ██╔════╝╚██╗██╔╝██╔══██╗██╔══██╗██╔════╝██╔════╝██╔════╝
    ╚█████╗░███████║██████╦╝██║░░██║██████╔╝  █████╗░░░╚███╔╝░██████╔╝██████╔╝█████╗░░╚█████╗░╚█████╗░
    ░╚═══██╗██╔══██║██╔══██╗██║░░██║██╔══██╗  ██╔══╝░░░██╔██╗░██╔═══╝░██╔══██╗██╔══╝░░░╚═══██╗░╚═══██╗
    ██████╔╝██║░░██║██████╦╝╚█████╔╝██║░░██║  ███████╗██╔╝╚██╗██║░░░░░██║░░██║███████╗██████╔╝██████╔╝
    ╚═════╝░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝  ╚══════╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░░╚═╝╚══════╝╚═════╝░╚═════╝░
    """
    )


def exibir_opcoes():
    print("1. Cadastrar restaurante")
    print("2. Listar restaurante")
    print("3. Ativar restaurante")
    print("4. Sair\n")


def finalizar_app():
    exibir_subtitulo("Finalizando o app")


def voltar_menu_principal():
    input("\nDigite uma tecla para voltar ao menu principal. ")
    main()


def exibir_subtitulo(titulo):
    os.system("clear")
    print(f"{titulo}\n")


def opcao_invalida():
    print("Opção inválida!\n")
    voltar_menu_principal()


def cadastrar_novo_restaurante():
    exibir_subtitulo("Cadastro de novos restaurantes")

    nome_restaurante = input("Digite o nome do restaurante que deseja cadastrar: ")
    categoria = input(f"Digite o nome da categoria do restaurante {nome_restaurante}: ")

    dados_restaurante = {
        "nome": nome_restaurante,
        "categoria": categoria,
        "ativo": False,
    }

    restaurantes.append(dados_restaurante)

    print(f"O restaurante {nome_restaurante} foi cadastrado com sucesso")

    voltar_menu_principal()


def listar_restaurantes():
    exibir_subtitulo("Listando os restaurantes")

    for restaurante in restaurantes:
        nome_restaurant = restaurante["nome"]
        categoria = restaurante["categoria"]
        ativo = restaurante["ativo"]
        print(f"- {nome_restaurant} | {categoria} | {ativo}")

    voltar_menu_principal()


def alternar_estado_restaurante():
    exibir_subtitulo("Alternando estado do restaurante")

    nome_restaurante = input(
        "Digite o nome do restaurante que deseja alterar o estado: "
    )
    restaurante_encontrado = False

    for restaurante in restaurantes:
        if nome_restaurante == restaurante["nome"]:
            restaurante_encontrado = True
            restaurante["ativo"] = not restaurante["ativo"]
            mensagem = (
                f"O restaurante {nome_restaurante} foi ativado com sucesso"
                if restaurante["ativo"]
                else f"O restaurante {nome_restaurante} foi desativado com sucesso"
            )
            print(mensagem)

    if not restaurante_encontrado:
        print("O restaurante não foi encontrado.")

    voltar_menu_principal()


def escolher_opcao():
    try:
        opcao_escolhida = int(input("Escolha uma opção: "))
        match opcao_escolhida:
            case 1:
                cadastrar_novo_restaurante()
            case 2:
                listar_restaurantes()
            case 3:
                alternar_estado_restaurante()
            case 4:
                finalizar_app()
            case _:
                opcao_invalida()
    except:
        opcao_invalida()


def main():
    os.system("clear")
    exibir_nome_programa()
    exibir_opcoes()
    escolher_opcao()


if __name__ == "__main__":
    main()
