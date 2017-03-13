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

        List<string> Requests { get; set; }

        List<Review> GetReviewsFromGroups(DateTime dateStart, DateTime dateFinish);

        List<Review> GetReviewsFromTopics(DateTime dateStart, DateTime dateFinish);
    }
}
