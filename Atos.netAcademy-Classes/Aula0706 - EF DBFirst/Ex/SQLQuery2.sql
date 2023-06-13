
create database ExAlunoCurso

create table Alunos
(
    id integer identity primary key,
    nome varchar(100) not null
)

create table Cursos
(
     id integer identity primary key,
    nome varchar(100) not null
)

Create Table Matricula
(
    id integer identity primary key,
	fk_aluno integer,
    foreign key (fk_aluno) references Alunos(id),
	fk_curso integer,
    foreign key (fk_curso) references Cursos(id)
)