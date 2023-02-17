namespace ERPNETv1.Entity
{
    public class ClienteTO
    {

        public ClienteTO()
        {
            Nombre = string.Empty;
            Ciudad = string.Empty;
        }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
    }
}
