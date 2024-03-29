CREATE TABLE Curso(
	Cod_curso INTEGER NOT NULL PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL
);

CREATE TABLE Aluno(
	RA INTEGER NOT NULL PRIMARY KEY,
	Cod_curso INTEGER NOT NULL,
	RFID VARCHAR(10) NOT NULL,
	Nome VARCHAR(50) NOT NULL,
	FOREIGN KEY(Cod_curso) REFERENCES Curso(Cod_curso)
);

CREATE TABLE Professor(
	Cod_professor INTEGER NOT NULL PRIMARY KEY,
    RFID  VARCHAR(10) NOT NULL,
    Nome VARCHAR(50) NOT NULL
);

CREATE TABLE Turma(
	Cod_turma INTEGER NOT NULL PRIMARY KEY AUTO_INCREMENT,
    Cod_professor INTEGER NOT NULL,
    Nome VARCHAR(50) NOT NULL,
    FOREIGN KEY(Cod_professor) REFERENCES Professor(Cod_professor)
);
CREATE TABLE Aula(
	Cod_aula INTEGER NOT NULL  KEY AUTO_INCREMENT PRIMARY KEY,
    Cod_professor INTEGER NOT NULL,
    Data VARCHAR(10),
    Cod_turma INTEGER NOT NULL,
    FOREIGN KEY(Cod_professor) REFERENCES Professor(Cod_professor),
	FOREIGN KEY(Cod_turma) REFERENCES Turma(Cod_turma)
);


CREATE TABLE Aluno_Turma(
	RA INTEGER NOT NULL,
    Cod_turma INTEGER NOT NULL,
    FOREIGN KEY(RA) REFERENCES Aluno(RA),
    FOREIGN KEY(Cod_turma) REFERENCES Turma(Cod_turma)
);

CREATE TABLE Aluno_Aula(
	Cod_aula INTEGER NOT NULL,
    RA INTEGER NOT NULL,
	FOREIGN KEY(Cod_aula) REFERENCES Aula(Cod_aula),
    FOREIGN KEY(RA) REFERENCES Aluno(RA)
);

DROP TABLE Aluno_Aula;
DROP TABLE Aluno_Turma;
DROP TABLE Turma;
DROP TABLE Aula;
DROP TABLE professor;
DROP TABLE Aluno;
DROP TABLE Curso;


     
