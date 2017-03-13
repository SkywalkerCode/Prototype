using Prototype.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkNet;
using VkNet.Enums.Filters;
using VkNet.Model;
using VkNet.Model.RequestParams;

namespace Prototype.SocialNetwork
{
    public class VK : ISocialNetwork
    {
        private VkApi Vk;
        private List<string> requests;
        private string NameSocialNetwork;

        public VK()
        {
            Requests = new List<string>();
            Vk = new VkApi();
            NameSocialNetwork = "Вконтакте";
        }

        public bool IsAuthorized
        {
            get
            {
                return Vk.IsAuthorized;
            }
        }

        public string Name
        {
            get
            {
                return NameSocialNetwork;
            }
        }

        public bool Autorization()
        {
            try
            {
                Vk.Authorize(new ApiAuthParams()
                {
                    ApplicationId = 5913355,
                    Login = "79655776464",
                    Password = "Prototype8080",
                    Settings = Settings.All
                });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<string> Requests
        {
            get
            {
                return requests;
            }
            set
            {
                requests = value;
            }
        }

        public List<Review> GetReviewsFromGroups(DateTime dateStart, DateTime dateFinish)
        {
            List<Review> Reviews = new List<Review>();
            foreach (string request in Requests)
            {
                Reviews.AddRange(SearchInGroups(dateStart, dateFinish, request));
            }
            return Reviews;
        }

        public List<Review> GetReviewsFromTopics(DateTime dateStart, DateTime dateFinish)
        {
            List<Review> Reviews = new List<Review>();
            foreach (string request in Requests)
            {
                Reviews.AddRange(SearchInTopics(dateStart, dateFinish, request));
            }
            return Reviews;
        }

        private List<Review> SearchInTopics(DateTime dateStart, DateTime dateFinish, string request)
        {
            List<Review> Reviews = new List<Review>();
            foreach (NewsSearchResult newsResult in GetNews(dateStart, dateFinish, request))
            {
                string text = newsResult.Text;
                string uri = String.Format("vk.com/wall{0}_{1}", newsResult.OwnerId, newsResult.Id);
                Reviews.Add(new Review(text, uri));
            }
            return Reviews;
        }

        private List<NewsSearchResult> GetNews(DateTime dateStart, DateTime dateFinish, string request)
        {
            NewsFeedSearchParams newsParams = new NewsFeedSearchParams
            {
                Query = request,
                Count = 200,
                StartTime = dateStart,
                EndTime = dateFinish
            };
            return Vk.NewsFeed.Search(newsParams).ToList();
        }

        private List<Review> SearchInGroups(DateTime dateStart, DateTime dateFinish, string request)
        {
            List<Review> Reviews = new List<Review>();
            foreach (Group group in GetGroups(request))
            {
                if (group.IsClosed == 0)
                {
                    foreach (Topic topic in GetTopics(group))
                    {
                        if (topic.Сreated.Value.Date <= dateFinish && topic.Updated.Value.Date >= dateStart)
                        {
                            foreach (Comment comment in GetComments(group, topic, dateStart, dateFinish))
                            {
                                string text = comment.Text;
                                string uri = String.Format("vk.com/topic{0}_{1}?post={2}", group.Id, topic.Id, comment.Id);
                                Reviews.Add(new Review(text, uri));
                            }
                        }
                    }
                }
            }
            return Reviews;
        }

        private List<Group> GetGroups(string request)
        {
            List<Group> resultGroups = new List<Group>();
            List<Group> newGroups;
            GroupsSearchParams groupsParams = new GroupsSearchParams
            {
                Query = request,
                CityId = 110,
                Count = 1000,
                Offset = 0
            };
            do
            {
                try
                {
                    newGroups = Vk.Groups.Search(groupsParams).ToList();
                }
                finally
                {
                    System.Threading.Thread.Sleep(1000);
                    newGroups = Vk.Groups.Search(groupsParams).ToList();
                }
                resultGroups.AddRange(newGroups);
                groupsParams.Offset += groupsParams.Count;
            }
            while (newGroups.Count != 0);
            return resultGroups;
        }

        private List<Topic> GetTopics(Group group)
        {
            List<Topic> resultTopics = new List<Topic>();
            List<Topic> newTopics;
            BoardGetTopicsParams topicsParams = new BoardGetTopicsParams
            {
                GroupId = group.Id,
                Count = 100,
                Offset = 0
            };
            do
            {
                try
                {
                    newTopics = Vk.Board.GetTopics(topicsParams).ToList();
                }
                finally
                {
                    System.Threading.Thread.Sleep(1000);
                    newTopics = Vk.Board.GetTopics(topicsParams).ToList();
                }
                resultTopics.AddRange(newTopics);
                topicsParams.Offset += topicsParams.Count;
            }
            while (newTopics.Count != 0);
            return resultTopics;
        }

        private List<Comment> GetComments(Group group, Topic topic, DateTime dateStart, DateTime dateFinish)
        {
            List<Comment> resultComments = new List<Comment>();
            List<Comment> newComments;
            BoardGetCommentsParams commentsParams = new BoardGetCommentsParams
            {
                TopicId = topic.Id,
                GroupId = group.Id,
                Count = 100,
                Offset = 0
            };
            do
            {
                try
                {
                    newComments = Vk.Board.GetComments(commentsParams).Items.ToList();
                }
                finally
                {
                    System.Threading.Thread.Sleep(1000);
                    newComments = Vk.Board.GetComments(commentsParams).Items.ToList();
                }
                commentsParams.Offset += commentsParams.Count;
                if (newComments.Count > 0)
                {
                    newComments = SelectionOnTime(newComments, dateStart, dateFinish);
                    resultComments.AddRange(newComments);
                }
            }
            while (newComments.Count != 0);
            return resultComments;
        }

        private List<Comment> SelectionOnTime(List<Comment> comments, DateTime dateStart, DateTime dateFinish)
        {
            List<Comment> resultComments = new List<Comment>();
            DateTime dateFirstComment = GetDate(comments[0]);
            DateTime dateLastComment = GetDate(comments[comments.Count - 1]);
            if (dateFirstComment >= dateStart || dateLastComment <= dateFinish)
            {
                if (dateFirstComment >= dateStart && dateLastComment <= dateFinish)
                {
                    return comments;
                }
                else
                {
                    foreach(Comment comment in comments)
                    {
                        DateTime dateComment = GetDate(comment);
                        if (dateComment >= dateStart && dateComment <= dateFinish)
                        {
                            resultComments.Add(comment);
                        }
                    }
                }
            }
            return resultComments;
        }

        private DateTime GetDate(Comment comment)
        {
            return new DateTime(
                    comment.Date.Value.Year,
                    comment.Date.Value.Month,
                    comment.Date.Value.Day
                    );
        }
    }
}
