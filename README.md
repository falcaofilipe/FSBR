# FSBR
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

Obs: Não ha necessidade de criar a base de dados e tabela, basta rodar o comando Add-Migration Npus e update-database no janela Console do Gerenciador de Pacotes.

Usei Migration para criação e manutenção da base de dados. Instalando o pacote Microsoft.EntityFrameworkCore.SqlServer(8.0.8) se tem o sqlserver integrado ao visual studio.

Não prestei atenção que era pra armazenar também o código do municipio e não pude implementar a paginação.

Alguns comentários foram deixados propositalmente.


 
