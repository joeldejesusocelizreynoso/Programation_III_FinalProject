//Joel De Jesús Oseliz Reynoso - 20231132

using System;
using System.ComponentModel.DataAnnotations;

public class Reporte
{
    public string Id { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo fecha es requerido.")]

    public DateTime Fecha { get; set; } = DateTime.Now;

    [Required(ErrorMessage = "El campo Matricula es requerido.")]

    public string Matricula { get; set; } = "";

    [Required(ErrorMessage = "El campo Nombre es requerido.")]

    public string Nombre { get; set; } = "";

    [Required(ErrorMessage = "El campo Apellido es requerido.")]

    public string Apellido { get; set; } = "";

    [Required(ErrorMessage = "El campo Curso es requerido.")]

    public string Curso { get; set; } = "";

    [Required(ErrorMessage = "El campo Motivo es requerido.")]
    [MinLength(20, ErrorMessage = "La descripción del campo Motivo debe tener al menos 20 caracteres.")]

    public string Motivo { get; set; } = "";
}
