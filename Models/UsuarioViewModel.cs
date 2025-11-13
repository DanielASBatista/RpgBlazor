namespace RpgBlazor.Models
{
    public class UsuarioViewModel
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string PasswordString { get; set; } = string.Empty;
        public byte[]? Foto { get; set; }
        public string Perfil { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Token { get; set; } = string.Empty;
        public DateTime? DataAcesso { get; set; }
    }
}
