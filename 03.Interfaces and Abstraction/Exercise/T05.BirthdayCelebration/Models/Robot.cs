﻿using BirthdayCelebration.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebration.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }
        public string Id { get; private set; }
    }
}
