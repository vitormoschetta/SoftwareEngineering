using Pattern.Interfaces;
using Pattern.Models;

namespace Pattern
{
    public class AloFactory
    {
        public IAloMundo CriaAloMundo(string opcao)
        {
            switch (opcao)
            {
                case "01":
                    return new EnglishAloMundo();
                case "02":
                    return new SpanishAloMundo();
                case "03":
                    return new GermanAloMundo();
                default:
                    return new EnglishAloMundo();
            }
        }
    }
}