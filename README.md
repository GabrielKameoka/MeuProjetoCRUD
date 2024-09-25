# MeuProjetoCRUD - Sistema CRUD de Contatos 

### Descrição

Este projeto é um sistema CRUD (Create, Read, Update, Delete) básico para gerenciar contatos. Ele permite cadastrar, buscar, atualizar e deletar contatos armazenados em um banco de dados SQL Server.

### Tecnologias Utilizadas

Front-end: Não há utilização de ferramentas front-end neste projeto!!!

Back-end: ASP.NET Core (.NET 8)

Banco de dados: Microsoft SQL Server

Entity Framework Core: ORM (Object Relational Mapper) para mapeamento entre objetos e tabelas do banco de dados.


### Pré-requisitos


.NET 8(ou a versão mais recente) SDK instalado (verifique em https://dotnet.microsoft.com/download)
SQL Server Express (ou outra versão do SQL Server) instalado (opcional para desenvolvimento local)

### Instalação

1. Clone o seu repositório:

```
git clone https://github.com/GabrielKameoka/MeuProjetoCRUD
```

2. Restaure as dependências do projeto:

```
cd MeuProjetoCRUD
dotnet restore
```

### Configuração

1. Abra o arquivo appsettings.Development.json e modifique a string de conexão "ConexaoPadrao" para apontar para a sua instância do SQL Server.

2. (Opcional) Configure o front-end para consumir a API em http://localhost:5000 (porta padrão do ASP.NET Core).

### Executando a aplicação

1. Abra o terminal/prompt de comando e navegue até a pasta do projeto (MeuProjetoCRUD).

2. Execute o comendo:
```
dotnet run
```

3. A aplicação será iniciada e acessível em http://localhost:5000 (por padrão).

### Contribuição

Contribuindo

Sinta-se livre para contribuir com o projeto! Você pode reportar bugs, sugerir melhorias ou enviar pull requests. Para isso, siga os guidelines do GitHub: https://guides.github.com/
