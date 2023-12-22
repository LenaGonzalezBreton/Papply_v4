using DynamicData;
using Papply.Models;
using System.Threading.Tasks;

namespace Papply.Storage
{
    static class DataStorage
    {
        public static SourceCache<Models.Tp, string> Tps = new(t => t.IdTp);
        public static SourceCache<Models.Promotion, string> Promotions = new(p => p.IdPromotion);
        public static SourceCache<Models.Student, string> Students = new(s => s.IdStudent);
        public static SourceCache<Models.Task, string> Tasks = new(t => t.IdTask);
    }
}
