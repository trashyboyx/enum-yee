using System;
using System.Collections.Generic;
using System.Text;

namespace enum_yee.Entities
{
    class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(Title);
            builder.Append(Likes);
            builder.Append(" likes - ");
            builder.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            builder.AppendLine(Content);
            builder.AppendLine("Comments: ");
            Comments.ForEach(comment =>
            {
                builder.AppendLine(comment.Text);
            });
            return builder.ToString();
        }
    }
}
