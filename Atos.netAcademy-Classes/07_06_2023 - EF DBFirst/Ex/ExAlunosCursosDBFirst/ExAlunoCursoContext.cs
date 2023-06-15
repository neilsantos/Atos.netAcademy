using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ExAlunosCursosDBFirst;

public partial class ExAlunoCursoContext : DbContext
{
    public ExAlunoCursoContext()
    {
    }

    public ExAlunoCursoContext(DbContextOptions<ExAlunoCursoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Matricula> Matriculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=ExAlunoCurso; User ID=USUARIO; password=NEILSANTOS; language=Portuguese; trusted_connection=true; encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Alunos__3213E83FB3F661B5");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cursos__3213E83FA24F952C");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Matricula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Matricul__3213E83F1CFC61EF");

            entity.ToTable("Matricula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FkAluno).HasColumnName("fk_aluno");
            entity.Property(e => e.FkCurso).HasColumnName("fk_curso");

            entity.HasOne(d => d.FkAlunoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.FkAluno)
                .HasConstraintName("FK__Matricula__fk_al__3B75D760");

            entity.HasOne(d => d.FkCursoNavigation).WithMany(p => p.Matriculas)
                .HasForeignKey(d => d.FkCurso)
                .HasConstraintName("FK__Matricula__fk_cu__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
