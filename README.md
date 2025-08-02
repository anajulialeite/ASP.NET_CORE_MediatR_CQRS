# ASP.NET_CORE_MediatR_CQRS

<img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" align="left" width="50" height="50"/>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dotnetcore/dotnetcore-original.svg" align="left" width="50" height="50"/>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/visualstudio/visualstudio-original.svg" align="center" width="50" height="50"/> 

Projeto criado como apoio para meu estágio, com foco em boas práticas de separação de responsabilidades e arquitetura limpa.

## Funcionalidades Implementadas

- ✅ Cadastro de produtos (`CreateProductCommand`)
- ✅ Consulta de produtos por ID (`GetProductByIdQuery`)
- ✅ Listagem de todos os produtos (`GetAllProductsQuery`)
- ✅ Atualização de produto (`UpdateProductCommand`)
- ✅ Remoção de produto (`DeleteProductCommand`)


## Tecnologias e Conceitos utilizado

- [.NET 9](https://dotnet.microsoft.com/)
- **ASP.NET Core Web API**
- [MediatR](https://github.com/jbogard/MediatR)
- Entity Framework Core (com banco em memória)
- Padrão CQRS (Commands e Queries separados)
- Swagger (para testes dos endpoints)

# 📁 Estrutura do Projeto

```bash
📂Controllers
   └── ProdutosController.cs
📂Domain
   └── Command.cs
      └── ProdutoCreateCommand.cs
      └── ProdutoDeleteCommand.cs
      └── ProdutoUpdateCommand.cs
   ├── Entity.cs
      └── Produto.cs
   └── Handler.cs
      └── ProdutoCreateCommandHandler.cs
      └── ProdutoDeleteCommandHandler.cs
      └── ProdutoUpdateCommandHandler.cs
📂EventsHandlers
   └── LogEventsHandler.cs
📂Notifications
   ├── ErroNotification.cs
   ├── ProdutoCreateNotification.cs
   ├── ProdutoDeleteNotification.cs
   └── ProdutoUpdateNotification.cs.cs
📂Repository
   ├── IRepository.cs
   └── ProdutoRepository.cs
Program.cs
Startup.cs
```

## Como Executar

Clone o repositório:

    git clone https://github.com/seu-usuario/seu-repositorio.git

Abra o projeto no Visual Studio 2022 ou superior.

Execute com F5 ou usando o terminal:

```bash

dotnet run

```

Acesse o Swagger:

    https://localhost:5001/swagger

## Testes via Swagger

  - Criar um produto
  
        POST /api/products

        {
        "name": "Notebook",
        "price": 4200
        }


  - Listar todos os produtos
``` bash
  GET /api/products
```

  - Buscar por ID
``` bash
  GET /api/products/{id}
```

  - Atualizar produto
``` bash
  PUT /api/products/{id}
```

  - Deletar produto
``` bash
  DELETE /api/products/{id}
```

## Autora

Ana Júlia de Lima Aguiar Leite

<a href="https://www.linkedin.com/in/anajulialimaleite/" style="text-decoration:none" target="_blank" rel="noopener noreferrer">
    <img src="https://img.shields.io/badge/Linkedin-%231C003F?style=for-the-badge&logo=LinkedIn&logoColor=white" alt="LinkedIn"/>
</a>

## Links Úteis

- [Artigo de como implementar o padrão Mediator usando o MediatR](https://macoratti.net/20/07/aspc_mediatr1.htm)  
- [.NET - O padrão do projeto Mediator](https://www.macoratti.net/11/06/pp_med1.htm)

## License

[![MIT License](https://img.shields.io/badge/License-MIT-%231C003F.svg)](./LICENSE)
