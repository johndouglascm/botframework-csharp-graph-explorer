﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftGraphBot.Models
{
    [Serializable]
    public class BaseEntity
    {
        public BaseEntity() { }
        public BaseEntity(User user, EntityType type)
        {
            this.id = user.id;
            this.text = user.ToString();
            this.entityType = type;
        }
        public BaseEntity(Group group)
        {
            this.id = group.id;
            this.text = group.ToString();
            this.entityType = EntityType.Group;
        }

        public string id { get; set; }
        public string text { get; set; }
        public EntityType entityType { get; set; }

        public override string ToString()
        {
            return this.text;
        }
    }
}
