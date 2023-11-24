using DynamicData;
using Papply.Models;
using System.Threading.Tasks;

namespace Papply.Storage
{
    static class DataStorage
    {
        public static SourceCache<Models.Tp, int> TPS = new(t => t.IdTp);
        public static SourceCache<Models.Promotion, int> Promotions = new(p => p.IDPromotion);
        public static SourceCache<Models.Student, int> Students = new(s => s.IdStudent);
        public static SourceCache<Models.Task, int> Tasks = new(t => t.IdTask);
    }
}
