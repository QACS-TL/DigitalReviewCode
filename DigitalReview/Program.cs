namespace DigitalReview
{
    class Program
    {
        public static void Main()
        {
            SequenceSelectionAndIteration();
            ClassesAndProperties();
            PrivateInternalProtectedAndPublic();
            ExceptionHandlingLogic();
            InheritanceAndPolymorphism();
            LinqAndLambda();

            Console.WriteLine("End");
        }

        public static void SequenceSelectionAndIteration()
        {
            Console.WriteLine("Here's an example of Sequence:");
            Console.WriteLine("You will see this first");
            Console.WriteLine("You will see this next");
            Console.WriteLine("And then you'll see this.");

            Console.WriteLine("Here's an example of Selection:");
            Console.WriteLine("Yes or No?");
            string response = Console.ReadLine();
            if (response != null && response.ToLower() == "yes")
            {
                Console.WriteLine("YES! Alright!!!!");
            }
            else
            {
                Console.WriteLine("NO? That's a shame");
            }

            Console.WriteLine("Here's an example of Iteration:");
            Console.WriteLine("How many loops?");
            string loopLimit = Console.ReadLine();
            if (response != null && Int32.TryParse(loopLimit, out int numValue))
            {
                for(int i = 1; i <= numValue; i++)
                {
                    string pluralise = i == 1 ? "" : "s";
                    Console.WriteLine($"I love looping I've done it {i} time{pluralise}");
                }
            }
            else
            {
                Console.WriteLine("You should have entered something numeric!");
            }
        }

        public static void ClassesAndProperties()
        {
            List<string> text = new List<string>();
            text.Add("Well, my prince, Genoa and Lucca are now no more than possessions, estates, of the Buonaparte family");
            text.Add("But I warn you, if you don't tell me that this means war, if you still try to defend the infamies and horrors perpetrated by that Antichrist- I really believe he is Antichrist- I will have nothing more to do with you and you are no longer my friend, no longer my 'faithful slave,' as you call yourself! But how do you do? I see I have frightened you- sit down and tell me all the news.");
            text.Add("Blah, blah, blah");
            text.Add("This goes on for hours...");
            text.Add("Blah ,blah,, blah");
            text.Add("In the first case, the need was to renounce the consciousness of a nonexistent immobility in space and recognize a movement we do not feel; in the present case, it is just as necessary to renounce a nonexistent freedom and recognize a dependence we do not feel.");

            Movie movie = new Movie
            {
                ID = 1,
                Title = "War and Peace (abridged)",
                Script = text
            };
            movie.RollTheFilm();
           
        }

        public static void PrivateInternalProtectedAndPublic()
        {
            List<string> text = new List<string>();
            text.Add("Eh, what's up, doc?");
            text.Add("Th-th-th-that's all, folks!");
            text.Add("Meep! Meep!");
            text.Add("You're dethpicable!");
            text.Add("Why you wascawwy wabbit!");
            text.Add("Sufferin' succotash!");
            text.Add("What's the big idea, son?");
            text.Add("I will name him George");

            Drama film = new Drama
            {
                ID = 2,
                Title = "Bugs Bunny - The Movie",
                Script = text
            };

            Console.WriteLine(film.anyoneCanSeeThisEvenCodeInOtherApps);
            Console.WriteLine(film.otherFilesInTheSameAppMightWellSeeThis);

            //Console.WriteLine(film.theOutsideWorldCannotSeeThis);
            //Console.WriteLine(film.onlyVisibleToCodeInClassesThatInheritFromThis);
        }

        public static void ExceptionHandlingLogic()
        {
            int numerator = 100;
            int denominator = 0;
            int result = 0;

            try
            {
                //Possible division by zero
                result = numerator / denominator;
                Console.WriteLine("You may see this, but not if the line before triggers an exception");
                return;
            }
            catch(Exception exn)
            {
                Console.WriteLine(exn);
            }
            finally
            {
                Console.WriteLine("This line will be printed no matter what");
            }
            Console.WriteLine("You will only see this if an error occurred");
        }

        public static void InheritanceAndPolymorphism()
        {
            //Inheritance
            Drama drama = new Movie();
            //Could be made to work:
            //drama.RollTheFilm()
            TheatricalPlay play = new TheatricalPlay();
            Movie movie = new Movie();

            List<Drama> dramas = new List<Drama>();
            dramas.Add(drama);
            dramas.Add(play);
            dramas.Add(movie);

            foreach(Drama d in dramas)
            {
                Console.WriteLine(d.Play());
            }

        }

        public static void LinqAndLambda()
        {
            List<string> text = new List<string>();
            text.Add("Well, my prince, Genoa and Lucca are now no more than possessions, estates, of the Buonaparte family");
            text.Add("But I warn you, if you don't tell me that this means war, if you still try to defend the infamies and horrors perpetrated by that Antichrist- I really believe he is Antichrist- I will have nothing more to do with you and you are no longer my friend, no longer my 'faithful slave,' as you call yourself! But how do you do? I see I have frightened you- sit down and tell me all the news.");
            text.Add("Blah, blah, blah");
            text.Add("This goes on for hours...");
            text.Add("Blah ,blah, blah");
            text.Add("In the first case, the need was to renounce the consciousness of a nonexistent immobility in space and recognize a movement we do not feel; in the present case, it is just as necessary to renounce a nonexistent freedom and recognize a dependence we do not feel.");

            Movie film1 = new Movie
            {
                ID = 1,
                Title = "War and Peace (abridged)",
                Script = text
            };

            text = new List<string>();
            text.Add("Eh, what's up, doc?");
            text.Add("Th-th-th-that's all, folks!");
            text.Add("Meep! Meep!");
            text.Add("You're dethpicable!");
            text.Add("Why you wascawwy wabbit!");
            text.Add("Sufferin' succotash!");
            text.Add("What's the big idea, son?");
            text.Add("I will name him George");

            Drama film2 = new Drama
            {
                ID = 2,
                Title = "Bugs Bunny - The Movie",
                Script = text
            };


            text = new List<string>();
            text.Add("Call me Ishmael.");
            text.Add("Crunch!");
            text.Add("And I only am escaped alone to tell thee.");

            Drama film3 = new Drama
            {
                ID = 3,
                Title = "Moby Dick",
                Script = text
            };


            text = new List<string>();
            text.Add("In my younger and more vulnerable years my father gave me some advice that I’ve been turning over in my mind ever since.");
            text.Add("Eat, drink, dance and be merry!");
            text.Add("So we beat on, boats against the current, borne back ceaselessly into the past.");

            Drama film4 = new Drama
            {
                ID = 4,
                Title = "The Great Gatsby",
                Script = text
            };


            List<Drama> dramas = new List<Drama>();
            dramas.Add(film1);
            dramas.Add(film2);
            dramas.Add(film3);
            dramas.Add(film4);

            //LINQ using query notation
            Console.WriteLine("\nMovies with the word 'the' in them:");
            var movies = from film in dramas
                         where film.GetScriptAsText().ToLower().Contains("the")
                         select film;
            foreach(Drama film in movies)
            {
                Console.WriteLine(film.Title);
            }

            //LINQ using Lambda notation
            Console.WriteLine("\nMovies with the word 'Blah' in them:");
            var movies2 = dramas
                     .Where(d => d.GetScriptAsText().ToLower().Contains("blah"))
                     .Select(d => new { Title = d.Title, Text = d.GetScriptAsText() });
            foreach (var film in movies2)
            {
                Console.WriteLine(film.Title);
            }
        }

    }
}