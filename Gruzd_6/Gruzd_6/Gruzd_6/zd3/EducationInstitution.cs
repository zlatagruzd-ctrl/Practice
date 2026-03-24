namespace Gruzd_6
{

    public class EducationInstitution
    {
        public string Name { get; set; }

        public EducationInstitution(string name)
        {
            Name = name;
        }
    }


    public interface IHasOnlineCourses
    {
        void ShowOnlineInfo();
    }

  
    public interface IHasCampus
    {
        void ShowCampusInfo();
    }

    
    public class OnlineSchool : EducationInstitution, IHasOnlineCourses
    {
        public OnlineSchool(string name) : base(name) { }

        public void ShowOnlineInfo()
        {
            Console.WriteLine($"{Name}: предоставляет онлайн-курсы.");
        }
    }

    public class University : EducationInstitution, IHasCampus
    {
        public University(string name) : base(name) { }

        public void ShowCampusInfo()
        {
            Console.WriteLine($"{Name}: имеет кампус и очное обучение.");
        }
    }
}