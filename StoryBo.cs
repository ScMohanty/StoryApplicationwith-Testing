using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApplication
{
   public class StoryBo
    {
        public List<Story> findStory(List<Story> storyList, String authorName)
        {
            List<Story> result = new List<Story>();
           foreach(var item in storyList)
            {
                if(item.AuthorName.Equals(authorName))
                {
                    Console.WriteLine(item);
                    result.Add(item);
                }
            }
            return result;

        }
        public List<Story> findStory(List<Story> storyList, int noOfLikes)
        {
            List<Story> result = new List<Story>();
            foreach(var item in storyList)
            {
                if(item.NoOfLikes>= noOfLikes)
                {
                    result.Add(item);
                }
            }
            return result;
        }
       



    }
}
