using System;
using System.Reflection.Emit;





class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "(Twime Technologies)";
        job1._jobTitle = "Branch Manager";
        job1._startYear = "2021";
        job1._endYear = "2024";

        Job job2 = new Job();
    
        job2._company = "(Southernbase)";
        job2._jobTitle = "IT Personel";
        job2._startYear = "2017";
        job2._endYear = "2019";


        Resume myResume = new Resume();
        myResume._name = "Jacob Okwusi Mbabo";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
            
    }
}