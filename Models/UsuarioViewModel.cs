namespace RpgBlazor.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public byte[]? Foto { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public DateTime? DataAcesso { get; set; }

        // adiciona campo para o login (usado no form)
        public string PasswordString { get; set; } = string.Empty;

        // adiciona campo para o token de retorno
        public string? Token { get; set; } = string.Empty;
    }
}
