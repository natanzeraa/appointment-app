> 🚧 _Em andamento_ 🚧


# App de agendamento 📅

### Descrição do projeto
Este app foi feito com o intuito de *aprender mais sobre o universo .NET* e entender melhor sobre como funciona o conceito de 👉 **[Minimal API's](https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-8.0)** e como podemos estruturar um projeto dentro do .NET de forma a manter o código limpo, organizado e reutilizável.


---

### Tecnologias utizadas
[![My Skills](https://skillicons.dev/icons?i=dotnet,cs,sqlite,visualstudio&perline=4)](https://skillicons.dev)


### Estrutura do projeto

```
appointment-app
│   .gitignore
│   app.db
│   app.db-shm
│   app.db-wal
│   AppointmentApplication.csproj
│   AppointmentApplication.csproj.user
│   AppointmentApplication.sln
│   appsettings.Development.json
│   appsettings.json
│   Program.cs
├───bin
├───Data
├───Extensions
├───Migrations
├───Models
├───obj
├───Properties
├───Routes
└───ViewModels
```

---

### Rodando o projeto localmente
Para rodar esse projeto localmente é muito simples, mas você vai precisar ter 👉 **[SDK do .NET 9](https://dotnet.microsoft.com/en-us/download)** instalado no seu computador.

1. Clone o projeto na sua máquina
    ```
    git clone https://github.com/natanzeraa/appointment-app.git
    ```
2. Feito isso acesse a pasta do projeto
    ```
   cd appointment-app
   ```
3. É sempre bom rodar os dois comandos abaixo para limpar e buidal o projeto novamente antes de rodar
    ```
   dotnet clean
   
   dotnet build
   ```
4. Agora basta rodar o projeto
    ```
   dotnet watch run
   ```
---

### Endpoints

Nesse projeto estou utilizando 👉 **[Swagger](https://swagger.io/)** para documentar os endpoints e manter uma visualização clara e objetiva do que estou construindo. 

Além disso comecei a utilizar recentemente o 👉 **[APIDog](https://apidog.com/)** para documentar minhas API's e manter um fluxo de desenvolvimento consistente entre Backend e Frontend. Nele é possível "mockar" dados e manter o trabalho constante em ambos os lados mesmo quando não temos um determinado endpoint em pleno funcionamento ainda, além de que temos uma visualização clara e objetiva dos dados de entrada e saída que cada endpoint vai receber e assim poder seguir a "regra de negócio" do backend. Recomendo muito essa ferramenta 😎

Mas seguindo aqui nossa configuração de ambiente 👇

Depois que a API estiver rodando você pode acessar essa visualização através da url 👉 *http://localhost:5056/swagger/index.html*

####

**_Agora confere logo aqui abaixo todos os endpoints da aplicação com as especificações de entrada e saída de dados 👇_**

####

---

<details>
  <summary>Colaboradores</summary>

  ## GET Buscar todos os colaboradores

  GET /employee/test

  > Response Examples

  > 200 Response

  ```json
  [
    {
      "id": "string",
      "firstName": "string",
      "lastName": "string",
      "email": "string",
      "profession": "string"
    }
  ]
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» firstName|string|true|none||firstName|
  |» lastName|string|true|none||lastName|
  |» email|string|true|none||email|
  |» profession|string|true|none||profession|

  ## GET Buscar um colaborador

  GET /api/v1/employee/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "firstName": "string",
    "lastName": "string",
    "email": "string",
    "profession": "string"
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» firstName|string|true|none||firstName|
  |» lastName|string|true|none||lastName|
  |» email|string|true|none||email|
  |» profession|string|true|none||profession|

  ## PUT Atualizar um colaborador

  PUT /api/v1/employee/{id}

  > Body Parameters

  ```json
  {
    "FirstName": "string",
    "LastName": "string",
    "Email": "string",
    "Profession": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|
  |body|body|object| no |none|
  |» FirstName|body|string| yes |none|
  |» LastName|body|string| yes |none|
  |» Email|body|string| yes |none|
  |» Profession|body|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {}
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  ## DELETE Deletar um colaborador

  DELETE /api/v1/employee/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 204 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|none|string|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  ## POST Criar um novo colaborador

  POST /api/v1/employee/new

  > Body Parameters

  ```json
  {
    "FirstName": "string",
    "LastName": "string",
    "Email": "string",
    "Profession": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |body|body|object| no |none|
  |» FirstName|body|string| yes |none|
  |» LastName|body|string| yes |none|
  |» Email|body|string| yes |none|
  |» Profession|body|string| yes |none|

  > Response Examples

  > 201 Response

  ```json
  {}
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|none|Inline|
</details>


---

<details>
  <summary>Clientes</summary>

  ## GET Buscar todos os clientes

  GET /api/v1/costumer

  > Response Examples

  > 200 Response

  ```json
  [
    {
      "id": "string",
      "name": "string",
      "phoneNumber": "string"
    }
  ]
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» phoneNumber|string|true|none||phoneNumber|

  ## GET Buscar um cliente

  GET /api/v1/costumer/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "phoneNumber": "string"
  }
  ```

  > 404 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» phoneNumber|string|true|none||phoneNumber|

  ## PUT Atualizar um cliente

  PUT /api/v1/costumer/{id}

  > Body Parameters

  ```json
  {
    "name": "string",
    "phoneNumber": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|
  |body|body|object| no |none|
  |» name|body|string| yes |name|
  |» phoneNumber|body|string| yes |phoneNumber|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "phoneNumber": "string"
  }
  ```

  > 404 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» phoneNumber|string|true|none||phoneNumber|

  ## DELETE Deletar um cliente

  DELETE /api/v1/costumer/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 204 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|none|null|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  ## POST Criar um novo cliente

  POST /api/v1/costumer/new

  > Body Parameters

  ```json
  {
    "name": "string",
    "phoneNumber": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |body|body|object| no |none|
  |» name|body|string| yes |name|
  |» phoneNumber|body|string| yes |phoneNumber|

  > Response Examples

  > 201 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "phoneNumber": "string"
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **201**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» phoneNumber|string|true|none||phoneNumber|
</details>

---

<details>
  <summary>Serviços</summary>
  
  ## GET Buscar todos os serviços

  GET /api/v1/service

  > Response Examples

  > 200 Response

  ```json
  [
    {
      "id": "string",
      "name": "string",
      "description": "string",
      "price": 0
    }
  ]
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» description|string|true|none||description|
  |» price|number|true|none||price|

  ## POST Criar um novo serviço

  POST /api/v1/service/new

  > Body Parameters

  ```json
  {
    "name": "string",
    "description": "string",
    "price": 0
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |body|body|object| no |none|
  |» name|body|string| yes |name|
  |» description|body|string| yes |description|
  |» price|body|number| yes |price|

  > Response Examples

  > 201 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "price": 0
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **201**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» description|string|true|none||description|
  |» price|number|true|none||price|

  ## GET Buscar um serviço

  GET /api/v1/service/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "price": 0
  }
  ```

  > 404 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» description|string|true|none||description|
  |» price|number|true|none||price|

  ## PUT Atualizar um serviço

  PUT /api/v1/service/{id}

  > Body Parameters

  ```json
  {
    "name": "string",
    "description": "string",
    "price": 0
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|
  |body|body|object| no |none|
  |» name|body|string| yes |name|
  |» description|body|string| yes |description|
  |» price|body|number| yes |price|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "name": "string",
    "description": "string",
    "price": 0
  }
  ```

  > 404 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» name|string|true|none||name|
  |» description|string|true|none||description|
  |» price|number|true|none||price|

  ## DELETE Deletar um serviço

  DELETE /api/v1/service/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 204 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|none|null|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|
</details>

---

<details>
  <summary>Agendamentos</summary>

  ## GET Buscar todos os agendamentos

  GET /api/v1/appointment

  > Response Examples

  > 200 Response

  ```json
  [
    {
      "start": "string",
      "end": "string",
      "employee": {
        "name": "string",
        "email": "string",
        "profession": "string"
      },
      "service": {
        "name": "string",
        "description": "string",
        "price": 0
      },
      "costumer": {
        "name": "string",
        "phoneNumber": "string"
      }
    }
  ]
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» start|string|false|none||name|
  |» end|string|false|none||description|
  |» employee|object|false|none||none|
  |»» name|string|true|none||none|
  |»» email|string|true|none||none|
  |»» profession|string|true|none||none|
  |» service|object|false|none||none|
  |»» name|string|true|none||none|
  |»» description|string|true|none||none|
  |»» price|integer|true|none||none|
  |» costumer|object|false|none||none|
  |»» name|string|true|none||none|
  |»» phoneNumber|string|true|none||none|

  ## GET Buscar um agendamento

  GET /api/v1/appointment/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "start": "string",
    "end": "string",
    "employee": {
      "name": "string",
      "email": "string",
      "profession": "string"
    },
    "service": {
      "name": "string",
      "description": "string",
      "price": 0
    },
    "costumer": {
      "name": "string",
      "phoneNumber": "string"
    }
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» start|string|true|none||none|
  |» end|string|true|none||none|
  |» employee|object|true|none||none|
  |»» name|string|true|none||none|
  |»» email|string|true|none||none|
  |»» profession|string|true|none||none|
  |» service|object|true|none||none|
  |»» name|string|true|none||none|
  |»» description|string|true|none||none|
  |»» price|integer|true|none||none|
  |» costumer|object|true|none||none|
  |»» name|string|true|none||none|
  |»» phoneNumber|string|true|none||none|

  ## DELETE Remover um agendamento

  DELETE /api/v1/appointment/{id}

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|

  > Response Examples

  > 204 Response

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |204|[No Content](https://tools.ietf.org/html/rfc7231#section-6.3.5)|none|Inline|
  |404|[Not Found](https://tools.ietf.org/html/rfc7231#section-6.5.4)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **204**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» start|string|true|none||none|
  |» end|string|true|none||none|
  |» employeeId|string|true|none||none|
  |» costumerId|string|true|none||none|
  |» serviceId|string|true|none||none|

  ## POST Criar um novo agendamento

  POST /api/v1/appointment/new

  > Body Parameters

  ```json
  {
    "start": "string",
    "end": "string",
    "employeeId": "string",
    "costumerId": "string",
    "serviceId": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |body|body|object| no |none|
  |» start|body|string| yes |none|
  |» end|body|string| yes |none|
  |» employeeId|body|string| yes |none|
  |» costumerId|body|string| yes |none|
  |» serviceId|body|string| yes |none|

  > Response Examples

  > 201 Response

  ```json
  {
    "id": "string",
    "start": "string",
    "end": "string",
    "service": "string",
    "price": 0,
    "employee": "string",
    "costumer": "string"
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **201**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» start|string|true|none||none|
  |» end|string|true|none||none|
  |» service|string|true|none||none|
  |» price|integer|true|none||none|
  |» employee|string|true|none||none|
  |» costumer|string|true|none||none|

  ## PUT Editar um agendamento

  PUT /api/v1/appointment{id}

  > Body Parameters

  ```json
  {
    "start": "string",
    "end": "string",
    "employeeId": "string",
    "costumerId": "string",
    "serviceId": "string"
  }
  ```

  ### Params

  |Name|Location|Type|Required|Description|
  |---|---|---|---|---|
  |id|path|string| yes |none|
  |body|body|object| no |none|
  |» start|body|string| yes |none|
  |» end|body|string| yes |none|
  |» employeeId|body|string| yes |none|
  |» costumerId|body|string| yes |none|
  |» serviceId|body|string| yes |none|

  > Response Examples

  > 200 Response

  ```json
  {
    "id": "string",
    "start": "string",
    "end": "string",
    "employeeId": "string",
    "costumerId": "string",
    "serviceId": "string"
  }
  ```

  ### Responses

  |HTTP Status Code |Meaning|Description|Data schema|
  |---|---|---|---|
  |200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

  ### Responses Data Schema

  HTTP Status Code **200**

  |Name|Type|Required|Restrictions|Title|description|
  |---|---|---|---|---|---|
  |» id|string|true|none||ID|
  |» start|string|true|none||none|
  |» end|string|true|none||none|
  |» employeeId|string|true|none||none|
  |» costumerId|string|true|none||none|
  |» serviceId|string|true|none||none|
</details>

---

<div align="center" >

   <h4>Quem sou eu</h4>

   <img src="https://avatars.githubusercontent.com/u/172435339?v=4" alt="autor" width="120">

   <div align="center" >
      <br>
      <p>Eu sou Natan Oliveira 👉 Web Developer desde 2022.</p>
      <p>Meu primeiro contato com tecnologia foi através do canal do grande mestre Fábio Akita,</br> 
      onde assisti seu vídeo sobre The DEFINITIVE UBUNTU Guide for Beginning Devs e desde então </br> 
      comecei aprender mais sobre esse universo até cair em liguagens de programação e desenvolvimento web. </br> 
      Comecei aprendendo JavaScript, HTML, Css e depois de entrar no mercado de trabalho gostei de backend </br> 
      onde estou até hoje com linguagens como C#, Java e Python.</p>
      <h4>Sinta-se à vontade para me contatar através do Linkedin 👇</h4>
   </div>

   [![My Skills](https://skillicons.dev/icons?i=linkedin&perline=4)](https://www.linkedin.com/in/natan-oliveira-71023822b/)

</div>

---

