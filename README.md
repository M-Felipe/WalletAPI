# WalletAPI

![License](https://img.shields.io/badge/license-MIT-blue.svg)

## Descrição

A **WalletAPI** é uma API RESTful desenvolvida em C# com ASP.NET Core para gerenciar carteiras digitais e transações financeiras. Ela permite que os usuários:

* se cadastrem;
* autentiquem;
* consultem saldos;
* adicionem saldo às suas carteiras;
* realizem transferências entre usuários;
* consultem o histórico de transações.

A API utiliza autenticação JWT e armazena os dados em um banco de dados MySQL.

---

## Índice

1. [Estrutura de Pastas](#estrutura-de-pastas)
2. [Requisitos](#requisitos)
3. [Configuração Inicial](#configuracao-inicial)
4. [Executando o Projeto](#executando-o-projeto)
5. [Rotas da API](#rotas-da-api)
6. [Scripts e Comandos Úteis](#scripts-e-comandos-uteis)
7. [Considerações Finais](#consideracoes-finais)

---

## Estrutura de Pastas

```
/WalletAPI
│
├── /Controllers          # Controladores da API (rotas e lógica HTTP)
├── /Data                 # Contexto do banco de dados e migrations
├── /DTOs                 # Objetos de transferência de dados (DTOs)
├── /Models               # Modelos de entidade (representação das tabelas no banco)
├── /Services             # Serviços de lógica de negócios
├── /Utils                # Utilitários (JWT, hashing, etc.)
├── appsettings.json      # Configurações da aplicação
├── WalletAPI.csproj      # Arquivo de projeto
├── Program.cs            # Ponto de entrada da aplicação
├── README.md             # Documentação do projeto
└── database.sql          # Script SQL para criar o banco de dados e populá-lo
```

---

## Requisitos

* [.NET 6 SDK ou superior](https://dotnet.microsoft.com/download/dotnet/6.0)
* [MySQL Server](https://dev.mysql.com/downloads/mysql/)
* Ferramenta para testar APIs, como [Postman](https://www.postman.com/) ou [Insomnia](https://insomnia.rest/)

---

## Observações
* A migration esta configurada para criar as tabelas necessárias.
* Optei por usar o MySQL por ja ter instalado em minha maquina.


## Configuração Inicial

### 1. Clonar o Repositório

```bash
git clone https://github.com/M-Felipe/WalletAPI.git
cd WalletAPI
```

### 2. Configurar a String de Conexão

Atualize o `appsettings.json` com os dados do seu banco e o JWT:

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=WalletDB;User=root;Password=yourpassword;"
},
"Jwt": {
  "Key": "C95E8B8D43F9A62C4F8D9A3B1C5F7D3A",
  "Issuer": "WalletAPI",
  "Audience": "WalletAPI"
},
```



### 4. Instalar as Dependências

```bash
dotnet restore
```

---

## Executando o Projeto

### 1. Executar Migrações

OBS.:já deixei uma migration pronta, mas você pode criar uma nova se preferir.

```bash
dotnet ef database update
```

### 2. Iniciar o Projeto

```bash
dotnet run
```

A API estará disponível em:

* [http://localhost:5000](http://localhost:5000)
* [https://localhost:5001](https://localhost:5001)

---

## Rotas da API

### Autenticação

**Registrar Usuário**

* `POST /api/auth/register`

```json
{
    "username": "user3",
    "password": "password123"
}
```

**Resposta:**

```json
{
    "message": "Usuario registrado com sucesso."
}
```

**Login**

* `POST /api/auth/login`

```json
{
    "username": "user3",
    "password": "password123"
}
```

**Resposta:**

```json
{
    "token": "<JWT_token>"
}
```

### Carteira

**Consultar Saldo**

* `GET /api/wallet/balance`
* Cabeçalho: `Authorization: Bearer <token>`

**Resposta:**

```json
{
    "balance": 1000.00
}
```

**Adicionar Saldo**

* `POST /api/wallet/add-balance`
* Cabeçalho: `Authorization: Bearer <token>`

```json
{
    "amount": 500.00
}
```

**Resposta:**

```json
{
    "message": "Valor adicionado com sucesso.",
    "newBalance": 1500.00
}
```

### Transações

**Realizar Transferência**

* `POST /api/transaction/transfer`
* Cabeçalho: `Authorization: Bearer <token>`

```json
{
    "ReceiverId": "user2",
    "amount": 250.00
}
```

**Resposta:**

```json
{
    "message": "Transferencia realizada com sucesso."
}
```

**Histórico de Transações**

* `GET /api/transaction/history`
* Cabeçalho: `Authorization: Bearer <token>`

**Resposta:**

```json
[
    {
        "id": 1,
        "type": "Credit",
        "amount": 500.00,
        "timestamp": "2024-05-01T10:00:00"
    },
    {
        "id": 2,
        "type": "Transfer",
        "amount": -250.00,
        "timestamp": "2024-05-02T14:30:00"
    }
]
```

---

## Scripts e Comandos Úteis

* `dotnet restore` – Restaura dependências do projeto
* `dotnet run` – Inicia o servidor
* `dotnet ef migrations add <Nome>` – Cria uma nova migration
* `dotnet ef database update` – Aplica as migrations

---

## Considerações Finais

Esta API é uma base para projetos de carteira digital para desafio de BackEnd
