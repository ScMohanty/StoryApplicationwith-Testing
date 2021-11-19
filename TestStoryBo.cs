using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using NUnit.Framework;
using StoryApplication;
namespace TestStoryApplication1
{
    [TestFixture]
    class TestStoryBo
    {
       StoryBo storyBo = null;
        static List<Story> storyList;


            [SetUp]
        public void SetUp()
        {
            storyBo = new StoryBo();
            storyList = new List<Story>();
            Story s = new Story("one", "subash", "young", 23, 3400, 4500);
            Story s1 = new Story("two", "subash", "young", 23, 7400, 9500);
            Story s2 = new Story("three", "lucky", "old", 232, 9400, 10500);
            Story s3 = new Story("four", "lucky", "young", 28, 4400, 10500);
            storyList.Add(s);
            storyList.Add(s1);
            storyList.Add(s2);
            storyList.Add(s3);
        }
        [Test]
       [TestCase("subash",2)]
        public void TestByAuthorName(string authorName,int length)
        {
            List<Story> sortedStory = storyBo.findStory(storyList, authorName);
            Assert.AreEqual(sortedStory.Count, length);
        }

        [Test]
        [TestCase("9400",1)]
        public void TestByNoOfLike(int likes,int length)
        {
            List<Story> sortedStory= storyBo.findStory(storyList, likes);
            Assert.AreEqual(sortedStory.Count, length);
        }
    }
}
