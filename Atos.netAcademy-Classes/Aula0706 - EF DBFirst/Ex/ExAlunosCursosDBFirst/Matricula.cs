using System;
using System.Collections.Generic;

namespace ExAlunosCursosDBFirst;

public partial class Matricula
{
    public int Id { get; set; }

    public int? FkAluno { get; set; }

    public int? FkCurso { get; set; }

    public virtual Aluno? FkAlunoNavigation { get; set; }

    public virtual Curso? FkCursoNavigation { get; set; }
}
