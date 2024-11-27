# App de agendamento 📅

### Descrição do projeto
Este app foi feito com o intuito de *aprender mais sobre o universo .NET* e entender melhor sobre como funciona o conceito de 👉 **[Minimal API's](https://learn.microsoft.com/pt-br/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-8.0)** e como podemos estruturar um projeto dentro do .NET de forma a manter o código limpo, organizado e reutilizável.


---

### Tecnologias utizadas
[![My Skills](https://skillicons.dev/icons?i=dotnet,cs,sqlite,rider&perline=4)](https://skillicons.dev)

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

Nesse projeto estou utilizando 👉 **[Swagger](https://swagger.io/)** para documentar os endpoints e manter uma visualização clara e objetiva do que estamos construindo.

Depois que a API estiver rodando você pode acessar essa visualização através da url 👉 *http://localhost:5056/swagger/index.html*

### GET Buscar todos os colaboradores

**GET** 👉 */api/v1/employees*

> Response Examples

> 200 Response

```json
[
  {
    "id": "5b8ae3d0-a5fa-4e25-b00d-421f5b5635b8",
    "firstName": "Elenir",
    "lastName": "Teixeira da Costa",
    "email": "elenir_nails@gmail.com",
    "profession": "Manicure"
  },
  {
    "id": "50efe024-2baa-4dbe-99f3-fc6d2862c24d",
    "firstName": "Elizangela",
    "lastName": "Mendes",
    "email": "elizzhairdresser@gmail.com",
    "profession": "Cabeleireira"
  },
  {
    "id": "a0606426-7d60-461e-8800-43c1ede7a995",
    "firstName": "Kirstin",
    "lastName": "Muller",
    "email": "Golden_Trantow@hotmail.com",
    "profession": "Extencionista de Cílios"
  }
]
```

#### Responses

|HTTP Status Code |Meaning|Description|Data schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|none|Inline|

#### Responses Data Schema

### POST Criar um novo colaborador

**POST** 👉 */api/v1/employee/new*

> Body Parameters

```json
{
  "FirstName": "string",
  "LastName": "string",
  "Email": "string",
  "Profession": "string"
}
```

#### Params

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
{
  "id": "a0606426-7d60-461e-8800-43c1ede7a995",
  "firstName": "Kirstin",
  "lastName": "Muller",
  "email": "Golden_Trantow@hotmail.com",
  "profession": "Extencionista de Cílios"
}
```

#### Responses

|HTTP Status Code |Meaning|Description|Data schema|
|---|---|---|---|
|201|[Created](https://tools.ietf.org/html/rfc7231#section-6.3.2)|none|Inline|

---

<div align="center" >

   <p>Autor</p>

   <img src="https://avatars.githubusercontent.com/u/172435339?v=4" alt="autor" width="120">

   <pre>
   Eu sou Natan Oliveira 👉 Web Developer desde 2022. 

   Meu primeiro contato com tecnologia foi através do canal do grande mestre Fábio Akita, 
   onde assisti seu vídeo sobre The DEFINITIVE UBUNTU Guide for Beginning Devs e desde então 
   comecei aprender mais sobre esse universo até cair em liguagens de programação e desenvolvimento web. 
   Comecei aprendendo JavaScript, HTML, Css e depois de entrar no mercado de trabalho gostei de backend 
   onde estou até hoje com linguagens como C#, Java e Python.
   
   Sinta-se à vontade para me contatar através do Linkedin 👇
   </pre>

   [![My Skills](https://skillicons.dev/icons?i=linkedin&perline=4)](https://www.linkedin.com/in/natan-oliveira-71023822b/)

</div>

