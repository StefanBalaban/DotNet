using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    class StackOverflowPost
    {
        public readonly DateTime Posted;
        public string Title { get; set; }
        public string Description { get; set; }
        private int VoteCount { get; set; } = 0;

        // This class is pretty simple, as it is initialized to a object it's Posted property is set to the current date and time, VoteCount property is set trough the Vote method and the other properties are public
        public StackOverflowPost()
        {
            Posted = DateTime.Now;
        }

        public void Vote(char vote)
        {
            if (vote == '+')
                VoteCount++;
            else if (vote == '-')
                VoteCount--;
        }

        
    }
}
