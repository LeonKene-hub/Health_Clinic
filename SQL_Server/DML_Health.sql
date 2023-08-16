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

INSERT INTO Usuario (IdTipoUsuario,Nome, Email, Senha)
VALUES
	(1,'Maria Alice','mariaalice74@yahoo.com','pb3PndW9p'),
	(1,'Pietro Nogueira','pietro_nogueira@gmail.com','KFWrkdNG2'),
	(2,'orenzo Melo','lorenzo_melo@aol.com','SlWIAp4ND'),
	(2,'Alessandra Silva','alessandra_silva@yahoo.com','Kc3FoQCN1'),
	(3,'Antonio Nogueira','antônio_nogueira@yandex.com','hNmAuHg7R'),
	(3,'Caio Souza','caio_souza@hotmail.com','YF5TRQGsi'),
	(3,'Isabelly Carvalho','isabelly_carvalho@outlook.com','MysZq8Kb1')

INSERT INTO Clinica (RazaoSocial, NomeFantasia, CNPJ, Endereco, HorarioAbertura, HorarioFechamento)
VALUES
	('Clinica Motta San Francisco','Clinica Motta','72613820000160','644 Costa Marginal - Cardoso, DF / 30839-716','08:30','21:00'),
	('Clinica Motta Januaria','Clinica Motta','87653028000106','1505 Batista Alameda - Miguel Pereira, MG / 52359-116','08:30','21:00')

INSERT INTO Medico(IdUsuario, IdEspecialidade, IdClinica, CRM)
VALUES
	(3,1,2,'CRM/DF123456'),
	(4,2,1,'CRM/MG654321')

INSERT INTO Paciente(IdUsuario, DataNascimento, Sexo, Endereco, Telefone, CNS)
VALUES
	(5, '01-09-1978', 'Masculino', 'Rua CJ-13, Jardim Tropical', '11912345678', '123456789012345'),
	(6, '15-06-2006', 'Masculino', 'Rua Quarenta e Oito, Bequimão', '11909876543', '098765432109876'), 
	(7, '12-11-2007', 'Feminino', 'Via Cícero Granja, Papicu', '12345678901', '123456789009876')

INSERT INTO Consulta (IdPaciente, IdMedico, [Local], Hora, Dia, Descricao)
VALUES
	(3, 2, 'Clinica Motta', '09:30', '18-05-2021', 'Paciente em choque'),
	(2, 1, 'Clinica Motta', '15:00', '09-08-2023','Consulta de rotina')

INSERT INTO Comentario (IdPaciente, IdConsulta, Comentario)
VALUES 
	(3,1, 'Foi td tao de repente, mas gracas a Deus deu td certo'),
	(2, 2, 'Fui muito bem atendido e td decorreu bem'),
	(3, 1, 'Muito obrigada pelo atendimento em um momento assim')