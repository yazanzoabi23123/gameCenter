﻿using gameCenter.Projects.Project1.Models;
using System;
using System.Threading;

namespace WpfApp1.Models
{
    internal class User
    {
        public static int count =0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastLogIn { get; set; }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Status = UserStatusTypes.Logged_Off.ToString();
            Created = DateTime.Now;
            count++;
            Id = count;
        }
    }
}
