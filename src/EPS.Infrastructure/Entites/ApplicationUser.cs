﻿using EPS.Domain.ApplicationUser;


namespace EPS.Infrastructure.Entites
{
    public class ApplicationUser
    {
        public bool IsDeleted { get; set; }
        public UserType UserType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
