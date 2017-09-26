﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocialConnector.Entites.EF_DbContext;
using SocialConnector.Entites.Entities;
using SocialConnector.Models.Security;

namespace SocialConnector.Mappings.Security
{
    public static class UserMapping
    {
        public static User MapUserFromRegisterModel(RegisterModel rm, SocialConnectorDbContext context)
        {
            return new User
            {
                Email = rm.Email,
                Password = rm.Password,
                UserName = rm.UserName,
                FirstName = rm.FirstName,
                LastName = rm.LastName,
                Nationality = context.Nationalities.FirstOrDefault(n => n.Title == rm.Nationality),
                Religion = context.Religions.FirstOrDefault(r => r.Title == rm.Religion),
                PlaceOfBirth = rm.PlaceOfBirth,
                DateOfBirth = rm.DateOfBirth,
                DateStarted = DateTime.Today,
                Gender = context.Genders.FirstOrDefault(g => g.Title == rm.Gender.ToString())
            };
        }
    }
}