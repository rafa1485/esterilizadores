-- Script Date: 3/12/2018 12:25 a. m.  - ErikEJ.SqlCeScripting version 3.5.2.75
CREATE TABLE [CICLOS] (
  [Id] INTEGER NOT NULL
, [numeroCicloDia] NUMERIC NULL
, [fechaHoraInicio] datetime NOT NULL
, [fechaHoraFinal] datetime NULL
, [idEquipo] INTEGER NOT NULL
, [IdTipoCiclo] INTEGER NULL
, [idResponsableInicio] INTEGER NULL
, [idResponsableFinal] INTEGER NULL
, CONSTRAINT [PK_asd] PRIMARY KEY ([Id])
);
