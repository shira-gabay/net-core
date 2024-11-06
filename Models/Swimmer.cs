namespace net_core.Models
{
    public class Swimmer
    {

            public int Id { get; set; }          // תז מדריך
        public string Name { get; set; }        // שם השוחה
            public int Age { get; set; }          // גיל השוחה
            public string Level { get; set; }      // רמת השחייה: מתחיל, בינוני, מתקדם
            public string Email { get; set; }       // כתובת אימייל
            public string Phone { get; set; }       // מספר טלפון ליצירת קשר
        
    }
}
