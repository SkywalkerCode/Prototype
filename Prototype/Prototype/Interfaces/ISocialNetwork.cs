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

        void AddRequest(string query);

        void RemoveRequest(string query);

        List<Review> GetReviews(DateTime dateStart, DateTime dateFinish, bool discussions, bool topics);
    }
}
