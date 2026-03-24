namespace Gruzd_6
{
    public class zd3
    {
        public static void zd()
        {
            
            EducationInstitution[] institutions =
            {
                new OnlineSchool("SkillBox"),
                new University("БГУ"),
                new OnlineSchool("Udemy"),
                new University("ГрГУ"),
                new OnlineSchool("Coursera")
            };

            Console.WriteLine("Онлайн-школы:\n");

          
            foreach (var inst in institutions)
            {
                if (inst is IHasOnlineCourses online)
                {
                    online.ShowOnlineInfo();
                }
            }
        }
    }
}