using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiGallery.Views.Lists.Models
{
   public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

        

    public class MovieList 
    {
        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie(){
                Id = 1 , Name = "Sem Ar" ,
                Description = "Uma viagem de mergulho em alto mar se transforma em uma luta pela sobrevivência de duas irmãs. Ao ocorrer um catastrófico deslizamento de terra, rochas caem no oceano e as prendem abaixo da superfície." ,
                LaunchYear = 2023 , 
                Duration = new TimeSpan(1, 31, 0)
            
            });

            list.Add(new Movie() 
            {Id = 2 , 
            Name = "Pippa" ,
            Description = "Balram Singh Mehta se apresenta para provar seu valor durante a guerra indo-paquistanesa de 1971." ,
            LaunchYear = 2023 , 
            Duration = new TimeSpan(2 ,19 , 0)
            });

            list.Add(new Movie()
            {
                Id = 3,
                Name = "Oppenheimer",
                Description = "O físico J. Robert Oppenheimer trabalha com uma equipe de cientistas durante o Projeto Manhattan, levando ao desenvolvimento da bomba atômica.",
                LaunchYear = 2023,
                Duration = new TimeSpan(3, 00, 0)
            });

            list.Add(new Movie()
            {
                Id = 4 ,
                Name = "Interestelar",
                Description = "As reservas naturais da Terra estão chegando ao fim e um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial",
                LaunchYear = 2014 ,
                Duration = new TimeSpan(2, 49, 0)
            });
            list.Add(new Movie()
            {
                Id = 5 ,
                Name = "The Batman" ,
                Description = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como a personificação da vingança para a população.",
                LaunchYear = 2022 ,
                Duration = new TimeSpan(2 , 56 , 0)
            });    
            list.Add(new Movie()
            {
                Id = 6 ,
                Name = "Tropa de Elite" , 
                Description = "Nascimento, capitão da Tropa de Elite do Rio de Janeiro, é designado para chefiar uma das equipes que tem como missão apaziguar o Morro do Turano. Ele precisa cumprir as ordens enquanto procura por um substituto para ficar em seu lugar.",
                LaunchYear = 2007 ,
                Duration = new TimeSpan(1 , 55 , 0)
            });
            list.Add(new Movie()
            { 
                Id = 7 ,
                Name = "A socieade da neve" ,
                Description = "Em 1972, um voo vindo do Uruguai colide com uma geleira nos Andes. Apenas 29 dos seus 45 passageiros sobreviveram ao acidente. Presos em um dos ambientes mais hostis do planeta, eles são forçados a lutar pelas suas vidas." ,
                LaunchYear = 2023 ,
                Duration = new TimeSpan(2 , 24 , 0 )
            });
            list.Add(new Movie()
            {
                Id = 8 ,
                Name = "Corra!" ,
                Description = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador." ,
                LaunchYear = 2017 , 
                Duration = new TimeSpan(1 , 44 , 0)
            });
            list.Add(new Movie()
            {
                Id = 9 , 
                Name = "Django Livre" , 
                Description = "No sul dos Estados Unidos, o ex-escravo Django faz uma aliança inesperada com o caçador de recompensas Schultz para caçar os criminosos mais procurados do país e resgatar sua esposa de um fazendeiro que força seus escravos a participar de competições mortais." ,
                LaunchYear =2013 ,
                Duration = new TimeSpan(2 , 45 , 0)
            });
            list.Add(new Movie()
            { 
                Id = 10 ,
                Name = "Homem Aranha" , 
                Description = "Depois de ser picado por uma aranha geneticamente modificada em uma demonstração científica, o jovem nerd Peter Parker ganha superpoderes." ,
                LaunchYear = 2002 ,
                Duration = new TimeSpan(2 , 01 , 0) ,
            });


            return list;

        }
    
    
    }

}
