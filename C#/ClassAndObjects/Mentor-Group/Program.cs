using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Mentor_Group
{
    class Date
    {
        public string Name;
        public List<DateTime> Dates;
    }

    class Comments
    {
        public string Name;
        public string Comment;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> data = new List<string>();
            List<Date> userDates = new List<Date>();
            
            while (input != "end of dates")
            {
                data = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                Date currentDate = new Date();
                currentDate.Name = data[0];
                if (data.Count >1)
                {
                    List<DateTime> inputDates = new List<DateTime>();

                    for (int i = 1; i < data.Count; i++)
                    {
                        inputDates.Add(DateTime.ParseExact(data[i], "dd/MM/yyyy", CultureInfo.InvariantCulture));
                    }
                    
                    currentDate.Dates = inputDates;
                    
                }
                
                userDates.Add(currentDate);
                input = Console.ReadLine();
                data.Clear();
            }

            SortedDictionary<string, List<DateTime>> allStudents = new SortedDictionary<string, List<DateTime>>();
            foreach (var user in userDates)
            {
                if (!allStudents.ContainsKey(user.Name))
                {
                    allStudents[user.Name] = new List<DateTime>();
                }
                if (user.Dates != null)
                {
                    allStudents[user.Name].AddRange(user.Dates);
                }
                
            }                    
              

            string inputComments = Console.ReadLine();
            List<string> data2 = new List<string>();
            List<Comments> userComments = new List<Comments>();
            

            while (inputComments != "end of comments")
            {
                data2 = inputComments.Split('-').ToList();
                string name = data2[0];
                string comment = data2[1];

                Comments currentComment = new Comments();
                currentComment.Name = name;
                currentComment.Comment= comment;

                if (allStudents.ContainsKey(name))
                {
                     userComments.Add(currentComment);
                }

                inputComments = Console.ReadLine();
            }

          SortedDictionary<string, List<string>> commentOfUrser = new SortedDictionary<string, List<string>>();
            foreach (var user in userComments)
            {
                if (!commentOfUrser.ContainsKey(user.Name))
                {
                    commentOfUrser[user.Name] = new List<string>();
                }
                commentOfUrser[user.Name].Add(user.Comment);
            }

                    foreach (var user in allStudents)
                    {
                        Console.WriteLine(user.Key);
                        Console.WriteLine("Comments:");

                        if (commentOfUrser.ContainsKey(user.Key))
                        {
                           foreach (var comment in commentOfUrser[user.Key])
                           {
                                //foreach (string comment in student.Value)
                                //{
                                   Console.WriteLine($"- {comment}");
                                //}
                        
                           }
                        }
                
                        Console.WriteLine("Dates attended:");

                if (user.Value !=null)
                {
                    foreach (var item in user.Value.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {item:dd/MM/yyyy}");
                    }
                }
                            

                             
                         
                    }
           
        }
    }
}
