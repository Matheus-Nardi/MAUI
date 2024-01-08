using AppJogoDaForca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppJogoDaForca.Repositories
{
    class WordRepositories
    {
        private List <Word> _words;

        public WordRepositories()
        {
            _words = new List<Word>();
            _words.Add(new Word("Animal" , "Golfinho".ToUpper()));
            _words.Add(new Word("Animal" , "Macaco".ToUpper()));
            _words.Add(new Word("Animal" , "Gorila".ToUpper()));
            _words.Add(new Word("Animal" , "Gato".ToUpper()));
            _words.Add(new Word("Animal" , "Cachorro".ToUpper()));
            _words.Add(new Word("Fruta" , "Banana".ToUpper()));
            _words.Add(new Word("Fruta" , "Ameixa".ToUpper()));
            _words.Add(new Word("Objeto" , "Faca".ToUpper()));
            _words.Add(new Word("Vestimenta" , "Terno".ToUpper()));
            _words.Add(new Word("Vestimenta" , "Chapeu".ToUpper()));
            _words.Add(new Word("Vestimenta" , "Gravata".ToUpper()));
            _words.Add(new Word("Vestimenta" , "Meia".ToUpper()));
            _words.Add(new Word("País" , "Brasil".ToUpper()));
            _words.Add(new Word("País" , "Argentina".ToUpper()));
            _words.Add(new Word("País" , "Inglaterra".ToUpper()));
            _words.Add(new Word("País" , "Alemanha".ToUpper()));
            _words.Add(new Word("País" , "Espanha".ToUpper()));
            _words.Add(new Word("País" , "Portugal".ToUpper()));
            _words.Add(new Word("País" , "Franca".ToUpper()));

            _words.Add(new Word("Profissão" , "Advogado".ToUpper()));
            _words.Add(new Word("Profissão" , "Engenheiro".ToUpper()));
            _words.Add(new Word("Profissão" , "Medico".ToUpper()));
            _words.Add(new Word("Profissão" , "Professor".ToUpper()));
            _words.Add(new Word("Profissão" , "Programador".ToUpper()));
            _words.Add(new Word("Profissão" , "Policial".ToUpper()));
            _words.Add(new Word("Profissão" , "Bombeiro".ToUpper()));
        }

        public Word GetRandomWord()
        {
            Random random = new Random();
            int index = random.Next(0, _words.Count);
            return _words[index];
        }
    }
}
