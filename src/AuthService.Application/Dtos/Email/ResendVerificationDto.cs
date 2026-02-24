using System.ComponentModel.DataAnnotations;

namespace AuthService.Application.Dtos.Email;

public class ResendVerificationDto
{
    [Required(ErrorMessage = "Email es obligatorio.")]

    public string Email { get; set; } = string.Empty;
}