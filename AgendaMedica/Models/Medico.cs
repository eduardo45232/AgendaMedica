namespace AgendaMedica.Models
{
    public class Medico
    {
        public Guid MedicoId { get; set; }
        public string Nome { get; set; }
        public string CRM { get; set; }
        public string Celular { get; set; }

        //chave estrangeira
        public Guid EspecialidadeId { get; set; }//fk
        public Especialidade? Especialidade { get; set; }

    }
}
