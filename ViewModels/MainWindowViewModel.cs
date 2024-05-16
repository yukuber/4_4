using System;
using System.Collections.Generic;
using _4_4.Models;
namespace _4_4.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
public MainWindowViewModel()
    {
        MainMenuEntity = new() 
        { 
            MainTopicsList = new List<string> {"Main topic 1","Main topic 2", "Main topic 3"},
        };
        
        BlogsEntities = new List<BlogsEntity>()
        {
            new BlogsEntity() 
            {
                Article = "Kas yra Lorem Ipsum?", 
                Text = "Lorem ipsum - tai fiktyvus tekstas naudojamas spaudos ir grafinio dizaino pasaulyje jau nuo XVI a. pradžios. Lorem Ipsum tapo standartiniu fiktyviu tekstu, kai nežinomas spaustuvininkas atsitiktine tvarka išdėliojo raides atspaudų prese ir tokiu būdu sukūrė raidžių egzempliorių. Šis tekstas išliko beveik nepasikeitęs ne tik penkis amžius, bet ir įžengė i kopiuterinio grafinio dizaino laikus. Jis išpopuliarėjo XX a. šeštajame dešimtmetyje, kai buvo išleisti Letraset lapai su Lorem Ipsum ištraukomis, o vėliau -leidybinė sistema AldusPageMaker, kurioje buvo ir Lorem Ipsum versija.", 
                ImagePath = "black_234x60.png",
                Tags = new List<string> {"Tag1       ", "Tag2       ", "Tag3"}
            },
            
            new BlogsEntity() 
            {
                Article = "Iš kur jis atsirado?",
                Text = "Daug kas galvoja, kad Lorem Ipsum - tai vien tik atsitiktinai surinktas tekstas, bet taip nėra. Jo šaknis galima rasti klasikiniame Lotynų kalba parašytame kūrinyje, išleistame 45 pr. m. e., t.y. prieš du tūkstančius metų. Richard McClintock, lotynų kalbos profesorius Hampden-Sydney (JAV) koledže, išrinko vieną iš neaiškesnių žodžių iš Lorem Ipsum ištraukos - „consectetur“, ir ėmėsi ieškoti jo klasikinėje lotynų kalbos literatūroje. Tokiu būdu jis rado neabejotiną šio žodžio ir Lorem Ipsum šaltinį knygos „de Finibus Bonorum et Malorum“ (Apie gėrio ir blogio ribas) 1.10.32 ir 1.10.33 pastraipose. Kūrinio autorius – Ciceronas, parašęs jį 45 pr. m. e. Šis etikos teorijos traktatas buvo labai populiarus Renesanso laikais. Pirmoji Lorem Ipsum teksto eilutė, „Lorem ipsum dolor sit amet..“ sukurta remiantis 1.10.32 pastraipa."
            },     
            new BlogsEntity() 
            {
                Article = "Это конец?",
                Text = "С группой 9.4 занятий больше не будет"
            }
        };
        NewsEntities = new List<NewsEntity>
        {
            new() { Text = "Президент России Владимир Путин прибыл в Харбин в рамках второй части рабочей поездки в Китай.", PublishTime = DateTime.Now },
            new() { Text = "ВАШИНГТОН, 16 мая — РИА Новости. Соединенные Штаты считают положение украинских войск невероятно отчаянным, заявил заместитель официального представителя Госдепа Ведант Патель.", PublishTime = DateTime.Now.AddDays(-1) }
        };
    }

    public MainEntity MainMenuEntity {get; set;}
    public List<BlogsEntity> BlogsEntities {get; set;}
    public List<NewsEntity> NewsEntities {get; set;}

    
}