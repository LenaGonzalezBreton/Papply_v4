using DynamicData;
using Papply.Models;


namespace Papply.Storage
{
    static class DataStorage
    {
        public static SourceCache<Degree, int> Degrees = new(d => d.IDDegree);
        public static SourceCache<Promotion, int> Promotions = new(p => p.IDPromotion);
        public static SourceCache<Student, int> Students = new(s => s.IDStudent);
        public static SourceCache<Task, int> Tasks = new(t => t.IDTask);
    }
}
