USE Health_Clinic

--Consulta medica 
SELECT
	Paciente.NomePaciente AS Paciente,
	Medico.NomeMedico AS Medico,
	Consulta.Hora AS Horario,
	Consulta.[Local]
FROM
Consulta INNER JOIN Medico ON Consulta.IdMedico = Medico.IdMedico
INNER JOIN Paciente ON Consulta.IdPaciente = Paciente.IdPaciente

--Comentario
SELECT
	Paciente.NomePaciente AS Paciente,
	Comentario.Comentario AS Comentario
FROM
Comentario LEFT JOIN Paciente ON Paciente.IdPaciente = Comentario.IdPaciente