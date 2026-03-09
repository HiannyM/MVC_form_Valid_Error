
using System.ComponentModel.DataAnnotations;

namespace MVC_form_Valid_Error.Models;

public class Cliente
{
    public int Id { get; set; }

    // TODO: Agrega [Required], [StringLength], [Display] apropiados
    [Required(ErrorMessage = "El nombre es obligatorio")]
    [StringLength(100, MinimumLength = 3,
        ErrorMessage = "El nombre debe tener entre 3 y 100 caracteres")]
    [Display(Name = "Nombre del cliente")]
    public string Nombre { get; set; } = "";

    // TODO: Agrega [Required], [EmailAddress], [Display]
    [Required(ErrorMessage = "El email es obligatorio")]
    [EmailAddress(ErrorMessage = "Email no válido")]
    [Display(Name = "Correo electrónico")]
    public string Email { get; set; } = "";

    // TODO: Agrega [Phone] y que NO sea obligatorio
    [Phone(ErrorMessage = "Teléfono no válido")]
    [Display(Name = "Teléfono")]
    public string? Telefono { get; set; }

    // TODO: El cliente debe ser mayor de 18 años
    // Pista: usa [Range] con DateTime o implementa IValidatableObject
    [Display(Name = "Fecha de nacimiento")]
    [DataType(DataType.Date)]
    public DateOnly FechaNacimiento { get; set; }
}
