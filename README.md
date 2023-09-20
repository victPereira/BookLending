# Aplicativo de Empréstimo de Livros

## Visão Geral

Este é um aplicativo web para gerenciamento de empréstimo de livros, desenvolvido em ASP.NET Core. O aplicativo permite que os usuários registrem empréstimos de livros, atualizem informações existentes, excluam registros e exportem os dados para um arquivo Excel.

## Recursos Principais

- Listagem de empréstimos de livros.
- Registro de novos empréstimos com informações do receptor, fornecedor e livro.
- Atualização de empréstimos existentes (exceto a data de empréstimo e o ID).
- Exclusão de empréstimos.
- Exportação de dados para um arquivo Excel.

## Como Executar o Projeto

Para executar o projeto em seu ambiente local, siga estas etapas:

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

## Exportando para Excel

Você pode exportar os dados da tabela de empréstimos de livros para um arquivo Excel. Para fazer isso, siga estas etapas:

1. Acesse o aplicativo em seu navegador.
2. Clique no botão "Export" na interface do usuário.
3. Isso fará o download de um arquivo Excel chamado "LendingBook.xls", que conterá todos os dados da tabela de empréstimos de livros.

## Atualização de Dados

Ao atualizar os dados de um empréstimo de livro, observe que a data de empréstimo e o ID não são atualizados automaticamente. A data de empréstimo permanecerá a mesma que estava originalmente no registro.

## Contribuição

Este projeto é de código aberto, e você é incentivado a contribuir. Aqui estão algumas maneiras de contribuir:

- Reportar problemas (issues): Se você encontrar algum bug ou problema, crie uma issue no repositório.

- Enviar Pull Requests: Se você tem melhorias ou correções para propor, sinta-se à vontade para enviar um pull request.


**Feito por:** [Victor V. Pereira]([https://github.com/seu-usuario-github](https://github.com/victPereira))

Se você tiver alguma dúvida ou precisar de mais informações, sinta-se à vontade para entrar em contato através do GitHub ou do meu e-mail: vict.torpereira@hotmail.com

Este projeto demonstra minhas habilidades em desenvolvimento web com ASP.NET Core, banco de dados SQL Server e exportação de dados para Excel. Obrigado por revisar esta documentação e o projeto em si.
