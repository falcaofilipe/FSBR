# FSBR
DESAFIO – CADASTRO DE PROCESSOS

OBJETIVO
Codificar uma aplicação web em C#, que deverá ser possível cadastrar, listar, editar e excluir
um processo.
O mesmo deverá ser feito utilizando .Net, Entity framework, MVC, e
1. O sistema deverá garantir a integridade das informações cadastradas.
2. A tela onde será feita a listagem dos processos deverá ter paginação.
3. Na listagem dos dados deve-se mostrar apenas o npu, a data de cadastro e a UF do
processo.
4. Ao clicar em visualizar, deverá ser exibido as demais informações do processo, sendo
possível realizar a confirmação de visualização e salvando a data e hora em que essa
confirmação foi realizada.
5. Na tela te cadastro ao selecionar a UF o sistema deverá realizar uma busca na API do
IBGE, onde deverão ser persistidas do banco de dados o nome do município
selecionado com o seu respectivo código.
A tabela deve possuir os campos abaixo:
- id
- Nome do processo
- npu ( string no formato 1111111-11.1111.1.11.1111 que só aceite números)
- Data de cadastro
- Data de visualização
- UF
- Município
TECNOLOGIAS QUE PODERÃO SER UTILIZADAS
● Utilizar um banco de dados SQL de sua preferencia
Obs.:
● Versão das tecnologias à sua escolha.
● Não será avaliado layout e sim funcionalidade. No entanto, é importante garantir o mínimo
de apresentação para que fluxo do crud seja executado sem problemas.
● Não é necessário implementar autenticação.

• ENVIO
Subir o projeto no GitHub com um documento de setup e os scripts de criação de banco de
dados e tabelas.
• Documentação da API do IBGE
https://servicodados.ibge.gov.br/api/docs/localidades

-----------------------------------------------------------------------------------------

ASP.NET CRUD MVC EF

----PACKAGES----

Microsoft.AspNet.Mvc (5.3.0)
Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore(8.0.8)
Microsoft.AspNetCore.Identity.EntityFrameworkCore(8.0.8)
Microsoft.AspNetCore.Identity.UI(8.0.8)
Microsoft.EntityFrameworkCore.SqlServer(8.0.8)
Microsoft.EntityFrameworkCore.Tools (8.0.8)
Microsoft.Visualstudio.Web.CodeGeneration.Design (8.0.5)

----SCRIPTS DATABASE----

CREATE DATABASE aspnet-desafioMVC;

CREATE TABLE [dbo].[Npus] (
    [id]               INT            IDENTITY (1, 1) NOT NULL,
    [nomeProcesso]     NVARCHAR (MAX) NOT NULL,
    [npu]              NVARCHAR (MAX) NOT NULL,
    [dataCadastro]     NVARCHAR (MAX) NOT NULL,
    [dataVisualizacao] NVARCHAR (MAX) NOT NULL,
    [uf]               NVARCHAR (MAX) NOT NULL,
    [municipio]        NVARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_Npus] PRIMARY KEY CLUSTERED ([id] ASC)
);

Obs: Não ha necessidade de criar a base de dados e tabela, basta rodar o comando Add-Migration Npus e update-database na janela Console do Gerenciador de Pacotes.

Usei Migration para criação e manutenção da base de dados. Instalando o pacote Microsoft.EntityFrameworkCore.SqlServer(8.0.8) se tem o sqlserver integrado ao visual studio.

Não prestei atenção que era pra armazenar também o código do municipio e não pude implementar a paginação.

Alguns comentários foram deixados propositalmente.


 
