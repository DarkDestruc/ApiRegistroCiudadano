namespace ApiRegistroCiudadano.Models
{
    public class CINuevoRegistro
    {
        public int Id { get; set; }
        public string NumeroIdentidad { get; set; }
        public int LugarDeNacimiento { get; set; }

        public RegistroNuevo RegistroNuevo { get; set; }
    }
}
