using LinqLab.Domain.Consts;
using LinqLab.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
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
                throw new BusinessRuleViolationException("title can not be empty.");
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

        public void UpdateTitle(string newTitle)
        {
            ValidateTitle(newTitle);
            Title = newTitle;
        }

        private void ValidateTitle(string title)
        {
            if(string.IsNullOrWhiteSpace(title))
            {
                throw new BusinessRuleViolationException("Title cannot be empty.");
            }

            if(title.Length>100)
            {
                throw new BusinessRuleViolationException("Title max length is 100");
            }
        }

        public void MarkComplete() => IsCompleted = true;
        public void MarkInCompleted() => IsCompleted = false;
    }
}
