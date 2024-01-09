from datetime import datetime, timedelta


class Datas:
    def __init__(self):
        self.momento_cadastro = datetime.today()

    def __str__(self):
        return self.format_data()

    def mes_cadastro(self):
        meses_do_ano = [
            "janeiro",
            "fevereiro",
            "março",
            "abril",
            "maio",
            "junho",
            "julho",
            "agosto",
            "setembro",
            "outubro",
            "novembro",
            "dezembro",
        ]
        mes_cadastro = self.momento_cadastro.month
        return meses_do_ano[mes_cadastro - 1].title()

    def dia_semana(self):
        dias_semana = [
            "segunda",
            "terça",
            "quarta",
            "quinta",
            "sexta",
            "sabado",
            "domingo",
        ]
        dia_semana = self.momento_cadastro.weekday()
        return dias_semana[dia_semana].title()

    def format_data(self):
        return self.momento_cadastro.strftime("%d/%m/%Y %H:%M:%S")

    def tempo_cadastro(self):
        return (datetime.today() + timedelta(days=30)) - self.momento_cadastro
