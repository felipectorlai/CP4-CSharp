# cp4

# Projeto API de Taxa de Câmbio

Este projeto é uma API para conversão de moedas que utiliza taxas de câmbio fornecidas por um serviço externo. Desenvolvido em ASP.NET Core, a aplicação demonstra o uso de 'IOptions<T>' para gerenciar configurações a partir do arquivo 'appsettings.json'.

# Sumário

- [Tecnologias]
- [Pré-requisitos]
- [Instalação]
- [Configuração]
- [Execução]
- [Uso]
- [Estrutura do Projeto]()
- [Contribuição]
- [Licença]

# Tecnologias

Este projeto utiliza as seguintes tecnologias:

- .NET 7
- ASP.NET Core Web API
- `System.Text.Json` para serialização/deserialização de JSON
- `IOptions<T>` para gerenciamento de configurações
- Swagger para documentação de API

# Pré-requisitos

Ferramentas instaladas:

- [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK 7](https://dotnet.microsoft.com/download/dotnet/7.0)

# Instalação

1. Clone o repositório para seu ambiente local:

   bash
   git clone https://github.com/seu-usuario/seu-repositorio.git

   A - Navegue até o diretório do projeto:
   cd seu-repositorio

   B - Restaure as dependências do projeto:
   dotnet restore

# Configuração

1 - No arquivo appsettings.json, configure a URL da API de taxa de câmbio, conforme mostrado abaixo:

{
  "ExchangeRateApi": {
    "BaseUrl": "https://v6.exchangerate-api.com/v6/YOUR_API_KEY/latest/USD"
  }
}

2 - A classe ExchangeRateApiSettings mapeia essa configuração, e o serviço ExchangeRateService utiliza IOptions<ExchangeRateApiSettings> para capturar e usar a URL configurada.

# Execução

1 - Para iniciar a aplicação, utilize o seguinte comando:
dotnet run

2 - A API estará disponível em http://localhost:5002 e https://localhost:5003. Para acessar a documentação do Swagger, navegue até:
http://localhost:5002/swagger/index.html

# Uso

  Endpoints Disponíveis
  GET /api/exchange/usd-to-brl
  Retorna a taxa de câmbio atual de USD para BRL.

  {
    "USD_To_BRL": 5.13
  }

# Estrutura do Projeto

. Controllers: Controladores da API.
. Interfaces: Interfaces para abstrações de serviços.
. Services: Serviços que implementam a lógica de negócios.
. Models: Classes de modelo para deserialização de JSON e outras estruturas de dados.

# Contribuição

Contribuições são bem-vindas! Para contribuir, siga estas etapas:

  . Faça um fork do projeto.
  . Crie uma nova branch (git checkout -b feature/nova-feature).
  . Commit suas alterações (git commit -m 'Adiciona nova feature').
  . Faça um push para a branch (git push origin feature/nova-feature).
  . Abra um Pull Request.

# Licença

Este projeto está licenciado sob a MIT License.
