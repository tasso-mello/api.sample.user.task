﻿namespace domain.paysimplex.Models
{
    using domain.paysimplex.Enums;
    using domain.paysimplex.Models.Base;
    using System;
    public class Task : BaseModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public State State { get; set; } = State.Scheduled;
        public DateTime? Start { get; set; } = DateTime.Today;
        public DateTime? End { get; set; }
        public TimeSpan EstimatedTime { get; set; }
        public string File { get; set; } //Blob
        public long? UserId { get; set; }
        public User User { get; set; }
    }
}
