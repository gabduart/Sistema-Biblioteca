/*
    USE master;
    DROP DATABASE BibliotecaDB;
*/
CREATE DATABASE BibliotecaDB;

USE BibliotecaDB;

-- Tabela de Autores
CREATE TABLE Autores (
    AutorID INT CONSTRAINT PK_AutorId PRIMARY KEY IDENTITY,
    Nome VARCHAR(255) NOT NULL
);

-- Tabela de Editores
CREATE TABLE Editores (
    EditorID INT CONSTRAINT PK_EditorId PRIMARY KEY IDENTITY,
    Nome VARCHAR(255) NOT NULL
);

-- Tabela de Categorias
CREATE TABLE Categorias (
    CategoriaID INT CONSTRAINT PK_CategoriaId PRIMARY KEY IDENTITY,
    Nome VARCHAR(100) NOT NULL
);

-- Tabela de Classifica��o Dewey
CREATE TABLE ClassificacaoDewey (
    ClassificacaoID INT CONSTRAINT PK_ClassificacaoId PRIMARY KEY IDENTITY,
    Codigo VARCHAR(20) NOT NULL,
    Descricao VARCHAR(255)
);

-- Tabela de Livros
CREATE TABLE Livros (
    LivroID INT CONSTRAINT PK_LivroId PRIMARY KEY IDENTITY,
    ISBN VARCHAR(13) CONSTRAINT UK_BarCodeISBN UNIQUE NOT NULL,
    Titulo VARCHAR(255) NOT NULL,
    Subtitulo VARCHAR(255),
    AutorID INT CONSTRAINT FK_AutorID REFERENCES Autores(AutorID),
    EditorID INT CONSTRAINT FK_EditorID REFERENCES Editores(EditorID),
    DataPublicacao DATE,
    Edicao VARCHAR(50),
    CategoriaID INT CONSTRAINT FK_CategoriaID REFERENCES Categorias(CategoriaID),
    ClassificacaoID INT CONSTRAINT FK_ClassificacaoID REFERENCES ClassificacaoDewey(ClassificacaoID),
    PalavrasChave TEXT,
    NumeroPaginas INT,
    Dimensoes VARCHAR(50),
    Peso DECIMAL(5,2),
    Resumo TEXT,
    ImagemCapa VARCHAR(255)
);

-- Tabela de Exemplares
CREATE TABLE Exemplares (
    ExemplarID INT CONSTRAINT PK_ExemplarId PRIMARY KEY IDENTITY,
    LivroID INT CONSTRAINT FK_LivroID_Exemplar REFERENCES Livros(LivroID),
    Status VARCHAR(50) DEFAULT 'Dispon�vel',
    Localizacao VARCHAR(100),
    DataAquisicao DATE DEFAULT GETDATE(),
    Observacoes TEXT
);

-- Tabela de Usu�rios (Leitores)
CREATE TABLE Usuarios (
    UsuarioID INT CONSTRAINT PK_UsuarioId PRIMARY KEY IDENTITY,
    Nome VARCHAR(255) NOT NULL,
    Endereco VARCHAR(255),
    Telefone VARCHAR(20),
    Email VARCHAR(100),
    DataCadastro DATE DEFAULT GETDATE()
);

-- Tabela de Empr�stimos
CREATE TABLE Emprestimos (
    EmprestimoID INT CONSTRAINT PK_EmprestimoId PRIMARY KEY IDENTITY,
    LivroID INT,
    UsuarioID INT,
    DataEmprestimo DATE DEFAULT GETDATE(),
    DataDevolucaoPrevista DATE,
    DataDevolucao DATE,
    CONSTRAINT FK_LivroEmprestimo FOREIGN KEY (LivroID) REFERENCES Livros(LivroID),
    CONSTRAINT FK_UsuarioEmprestimo FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

-- Tabela de Reservas
CREATE TABLE Reservas (
    ReservaID INT CONSTRAINT PK_ReservaId PRIMARY KEY IDENTITY,
    LivroID INT,
    UsuarioID INT,
    DataReserva DATE DEFAULT GETDATE(),
    Status VARCHAR(50) DEFAULT 'Pendente',
    CONSTRAINT FK_LivroReserva FOREIGN KEY (LivroID) REFERENCES Livros(LivroID),
    CONSTRAINT FK_UsuarioReserva FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
);

-- Tabela de Funcionarios
CREATE TABLE Funcionarios (
    FuncionarioID INT PRIMARY KEY IDENTITY,
    Nome VARCHAR(255) NOT NULL,
    Cargo VARCHAR(100),
    DataContratacao DATE,
    Salario DECIMAL(10, 2),
    Telefone VARCHAR(20),
    Email VARCHAR(100),
    Endereco VARCHAR(255),
    DataNascimento DATE,
    Observacoes TEXT
);
-- ALTER TABLE Funcionarios ADD Visible BIT;
-- ALTER TABLE Funcionarios ADD CONSTRAINT DF_Funcionarios_Visible DEFAULT 1 FOR Visible;
-- UPDATE Funcionarios SET Visible = 1 WHERE ;


-- Inser��o de todos os c�digos da Classifica��o Dewey

INSERT INTO ClassificacaoDewey (Codigo, Descricao) VALUES 
('000', 'Generalidades'),
('010', 'Bibliografia'),
('020', 'Biblioteconomia'),
('030', 'Enciclop�dias e livros de fatos'),
('040', 'Cole��es gerais'),
('050', 'Revistas, jornais e s�ries'),
('060', 'Organiza��es gerais e museologia'),
('070', 'Jornalismo, jornais e publica��es'),
('080', 'Cole��es em outros idiomas'),
('090', 'Manuscritos e livros raros'),

('100', 'Filosofia'),
('110', 'Metaf�sica'),
('120', 'Epistemologia, causa��o, gnoseologia'),
('130', 'Parapsicologia e ocultismo'),
('140', 'Filosofias espec�ficas'),
('150', 'Psicologia'),
('160', 'L�gica'),
('170', '�tica (Filosofia moral)'),
('180', 'Filosofia antiga, medieval e oriental'),
('190', 'Filosofia moderna ocidental'),

('200', 'Religi�o'),
('210', 'Filosofia e teoria da religi�o'),
('220', 'B�blia'),
('230', 'Cristianismo'),
('240', 'Cristianismo - Pr�ticas devocionais'),
('250', 'Cristianismo - Doutrina crist�'),
('260', 'Igreja crist� e seus minist�rios'),
('270', 'Hist�ria e geografia da Igreja crist�'),
('280', 'Cristianismo - Denomina��es crist�s'),
('290', 'Outras religi�es'),

('300', 'Ci�ncias sociais'),
('310', 'Estat�sticas'),
('320', 'Ci�ncia pol�tica'),
('330', 'Economia'),
('340', 'Direito'),
('350', 'Administra��o p�blica e ci�ncia militar'),
('360', 'Problemas sociais e servi�os sociais'),
('370', 'Educa��o'),
('380', 'Com�rcio, comunica��es e transporte'),
('390', 'Costumes, etiqueta e folclore'),

('400', 'L�nguas'),
('410', 'Lingu�stica'),
('420', 'Ingl�s e l�nguas anglo-sax�nicas'),
('430', 'L�nguas germ�nicas'),
('440', 'Franc�s e l�nguas rom�nicas'),
('450', 'Italiano, romeno e l�nguas rom�nicas'),
('460', 'L�nguas hisp�nicas e portuguesas'),
('470', 'L�nguas it�licas e l�nguas rom�nicas orientais'),
('480', 'L�nguas hel�nicas'),
('490', 'Outras l�nguas'),

('500', 'Ci�ncias naturais e matem�tica'),
('510', 'Matem�tica'),
('520', 'Astronomia'),
('530', 'F�sica'),
('540', 'Qu�mica'),
('550', 'Ci�ncias da Terra e geologia'),
('560', 'Paleontologia'),
('570', 'Ci�ncias da vida'),
('580', 'Bot�nica'),
('590', 'Zoologia'),

('600', 'Tecnologia (Ci�ncias aplicadas)'),
('610', 'Ci�ncias m�dicas e medicina'),
('620', 'Engenharia'),
('630', 'Agricultura'),
('640', 'Administra��o dom�stica e servi�os relacionados'),
('650', 'Administra��o de neg�cios e finan�as'),
('660', 'Engenharia qu�mica'),
('670', 'Ind�strias manufatureiras'),
('680', 'Ind�strias manufatureiras para usos espec�ficos'),
('690', 'Constru��o e engenharia civil'),

('700', 'Artes'),
('710', 'Planejamento da paisagem e �reas recreativas'),
('720', 'Arquitetura'),
('730', 'Artes pl�sticas escultura'),
('740', 'Desenho, artes decorativas e artes aplicadas'),
('750', 'Pintura'),
('760', 'Gravura e gravuras'),
('770', 'Fotografia e fotografia cinematogr�fica'),
('780', 'M�sica'),
('790', 'Esportes, jogos e entretenimento'),

('800', 'Literatura e ret�rica'),
('810', 'Literatura americana em ingl�s'),
('820', 'Literatura inglesa e anglo-sax�nica'),
('830', 'Literaturas germ�nicas'),
('840', 'Literaturas francesas e l�nguas rom�nicas'),
('850', 'Literaturas italianas, romenas e l�nguas rom�nicas'),
('860', 'Literaturas espanholas e portuguesas'),
('870', 'Literaturas latinas'),
('880', 'Literaturas hel�nicas cl�ssicas'),
('890', 'Literaturas em outras l�nguas'),

('900', 'Geografia e hist�ria'),
('910', 'Geografia e viagens'),
('920', 'Biografia e genealogia'),
('930', 'Hist�ria antiga'),
('940', 'Hist�ria da Europa'),
('950', 'Hist�ria da �sia'),
('960', 'Hist�ria da �frica'),
('970', 'Hist�ria da Am�rica do Norte'),
('980', 'Hist�ria da Am�rica do Sul'),
('990', 'Hist�ria de outros lugares');

-- Inser��es na tabela Autores
INSERT INTO Autores (Nome) VALUES 
('Machado de Assis'),
('Clarice Lispector');

-- Inser��es na tabela Editores
INSERT INTO Editores (Nome) VALUES 
('Companhia das Letras'),
('Editora Globo');

-- Inser��es na tabela Categorias
INSERT INTO Categorias (Nome) VALUES 
('Romance'),
('Fic��o Cient�fica');

-- Inser��es na tabela Livros
INSERT INTO Livros (ISBN, Titulo, Subtitulo, AutorID, EditorID, DataPublicacao, Edicao, CategoriaID, ClassificacaoID, PalavrasChave, NumeroPaginas, Dimensoes, Peso, Resumo, ImagemCapa) VALUES 
('9788535902772', 'Dom Casmurro', NULL, 1, 1, '2023-01-01', '1� edi��o', 1, 90, 'Romance, Cl�ssico', 256, '15x23 cm', 0.35, 'Dom Casmurro � um romance escrito por Machado de Assis.', 'dom_casmurro.jpg'),
('9788535910272', 'A Hora da Estrela', NULL, 2, 1, '2022-05-15', '2� edi��o', 1, 82, 'Romance, Literatura Brasileira', 192, '14x21 cm', 0.25, 'A Hora da Estrela � uma obra de Clarice Lispector.', 'hora_estrela.jpg');

-- Inser��es na tabela Exemplares
INSERT INTO Exemplares (LivroID, Status, Localizacao, DataAquisicao, Observacoes) VALUES 
(1, 'Dispon�vel', 'Estante A', '2023-01-10', 'Exemplar em bom estado.'),
(2, 'Emprestado', 'Estante B', '2023-02-05', 'Empr�stimo v�lido at� 2023-03-05.');

-- Inser��es na tabela Usuarios
INSERT INTO Usuarios (Nome, Endereco, Telefone, Email, DataCadastro) VALUES 
('Jo�o Silva', 'Rua das Flores, 123', '(11) 98765-4321', 'joao.silva@email.com', GETDATE()),
('Maria Santos', 'Av. Principal, 456', '(11) 91234-5678', 'maria.santos@email.com', GETDATE());

-- Inser��es na tabela Emprestimos
INSERT INTO Emprestimos (LivroID, UsuarioID, DataEmprestimo, DataDevolucaoPrevista, DataDevolucao) VALUES 
(1, 1, GETDATE(), '2023-01-20', NULL),
(2, 2, '2023-02-10', '2023-03-10', NULL);

-- Inser��es na tabela Reservas
INSERT INTO Reservas (LivroID, UsuarioID, DataReserva, Status) VALUES 
(1, 2, GETDATE(), 'Pendente'),
(2, 1, '2023-02-01', 'Pendente');

-- Inser��es na tabela Funcionarios
INSERT INTO Funcionarios (Nome, Cargo, DataContratacao, Salario, Telefone, Email, Endereco, DataNascimento, Observacoes) VALUES 
('Pedro Oliveira', 'Bibliotec�rio', '2020-05-15', 3500.00, '(11) 99876-5432', 'pedro.oliveira@email.com', 'Av. das Palmeiras, 789', '1985-03-20', 'Respons�vel pelo setor de empr�stimos.'),
('Ana Souza', 'Auxiliar Administrativo', '2021-08-20', 2500.00, '(11) 98765-4321', 'ana.souza@email.com', 'Rua das Violetas, 456', '1990-07-12', 'Auxilia na cataloga��o e organiza��o dos livros.');

-- Selecionar todos os registros da tabela Autores
SELECT * FROM Autores;

-- Selecionar todos os registros da tabela Editores
SELECT * FROM Editores;

-- Selecionar todos os registros da tabela Categorias
SELECT * FROM Categorias;

-- Selecionar todos os registros da tabela ClassificacaoDewey
SELECT * FROM ClassificacaoDewey;

-- Selecionar todos os registros da tabela Livros
-- SELECT * FROM Livros;
GO 
CREATE VIEW vwLivros
AS
SELECT	l.LivroID AS 'C�digo do Livro',
		l.ISBN,
		l.Titulo AS 'T�tulo',
		l.Subtitulo AS 'Subt�tulo',
		a.Nome AS 'Autor',
		e.Nome AS 'Editor',
		l.DataPublicacao AS 'Data de Publica��o',
		l.Edicao AS 'Edi��o',
		c.Nome AS 'Categoria',
		cl.Descricao AS 'Classifica��o de Dewey',
		l.PalavrasChave AS 'Palavras Chave',
		l.NumeroPaginas AS 'N�mero de P�ginas',
		l.Dimensoes AS 'Dimens�es',
		l.Peso,
		l.Resumo,
		l.ImagemCapa AS 'Imagem da Capa'
FROM Livros l
INNER JOIN Autores a ON a.AutorID = l.AutorID
INNER JOIN Editores e ON e.EditorID = l.EditorID
INNER JOIN Categorias c ON c.CategoriaID = l.CategoriaID
INNER JOIN ClassificacaoDewey cl ON cl.ClassificacaoID = l.ClassificacaoID;

SELECT * FROM vwLivros;

-- Selecionar todos os registros da tabela Exemplares
-- SELECT * FROM Exemplares;
GO 
CREATE VIEW vwExemplares
AS
SELECT	e.ExemplarID AS 'C�digo do Exemplar',
		l.Titulo AS 'T�tulo',
		e.Status,
		e.Localizacao AS 'Localiza��o',
		e.DataAquisicao AS 'Data de Aquisi��o',
		e.Observacoes AS 'Observa��es'
FROM Exemplares e
INNER JOIN Livros l ON l.LivroID = e.LivroID;

SELECT * FROM vwExemplares;

-- Selecionar todos os registros da tabela Usuarios
-- SELECT * FROM Usuarios;
GO 
CREATE VIEW vwUsuarios
AS
SELECT	u.UsuarioID AS 'C�digo do Usu�rio',
		u.Nome,
		u.Endereco AS 'Endere�o',
		u.Telefone,
		u.Email AS 'E-mail',
		u.DataCadastro AS 'Data de Cadastro'
FROM Usuarios u;

SELECT * FROM vwUsuarios;

-- Selecionar todos os registros da tabela Emprestimos
-- SELECT * FROM Emprestimos;
GO 
CREATE VIEW vwEmprestimos
AS
SELECT	e.EmprestimoID,
		l.Titulo AS 'T�tulo',
		u.Nome AS 'Usu�rio',
		e.DataEmprestimo AS 'Data de Empr�stimo',
		e.DataDevolucaoPrevista AS 'Data de Devolu��o Prevista',
		e.DataDevolucao AS 'Data de Devolu��o'
FROM Emprestimos e
INNER JOIN Livros l ON l.LivroID = e.LivroID
INNER JOIN Usuarios u ON u.UsuarioID = e.UsuarioID;

SELECT * FROM vwEmprestimos;

-- Selecionar todos os registros da tabela Reservas
-- SELECT * FROM Reservas;
GO
CREATE VIEW vwReservas
AS
SELECT	r.ReservaID AS 'C�digo da Reserva',
		l.Titulo AS 'T�tulo',
		u.Nome AS 'Usu�rio',
		r.DataReserva AS 'Data de Reserva',
		r.Status
FROM Reservas r
INNER JOIN Livros l ON l.LivroID = r.LivroID
INNER JOIN Usuarios u ON u.UsuarioID = r.UsuarioID;

SELECT * FROM vwReservas;

-- Selecionar todos os registros da tabela Funcionarios
-- SELECT * FROM Funcionarios;
GO
CREATE VIEW vwFuncionario
AS
SELECT	f.FuncionarioID AS 'C�digo do Funcion�rio',
		f.Nome,
		f.Cargo,
		f.DataContratacao AS 'Data de Contrata��o',
		f.Salario AS 'Sal�rio',
		f.Telefone,
		f.Email AS 'E-mail',
		f.Endereco AS 'Endere�o',
		f.DataNascimento AS 'Data de Nascimento',
		f.Observacoes AS 'Observa��es'
		-- f.Visible
FROM Funcionarios f
WHERE Visible = 1;
-- DROP VIEW vwFuncionario
SELECT * FROM vwFuncionario;