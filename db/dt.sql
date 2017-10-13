CREATE TABLE "Noticias"(
    "Id" int NOT NULL,
    "Titulo" varchar(100) NOT NULL,
    "Conteudo" text NOT NULL,
    "DataCadastro" timestamp NOT NULL,
    "DataPublicacao" timestamp NULL,
    CONSTRAINT "PK_Noticias" PRIMARY KEY ("Id")
);

INSERT INTO "Noticias"
           ("Id"
           ,"Titulo"
           ,"Conteudo"
           ,"DataCadastro"
           ,"DataPublicacao")
     VALUES
           (1
           ,'Teste'
           ,'Conteúdo Teste'
           ,'2017-10-13 16:59'
           ,null);
