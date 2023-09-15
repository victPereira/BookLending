# Documentação do Projeto - Aplicativo de Empréstimo de Livros


## Visão Geral

Este é um projeto de um aplicativo web para gerenciamento de empréstimo de livros. O aplicativo é desenvolvido em ASP.NET Core e utiliza o Entity Framework Core para interagir com o banco de dados SQL Server. Ele permite aos usuários listar, criar, editar e excluir registros de empréstimos de livros.

## Habilidades Demonstradas

Neste projeto, foram demonstradas várias habilidades e conhecimentos técnicos, incluindo:

- **ASP.NET Core**: O projeto utiliza o framework ASP.NET Core para construir um aplicativo web robusto e escalável.

- **Entity Framework Core**: O Entity Framework Core é usado para mapear objetos de modelo para o banco de dados, simplificando as operações de CRUD (Create, Read, Update, Delete).

- **MVC (Model-View-Controller)**: A estrutura do projeto segue o padrão MVC, separando claramente a lógica de negócios, as visualizações e os controladores.

- **Validação de Modelos**: Foram aplicadas validações de modelos usando atributos, garantindo que os dados sejam inseridos corretamente.

- **Banco de Dados SQL Server**: O aplicativo se conecta a um banco de dados SQL Server para armazenar os registros de empréstimo de livros.

- **HTML e CSS**: As visualizações foram criadas em HTML e estilizadas usando CSS para uma interface de usuário atraente e responsiva.

- **Rotas e Controladores**: Foram definidas rotas personalizadas e controladores para manipular as diferentes ações do aplicativo.

- **Conexão com Banco de Dados**: A configuração da conexão com o banco de dados foi feita de forma segura, seguindo boas práticas de desenvolvimento.

## Estrutura do Projeto

A estrutura do projeto é organizada da seguinte forma:

- `Controllers/`: Contém os controladores MVC do aplicativo.
- `Data/`: Contém a configuração do contexto do banco de dados.
- `Models/`: Contém os modelos de dados para empréstimos de livros e erros.
- `Views/`: Contém as visualizações HTML para o aplicativo.
- `wwwroot/`: Contém arquivos estáticos, como imagens e folhas de estilo.

## Como Executar o Projeto

Siga estas etapas para configurar e executar o projeto em seu ambiente local:

1. **Requisitos Prévios**:
   - Instale o [.NET SDK](https://dotnet.microsoft.com/download).
   - Configure um servidor SQL (por exemplo, SQL Server).

2. **Configuração do Banco de Dados**:
   - Abra o arquivo `appsettings.json` no projeto e configure a conexão com o banco de dados:
     ```json
     "ConnectionStrings": {
         "DefaultConnection": "YourConnectionStringHere"
     }
     ```
   - No terminal, navegue até a pasta raiz do projeto e execute as migrações para criar o banco de dados:
     ```
     dotnet ef database update
     ```

3. **Executando o Aplicativo**:
   - No terminal, na pasta raiz do projeto, execute o seguinte comando para iniciar o aplicativo:
     ```
     dotnet run
     ```
   - O aplicativo estará disponível em `https://localhost:5001` (ou `http://localhost:5000`).

## Funcionalidades

O aplicativo oferece as seguintes funcionalidades:

- **Listar Empréstimos de Livros**: Visualize uma lista de todos os empréstimos de livros.

- **Registrar Novo Empréstimo**: Adicione um novo empréstimo de livro com informações de receptor, fornecedor e livro.

- **Editar Empréstimo Existente**: Atualize informações de um empréstimo de livro existente.

- **Excluir Empréstimo**: Remova um empréstimo de livro da lista.

## Contribuição

Este projeto é de código aberto, e você é incentivado a contribuir. Aqui estão algumas maneiras de contribuir:

- Reportar problemas (issues): Se você encontrar algum bug ou problema, crie uma issue no repositório.

- Enviar Pull Requests: Se você tem melhorias ou correções para propor, sinta-se à vontade para enviar um pull request.


**Feito por:** [Victor Pereira](https://github.com/victPereira)

