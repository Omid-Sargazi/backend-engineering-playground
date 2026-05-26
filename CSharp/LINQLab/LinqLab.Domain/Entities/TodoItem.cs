using LinqLab.Domain.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab.Domain.Entities
{
    public class TodoItem
    {
        public Guid Id { get; private set; }
        public string Title { get; private set; }
        public bool IsCompleted { get; private set; }
        public Priority Priority { get; private set; }

        public TodoItem(string title, Priority priority)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentNullException("title can not be empty.",nameof(title));
            }

            if(title.Length>100)
            {
                throw new ArgumentException("Title max length is 100", nameof(title));
            }
            Id = Guid.NewGuid();
            Title = title;
            Priority = priority;
            IsCompleted = false;
        }

        public void MarkComplete() => IsCompleted = true;
        public void MarkInCompleted() => IsCompleted = false;
    }
}
