using AppMauiGallery.Models;
using AppMauiGallery.Views.Components.Mains;
using AppMauiGallery.Views.Components.Visuals;
using AppMauiGallery.Views.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMauiGallery.Repositories
{
    internal class CategoryRepository
    {
        public CategoryRepository() { }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category
            {
                Name = "Layout",
                Components = new List<Component>{
                    new Component {
                    Title = "Stack Layout",
                    Description = "Organização sequencial dos elementos",
                    Page = typeof(StackLayoutPage)
                } ,
                    new Component
                    {
                        Title = "Grid" ,
                        Description = "Organização dos elementos em tabela" ,
                        Page = typeof(GridLayoutPage)
                    },

                    new Component
                    {
                        Title = "Absolute Layout",
                        Description = "Liberdade total para posicionar e dimensionar elementos na tela" ,
                        Page = typeof(AbsoluteLayoutPage)
                    } ,

                    new Component
                    {
                        Title = "Flex Layout" ,
                        Description = "Organiza os elementos de forma sequencial e com muitas opções de personalização" ,
                        Page = typeof(FlexLayoutPage)
                    } ,


                 }
            });


            categories.Add(new Category
            {
                Name = "Componentes(Views)",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "Box View",
                        Description = "Um componente que exibe uma caixa colorida",
                        Page = typeof(BoxViewPage)
                    } ,
                    new Component
                    {
                        Title = "Label",
                        Description = "Um componente que exibe um texto",
                        Page = typeof(LabelPage)
                    } ,
                    new Component
                    {
                        Title = "Button",
                        Description = "Um componente que exibe um botão",
                        Page = typeof(ButtonPage)
                    } ,
                    new Component
                    {
                        Title = "Image",
                        Description = "Um componente que exibe uma imagem",
                        Page = typeof(ImagePage)
                    } ,

                    new Component
                    {
                        Title = "ImageButton",
                        Description = "Um componente que exibe uma imagem e permite interação",
                       Page = typeof(ImageButtonPage)
                    }
                }
            });

            categories.Add(new Category
            {
                Name = "Visuais",
                Components = new List<Component>
                {
                    new Component
                    {
                        Title = "Frame",
                        Description = "Caixa que envolve outro elementos",
                        Page = typeof(FramePage)
                    } ,

                    new Component
                    {
                        Title = "Border",
                        Description = "Caixa que envolve outro elementos",
                        Page = typeof(BorderPage)
                    } ,
                    new Component
                    {
                        Title = "Shadow" ,
                        Description = "Adiciona sombra a um elemento" ,
                        Page = typeof(ShadowPage)
                    
                    }

                    
                }


            });




            return categories;
        }
    }
}
