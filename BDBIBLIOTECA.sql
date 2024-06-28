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

-- Tabela de Classificação Dewey
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
    Status VARCHAR(50) DEFAULT 'Disponível',
    Localizacao VARCHAR(100),
    DataAquisicao DATE DEFAULT GETDATE(),
    Observacoes TEXT
);

-- Tabela de Usuários (Leitores)
CREATE TABLE Usuarios (
    UsuarioID INT CONSTRAINT PK_UsuarioId PRIMARY KEY IDENTITY,
    Nome VARCHAR(255) NOT NULL,
    Endereco VARCHAR(255),
    Telefone VARCHAR(20),
    Email VARCHAR(100),
    DataCadastro DATE DEFAULT GETDATE()
);

-- Tabela de Empréstimos
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


-- Inserção de todos os códigos da Classificação Dewey

INSERT INTO ClassificacaoDewey (Codigo, Descricao) VALUES 
('000', 'Generalidades'),
('010', 'Bibliografia'),
('020', 'Biblioteconomia'),
('030', 'Enciclopédias e livros de fatos'),
('040', 'Coleções gerais'),
('050', 'Revistas, jornais e séries'),
('060', 'Organizações gerais e museologia'),
('070', 'Jornalismo, jornais e publicações'),
('080', 'Coleções em outros idiomas'),
('090', 'Manuscritos e livros raros'),

('100', 'Filosofia'),
('110', 'Metafísica'),
('120', 'Epistemologia, causação, gnoseologia'),
('130', 'Parapsicologia e ocultismo'),
('140', 'Filosofias específicas'),
('150', 'Psicologia'),
('160', 'Lógica'),
('170', 'Ética (Filosofia moral)'),
('180', 'Filosofia antiga, medieval e oriental'),
('190', 'Filosofia moderna ocidental'),

('200', 'Religião'),
('210', 'Filosofia e teoria da religião'),
('220', 'Bíblia'),
('230', 'Cristianismo'),
('240', 'Cristianismo - Práticas devocionais'),
('250', 'Cristianismo - Doutrina cristã'),
('260', 'Igreja cristã e seus ministérios'),
('270', 'História e geografia da Igreja cristã'),
('280', 'Cristianismo - Denominações cristãs'),
('290', 'Outras religiões'),

('300', 'Ciências sociais'),
('310', 'Estatísticas'),
('320', 'Ciência política'),
('330', 'Economia'),
('340', 'Direito'),
('350', 'Administração pública e ciência militar'),
('360', 'Problemas sociais e serviços sociais'),
('370', 'Educação'),
('380', 'Comércio, comunicações e transporte'),
('390', 'Costumes, etiqueta e folclore'),

('400', 'Línguas'),
('410', 'Linguística'),
('420', 'Inglês e línguas anglo-saxônicas'),
('430', 'Línguas germânicas'),
('440', 'Francês e línguas românicas'),
('450', 'Italiano, romeno e línguas românicas'),
('460', 'Línguas hispânicas e portuguesas'),
('470', 'Línguas itálicas e línguas românicas orientais'),
('480', 'Línguas helênicas'),
('490', 'Outras línguas'),

('500', 'Ciências naturais e matemática'),
('510', 'Matemática'),
('520', 'Astronomia'),
('530', 'Física'),
('540', 'Química'),
('550', 'Ciências da Terra e geologia'),
('560', 'Paleontologia'),
('570', 'Ciências da vida'),
('580', 'Botânica'),
('590', 'Zoologia'),

('600', 'Tecnologia (Ciências aplicadas)'),
('610', 'Ciências médicas e medicina'),
('620', 'Engenharia'),
('630', 'Agricultura'),
('640', 'Administração doméstica e serviços relacionados'),
('650', 'Administração de negócios e finanças'),
('660', 'Engenharia química'),
('670', 'Indústrias manufatureiras'),
('680', 'Indústrias manufatureiras para usos específicos'),
('690', 'Construção e engenharia civil'),

('700', 'Artes'),
('710', 'Planejamento da paisagem e áreas recreativas'),
('720', 'Arquitetura'),
('730', 'Artes plásticas escultura'),
('740', 'Desenho, artes decorativas e artes aplicadas'),
('750', 'Pintura'),
('760', 'Gravura e gravuras'),
('770', 'Fotografia e fotografia cinematográfica'),
('780', 'Música'),
('790', 'Esportes, jogos e entretenimento'),

('800', 'Literatura e retórica'),
('810', 'Literatura americana em inglês'),
('820', 'Literatura inglesa e anglo-saxônica'),
('830', 'Literaturas germânicas'),
('840', 'Literaturas francesas e línguas românicas'),
('850', 'Literaturas italianas, romenas e línguas românicas'),
('860', 'Literaturas espanholas e portuguesas'),
('870', 'Literaturas latinas'),
('880', 'Literaturas helênicas clássicas'),
('890', 'Literaturas em outras línguas'),

('900', 'Geografia e história'),
('910', 'Geografia e viagens'),
('920', 'Biografia e genealogia'),
('930', 'História antiga'),
('940', 'História da Europa'),
('950', 'História da Ásia'),
('960', 'História da África'),
('970', 'História da América do Norte'),
('980', 'História da América do Sul'),
('990', 'História de outros lugares');

-- Inserções na tabela Autores
INSERT INTO Autores (Nome) VALUES 
('Machado de Assis'),
('Clarice Lispector');

-- Inserções na tabela Editores
INSERT INTO Editores (Nome) VALUES 
('Companhia das Letras'),
('Editora Globo');

-- Inserções na tabela Categorias
INSERT INTO Categorias (Nome) VALUES 
('Romance'),
('Ficção Científica');

-- Inserções na tabela Livros
INSERT INTO Livros (ISBN, Titulo, Subtitulo, AutorID, EditorID, DataPublicacao, Edicao, CategoriaID, ClassificacaoID, PalavrasChave, NumeroPaginas, Dimensoes, Peso, Resumo, ImagemCapa) VALUES 
('9788535902772', 'Dom Casmurro', NULL, 1, 1, '2023-01-01', '1ª edição', 1, 90, 'Romance, Clássico', 256, '15x23 cm', 0.35, 'Dom Casmurro é um romance escrito por Machado de Assis.', 'dom_casmurro.jpg'),
('9788535910272', 'A Hora da Estrela', NULL, 2, 1, '2022-05-15', '2ª edição', 1, 82, 'Romance, Literatura Brasileira', 192, '14x21 cm', 0.25, 'A Hora da Estrela é uma obra de Clarice Lispector.', 'hora_estrela.jpg');

-- Inserções na tabela Exemplares
INSERT INTO Exemplares (LivroID, Status, Localizacao, DataAquisicao, Observacoes) VALUES 
(1, 'Disponível', 'Estante A', '2023-01-10', 'Exemplar em bom estado.'),
(2, 'Emprestado', 'Estante B', '2023-02-05', 'Empréstimo válido até 2023-03-05.');

-- Inserções na tabela Usuarios
INSERT INTO Usuarios (Nome, Endereco, Telefone, Email, DataCadastro) VALUES 
('João Silva', 'Rua das Flores, 123', '(11) 98765-4321', 'joao.silva@email.com', GETDATE()),
('Maria Santos', 'Av. Principal, 456', '(11) 91234-5678', 'maria.santos@email.com', GETDATE());

-- Inserções na tabela Emprestimos
INSERT INTO Emprestimos (LivroID, UsuarioID, DataEmprestimo, DataDevolucaoPrevista, DataDevolucao) VALUES 
(1, 1, GETDATE(), '2023-01-20', NULL),
(2, 2, '2023-02-10', '2023-03-10', NULL);

-- Inserções na tabela Reservas
INSERT INTO Reservas (LivroID, UsuarioID, DataReserva, Status) VALUES 
(1, 2, GETDATE(), 'Pendente'),
(2, 1, '2023-02-01', 'Pendente');

-- Inserções na tabela Funcionarios
INSERT INTO Funcionarios (Nome, Cargo, DataContratacao, Salario, Telefone, Email, Endereco, DataNascimento, Observacoes) VALUES 
('Pedro Oliveira', 'Bibliotecário', '2020-05-15', 3500.00, '(11) 99876-5432', 'pedro.oliveira@email.com', 'Av. das Palmeiras, 789', '1985-03-20', 'Responsável pelo setor de empréstimos.'),
('Ana Souza', 'Auxiliar Administrativo', '2021-08-20', 2500.00, '(11) 98765-4321', 'ana.souza@email.com', 'Rua das Violetas, 456', '1990-07-12', 'Auxilia na catalogação e organização dos livros.');

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
SELECT	l.LivroID AS 'Código do Livro',
		l.ISBN,
		l.Titulo AS 'Título',
		l.Subtitulo AS 'Subtítulo',
		a.Nome AS 'Autor',
		e.Nome AS 'Editor',
		l.DataPublicacao AS 'Data de Publicação',
		l.Edicao AS 'Edição',
		c.Nome AS 'Categoria',
		cl.Descricao AS 'Classificação de Dewey',
		l.PalavrasChave AS 'Palavras Chave',
		l.NumeroPaginas AS 'Número de Páginas',
		l.Dimensoes AS 'Dimensões',
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
SELECT	e.ExemplarID AS 'Código do Exemplar',
		l.Titulo AS 'Título',
		e.Status,
		e.Localizacao AS 'Localização',
		e.DataAquisicao AS 'Data de Aquisição',
		e.Observacoes AS 'Observações'
FROM Exemplares e
INNER JOIN Livros l ON l.LivroID = e.LivroID;

SELECT * FROM vwExemplares;

-- Selecionar todos os registros da tabela Usuarios
-- SELECT * FROM Usuarios;
GO 
CREATE VIEW vwUsuarios
AS
SELECT	u.UsuarioID AS 'Código do Usuário',
		u.Nome,
		u.Endereco AS 'Endereço',
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
		l.Titulo AS 'Título',
		u.Nome AS 'Usuário',
		e.DataEmprestimo AS 'Data de Empréstimo',
		e.DataDevolucaoPrevista AS 'Data de Devolução Prevista',
		e.DataDevolucao AS 'Data de Devolução'
FROM Emprestimos e
INNER JOIN Livros l ON l.LivroID = e.LivroID
INNER JOIN Usuarios u ON u.UsuarioID = e.UsuarioID;

SELECT * FROM vwEmprestimos;

-- Selecionar todos os registros da tabela Reservas
-- SELECT * FROM Reservas;
GO
CREATE VIEW vwReservas
AS
SELECT	r.ReservaID AS 'Código da Reserva',
		l.Titulo AS 'Título',
		u.Nome AS 'Usuário',
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
SELECT	f.FuncionarioID AS 'Código do Funcionário',
		f.Nome,
		f.Cargo,
		f.DataContratacao AS 'Data de Contratação',
		f.Salario AS 'Salário',
		f.Telefone,
		f.Email AS 'E-mail',
		f.Endereco AS 'Endereço',
		f.DataNascimento AS 'Data de Nascimento',
		f.Observacoes AS 'Observações'
		-- f.Visible
FROM Funcionarios f
WHERE Visible = 1;
-- DROP VIEW vwFuncionario
SELECT * FROM vwFuncionario;