using net_core.Models;

namespace net_core
{
    public class Data
    {

        public static List<Instructor> Instructors { get; set; } = new List<Instructor>
    {
        new Instructor { Id=1, Name = "יוסי", Age = 30, Experience = 5, Specialty = "שחיית גב", Phone = "050-1234567" },
        new Instructor { Id=2, Name = "מיכל", Age = 28, Experience = 3, Specialty = "שחיי", Phone = "050-2345678" },
        new Instructor { Id=3, Name = "רמי", Age = 35, Experience = 10, Specialty = "שחיית פרפר", Phone = "050-3456789" },
        new Instructor { Id=4, Name = "עדי", Age = 32, Experience = 7, Specialty = "שחיית חופשי", Phone = "050-4567890" },
        new Instructor { Id=5, Name = "טל", Age = 26, Experience = 2, Specialty = "שחיית מים פתוחים", Phone = "050-5678901" }
    };

        public static List<Swimmer> Swimmers { get; set; } = new List<Swimmer>
    {
        new Swimmer { Id=1,Name = "דניאל", Age = 12, Level = "מתחיל", Email = "daniel@example.com", Phone = "050-6789012" },
        new Swimmer { Id=2,Name = "נועה", Age = 14, Level = "בינוני", Email = "noa@example.com", Phone = "050-7890123" },
        new Swimmer { Id=3,Name = "איתי", Age = 11, Level = "מתקדם", Email = "itai@example.com", Phone = "050-8901234" },
        new Swimmer { Id=4,Name = "מאיה", Age = 15, Level = "מתחיל", Email = "maya@example.com", Phone = "050-9012345" },
        new Swimmer { Id=5,Name = "עומר", Age = 13, Level = "בינוני", Email = "omer@example.com", Phone = "050-0123456" }
    };

        public static List<Activity> Activities { get; set; } = new List<Activity>
    {
        new Activity {Id=1, Name = "שחייה מהירה", Date = new DateTime(2024, 10, 15), Instructor = Instructors[0], Level = "בינוני", MaxParticipants = 10 },
        new Activity {Id=2, Name = "שחיית סגנונות", Date = new DateTime(2024, 10, 16), Instructor = Instructors[1], Level = "מתחיל", MaxParticipants = 12 },
        new Activity {Id=3, Name = "תחרות שחייה", Date = new DateTime(2024, 10, 17), Instructor = Instructors[2], Level = "מתקדם", MaxParticipants = 15 },
        new Activity {Id=4, Name = "שחיית פרפר", Date = new DateTime(2024, 10, 18), Instructor = Instructors[3], Level = "בינוני", MaxParticipants = 8 },
        new Activity {Id=5, Name = "שחייה חופשית", Date = new DateTime(2024, 10, 19), Instructor = Instructors[4], Level = "מתחיל", MaxParticipants = 20 }
    };
    }
}
