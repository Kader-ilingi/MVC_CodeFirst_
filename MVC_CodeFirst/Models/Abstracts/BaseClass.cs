namespace MVC_CodeFirst.Models.Abstracts
{
    public abstract class BaseClass : IBaseClass
    {
        public int ID { get; set ; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
    }
}
