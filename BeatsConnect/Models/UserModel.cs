using System;

namespace BeatsConnect.Models
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public int SID { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
    }
}