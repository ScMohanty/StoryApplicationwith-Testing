using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryApplication
{
  public  class Story
    {
        private string name;
        private string authorName;
        private string genre;
        private int noOfChapter;
        private int noOfReads;
        private int noOfLikes;


        public Story(string name, string authorName, string genre, int noOfChapter, int noOfLikes, int noOfReads)
        {
            Name = name;
            AuthorName = authorName;
            Genre = genre;
            NoOfChapter = noOfChapter;
            NoOfReads = noOfReads;
            NoOfLikes = noOfLikes;
        }

        public Story()
        {
        }

        public string Name { get => name; set => name = value; }
        public string AuthorName { get => authorName; set => authorName = value; }
        public string Genre { get => genre; set => genre = value; }
        public int NoOfChapter { get => noOfChapter; set => noOfChapter = value; }
        public int NoOfReads { get => noOfReads; set => noOfReads = value; }
        public int NoOfLikes { get => noOfLikes; set => noOfLikes = value; }

        public override string ToString()
        {
            return string.Format("{0,15} {1,15} {2,15} {3,15} {4,15} {5,15}",Name,AuthorName,Genre,NoOfChapter, NoOfLikes,NoOfReads);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
