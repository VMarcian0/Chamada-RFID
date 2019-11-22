SELECT A.RA AS RA, (SELECT Nome as Turma FROM Turma WHERE Cod_turma in 
(SELECT Cod_turma FROM Aluno_turma WHERE RA = '3')) as Turma, (SELECT(SELECT COUNT(*)
 FROM Aula WHERE Cod_turma = E.Cod_turma) - COUNT(*) FROM Aula WHERE B.Cod_aula = D.Cod_aula
 AND Cod_turma in (SELECT Cod_turma FROM Aluno_turma WHERE RA = '3') GROUP BY Cod_turma ) as Faltas FROM
Aluno A, Aluno_aula B, Aluno_turma C, Aula D, Turma E WHERE A.RA = '3' GROUP BY A.RA;

SELECT A.RA AS RA, (SELECT Nome as Turma FROM Turma WHERE Cod_turma in 
(SELECT Cod_turma FROM Aluno_turma WHERE RA = 3)) as Turma, 
 (SELECT (SELECT COUNT(*) FROM Aula WHERE Cod_turma = E.Cod_turma) - COUNT(*) FROM Aula WHERE B.Cod_aula = D.Cod_aula
 AND Cod_turma in (SELECT Cod_turma FROM Aluno_turma WHERE RA = 3) GROUP BY Cod_turma ) as Faltas FROM
Aluno A, Aluno_aula B, Aluno_turma C, Aula D, Turma E WHERE A.RA = 3  ;

SELECT A.RA AS RA,
	   (SELECT Nome from Turma WHERE Cod_turma IN (SELECT Cod_turma FROM Aluno_turma WHERE RA = '3') GROUP BY Nome) as Turma,
       ((SELECT COUNT(*) FROM Aula WHERE Cod_turma IN (SELECT Cod_turma FROM Aluno_turma WHERE RA = '3'))-(SELECT COUNT(*) FROM aluno_aula WHERE Cod_aula in (SELECT Cod_aula from Aula WHERE Cod_turma in (SELECT Cod_turma from aluno_turma WHERE RA = '3') )) )   AS Faltas
FROM 
Aluno A,
Aluno_aula B,
Aluno_turma C,
Aula D, 
Turma E
WHERE A.RA = '3'
GROUP BY A.RA;

SELECT * FROM aluno_aula
SELECT * FROM aluno
SELECT * FROM aula
SELECT Nome FROM turma WHERE Cod_Professor = (Select Cod_Professor from Professor where RFID = '1349CD1F')
SELECT * FROM Professor


INSERT INTO Aula (Cod_professor, Data, Cod_turma)" +
                                 " VALUES (" + cod_professor + ", '" + data + "'," +
                                 " (SELECT Cod_turma FROM Turma WHERE Nome ='" + cod_turma + "'))"