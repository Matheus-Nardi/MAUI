﻿using AppMauiGallery.Models;
using AppMauiGallery.Views.Cells;
using AppMauiGallery.Views.Components.Forms;
using AppMauiGallery.Views.Components.Mains;
using AppMauiGallery.Views.Components.Visuals;
using AppMauiGallery.Views.Layouts;
using AppMauiGallery.Views.Lists;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Component = AppMauiGallery.Models.Component;

namespace AppMauiGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository
    {
        private void LoadData()
        {
            _components = new List<Component>();
            _groupComponents = new List<GroupComponent>();

            LoadLayouts();
            LoadControls();
            LoadVisuals();
            LoadForms();
            LoadCells();
            LoadCollections();
        }



        private void LoadLayouts()
        {

            var components = new List<Component>{
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
                    }


                 };


            var group = new GroupComponent() { Name = "Layouts" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);

        }

        private void LoadControls()
        {
            var components = new List<Component>
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
                };

            var group = new GroupComponent() { Name = "Controles" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);


        }

        private void LoadVisuals()
        {
            var components = new List<Component>
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

                };

            var group = new GroupComponent() { Name = "Visuais" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);

        }

        private void LoadForms()
        {
            var components = new List<Component>
                {
                    new Component
                    {
                        Title = "Entry" ,
                        Description = "Cria uma caixa de entrada de texto" ,
                        Page = typeof(EntryPage)
                    } ,

                    new Component
                    {
                        Title = "Editor" ,
                        Description = "Cria uma caixa de entrada de texto" ,
                        Page = typeof(EditorPage)
                    } ,
                    new Component
                    {
                        Title = "CheckBox" ,
                        Description = "Cria um checkbox" ,
                        Page = typeof(CheckBoxPage)
                    } ,

                    new Component
                    {
                        Title = "RadioButton" ,
                        Description = "Cria uma caixa de marcação de escolha única",
                        Page = typeof(RadioButtonPage)
                    } ,

                    new Component
                    {
                        Title = "Switch" ,
                        Description = "Caixa de marcação / liga/desliga" ,
                        Page = typeof(SwitchPage)
                    } ,

                    new Component
                    {
                        Title = "Stepper" ,
                        Description = "Cria um controle de incremento" ,
                        Page = typeof(StepperPage)

                    } ,

                    new Component
                    {
                        Title = "Slider" ,
                        Description = "Cria uma barra de incremento" ,
                        Page = typeof(SliderPage)

                    } ,

                    new Component
                    {
                         Title = "Time Picker" ,
                         Description = "Cria um controle de seleção de horas e minutos" ,
                         Page = typeof(TimePickerPage)
                    } ,
                    new Component
                    {
                         Title = "Date Picker" ,
                         Description = "Cria um controle de seleção de data" ,
                         Page = typeof(DatePickerPage)
                    } ,
                    new Component
                    {
                         Title = "Search Bar" ,
                         Description = "Campo de entrada de texto para pesquisa" ,
                         Page = typeof(SearchBarPage)
                    } ,
                    new Component
                    {
                         Title = "Picker" ,
                         Description = "Cria um controle de seleção de itens" ,
                         Page = typeof(PickerPage)
                    }

                };

            var group = new GroupComponent() { Name = "Formularios" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);
        }

        private void LoadCells()
        {
            var components = new List<Component>
                 {
                    new Component
                    {
                        Title = "TextCell",
                        Description = "Apresente até duas labels onde uma é destianada ao título e outro a descrição",
                        Page = typeof(TextCellPage)
                    } ,
                     new Component
                    {
                        Title = "ImageCell",
                        Description = "Apresente uma imagem com duas labels onde uma é destianada ao título e outro a descrição",
                        Page = typeof(ImageCellPage)
                    } ,
                     new Component
                     {
                         Title = "SwitchCell",
                         Description = "Apresenta uma única label em conjuto com um switch",
                         Page = typeof(SwitchCellPage)
                     } ,
                     new Component
                     {
                            Title = "EntryCell",
                            Description = "Apresenta uma única label em conjuto com um campo de entrada de texto",
                            Page = typeof(EntryCellPage)
                     },
                     new Component
                     {
                            Title = "ViewCell",
                            Description = "Apresenta uma view personalizada",
                            Page = typeof(ViewCellPage)
                     },

                 };

            var group = new GroupComponent() { Name = "Células" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);

        }

        private void LoadCollections()
        {
            var components =  new List<Component>
                 {
                    new Component
                    {
                        Title = "TableView",
                        Description = "Apresenta células em linhas separadas e permite agrupar por seção",
                        Page = typeof(TableViewPage)
                    } ,
                    new Component
                    {
                        Title = "Picker",
                        Description = "Apresenta uma lista de seleção única",
                        Page = typeof(PickerListPage)
                    } ,
                    new Component
                    {
                        Title = "ListView",
                        Description = "Apresenta uma lista de itens ",
                        Page = typeof(ListViewPage)
                    } ,
                    new Component
                    {
                        Title = "ColletionView",
                        Description = "Apresenta uma lista de itens ",
                        Page = typeof(CollectionViewPage)
                    } ,
                    new Component
                    {
                        Title = "CarouselView",
                        Description = "Apresenta uma lista de itens horizontais com navegação lateral",
                        Page = typeof(CarouselViewPage)
                    } ,
                    new Component
                    {
                        Title = "BindableLayout (Atributo)",
                        Description = "Permite que os layouts possam apresentar nossas listas e coleções",
                        Page = typeof(BindableLayoutPage)
                    },
                    new Component
                    {
                        Title = "DataTemplateSelector (Classe)",
                        Description = "Permite que os itens possam ser apresentados com layouts diferentes",
                        Page = typeof(DataTemplateSelectorPage)
                    },

                };
            var group = new GroupComponent() { Name = "Coleções e Listas" };
            group.AddRange(components);

            _components.AddRange(components);
            _groupComponents.Add(group);

        }

    }
}