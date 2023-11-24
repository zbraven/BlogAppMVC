﻿namespace BlogAppMVC.Entity
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } 
            = null!;
        public List<Post> Posts { get; set; } = new List<Post>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
