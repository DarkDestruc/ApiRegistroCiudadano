namespace ApiRegistroCiudadano.Models
{
    public class RegistroNuevo
    {
        public int ID { get; set; }
        public string Apellidos { get; set; }
        public string Nombres { get; set; }
        public string Ciudad { get; set; }

        public CINuevoRegistro CINuevoRegistro { get; set; }
    }
}
