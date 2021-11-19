using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("ENTER THE NUMBER OF STORY YOU HAVE");
            int noOfStory = Convert.ToInt32(Console.ReadLine());
            List<Story> storyList = new List<Story>();

            List<Story> shortedOrder = new List<Story>();

            StoryBo classbo;


            for(int i=0;i<noOfStory;i++)
            {
                Console.WriteLine("The story details should be given as a comma-separated value in the below order name, authorName, genre, noOfChapters, noOfLikes, noOfReads");
                string storyDetails = Console.ReadLine();
                string[] storys = storyDetails.Split(',') ;
                Story story = new Story(storys[0], storys[1], storys[2], int.Parse(storys[3]), int.Parse(storys[4]), int.Parse(storys[5]));
               
                storyList.Add(story);
            }
            Console.WriteLine("ENTER 1 FOR SORTING BASED ON AUTHOR NAME/ENTER 2 FOR SORTING BASED ON NO OF LIKES");
            choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("ENTER THE AUTHOR NAME BASED ON AUTHOR NAME DETAILS WILL BE SHORTLISTED");
                    classbo = new StoryBo();
                    shortedOrder = classbo.findStory(storyList, Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("ENTER THE NUMBER OF LIKE ");
                    classbo = new StoryBo();
                    shortedOrder = classbo.findStory(storyList, Convert.ToInt32(Console.ReadLine()));
                    break;

                default:
                    {
                        Console.WriteLine("no such matching availabe");
                        break;
                    }
            }

            foreach(var item in shortedOrder)
            {
                Console.WriteLine(item);
            }

        }
    }
}
