namespace Domain.Models;

public record RegisterDto(string Username, string Email, string Password);
public record LoginDto(string Username, string Password);
public record LoginResponseDto(Guid Id,string Username, string Token);
public record ResetPasswordDto(string Email, string Token, string NewPassword);

