namespace net_core.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }         // שם הפעילות
        public DateTime Date { get; set; }       // תאריך הפעילות
        public Instructor Instructor { get; set; } // המדריך המוביל
        public string Level { get; set; }        // רמת הפעילות (מתחיל, בינוני, מתקדם)
        public int MaxParticipants { get; set; } // מספר משתתפים מקסימלי

    }
}
