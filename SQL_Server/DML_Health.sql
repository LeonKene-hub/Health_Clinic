USE Health_Clinic

--inserir valores

INSERT INTO TipodeUsuario (TituloTipoUsuario)
VALUES 
	('Administrador'),
	('Medico'),
	('Paciente')

INSERT INTO Especialidade (Especialidade)
VALUES
	('Pediatria'),
	('Psiquiatria'),
	('Dermatologia'),
	('Oftalmologia'),
	('Cardiologia'),
	('Anestesiologia'),
	('Traumatologia'),
	('Ginecologia '),
	('Obstetrícia'),
	('Radiologia ')

INSERT INTO Usuario (IdTipoUsuario, Email, Senha)
VALUES
	(1,'mariaalice74@yahoo.com','pb3PndW9p'),
	(1,'pietro_nogueira@gmail.com','KFWrkdNG2'),
	(2,'lorenzo_melo@aol.com','SlWIAp4ND'),
	(2,'alessandra_silva@yahoo.com','Kc3FoQCN1'),
	(3,'antônio_nogueira@yandex.com','hNmAuHg7R'),
	(3,'caio_souza@hotmail.com','YF5TRQGsi'),
	(3,'isabelly_carvalho@outlook.com','MysZq8Kb1')

INSERT INTO Clinica (RazaoSocial, NomeFantasia, CNPJ, Endereco, HorarioAbertura, HorarioFechamento)
VALUES
	('Clinica Motta San Francisco','Clinica Motta','72613820000160','644 Costa Marginal - Cardoso, DF / 30839-716','08:30','21:00'),
	('Clinica Motta Januaria','Clinica Motta','87653028000106','1505 Batista Alameda - Miguel Pereira, MG / 52359-116','08:30','21:00')

INSERT INTO Medico(IdUsuario, IdEspecialidade, IdClinica, NomeMedico, CRM)
VALUES
	(3,1,2,'Lorenzo Melo','CRM/DF123456'),
	(4,2,1,'Alessandra Silva ','CRM/MG654321')

INSERT INTO Paciente(IdUsuario, NomePaciente, DataNascimento, Sexo, Endereco, Telefone, CNS)
VALUES
	(5, 'Antonio Nogueira', '01-09-1978', 'Masculino', 'Rua CJ-13, Jardim Tropical', '11912345678', '123456789012345'),
	(6, 'Caio Souza', '15-06-2006', 'Masculino', 'Rua Quarenta e Oito, Bequimão', '11909876543', '098765432109876'), 
	(7, 'Isabelly Carvalho', '12-11-2007', 'Feminino', 'Via Cícero Granja, Papicu', '12345678901', '123456789009876')

INSERT INTO Consulta (IdPaciente, IdMedico, [Local], Hora, Descricao)
VALUES
	(3, 2, 'Clinica Motta', '09:30', 'Paciente em choque'),
	(2, 1, 'Clinica Motta', '15:00', 'Consulta de rotina')

INSERT INTO Comentario (IdPaciente, IdConsulta, Comentario)
VALUES 
	(3,1, 'Foi td tao de repente, mas gracas a Deus deu td certo'),
	(2, 2, 'Fui muito bem atendido e td decorreu bem'),
	(3, 1, 'Muito obrigada pelo atendimento em um momento assim')