namespace net_core.Models
{
    public class Instructor
    {
        
     public int Id { get; set; }
     public string Name { get; set; }       // שם המדריך
     public int Age { get; set; }            // גיל המדריך
     public int Experience { get; set; }     // שנות ניסיון
     public string Specialty { get; set; }   // תחום התמחות
     public string Phone { get; set; }       // מספר טלפון ליצירת קשר
        
    }
}
