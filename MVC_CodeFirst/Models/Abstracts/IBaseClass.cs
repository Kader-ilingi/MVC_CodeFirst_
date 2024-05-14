namespace MVC_CodeFirst.Models.Abstracts
{
    public interface IBaseClass
    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
