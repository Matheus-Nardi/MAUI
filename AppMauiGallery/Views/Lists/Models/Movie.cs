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
        public Uri UrlImage { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    public class GroupMovie : List<Movie>
    {
        public String CompanyName { get; set; }
        
    }

        

    public class MovieList 
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGroup = new GroupMovie() { CompanyName = "Disney"};
                disneyGroup.Add(new Movie()
                {
                    Id = 1,
                    Name = "Sem Ar",
                    Description = "Uma viagem de mergulho em alto mar se transforma em uma luta pela sobrevivência de duas irmãs. Ao ocorrer um catastrófico deslizamento de terra, rochas caem no oceano e as prendem abaixo da superfície.",
                    LaunchYear = 2023,
                    Duration = new TimeSpan(1, 31, 0)

                });;

                disneyGroup.Add(new Movie()
                {
                    Id = 2,
                    Name = "Pippa",
                    Description = "Balram Singh Mehta se apresenta para provar seu valor durante a guerra indo-paquistanesa de 1971.",
                    LaunchYear = 2023,
                    Duration = new TimeSpan(2, 19, 0)
                });

                disneyGroup.Add(new Movie()
                {
                    Id = 3,
                    Name = "Oppenheimer",
                    Description = "O físico J. Robert Oppenheimer trabalha com uma equipe de cientistas durante o Projeto Manhattan, levando ao desenvolvimento da bomba atômica.",
                    LaunchYear = 2023,
                    Duration = new TimeSpan(3, 00, 0)
                });


            var paramoutGroup = new GroupMovie() { CompanyName = "Paramout" };

            paramoutGroup.Add(new Movie()
            {
                Id = 4,
                Name = "Interestelar",
                Description = "As reservas naturais da Terra estão chegando ao fim e um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial.",
                LaunchYear = 2014,
                Duration = new TimeSpan(2, 49, 0)
            });
            paramoutGroup.Add(new Movie()
            {
                Id = 5,
                Name = "The Batman",
                Description = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como a personificação da vingança para a população.",
                LaunchYear = 2022,
                Duration = new TimeSpan(2, 56, 0)
            });
            paramoutGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Tropa de Elite",
                Description = "Nascimento, capitão da Tropa de Elite do Rio de Janeiro, é designado para chefiar uma das equipes que tem como missão apaziguar o Morro do Turano. Ele precisa cumprir as ordens enquanto procura por um substituto para ficar em seu lugar.",
                LaunchYear = 2007,
                Duration = new TimeSpan(1, 55, 0)
            });
            paramoutGroup.Add(new Movie()
            {
                Id = 7,
                Name = "A socieadade da neve",
                Description = "Em 1972, um voo vindo do Uruguai colide com uma geleira nos Andes. Apenas 29 dos seus 45 passageiros sobreviveram ao acidente. Presos em um dos ambientes mais hostis do planeta, eles são forçados a lutar pelas suas vidas.",
                LaunchYear = 2023,
                Duration = new TimeSpan(2, 24, 0)
            });

            var universalGroup = new GroupMovie() { CompanyName = "Universal" };

            universalGroup.Add(new Movie()
            {
                Id = 8,
                Name = "Corra!",
                Description = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador.",
                LaunchYear = 2017,
                Duration = new TimeSpan(1, 44, 0)
            });
            universalGroup.Add(new Movie()
            {
                Id = 9,
                Name = "Django Livre",
                Description = "No sul dos Estados Unidos, o ex-escravo Django faz uma aliança inesperada com o caçador de recompensas Schultz para caçar os criminosos mais procurados do país e resgatar sua esposa de um fazendeiro que força seus escravos a participar de competições mortais.",
                LaunchYear = 2013,
                Duration = new TimeSpan(2, 45, 0)
            });
            universalGroup.Add(new Movie()
            {
                Id = 10,
                Name = "Homem Aranha",
                Description = "Depois de ser picado por uma aranha geneticamente modificada em uma demonstração científica, o jovem nerd Peter Parker ganha superpoderes.",
                LaunchYear = 2002,
                Duration = new TimeSpan(2, 01, 0),
            });
            List<GroupMovie> list = new List<GroupMovie>()
            {
                disneyGroup ,
                paramoutGroup ,
                universalGroup
            };

            return list;
            

        }
        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();
            list.Add(new Movie(){
                Id = 1 , Name = "Sem Ar" ,
                Description = "Uma viagem de mergulho em alto mar se transforma em uma luta pela sobrevivência de duas irmãs. Ao ocorrer um catastrófico deslizamento de terra, rochas caem no oceano e as prendem abaixo da superfície." ,
                UrlImage = new Uri("https://br.web.img2.acsta.net/c_310_420/pictures/23/08/07/19/09/5537249.png") ,
                LaunchYear = 2023 , 
                Duration = new TimeSpan(1, 31, 0)
            
            });

            list.Add(new Movie() 
            {Id = 2 , 
            Name = "Pippa" ,
            UrlImage= new Uri("https://m.media-amazon.com/images/M/MV5BODFkOWRhZTgtNzRjNi00MWM1LWFmMTAtOTM2YjJmZTdmZDY0XkEyXkFqcGdeQXVyMTY1MzAyNjU4._V1_.jpg"),
            Description = "Balram Singh Mehta se apresenta para provar seu valor durante a guerra indo-paquistanesa de 1971." ,
            LaunchYear = 2023 , 
            Duration = new TimeSpan(2 ,19 , 0)
            });

            list.Add(new Movie()
            {
                Id = 3,
                Name = "Oppenheimer",
                UrlImage= new Uri("https://upload.wikimedia.org/wikipedia/pt/5/5b/Oppenheimer_poster.jpg"),
                Description = "O físico J. Robert Oppenheimer trabalha com uma equipe de cientistas durante o Projeto Manhattan, levando ao desenvolvimento da bomba atômica.",
                LaunchYear = 2023,
                Duration = new TimeSpan(3, 00, 0)
            });

            list.Add(new Movie()
            {
                Id = 4 ,
                Name = "Interestelar",
                UrlImage = new Uri("https://musicart.xboxlive.com/7/b8841000-0000-0000-0000-000000000002/504/image.jpg?w=1920&h=1080"),
                Description = "As reservas naturais da Terra estão chegando ao fim e um grupo de astronautas recebe a missão de verificar possíveis planetas para receberem a população mundial.",
                LaunchYear = 2014 ,
                Duration = new TimeSpan(2, 49, 0)
            });
            list.Add(new Movie()
            {
                Id = 5 ,
                Name = "The Batman" ,
                UrlImage = new Uri("https://upload.wikimedia.org/wikipedia/pt/3/38/The_Batman_poster.jpg"),
                Description = "Após dois anos espreitando as ruas como Batman, Bruce Wayne se encontra nas profundezas mais sombrias de Gotham City. Com poucos aliados confiáveis, o vigilante solitário se estabelece como a personificação da vingança para a população.",
                LaunchYear = 2022 ,
                Duration = new TimeSpan(2 , 56 , 0)
            });    
            list.Add(new Movie()
            {
                Id = 6 ,
                Name = "Tropa de Elite" , 
                UrlImage = new Uri("data:image/jpeg;base64,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"),
                Description = "Nascimento, capitão da Tropa de Elite do Rio de Janeiro, é designado para chefiar uma das equipes que tem como missão apaziguar o Morro do Turano. Ele precisa cumprir as ordens enquanto procura por um substituto para ficar em seu lugar.",
                LaunchYear = 2007 ,
                Duration = new TimeSpan(1 , 55 , 0)
            });
            list.Add(new Movie()
            { 
                Id = 7 ,
                Name = "A socieadade da neve" ,
                UrlImage = new Uri("https://br.web.img2.acsta.net/r_1280_720/pictures/23/12/05/13/57/5988725.png"),
                Description = "Em 1972, um voo vindo do Uruguai colide com uma geleira nos Andes. Apenas 29 dos seus 45 passageiros sobreviveram ao acidente. Presos em um dos ambientes mais hostis do planeta, eles são forçados a lutar pelas suas vidas." ,
                LaunchYear = 2023 ,
                Duration = new TimeSpan(2 , 24 , 0 )
            });
            list.Add(new Movie()
            {
                Id = 8 ,
                Name = "Corra!" ,
                UrlImage = new Uri("https://br.web.img3.acsta.net/pictures/17/04/19/21/08/577190.jpg"),
                Description = "Chris é um jovem fotógrafo negro que está prestes a conhecer os pais de Rose, sua namorada caucasiana. Na luxuosa propriedade dos pais dela, Chris percebe que a família esconde algo muito perturbador." ,
                LaunchYear = 2017 , 
                Duration = new TimeSpan(1 , 44 , 0)
            });
            list.Add(new Movie()
            {
                Id = 9 , 
                Name = "Django Livre" , 
                UrlImage = new Uri("https://a-static.mlcdn.com.br/450x450/poster-cartaz-django-livre-c-pop-arte-poster/poparteskins2/15938531204/10cbfcb1c38f6ad2f6f7cc5576c83ee0.jpeg"),

                Description = "No sul dos Estados Unidos, o ex-escravo Django faz uma aliança inesperada com o caçador de recompensas Schultz para caçar os criminosos mais procurados do país e resgatar sua esposa de um fazendeiro que força seus escravos a participar de competições mortais." ,
                LaunchYear =2013 ,
                Duration = new TimeSpan(2 , 45 , 0)
            });
            list.Add(new Movie()
            { 
                Id = 10 ,
                Name = "Homem Aranha" , 
                UrlImage = new Uri("https://sm.ign.com/ign_br/screenshot/s/spider-man/spider-man-2002-poster-tobey-maguire-as-spider-man_dcy3.jpg") ,
                Description = "Depois de ser picado por uma aranha geneticamente modificada em uma demonstração científica, o jovem nerd Peter Parker ganha superpoderes." ,
                LaunchYear = 2002 ,
                Duration = new TimeSpan(2 , 01 , 0) ,
            });


            return list;

        }
    
    
    }

}
