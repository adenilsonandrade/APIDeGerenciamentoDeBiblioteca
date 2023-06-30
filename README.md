# APIDeGerenciamentoDeBiblioteca

WebAPI em C# utilizando o padrão RESTful, cada controller é responsável por tratar as operações CRUD relacionadas a uma entidade específica.

Funções

GET - Busca todos ou por Id Livros, Autores e Usuários

POST - Adicione qualquer entidade

PUT - Edita qualquer entidade por Id

DELETE - Remove qualquer entidade por Id

# Clonar repositorio
# Restaurar dotnet
# Executar migrações
    dotnet ef migrations add InitialCreate
# Atualizar o banco de dados
    dotnet ef database update
# Executar aplicação
    dotnet run

# Executando esta WebAPI

Teste a API usando Postman ou Swagger

http://localhost:5091/api/{entidade}

http://localhost:5091/Swagger/index.html

Referência da API

# Obter autores

    GET /api/autores/


{

  "data": [

    {

      "id": 1,

      "nome": "string",

      "livros": []

    }

  ]

}

POST Autor

    POST /api/autor/

{

  "nome": "string",

  "livros": [

    {

      "titulo": "string",

      "isbn": "string"

    }

  ]

}

# Obter livros

    GET /api/livro/

{

  "data": [

    {

      "id": 1,

      "titulo": "string",

      "isbn": "string",

      "autores": []

    }

  ]

}

POST livro

    POST /API/livros/

{

  "titulo": "string",

  "isbn": "string"

}


# Obter usuários
    GET /api/usuario/

{

  "data": [

    {

      "id": 1,

      "nome": "string",

      "livros": []

    }

  ]

}

POST livro

    POST /API/usuario/

{

  "nome": "string"

}
