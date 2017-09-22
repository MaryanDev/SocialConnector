﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SocialConnector.Entites.Entities
{
    public class Relationship
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FriendId { get; set; }
        public DateTime SendDate { get; set; }
        public DateTime? DateOfConfirmation { get; set; }
        public bool IsConfirmed { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        [ForeignKey(nameof(FriendId))]
        public User Friend { get; set; }
    }
}
