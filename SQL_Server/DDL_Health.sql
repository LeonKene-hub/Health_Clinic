CREATE DATABASE Health_Clinic
USE Health_Clinic

CREATE TABLE TipodeUsuario
(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	TituloTipoUsuario VARCHAR(30) NOT NULL
)

CREATE TABLE Especialidade
(
	IdEspecialidade INT PRIMARY KEY IDENTITY,
	Especialidade VARCHAR(50) NOT NULL
)

CREATE TABLE Clinica
(
	IdClinica INT PRIMARY KEY IDENTITY,
	RazaoSocial VARCHAR(90) NOT NULL,
	NomeFantasia VARCHAR(30) NOT NULL,
	CNPJ VARCHAR(14) NOT NULL,
	Endereco VARCHAR(90) NOT NULL,
	HorarioAbertura TIME NOT NULL,
	HorarioFechamento TIME NOT NULL
)

CREATE TABLE Usuario
(
	IdUsuario INT PRIMARY KEY IDENTITY,
	IdTipoUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoUsuario) NOT NULL,
	Email VARCHAR(90) NOT NULL,
	Senha VARCHAR(30) NOT NULL
)

CREATE TABLE Medico
(
	IdMedico INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade) NOT NULL,
	IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica) NOT NULL,
	NomeMedico VARCHAR(90) NOT NULL,
	CRM VARCHAR(20) NOT NULL
)

CREATE TABLE Paciente
(
	IdPaciente INT PRIMARY KEY IDENTITY,
	IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario) NOT NULL,
	NomePaciente VARCHAR(90) NOT NULL,
	DataNascimento DATE NOT NULL,
	Sexo VARCHAR(30) NOT NULL,
	Endereco VARCHAR(30) NOT NULL,
	Telefone VARCHAR(11) NOT NULL,
	CNS VARCHAR(15) NOT NULL
)

CREATE TABLE Consulta
(
	IdConsulta INT PRIMARY KEY IDENTITY,
	IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
	IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico) NOT NULL,
	[Local] VARCHAR(30) NOT NULL,
	Hora TIME NOT NULL,
	Descricao VARCHAR(90) NOT NULL
)

CREATE TABLE Comentario
(
	IdComentario INT PRIMARY KEY IDENTITY,
	IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente) NOT NULL,
	IdConsulta INT FOREIGN KEY REFERENCES Consulta(IdConsulta) NOT NULL,
	Comentario VARCHAR(120) NOT NULL
)

SELECT * FROM TipodeUsuario
SELECT * FROM Especialidade
SELECT * FROM Clinica
SELECT * FROM Medico
SELECT * FROM Usuario
SELECT * FROM Consulta
SELECT * FROM Paciente
SELECT * FROM Comentario
