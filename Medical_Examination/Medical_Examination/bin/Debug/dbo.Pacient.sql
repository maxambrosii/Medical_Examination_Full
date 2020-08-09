CREATE TABLE [dbo].[Pacient] (
    [Cod_Pacient] INT              NOT NULL,
    [FIO_Pacient] [dbo].[AllNames] DEFAULT ('without') NULL,
    [Adress]      VARCHAR (65)     DEFAULT ('without') NULL,
    [age]         TINYINT          NULL,
    [gender]      BIT              NULL,
    [IDNP]        CHAR (13)        NULL,
    [Strahovka]   CHAR (15)        NULL,
    [Nr_Uchastka] SMALLINT         NULL,
    PRIMARY KEY CLUSTERED ([Cod_Pacient] ASC),
    CHECK ([Cod_Pacient]>(1000)),
    CHECK ([age]<(110)),
);

