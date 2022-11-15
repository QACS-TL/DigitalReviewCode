using DigitalReview;

namespace DramaAndArtTests
{
    public class DramaTests
    {
        [Fact]
        public void MovieWithText()
        {
            //Arrange
            List<string> text = new List<string>();
            text.Add("Eh, what's up, doc?");
            text.Add("Th-th-th-that's all, folks!");
            text.Add("Meep! Meep!");
            text.Add("You're dethpicable!");
            text.Add("Why you wascawwy wabbit!");
            text.Add("Sufferin' succotash!");
            text.Add("What's the big idea, son?");
            text.Add("I will name him George");

            Drama film = new Movie
            {
                ID = 2,
                Title = "Bugs Bunny - The Movie)",
                Script = text
            };


            //Act
            string isItAPlay = film.Play();


            //Assert
            Assert.Equal("No, this is a movie", isItAPlay);

        }
    }
}