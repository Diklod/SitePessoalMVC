namespace SitePessoalMVC.Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Status { get; set; }
        public DateOnly Conclusion { get; set; }

        public Curso (int id, int name, string status, DateOnly conclusion)
        {
            Id = id;
            Name = name;
            Status = status;
            Conclusion = conclusion;
        }
    }
}
