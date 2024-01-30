from openai import OpenAI
from dotenv import load_dotenv
import os

load_dotenv()
cliente = OpenAI(api_key=os.getenv("OPENAI_API_KEY"))

resposta = cliente.chat.completions.create(
    messages=[
        {
            "role": "system",
            "content": "Listar apenso os nomes dos produtos sem considerar as descições",
        },
        {"role": "user", "content": "Liste 3 produtos sustentaveis"},
    ],
    model="gpt-4",
)

print(resposta.choices[0].message.content)
