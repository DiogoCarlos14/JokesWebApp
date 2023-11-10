namespace JokesWebApp.Models
{
    public class Jokes
    {
        public int Id { get; set; }

        public string Autor { get; set; }
        public string JokePergunta { get; set; }
        public string JokesRespostas { get; set; }

        public Jokes() {
            Id = 0;
            Autor = string.Empty;
            JokePergunta = string.Empty;
            JokesRespostas = string.Empty;
        }
    }
}
