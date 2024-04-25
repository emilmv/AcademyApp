
namespace Academy.Core.Entities
{
    public class Group
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Limit { get; set; }
        public List<Student> Students { get; set; }
    }
}
