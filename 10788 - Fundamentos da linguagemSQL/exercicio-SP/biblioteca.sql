
CREATE DATABASE Biblioteca;
GO

USE Biblioteca;
GO

------------------------------------------------------------
CREATE TABLE Autores (
    AutorID INT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Nacionalidade VARCHAR(50) NULL
);

GO

------------------------------------------------------------
CREATE TABLE Livros (
    LivroID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo VARCHAR(100) NOT NULL,
    AnoPublicacao INT NULL,
    AutorID INT NOT NULL,
    CONSTRAINT FK_Livros_Autores
        FOREIGN KEY (AutorID) REFERENCES Autores(AutorID)
);
GO

------------------------------------------------------------
INSERT INTO Autores (AutorID, Nome, Nacionalidade)
VALUES
(1, 'José Saramago', 'Português'),
(2, 'J. K. Rowling', 'Britânica'),
(3, 'George Orwell', 'Britânico');
GO

INSERT INTO Livros (Titulo, AnoPublicacao, AutorID)
VALUES
('Ensaio sobre a Cegueira', 1995, 1),
('Harry Potter e a Pedra Filosofal', 1997, 2),
('1984', 1949, 3),
('Ensaio sobre a Lucidez', 2004, 1);
GO

------------------------------------------------------------
CREATE PROCEDURE sp_ListarLivrosPorAutor
    @AutorID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        Titulo,
        AnoPublicacao
    FROM Livros
    WHERE AutorID = @AutorID;
END;
GO

------------------------------------------------------------
CREATE PROCEDURE sp_AdicionarLivro
    @Titulo        VARCHAR(100),
    @AnoPublicacao INT,
    @AutorID       INT,
    @NovoLivroID   INT OUTPUT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Livros (Titulo, AnoPublicacao, AutorID)
    VALUES (@Titulo, @AnoPublicacao, @AutorID);

    SET @NovoLivroID = SCOPE_IDENTITY();
END;
GO

------------------------------------------------------------

EXEC sp_ListarLivrosPorAutor @AutorID = 1;
GO

DECLARE @IDGerado INT;

EXEC sp_AdicionarLivro
    @Titulo = 'Livro de Teste',
    @AnoPublicacao = 2025,
    @AutorID = 1,
    @NovoLivroID = @IDGerado OUTPUT;

SELECT @IDGerado AS NovoLivroID;
GO
