USE Health_Clinic

--Comentario consulta medica 
SELECT
	Consulta.idConsulta,
	Consulta.Dia AS [Data],
	Consulta.Hora AS Horario,
	Clinica.NomeFantasia AS Clinica,
	Usuario.Nome AS Paciente,
	Especialidade.Especialidade,
	Medico.CRM,
	Consulta.Descricao,
	Comentario.Comentario
FROM 
Consulta 
LEFT JOIN Medico
ON Medico.IdMedico = Consulta.IdMedico
LEFT JOIN Especialidade
ON Especialidade.IdEspecialidade = Medico.IdEspecialidade
LEFT JOIN Clinica
ON Medico.IdClinica = Clinica.IdClinica
LEFT JOIN Paciente
ON Paciente.IdPaciente = Consulta.IdPaciente
LEFT JOIN Usuario
ON Usuario.IdUsuario = Paciente.IdUsuario
LEFT JOIN Comentario
ON Comentario.IdPaciente = Paciente.IdPaciente

--Exemplo de usuario
select 
	Usuario.Nome AS Medico,
	Usuario.Nome AS Paciente
from Usuario
left join Medico
on Usuario.IdUsuario = Medico.IdUsuario
left join Paciente
on Usuario.IdUsuario = Paciente.IdUsuario
left join Consulta
on Consulta.IdMedico = Medico.IdMedico and Consulta.IdPaciente = Paciente.IdPaciente

select * from Usuario
