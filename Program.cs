namespace music
{
    class Program
    {
        enum Genre
        {
            Pop,
            Country,
            Rock,
            Classical,
            Jazz
        }
        struct Music
        {
            private string? Title;
            private string? Artist;
            private string? Album;
            private string? Length;
            private Genre? Genre;

            public void setTitle(string? title)
            {
                Title = title;
            }
            public void setArtist(string? artist)
            {
                Artist = artist;
            }
            public void setAlbum(string? album)
            {
                Album = album;
            }
            public void setLength(string? length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("How many songs would you like to enter?");
            int size = int.Parse(Console.ReadLine() ?? "0");

            Music[] collection = new Music[size];

            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("What is the song title?");
                    string? tempTitle = Console.ReadLine();
                    collection[i].setTitle(tempTitle);

                    Console.WriteLine("Who is the artist?");
                    string? tempArtist = Console.ReadLine();
                    collection[i].setArtist(tempArtist);

                    Console.WriteLine("What is the album?");
                    string? tempAlbum = Console.ReadLine();
                    collection[i].setAlbum(tempAlbum);

                    Console.WriteLine("What is the length?");
                    string? tempLength = Console.ReadLine();
                    collection[i].setLength(tempLength);

                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("A - pop\nH - country\nS - rock\nR - classical\nD - jazz");
                    Genre tempGenre = Genre.Pop;
                    char g = char.Parse(Console.ReadLine() ?? "A");
                    switch (g)
                    {
                        case 'A':
                            tempGenre = Genre.Pop;
                            break;
                        case 'H':
                            tempGenre = Genre.Country;
                            break;
                        case 'S':
                            tempGenre = Genre.Rock;
                            break;
                        case 'R':
                            tempGenre = Genre.Classical;
                            break;
                        case 'D':
                            tempGenre = Genre.Jazz;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }
        }
    }
}
