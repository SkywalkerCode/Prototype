using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Tools
{
    public interface ISocialNetwork
    {
        bool Autorization();

        bool IsAuthorized { get; }

        string Name { get; }

        void AddQuery(string query);

        void RemoveQuery(string query);

        List<Review> GetComments(DateTime dateStart, DateTime dateFinish, bool discussions, bool topics);
    }
}
