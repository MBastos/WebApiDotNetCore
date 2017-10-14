CREATE SEQUENCE noticias_seq START 1;
CREATE TABLE IF NOT EXISTS "Noticias" (
    "Id" integer PRIMARY KEY default nextval('noticias_seq'),
    "Titulo" varchar(100) NOT NULL,
    "Conteudo" text NOT NULL,
    "DataCadastro" timestamp NOT NULL,
    "DataPublicacao" timestamp NULL
);

INSERT INTO "Noticias"
(   
    "Titulo",
    "Conteudo",
    "DataCadastro",
    "DataPublicacao"
)
VALUES
(
    'Teste',
    'Conteúdo Teste',
    '2017-10-13 16:59',
    null
);

INSERT INTO "Noticias"
(   
    "Titulo",
    "Conteudo",
    "DataCadastro",
    "DataPublicacao"
)
VALUES
(
    'Teste 2',
    'Conteúdo Teste 2',
    '2017-10-13 16:59',
    null
);
