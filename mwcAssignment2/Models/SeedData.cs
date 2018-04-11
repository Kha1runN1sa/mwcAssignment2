using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace mwcAssignment2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new mwcAssignment2Context(
                serviceProvider.GetRequiredService<DbContextOptions<mwcAssignment2Context>>()))
            {
                // Look for any movies.
                if (context.Blog.Any())
                {
                    return;   // DB has been seeded
                }

                context.Blog.AddRange(
    new Blog
    {
        Title = "Oatfarm Elit do minim fugiat Lorem consectetur elit ullamco aliquip consectetur.",
        Author = "Annette Pena",
        Date = DateTime.Parse("01/05/2016"),
        Avatar = "http://placehold.it/40x40",
        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
        Views = "27019",
        Email = "annettepena@oatfarm.com",
        Article = "Quis dolor aute cillum laboris non. Incididunt sit fugiat nisi sint anim sunt quis aliquip culpa velit ut. Officia incididunt deserunt dolore laboris nulla ad esse exercitation ipsum consectetur irure aute esse consequat.<br>Quis culpa sit fugiat duis anim fugiat eu. Ad minim consequat voluptate amet minim dolore Lorem cillum. Et deserunt irure aliquip dolore officia ullamco consequat quis eu est in nisi. Duis quis cillum ut sunt quis. Qui ipsum ad mollit pariatur culpa nulla sit ipsum et et mollit voluptate ullamco elit. Ex esse exercitation est et sit adipisicing est quis anim culpa laboris nisi.<br>",
        ArticleIntro = "est incididunt sunt aliquip pariatur non eiusmod ullamco est laborum tempor sint voluptate elit ullamco excepteur eiusmod velit magna eu sunt aliqua pariatur eiusmod ut aliquip est dolor ullamco Lorem sit cillum duis deserunt ea officia eiusmod velit sint nisi commodo officia sunt velit adipisicing commodo enim amet sit esse",
        Tag = "kittens"
    }
);

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Utarian Cupidatat sunt velit aliquip sunt.",
                        Author = "Marietta Hickman",
                        Date = DateTime.Parse("04/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "35141",
                        Email = "mariettahickman@utarian.com",
                        Article = "Fugiat Lorem minim quis voluptate ad do laboris id ullamco anim sint. Et quis nulla sunt nulla magna dolore minim consectetur anim proident. Dolor nostrud anim aliquip ea est nulla et sunt veniam Lorem ad. Commodo adipisicing anim aliqua elit sint velit duis ipsum sit. Ea aliqua ut qui esse proident culpa. Duis sit dolor occaecat velit nostrud ullamco nulla cupidatat officia veniam esse consectetur pariatur. Quis sint cillum officia est deserunt qui consequat deserunt.<br>Elit laborum sunt reprehenderit laborum mollit aute. Veniam magna duis voluptate duis eiusmod est laboris consequat enim in consequat cupidatat. Eiusmod esse culpa sunt nulla fugiat culpa deserunt aliqua aliquip ipsum mollit. Quis ullamco irure laborum fugiat in nisi elit eiusmod aliquip et tempor commodo ad. Exercitation ut consectetur eiusmod nisi pariatur esse magna reprehenderit.<br>",
                        ArticleIntro = "qui non sit do eiusmod proident consequat eiusmod consectetur eu cupidatat sint qui officia et exercitation irure incididunt laboris tempor fugiat qui do non velit ex ut non ullamco deserunt do ea cillum officia qui aliquip labore aute commodo esse esse anim incididunt amet dolore ad fugiat ad non eu",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Datagene Dolore sit qui consectetur dolor magna exercitation velit anim esse est ut sint ut.",
                        Author = "Briana Franks",
                        Date = DateTime.Parse("01/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "32293",
                        Email = "brianafranks@datagene.com",
                        Article = "Duis esse elit nulla cupidatat ullamco exercitation do officia laboris mollit. Amet in fugiat occaecat consequat nostrud dolor ad amet quis tempor mollit dolore mollit anim. Aliquip voluptate eiusmod in incididunt nulla est anim.<br>Consequat reprehenderit anim velit nostrud et deserunt sunt exercitation officia duis veniam. Velit excepteur tempor elit cillum sint eu magna fugiat aliquip esse dolore elit consectetur. Adipisicing sunt in consequat dolore nulla occaecat consequat elit incididunt cupidatat officia. Enim aliqua laboris elit aliqua nulla ad irure eiusmod. Nostrud est aliqua ullamco aliquip Lorem deserunt culpa dolore amet ipsum ea cillum do velit.<br>",
                        ArticleIntro = "eiusmod officia Lorem velit ex ipsum esse nulla cupidatat dolor exercitation enim aliqua ad dolore irure aliquip culpa ut ut mollit ut ipsum adipisicing eu commodo sint cupidatat commodo sunt occaecat Lorem commodo ex ea adipisicing pariatur veniam ad ut minim velit cupidatat enim laboris laboris quis incididunt reprehenderit esse",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Sustenza Quis amet et ex ullamco excepteur anim voluptate ex nostrud Lorem voluptate.",
                        Author = "Lindsay Savage",
                        Date = DateTime.Parse("01/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "24384",
                        Email = "lindsaysavage@sustenza.com",
                        Article = "Qui eu do laborum dolor ut consequat irure elit id. Aliqua aliqua consequat laborum ullamco enim mollit aliquip ipsum laborum. Magna Lorem sint sunt aliqua do irure do nulla.<br>Non irure enim magna minim et. Enim et Lorem reprehenderit consequat in do nisi mollit. Do in labore nisi dolore aute est nulla velit consequat. Veniam adipisicing ad ea commodo labore velit et eiusmod consequat. Et sint tempor pariatur nostrud qui exercitation non laborum. Nulla sunt irure nostrud ut in aliquip irure. Consectetur in enim elit irure excepteur culpa reprehenderit deserunt anim magna commodo.<br>",
                        ArticleIntro = "officia aliqua ipsum anim mollit proident non sit sint est elit tempor id incididunt aute est adipisicing incididunt aliquip consectetur id fugiat tempor minim tempor occaecat ex ex elit et consectetur exercitation et ex commodo exercitation et irure culpa tempor aliquip reprehenderit amet ullamco nulla pariatur labore enim ex culpa",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Bytrex Labore velit ex culpa cillum laborum labore aliqua irure aliquip ut nulla pariatur quis id.",
                        Author = "Whitney Copeland",
                        Date = DateTime.Parse("15/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "47823",
                        Email = "whitneycopeland@bytrex.com",
                        Article = "Commodo fugiat pariatur anim amet qui deserunt esse fugiat. Excepteur cupidatat anim ullamco aliqua est velit nisi est tempor qui aliquip in. Qui aute Lorem anim cupidatat incididunt reprehenderit ullamco qui esse sit.<br>Esse non ex sunt deserunt deserunt et magna aliquip labore fugiat occaecat commodo excepteur labore. Ex cupidatat et eu reprehenderit. Cillum elit laborum consectetur voluptate nostrud aliqua laboris ullamco in eiusmod minim esse amet aute.<br>",
                        ArticleIntro = "velit pariatur non occaecat aute aliqua voluptate voluptate irure fugiat irure reprehenderit nisi excepteur voluptate qui amet irure eiusmod elit ea esse nostrud tempor incididunt aute do anim aliqua elit laboris nostrud consectetur sint culpa magna ut commodo cupidatat anim commodo magna aute proident veniam est irure mollit eu ullamco",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Otherside Enim velit irure enim dolor ut dolore irure duis.",
                        Author = "Rhonda Schroeder",
                        Date = DateTime.Parse("02/10/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "6010",
                        Email = "rhondaschroeder@otherside.com",
                        Article = "Culpa amet quis velit sunt quis sit pariatur dolor qui eiusmod ex Lorem proident pariatur. Excepteur pariatur minim dolor anim. Cillum adipisicing est veniam nostrud labore anim. Dolor et labore enim consequat amet voluptate. Consequat laborum velit mollit enim in id ullamco voluptate magna eiusmod.<br>Eu adipisicing commodo cupidatat ut adipisicing nulla culpa veniam veniam id quis. Est sunt eiusmod non commodo laboris ut excepteur laborum cupidatat Lorem tempor fugiat. Consequat voluptate duis aute commodo mollit commodo nostrud do ex voluptate. Ullamco eu adipisicing duis veniam elit eiusmod sint velit Lorem velit adipisicing excepteur dolore. Exercitation laboris amet quis excepteur consectetur proident in qui qui. Velit sit Lorem in ipsum veniam qui aliquip id qui. Enim deserunt amet ea fugiat proident.<br>",
                        ArticleIntro = "commodo consectetur est exercitation dolor id consectetur nulla ipsum magna cupidatat aute aliquip deserunt adipisicing commodo excepteur nulla sint consequat excepteur dolor ut amet ullamco proident do deserunt in aute amet labore consequat do est duis non est ullamco voluptate eu et esse excepteur labore eiusmod voluptate enim incididunt officia",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Undertap Est ex laboris cillum officia Lorem nisi dolor laborum eu officia sunt id.",
                        Author = "Russell Cote",
                        Date = DateTime.Parse("02/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "26715",
                        Email = "russellcote@undertap.com",
                        Article = "Nostrud culpa cillum deserunt officia est labore eu adipisicing velit anim magna elit commodo reprehenderit. Irure in ipsum id consectetur. Aliqua sit ut ea excepteur amet sint non. Pariatur sit nostrud amet velit ullamco eu nulla laborum irure dolor. Aliquip veniam et nostrud deserunt eiusmod.<br>Laboris excepteur quis laboris consequat irure pariatur eu excepteur laboris aliquip. Reprehenderit cillum ut laborum enim Lorem minim enim. Culpa ut velit Lorem laboris minim culpa qui consectetur elit proident. Labore adipisicing culpa ipsum duis ad incididunt reprehenderit voluptate ex irure aliqua eiusmod. Nisi aliqua fugiat minim incididunt velit irure. Deserunt dolore et qui mollit nostrud tempor et pariatur non ut ad ea. In nisi nulla ad consectetur magna nisi do sit exercitation ut voluptate dolor.<br>",
                        ArticleIntro = "fugiat sint nisi in reprehenderit laboris magna duis eiusmod sint cupidatat et duis anim nisi eu non exercitation Lorem enim est minim proident magna consectetur amet culpa nostrud in veniam velit ad non magna incididunt irure consequat amet aliqua qui deserunt ullamco commodo dolor magna ut ipsum ut aute deserunt",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Firewax Laborum ipsum dolore velit fugiat mollit est nisi occaecat nisi.",
                        Author = "Serrano Hensley",
                        Date = DateTime.Parse("24/07/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "30430",
                        Email = "serranohensley@firewax.com",
                        Article = "Ex cillum labore do quis esse aute duis ut. Mollit in mollit occaecat Lorem nulla elit sit. Id minim laborum ullamco sit veniam esse adipisicing id quis laboris magna. Proident cupidatat consectetur nostrud mollit. Aliqua et sit tempor et in aliquip incididunt ullamco qui sint fugiat nostrud nisi. Nisi cupidatat culpa laborum cillum dolore magna. Exercitation deserunt eu ullamco officia do duis.<br>Est cillum ut ad aliqua proident sint consequat dolor irure proident laboris sit id. Eiusmod tempor consectetur velit aliqua exercitation. Velit aute esse consectetur aliqua et est. Adipisicing velit amet consectetur non labore exercitation occaecat irure sint ex commodo. Anim sint officia sint excepteur aliqua Lorem culpa. Cillum quis sunt amet sit fugiat incididunt reprehenderit et aliqua. Minim ea ullamco sint amet magna ut aliquip nulla tempor ipsum magna.<br>",
                        ArticleIntro = "amet quis proident et pariatur reprehenderit cillum pariatur elit fugiat veniam commodo laborum laboris proident quis ut occaecat ipsum est nostrud magna et nulla tempor cillum exercitation fugiat consectetur ad reprehenderit commodo eu reprehenderit velit ex commodo excepteur ea minim commodo tempor nulla eu magna sunt pariatur duis veniam mollit",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Maineland Ad aliqua in ipsum laborum commodo occaecat ea.",
                        Author = "Luann Pitts",
                        Date = DateTime.Parse("26/11/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "29819",
                        Email = "luannpitts@maineland.com",
                        Article = "Excepteur ullamco cupidatat nisi laboris id qui minim Lorem irure. Id nulla Lorem incididunt quis duis laboris. Veniam et sunt velit reprehenderit proident laboris. Ullamco laboris minim amet velit reprehenderit. Esse eiusmod consequat quis non deserunt aute deserunt labore cillum ex non nulla. Qui aliquip consequat deserunt voluptate sit ipsum. Duis ad aute nisi fugiat tempor laborum elit reprehenderit qui eiusmod.<br>Velit cillum minim eu adipisicing non nisi esse. Ipsum do enim ex nulla esse exercitation consectetur elit tempor proident. Sint deserunt quis mollit occaecat. Cupidatat tempor laborum sunt occaecat et. Quis quis dolore incididunt adipisicing laboris nostrud velit.<br>",
                        ArticleIntro = "commodo aute veniam cupidatat amet aliqua mollit officia cillum aute sint proident in ex aliquip sint cillum amet esse cupidatat enim veniam dolor ea elit sit ipsum consequat aliqua aliqua officia ea mollit cupidatat proident exercitation consequat minim amet anim exercitation et ea sit incididunt deserunt proident dolore laboris voluptate",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Geekwagon Laboris dolor voluptate commodo in excepteur.",
                        Author = "Margie Maynard",
                        Date = DateTime.Parse("08/07/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "38736",
                        Email = "margiemaynard@geekwagon.com",
                        Article = "Qui nulla voluptate laborum cupidatat ut aute ad reprehenderit. Proident officia irure occaecat proident et. Mollit nisi incididunt cupidatat laborum deserunt quis est culpa duis dolor elit pariatur fugiat.<br>Veniam aliquip incididunt anim cillum adipisicing culpa consequat culpa velit. Pariatur est ex excepteur excepteur deserunt dolore ea mollit tempor. Mollit incididunt incididunt sit cupidatat dolore voluptate deserunt minim elit velit est sunt et. Non esse ex nostrud veniam irure fugiat nostrud enim aliqua ut minim. Eiusmod dolore est irure voluptate qui nostrud exercitation ullamco quis fugiat pariatur enim ipsum.<br>",
                        ArticleIntro = "consequat eu enim sunt consectetur nostrud velit nostrud voluptate reprehenderit deserunt do deserunt eiusmod laboris amet minim id incididunt non non elit aliqua ipsum laboris sit nostrud qui consectetur nostrud et quis nulla reprehenderit sit voluptate ex labore veniam voluptate tempor et mollit elit ex aliquip commodo ex sint ullamco",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Biotica Cillum exercitation sunt nulla dolor id labore commodo non do aute duis.",
                        Author = "Gillespie Sims",
                        Date = DateTime.Parse("02/01/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "41986",
                        Email = "gillespiesims@biotica.com",
                        Article = "Officia reprehenderit exercitation ut aliquip anim officia dolore consectetur id nostrud minim mollit. Non veniam ad reprehenderit est laboris incididunt esse amet. Cupidatat amet voluptate cillum anim pariatur esse. Officia adipisicing elit tempor id cupidatat fugiat officia consequat Lorem enim fugiat aliqua. Ex in sit velit amet ex ea adipisicing mollit officia exercitation tempor in esse.<br>Do cupidatat irure consectetur ut reprehenderit proident velit ex cupidatat pariatur consequat. Quis deserunt amet ad incididunt eiusmod quis proident id. Ex sint magna mollit veniam dolore esse labore id aliquip. Incididunt reprehenderit pariatur ea officia enim proident cillum ipsum nisi. Sit fugiat qui adipisicing et laborum officia ea adipisicing irure officia veniam reprehenderit.<br>",
                        ArticleIntro = "magna ea elit nulla veniam incididunt anim sunt exercitation occaecat anim amet laborum cupidatat laborum laborum esse in excepteur commodo excepteur nostrud eiusmod velit incididunt consectetur sit nulla laboris labore pariatur anim labore anim quis veniam non consequat nostrud est Lorem aliqua officia eiusmod excepteur et tempor aliqua consequat pariatur",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Moltonic Incididunt ut eiusmod enim in do aute proident laboris quis aliqua cillum.",
                        Author = "Rodriguez Anthony",
                        Date = DateTime.Parse("17/02/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "14166",
                        Email = "rodriguezanthony@moltonic.com",
                        Article = "Elit do non dolore magna aliquip incididunt nostrud nulla tempor commodo nulla aute aliqua. Aute aute cillum proident non. Non duis incididunt adipisicing aliquip aliquip do occaecat fugiat sit et dolor. Sunt officia voluptate laborum cillum occaecat ad aute ut qui ad culpa eu adipisicing sit. Velit do reprehenderit laborum enim.<br>Id magna excepteur sunt officia occaecat laborum commodo exercitation consequat quis cupidatat mollit incididunt. Esse incididunt nisi occaecat labore irure velit. Anim ut incididunt veniam sit elit tempor duis commodo id labore magna labore elit.<br>",
                        ArticleIntro = "est incididunt in laboris sunt aliquip laboris et est velit nisi ad velit ad commodo incididunt exercitation aliqua laborum et do occaecat dolore excepteur magna exercitation sunt deserunt mollit reprehenderit velit adipisicing labore dolor est minim eu consectetur amet ipsum ad ullamco nostrud commodo excepteur labore aliqua ea culpa amet",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Mixers Fugiat eiusmod Lorem ad proident anim non culpa.",
                        Author = "Mosley Hendrix",
                        Date = DateTime.Parse("08/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "28861",
                        Email = "mosleyhendrix@mixers.com",
                        Article = "Nisi mollit incididunt reprehenderit veniam labore nisi ipsum. Do occaecat pariatur aute esse nulla ea sit commodo. Deserunt reprehenderit nostrud eiusmod ex cillum incididunt eu. Tempor commodo pariatur exercitation qui tempor esse tempor mollit amet laboris aliquip non adipisicing laborum. Culpa commodo est ut dolore velit incididunt aute nostrud minim aute sint sunt magna excepteur.<br>Duis sunt officia laborum aute dolore incididunt nisi sint. Aliqua laboris reprehenderit sit Lorem consectetur cupidatat. Incididunt consequat dolor cillum laborum sint quis anim pariatur.<br>",
                        ArticleIntro = "deserunt elit aute tempor sint dolore anim occaecat cupidatat velit consequat enim veniam sit do culpa nisi incididunt veniam consectetur eu veniam mollit commodo do labore nisi anim consequat velit qui sint ipsum veniam commodo eiusmod in dolor enim voluptate tempor incididunt nulla proident ipsum non ex ullamco in consequat",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Zanilla Enim ut nostrud ad id nisi exercitation dolor magna velit.",
                        Author = "Patel Mcdonald",
                        Date = DateTime.Parse("07/06/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "113",
                        Email = "patelmcdonald@zanilla.com",
                        Article = "Veniam consequat aute duis ex veniam mollit velit. Duis occaecat sit sint proident do voluptate do ipsum consequat elit amet voluptate Lorem est. Sit incididunt id in eu id laboris eu velit amet elit. Amet eu dolore veniam amet minim eiusmod aliqua fugiat in ut eiusmod qui occaecat.<br>Minim sunt ad eu eu mollit. Occaecat commodo aliqua cupidatat ad aute veniam est eu quis sint velit occaecat amet aliquip. Quis excepteur laboris minim laborum duis esse eu ea nisi anim.<br>",
                        ArticleIntro = "officia quis sit adipisicing non ipsum ad in mollit nostrud aliqua aliquip sunt adipisicing pariatur voluptate excepteur nisi fugiat laboris magna minim consectetur dolor sit non velit irure laborum velit nostrud nisi dolor labore amet commodo labore dolor esse officia aliqua ipsum laborum officia dolore occaecat ex non magna aliqua",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Enervate Sint sint et id eiusmod incididunt incididunt quis labore minim ea sunt.",
                        Author = "Ramos Wood",
                        Date = DateTime.Parse("19/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "43913",
                        Email = "ramoswood@enervate.com",
                        Article = "Tempor consequat officia sunt voluptate enim in anim in amet consectetur. Labore Lorem ullamco anim fugiat. Id magna proident laborum irure qui ut. Adipisicing laborum deserunt aliquip tempor. Nostrud ea in consequat exercitation. Exercitation duis sit voluptate mollit consequat laboris aliquip dolore reprehenderit excepteur exercitation deserunt excepteur.<br>Minim veniam dolor dolore elit amet laboris sit officia. Commodo consequat proident fugiat veniam amet amet dolor cillum incididunt aliqua fugiat irure. Velit mollit eiusmod laborum aliqua mollit voluptate eu. Ea sint pariatur excepteur labore irure qui veniam esse sunt fugiat exercitation.<br>",
                        ArticleIntro = "enim elit officia laborum minim anim officia esse consequat proident Lorem mollit excepteur eiusmod eu laborum nisi cillum minim laborum tempor ex aute commodo duis ut minim laborum anim proident veniam sit nostrud ad ea incididunt excepteur nulla eiusmod id officia esse velit dolore exercitation minim ex magna deserunt proident",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Goko Laboris esse eiusmod deserunt deserunt mollit irure velit officia ullamco tempor et.",
                        Author = "Norma Moreno",
                        Date = DateTime.Parse("22/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "39166",
                        Email = "normamoreno@goko.com",
                        Article = "Reprehenderit aliqua irure do non elit fugiat ut quis culpa mollit laboris irure ex dolore. Consequat elit ipsum ut qui commodo duis. Occaecat fugiat commodo et enim consectetur laboris ea consectetur ex tempor magna ea proident mollit. Non enim dolor elit laboris. Amet aute id est duis do ipsum voluptate proident elit. Ea voluptate non exercitation adipisicing aute occaecat sint duis nisi.<br>Commodo sunt id irure nulla deserunt est aute id non ex. Enim irure sunt velit consequat minim reprehenderit fugiat quis minim incididunt veniam pariatur id labore. Consectetur quis officia velit ut pariatur ex laboris fugiat excepteur.<br>",
                        ArticleIntro = "consectetur magna id labore nisi veniam qui consequat ex incididunt aute reprehenderit dolore ad enim sunt irure in magna ipsum in tempor excepteur ad elit laborum ea ut reprehenderit aute officia qui sint sunt cupidatat cupidatat consectetur non non dolor pariatur in eiusmod minim quis quis amet elit laboris esse",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Netility Minim ad duis officia consectetur sint esse officia culpa sint magna dolore exercitation veniam.",
                        Author = "Elliott Mercado",
                        Date = DateTime.Parse("23/02/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "30587",
                        Email = "elliottmercado@netility.com",
                        Article = "Non aute dolore pariatur sit magna eu consequat ad enim duis do. Dolore cupidatat occaecat ut sunt id pariatur aliquip Lorem cillum laboris proident velit. Occaecat ex veniam fugiat amet sint deserunt minim cupidatat. Amet velit aliqua eu incididunt cillum. Officia amet consequat duis commodo culpa. Non sunt deserunt Lorem pariatur Lorem excepteur.<br>Amet nostrud ad nisi dolor quis ea. Adipisicing culpa mollit nostrud aliqua magna sunt ullamco adipisicing labore laborum quis. Consequat quis fugiat tempor pariatur mollit incididunt laboris ad enim amet. Esse consequat Lorem ipsum ea proident. Laborum consequat in eu laborum ullamco proident. Cillum eu occaecat ea cillum aliquip qui mollit elit commodo.<br>",
                        ArticleIntro = "amet minim do et elit reprehenderit mollit incididunt dolore nulla est sunt cupidatat reprehenderit veniam proident ad minim duis id fugiat in adipisicing aliquip id duis ipsum culpa esse voluptate ipsum velit culpa non qui laboris consectetur quis nostrud sit exercitation ad nulla consectetur nostrud ipsum deserunt elit esse laboris",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Extragen Excepteur ex anim laborum labore et est qui ex Lorem voluptate quis.",
                        Author = "Tracie Pierce",
                        Date = DateTime.Parse("26/03/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "4949",
                        Email = "traciepierce@extragen.com",
                        Article = "Ea ex voluptate proident Lorem in consectetur. Magna aute elit fugiat veniam dolor ut Lorem reprehenderit deserunt. Et ea labore commodo sunt excepteur voluptate reprehenderit voluptate aliquip cupidatat cillum occaecat elit.<br>Ipsum do commodo proident elit. Amet commodo fugiat deserunt labore ea dolore non dolore in elit amet aliqua. Occaecat irure amet cillum reprehenderit dolore incididunt voluptate velit excepteur cupidatat aute excepteur. Ipsum dolor nulla sit proident mollit in nulla tempor nisi cillum veniam enim. Id enim eiusmod eu ipsum mollit culpa aute veniam cupidatat. Ad exercitation tempor ullamco culpa ullamco. Culpa minim et ut proident incididunt Lorem aliqua consectetur labore.<br>",
                        ArticleIntro = "labore laborum id laboris officia sunt culpa aliqua fugiat amet tempor incididunt nulla officia laboris esse aliquip minim reprehenderit velit sint laboris consequat cupidatat fugiat deserunt anim reprehenderit laborum sint tempor cillum consectetur eu eiusmod officia culpa esse occaecat nisi deserunt esse incididunt culpa duis amet voluptate culpa aliquip sint",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Deepends Aliqua consectetur ut cillum ex cillum aliquip.",
                        Author = "Katheryn Park",
                        Date = DateTime.Parse("29/02/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "31094",
                        Email = "katherynpark@deepends.com",
                        Article = "Occaecat nisi culpa consectetur velit incididunt occaecat ipsum exercitation deserunt amet non sit ea adipisicing. Cillum commodo amet pariatur labore officia aute quis officia nostrud magna. Anim elit id ipsum qui labore duis elit. Reprehenderit minim et voluptate commodo nostrud nostrud consectetur exercitation.<br>Aliquip sunt ullamco Lorem id pariatur nostrud fugiat proident eu. Magna culpa nostrud eu reprehenderit irure. Eu et minim fugiat est. Aute sit excepteur nisi pariatur enim culpa esse id incididunt tempor nisi tempor sint. Pariatur pariatur dolore id ea aliquip ad laborum sint Lorem enim aliquip enim aliquip. Ullamco culpa ullamco tempor non labore esse cillum.<br>",
                        ArticleIntro = "veniam duis Lorem pariatur esse mollit dolore minim occaecat ad laborum aute sint occaecat sit et enim reprehenderit non nostrud aute do amet velit non sit aliquip fugiat cillum nisi culpa quis exercitation nulla eu minim pariatur eiusmod cupidatat irure laboris cillum irure aute laborum veniam cillum do incididunt ex",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Isostream Reprehenderit exercitation ex in nulla occaecat reprehenderit minim.",
                        Author = "Henry Pruitt",
                        Date = DateTime.Parse("28/01/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "38917",
                        Email = "henrypruitt@isostream.com",
                        Article = "Laborum deserunt amet quis Lorem consectetur. In sint nostrud amet laborum eiusmod aliqua consectetur mollit aliquip ad voluptate consequat est ut. Proident aute ea irure aliqua quis ipsum voluptate minim minim exercitation. Laborum pariatur aliquip occaecat eiusmod tempor anim aute quis sunt minim nulla laborum. Sunt in Lorem voluptate dolore aute tempor voluptate.<br>Sunt ut id laborum ea proident do ea ea culpa reprehenderit. Commodo aliqua nulla reprehenderit nostrud reprehenderit ullamco magna labore ipsum ipsum quis commodo. Sit duis reprehenderit nostrud voluptate do cupidatat dolore.<br>",
                        ArticleIntro = "et sint exercitation sint nostrud est fugiat elit dolor non dolore pariatur esse ad et excepteur sunt consequat quis eiusmod in id quis anim ad et do aliquip ex cupidatat aliqua velit ullamco adipisicing in laboris dolor qui laborum voluptate labore adipisicing nulla mollit et sint sint elit esse et",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Zisis Officia ullamco irure duis elit magna ea.",
                        Author = "Whitaker Norton",
                        Date = DateTime.Parse("22/01/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "2466",
                        Email = "whitakernorton@zisis.com",
                        Article = "Aute deserunt sunt non fugiat tempor sint eiusmod quis dolor sunt incididunt sint pariatur. Pariatur cillum ipsum elit sit pariatur dolore laborum dolor culpa. Mollit fugiat voluptate culpa enim et sunt ipsum nisi anim. Labore mollit labore sunt irure culpa ut culpa ea labore amet. Esse exercitation quis aliqua mollit aliquip adipisicing Lorem irure. Ex mollit labore ipsum ut officia.<br>Labore culpa magna velit ullamco ea id pariatur nulla Lorem occaecat. Officia in qui occaecat officia irure. Reprehenderit ut aliquip et reprehenderit eu ut consectetur qui magna voluptate id.<br>",
                        ArticleIntro = "culpa magna ex laboris proident cillum consequat nostrud tempor ullamco Lorem sunt ullamco dolor ad ipsum ullamco sit et cillum eiusmod consequat quis velit ea commodo veniam cillum irure quis labore esse do nisi magna laboris aliqua fugiat magna sunt irure do anim aliqua nulla ad aliquip deserunt velit fugiat",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Glasstep Adipisicing nisi laborum do amet eiusmod esse dolor do dolor.",
                        Author = "Rosie Ross",
                        Date = DateTime.Parse("12/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "15689",
                        Email = "rosieross@glasstep.com",
                        Article = "In anim est quis magna id deserunt cillum velit minim nostrud tempor eu irure qui. Minim dolore ad consequat culpa cupidatat exercitation est exercitation do ullamco. Nisi excepteur consectetur reprehenderit amet tempor ad cillum ipsum ipsum ad eu.<br>Aliquip aliquip irure sint incididunt irure. Dolore nisi nostrud pariatur nisi adipisicing cillum. Excepteur do nostrud et deserunt consequat deserunt labore pariatur non sunt.<br>",
                        ArticleIntro = "occaecat labore dolore et incididunt do commodo laboris ipsum ipsum sit velit quis non est do esse veniam amet magna ullamco sunt sit deserunt sint elit nostrud incididunt cupidatat do proident aliquip elit excepteur fugiat mollit adipisicing sint culpa pariatur qui Lorem consequat sint deserunt amet est qui eiusmod culpa",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Enersave Cupidatat do cillum id qui eu ipsum consectetur ipsum voluptate.",
                        Author = "Lacey Merrill",
                        Date = DateTime.Parse("16/06/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "28474",
                        Email = "laceymerrill@enersave.com",
                        Article = "Occaecat cillum cupidatat labore quis consequat id consectetur qui consequat ullamco commodo. Proident proident officia in et labore. Officia nisi excepteur qui ut anim sit irure sunt enim in. Sit ad cillum irure sit ex excepteur duis qui commodo eu consequat. Consectetur voluptate sit ut ea excepteur veniam fugiat. Id in ad culpa laboris ea qui. Ullamco magna laboris in aute cupidatat nulla anim eiusmod.<br>Ad qui nisi mollit adipisicing adipisicing consequat anim ex. Nisi do amet voluptate amet culpa. Magna ea eiusmod minim id dolore cillum officia.<br>",
                        ArticleIntro = "elit et velit nisi sunt id qui sunt cupidatat adipisicing aliquip nisi sit dolor proident ex qui excepteur deserunt ipsum pariatur fugiat adipisicing incididunt nisi et in commodo consequat magna incididunt et dolor nulla adipisicing non enim sunt aliqua reprehenderit nulla officia est eiusmod pariatur reprehenderit irure amet consequat excepteur",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Strezzo Enim irure esse elit dolor ut anim exercitation ipsum mollit.",
                        Author = "Conner Sandoval",
                        Date = DateTime.Parse("01/02/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "11059",
                        Email = "connersandoval@strezzo.com",
                        Article = "Sint incididunt et sit commodo nostrud nostrud aliquip nostrud pariatur irure cupidatat proident voluptate amet. Voluptate voluptate voluptate id reprehenderit qui non sit reprehenderit est magna amet. Ut sunt duis cillum et aliquip. Anim aute duis mollit ut deserunt eiusmod tempor ipsum et voluptate veniam non do duis. Reprehenderit ad magna ullamco magna aliquip reprehenderit ex aliquip dolor sunt. Lorem Lorem ipsum magna deserunt minim ex ad.<br>Consequat incididunt sint sit fugiat Lorem dolor aute excepteur incididunt ullamco Lorem est dolore culpa. Minim culpa irure magna dolore exercitation ipsum ut tempor commodo. Voluptate occaecat duis anim adipisicing dolor aliqua. Minim enim enim nostrud consectetur. Cupidatat occaecat magna proident consectetur incididunt anim do.<br>",
                        ArticleIntro = "Lorem sit et Lorem non sit consequat culpa sunt exercitation cupidatat id dolore in elit consectetur eiusmod esse deserunt nostrud incididunt pariatur dolor est nisi mollit sit aliquip irure Lorem nulla Lorem ut consequat officia aute do et ex officia laboris nulla nulla culpa minim culpa fugiat eu cillum est",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Buzzworks Ex dolor duis qui eu consectetur elit elit commodo nisi anim commodo ad.",
                        Author = "Marshall Dawson",
                        Date = DateTime.Parse("07/01/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "24611",
                        Email = "marshalldawson@buzzworks.com",
                        Article = "Proident aliqua minim labore culpa nisi enim. Exercitation eiusmod deserunt sit esse tempor laboris et ad in proident ad cillum sit ipsum. Lorem ut labore quis laboris.<br>Qui qui id fugiat incididunt consequat dolor aliquip in excepteur reprehenderit. Ad laborum voluptate proident voluptate veniam eu aliquip elit esse consectetur sunt excepteur. Do deserunt aliquip anim sint labore occaecat exercitation deserunt aliquip id eiusmod est consequat. Adipisicing laboris ea nostrud dolore aliqua nostrud fugiat.<br>",
                        ArticleIntro = "sint duis proident Lorem laborum amet esse id laboris velit deserunt do qui deserunt laborum esse ipsum deserunt consequat nisi amet sunt deserunt aliqua veniam consequat est officia velit quis do proident in proident officia cillum minim cillum sunt aute do aliquip dolore sit pariatur nulla labore amet adipisicing labore",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Zuvy Nulla ullamco non veniam ipsum laboris exercitation id do cupidatat ut Lorem in veniam velit.",
                        Author = "Blackburn Donovan",
                        Date = DateTime.Parse("29/11/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "47422",
                        Email = "blackburndonovan@zuvy.com",
                        Article = "Ad consequat id et culpa non tempor consequat reprehenderit fugiat sit irure tempor labore. Labore ad ad id in amet ipsum duis anim qui. Quis ea nisi enim amet sint sit officia cillum do. Aute ex veniam labore reprehenderit in laboris aliqua officia duis dolore. Incididunt voluptate ea aliqua adipisicing laborum culpa ipsum. Aute nisi excepteur fugiat excepteur excepteur voluptate cillum ipsum mollit ad.<br>Esse irure adipisicing qui non eiusmod amet excepteur pariatur velit voluptate ea commodo adipisicing. Fugiat est duis irure ullamco adipisicing minim cupidatat consectetur enim Lorem fugiat duis. Nostrud anim elit occaecat sunt non. Sunt eiusmod amet labore Lorem fugiat Lorem laboris cupidatat sint.<br>",
                        ArticleIntro = "Lorem commodo est sunt et deserunt sint excepteur aliquip pariatur qui consequat voluptate velit minim dolore veniam minim aliquip cupidatat deserunt officia nostrud dolore ipsum voluptate reprehenderit ea dolor velit irure quis pariatur nisi ut ad consequat nostrud enim ullamco minim veniam officia ullamco tempor dolor officia minim pariatur ullamco",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Canopoly Cupidatat consequat amet duis sunt tempor ullamco cillum cillum pariatur cillum ullamco ad proident minim.",
                        Author = "Margret Warren",
                        Date = DateTime.Parse("20/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "36304",
                        Email = "margretwarren@canopoly.com",
                        Article = "Est in quis dolor nisi consequat in. Lorem consequat anim et cillum culpa in quis enim proident. Eiusmod duis laborum cupidatat anim quis pariatur consequat sunt nostrud consectetur laboris est. Deserunt aute culpa consequat proident voluptate mollit ullamco ut. Nisi aliquip reprehenderit cupidatat nulla veniam voluptate tempor nostrud.<br>Proident magna amet fugiat proident. Officia nostrud non aliqua dolor velit aliqua exercitation et. Irure nostrud nisi dolore irure Lorem excepteur esse non reprehenderit minim velit deserunt aliqua commodo. Irure cupidatat nisi id exercitation ea mollit esse nostrud ex reprehenderit.<br>",
                        ArticleIntro = "ut sint magna consequat et nisi laboris do nulla exercitation aliquip adipisicing consequat aliqua laborum culpa ad est reprehenderit sunt ad consequat velit consequat nostrud consectetur veniam veniam ex sunt laborum eiusmod officia veniam cillum eiusmod tempor ullamco anim occaecat commodo amet in nostrud dolore officia fugiat minim consectetur ipsum",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Envire Consequat deserunt ea ea veniam incididunt ex do nostrud reprehenderit consectetur irure dolore commodo culpa.",
                        Author = "Alfreda Mullen",
                        Date = DateTime.Parse("20/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "24656",
                        Email = "alfredamullen@envire.com",
                        Article = "Sit esse aute eiusmod commodo tempor cupidatat sunt. Laborum consequat reprehenderit cupidatat magna nisi aute in nulla do ut culpa tempor nulla. Incididunt reprehenderit duis ea amet Lorem deserunt duis veniam aliquip qui mollit laborum voluptate cillum.<br>Velit quis dolore ullamco ut qui elit adipisicing commodo ullamco ipsum eiusmod non minim pariatur. Consectetur elit in fugiat id. Reprehenderit mollit dolore non in reprehenderit irure. Nostrud consectetur velit excepteur proident velit ad dolore enim dolore exercitation non exercitation. Ut adipisicing dolor veniam eiusmod officia dolore nulla eu minim. Veniam quis labore eu duis dolor cupidatat mollit deserunt duis sunt exercitation.<br>",
                        ArticleIntro = "laborum laboris eu tempor velit ullamco minim cillum exercitation eiusmod aliqua velit aute laboris culpa veniam ullamco ea officia id et aliquip voluptate amet sunt tempor proident id laboris elit in commodo eu deserunt sint nulla eu occaecat commodo cillum pariatur aute est culpa est ea aliquip aliqua qui veniam",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Comstar Esse in consectetur ut mollit eu duis sint.",
                        Author = "Bush Goodwin",
                        Date = DateTime.Parse("05/11/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "16706",
                        Email = "bushgoodwin@comstar.com",
                        Article = "Cupidatat laboris ut id sunt duis excepteur veniam Lorem Lorem aute enim ullamco cupidatat elit. Ipsum adipisicing incididunt labore anim excepteur irure exercitation aliqua irure duis fugiat ullamco consectetur. Consequat officia aute do sunt ea est enim do in cupidatat sunt. Mollit proident nostrud culpa velit commodo duis irure ullamco fugiat cillum do.<br>Exercitation commodo cillum sunt nostrud deserunt dolore minim et consectetur ullamco eu. Velit commodo laboris officia commodo cillum ad Lorem nisi tempor. Veniam enim pariatur exercitation proident non laboris dolore excepteur. Laboris anim sunt pariatur laborum anim ullamco voluptate amet. Eu aliqua ex reprehenderit ex aliqua incididunt. Id culpa ex voluptate in non dolor dolore ea adipisicing sit officia. Cupidatat sunt eiusmod esse qui.<br>",
                        ArticleIntro = "tempor tempor pariatur sit ullamco amet consectetur sunt dolore ea fugiat nisi nisi dolor est pariatur irure mollit aliquip eu quis ullamco ullamco ex sit magna magna elit sint minim do aliquip officia exercitation consectetur occaecat occaecat proident deserunt anim sint sit consequat nulla Lorem adipisicing fugiat adipisicing quis non",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Brainclip Ex voluptate ex tempor labore commodo amet proident.",
                        Author = "Eva Grimes",
                        Date = DateTime.Parse("01/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "33323",
                        Email = "evagrimes@brainclip.com",
                        Article = "Excepteur cillum nulla laboris sunt. Elit id exercitation reprehenderit ut dolor commodo amet tempor nisi reprehenderit eu consequat nisi duis. Duis sit amet incididunt consectetur eiusmod fugiat pariatur aliqua nulla dolor nostrud. Ea excepteur ullamco est officia officia adipisicing cupidatat pariatur proident elit labore cillum. Sint velit labore anim sint ea officia veniam eu elit officia nulla deserunt.<br>Ipsum velit quis consequat laboris occaecat officia ullamco amet mollit ullamco. Mollit reprehenderit elit irure elit eiusmod voluptate exercitation sunt exercitation tempor ea laborum consectetur. Sint laborum aliquip enim exercitation laborum nostrud duis eiusmod. Veniam excepteur veniam mollit reprehenderit minim duis minim eiusmod aute. Eiusmod cillum amet officia aute nostrud reprehenderit officia. Fugiat dolor ut aute exercitation consectetur enim in duis sunt amet magna.<br>",
                        ArticleIntro = "elit sint duis quis eu in consectetur id adipisicing voluptate occaecat nostrud consectetur quis excepteur eiusmod aliqua ut incididunt cillum ad labore laborum aliqua incididunt qui enim est irure excepteur adipisicing elit ut pariatur sint et sunt duis dolore ullamco Lorem cupidatat consequat laboris id exercitation tempor ea aliquip enim",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Scentric Nisi sunt occaecat pariatur culpa fugiat.",
                        Author = "Craig Lloyd",
                        Date = DateTime.Parse("14/10/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "28610",
                        Email = "craiglloyd@scentric.com",
                        Article = "Pariatur tempor esse cupidatat nisi qui culpa quis duis reprehenderit amet exercitation do cillum commodo. Consequat sunt adipisicing enim laboris fugiat aute. Dolore eiusmod qui nostrud proident excepteur veniam ullamco amet fugiat. Consequat irure do id irure pariatur consectetur eiusmod veniam officia excepteur eiusmod. Laboris laborum elit magna tempor nulla cupidatat qui excepteur Lorem laborum nostrud nulla est. Nisi non eu eiusmod magna est adipisicing incididunt cillum dolor velit non incididunt.<br>Et deserunt eiusmod quis dolor eiusmod cupidatat sint eiusmod eiusmod culpa minim veniam aute sunt. Amet eu esse id sint laborum id pariatur nisi in est veniam sunt. Amet nisi elit deserunt do cillum est amet commodo eu dolor quis deserunt. Ad id ut quis laborum sit cillum proident esse.<br>",
                        ArticleIntro = "officia labore occaecat adipisicing consequat ex cillum mollit et tempor reprehenderit non voluptate aliqua voluptate aute velit veniam in laborum culpa deserunt voluptate reprehenderit officia esse voluptate dolore nisi quis Lorem ut ipsum et cillum nisi sint sit nostrud irure non nisi nostrud voluptate et Lorem dolor irure exercitation Lorem",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Verbus Adipisicing voluptate fugiat consequat veniam qui magna.",
                        Author = "Maude Mendoza",
                        Date = DateTime.Parse("22/03/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "48959",
                        Email = "maudemendoza@verbus.com",
                        Article = "Ut veniam enim pariatur elit sint adipisicing fugiat labore proident nisi deserunt sit elit. Cupidatat irure dolor voluptate Lorem pariatur mollit magna. Qui in occaecat in consectetur anim aliquip nulla. Excepteur duis non qui enim sint et et minim commodo velit.<br>In est tempor duis laborum nisi deserunt velit tempor aliquip ullamco magna consequat eu eu. Enim officia officia occaecat deserunt velit in aliquip sit quis sint do. Aute mollit dolor in velit cillum velit officia Lorem mollit amet consequat quis. Elit dolor eu ut eu.<br>",
                        ArticleIntro = "aliqua do mollit duis non amet nisi ipsum nisi culpa ad dolore tempor id est non anim culpa do sit aliqua consequat culpa qui sint veniam culpa velit et minim cillum non et dolor cupidatat reprehenderit veniam voluptate ad consequat dolor deserunt culpa esse laboris do duis pariatur dolor veniam",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Sureplex In deserunt aliqua pariatur irure nulla amet in culpa nisi aute.",
                        Author = "Stella Gates",
                        Date = DateTime.Parse("03/04/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "44472",
                        Email = "stellagates@sureplex.com",
                        Article = "Sint nisi Lorem sit fugiat aute reprehenderit magna voluptate amet. Et sit consectetur mollit elit fugiat enim id aliquip. Minim commodo do velit duis ad non. Id incididunt nulla eiusmod consequat. Ex eiusmod aliqua elit id ullamco et consequat eu. In eu exercitation velit aute consequat dolore. Tempor esse consequat magna cupidatat laborum exercitation.<br>Sint veniam magna laborum aliqua eiusmod excepteur elit excepteur do pariatur. Eiusmod dolore ullamco sit reprehenderit excepteur excepteur deserunt nisi velit cupidatat magna. Labore voluptate id commodo occaecat ad irure. Lorem nulla aliquip velit et quis. Labore cupidatat enim do consequat tempor aliqua cupidatat ad duis.<br>",
                        ArticleIntro = "qui deserunt enim irure aute est ex aute cillum exercitation voluptate veniam veniam Lorem aliqua exercitation exercitation ipsum ut proident ut culpa laboris ad amet minim nulla eiusmod consequat deserunt tempor labore velit veniam eu velit laborum labore deserunt qui magna sit veniam enim nulla duis amet velit ea pariatur",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Acumentor Duis sunt incididunt nostrud exercitation aliquip anim irure elit adipisicing incididunt velit velit sint deserunt.",
                        Author = "Hines Colon",
                        Date = DateTime.Parse("10/12/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "28075",
                        Email = "hinescolon@acumentor.com",
                        Article = "Ullamco tempor ullamco cillum eu exercitation voluptate adipisicing anim fugiat. Occaecat ipsum elit eu dolor velit aliquip Lorem ut dolor duis sit reprehenderit. Laborum aliquip minim eu ipsum pariatur cillum ex dolor anim irure eu laborum anim ipsum. Magna commodo cillum commodo elit cupidatat ex dolore ut aliquip ipsum exercitation dolor consequat dolore. Sint eu cupidatat enim sit ex laboris id amet voluptate adipisicing labore ea esse fugiat. Fugiat dolore aliqua officia quis fugiat nulla.<br>Excepteur nostrud enim sit deserunt. Amet laboris eiusmod veniam laborum qui. Lorem pariatur amet ipsum dolore fugiat deserunt aliquip excepteur sunt nulla nostrud eu. Eiusmod exercitation nostrud labore sit deserunt incididunt qui enim aute ut. Ea exercitation amet anim in. Aute Lorem quis reprehenderit eiusmod.<br>",
                        ArticleIntro = "cillum nisi quis et id eu cupidatat nisi Lorem sint exercitation elit fugiat excepteur velit aliquip pariatur minim occaecat dolor ullamco aute reprehenderit tempor cillum ut sunt adipisicing Lorem ad elit enim id et est eiusmod sint excepteur labore est non officia consequat enim elit ea nisi elit laboris sunt",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Ozean Consequat consequat est et nulla.",
                        Author = "Julianne Robinson",
                        Date = DateTime.Parse("20/06/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "18561",
                        Email = "juliannerobinson@ozean.com",
                        Article = "Enim incididunt sunt exercitation cillum dolore qui. Labore exercitation tempor adipisicing velit enim sint aute do proident. Aliqua officia sunt nulla et ut ea pariatur quis incididunt dolor id anim. Qui labore sit nisi elit voluptate aute irure.<br>Aute nisi ut veniam irure aliquip. Tempor nisi sit incididunt duis Lorem deserunt dolor consectetur aute et dolor. Exercitation ea laborum cupidatat cupidatat ullamco quis voluptate deserunt.<br>",
                        ArticleIntro = "et aliqua aliquip esse esse ad anim ut ipsum velit laborum ullamco pariatur qui elit adipisicing Lorem cillum aliqua sunt duis Lorem eiusmod laboris voluptate adipisicing non cillum labore nisi irure adipisicing eu voluptate cupidatat laborum et irure minim nulla ad eiusmod veniam culpa laboris fugiat in est Lorem ea",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Webiotic Ut cillum pariatur anim laborum id Lorem.",
                        Author = "Eugenia Spears",
                        Date = DateTime.Parse("02/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "11579",
                        Email = "eugeniaspears@webiotic.com",
                        Article = "Consequat anim qui proident deserunt qui proident irure qui. Ipsum sint Lorem nulla sit. Culpa aliquip ut excepteur ex ut cillum ullamco qui tempor ipsum voluptate adipisicing. Consectetur id aute commodo sunt tempor cillum ullamco culpa ut sunt. Fugiat exercitation amet aliquip sunt voluptate aute qui consequat do nostrud est qui eu. Eiusmod ad amet dolore do magna sunt et qui anim est exercitation laborum nostrud. Dolor officia ea ullamco ut mollit esse adipisicing aliqua officia sint non.<br>Nisi culpa qui id sint magna eiusmod enim sint excepteur dolore adipisicing do tempor labore. Veniam aliquip pariatur velit non et et duis. Ad eiusmod Lorem officia est eu exercitation.<br>",
                        ArticleIntro = "tempor non pariatur elit aute laboris cupidatat enim laboris incididunt velit occaecat elit occaecat fugiat labore dolore ea duis reprehenderit anim nostrud culpa aliqua nostrud velit pariatur tempor commodo minim incididunt pariatur laboris aliqua ipsum id excepteur ad amet aliqua enim quis officia id sunt in est voluptate ullamco laboris",
                        Tag = "kittens"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Obones Sunt dolore duis anim nulla nostrud eu ex.",
                        Author = "Corrine Mack",
                        Date = DateTime.Parse("02/04/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "49409",
                        Email = "corrinemack@obones.com",
                        Article = "Est proident proident ad qui officia consequat eu eiusmod. Veniam cillum aute sunt incididunt irure do adipisicing proident dolore amet. Tempor est anim aliquip nulla laboris. Enim eiusmod aliqua enim nostrud non minim. Dolore aliqua amet laborum sint veniam ea sint. Ipsum deserunt eiusmod ad proident ad tempor dolore.<br>Non excepteur est id occaecat excepteur occaecat. Fugiat consequat nulla veniam aute consectetur Lorem eiusmod reprehenderit. Tempor pariatur culpa sunt fugiat aliquip nulla qui consectetur. Incididunt in aliqua deserunt laborum. Proident eiusmod proident irure quis Lorem dolor aliquip ad consequat esse elit amet veniam sunt.<br>",
                        ArticleIntro = "labore fugiat sit anim dolor amet commodo sunt ad officia occaecat aute id tempor consequat et minim culpa culpa eiusmod culpa proident ut consequat ullamco aliqua laboris dolore aute velit cupidatat voluptate veniam consequat qui cillum in tempor id do ea excepteur ut mollit laborum ipsum quis ullamco cillum sit",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Comvene Cupidatat Lorem incididunt adipisicing excepteur commodo deserunt sit ex non proident enim adipisicing aute voluptate.",
                        Author = "Potts Jacobs",
                        Date = DateTime.Parse("10/12/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "19144",
                        Email = "pottsjacobs@comvene.com",
                        Article = "Magna commodo elit deserunt incididunt cupidatat reprehenderit anim cupidatat laborum adipisicing sit. Eu id ex sunt eiusmod commodo tempor commodo proident. Ad nisi in anim quis pariatur amet est fugiat do laboris. Laborum sint velit proident non ad. Nulla sit in elit duis ex anim aliquip minim sint et ad quis do ex. Ullamco sint laboris officia non excepteur aliquip pariatur occaecat aliqua reprehenderit duis excepteur officia.<br>Sint aliqua laborum pariatur sint exercitation in sunt dolor ullamco nostrud proident. Occaecat ad dolor et dolor nostrud est. Dolor excepteur officia duis cillum ex Lorem cillum nulla nisi quis exercitation in anim dolore. Excepteur veniam mollit tempor aute. Aute sunt ea adipisicing deserunt sit irure sit aliquip enim pariatur. Culpa sit velit magna sint eiusmod labore eu aliquip anim nostrud. Sunt sunt dolor cupidatat voluptate veniam ut mollit labore qui excepteur eu.<br>",
                        ArticleIntro = "ullamco voluptate veniam occaecat cupidatat pariatur exercitation duis aliquip veniam laborum ea deserunt dolor duis reprehenderit irure duis aute proident voluptate qui occaecat deserunt irure commodo elit qui ipsum do aliqua id irure laborum elit veniam sunt cillum consequat consequat velit laboris eu voluptate et occaecat esse ullamco voluptate incididunt",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Exoswitch Laborum excepteur est fugiat ullamco ad voluptate esse.",
                        Author = "Donaldson Heath",
                        Date = DateTime.Parse("10/03/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "21925",
                        Email = "donaldsonheath@exoswitch.com",
                        Article = "Quis laboris id elit consequat fugiat tempor ullamco. Eu elit id ullamco dolore quis veniam proident irure incididunt esse est exercitation aute. Aliquip non qui proident ea sit et. Aute eu occaecat in sint eu proident.<br>Commodo cillum nulla pariatur irure. Fugiat aliqua ullamco id sunt cupidatat labore quis Lorem. Occaecat dolore nostrud excepteur consectetur amet deserunt sint sit cupidatat. Nulla aliqua do ipsum cillum commodo.<br>",
                        ArticleIntro = "labore Lorem nostrud laborum occaecat nostrud ipsum dolor sit nisi qui elit consequat magna sit sit qui laborum tempor ipsum dolor ea nulla sunt id laborum ex laboris minim sit eu excepteur eiusmod et dolor pariatur adipisicing quis laborum fugiat exercitation reprehenderit est aliquip est magna sit excepteur fugiat occaecat",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Zoid Ex non ex mollit reprehenderit in incididunt veniam sunt et.",
                        Author = "Terra Stevenson",
                        Date = DateTime.Parse("13/04/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "26130",
                        Email = "terrastevenson@zoid.com",
                        Article = "Sit amet dolor dolor eiusmod. Officia anim sint proident dolore aliquip. Magna anim nulla officia culpa consequat anim cupidatat.<br>Esse et adipisicing culpa id magna nostrud fugiat fugiat sunt. Do eu voluptate minim id mollit ad. Ex ullamco do pariatur cupidatat amet ex.<br>",
                        ArticleIntro = "fugiat officia non deserunt et deserunt ullamco amet eiusmod consectetur nostrud dolor id minim laboris sint do adipisicing anim amet occaecat aliquip excepteur enim nostrud quis esse voluptate irure in ad adipisicing occaecat culpa commodo velit sit laboris occaecat dolor esse sunt nisi do esse Lorem incididunt exercitation cillum duis",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Bullzone Exercitation reprehenderit laboris ut qui qui consequat.",
                        Author = "Debra Gibbs",
                        Date = DateTime.Parse("27/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "35200",
                        Email = "debragibbs@bullzone.com",
                        Article = "Excepteur voluptate reprehenderit eiusmod id ad culpa velit reprehenderit ipsum. Eiusmod veniam ad eu enim enim aliqua est adipisicing mollit dolor mollit officia aliqua. Aliquip aliqua excepteur incididunt id eiusmod exercitation laboris est ex tempor enim ex sunt sint. Eiusmod laboris elit occaecat et Lorem cillum sint nulla consequat aute sunt aliqua. In id labore tempor velit quis cupidatat reprehenderit Lorem. Adipisicing enim cupidatat aute magna cillum duis esse quis nostrud consequat.<br>Ipsum minim id consectetur adipisicing qui proident. Deserunt culpa anim officia enim non duis ullamco. Voluptate sunt velit et consectetur nisi cillum et exercitation aliqua.<br>",
                        ArticleIntro = "duis dolor veniam culpa reprehenderit in eu sunt consectetur ullamco ipsum laboris sunt aute deserunt esse aliqua voluptate irure dolor esse sint dolore enim sit incididunt ipsum irure consectetur sunt do aute Lorem sunt voluptate magna et consectetur ullamco esse amet commodo sunt aliqua dolor duis veniam in elit tempor",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Terrago Minim ipsum occaecat minim deserunt ex dolor consectetur laboris eu adipisicing officia pariatur magna.",
                        Author = "Sallie Fulton",
                        Date = DateTime.Parse("19/02/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "14841",
                        Email = "salliefulton@terrago.com",
                        Article = "Velit non excepteur ea laborum occaecat reprehenderit est in mollit est ipsum. Exercitation labore officia nulla nulla reprehenderit ad in ullamco labore esse eiusmod. Irure enim non sint exercitation consectetur dolor magna cupidatat veniam pariatur amet dolor.<br>Consectetur anim qui sit labore amet Lorem. Nulla amet Lorem sint sit deserunt aliqua ea ea quis. Et culpa amet sit mollit consequat id ea in id. Duis ullamco incididunt excepteur deserunt. Cupidatat fugiat eiusmod id proident aliqua in in. Culpa anim amet mollit commodo elit sint minim ad nostrud anim magna fugiat.<br>",
                        ArticleIntro = "qui cillum ipsum nisi proident dolore cillum Lorem sint duis eiusmod do culpa irure dolore consectetur culpa consequat cupidatat proident culpa dolore officia adipisicing et pariatur ullamco labore reprehenderit labore do ipsum adipisicing consectetur cillum labore dolore do cillum ex commodo Lorem velit enim elit Lorem officia nisi do excepteur",
                        Tag = "sport"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Accupharm Voluptate officia anim sunt eiusmod esse et.",
                        Author = "Guy Wiley",
                        Date = DateTime.Parse("03/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "38686",
                        Email = "guywiley@accupharm.com",
                        Article = "Aliqua tempor elit tempor et consectetur in. Velit ad culpa enim dolor tempor culpa occaecat officia laboris. Duis elit amet exercitation magna ea minim reprehenderit occaecat ut commodo. Lorem reprehenderit aliquip aliqua voluptate nulla dolor Lorem adipisicing eiusmod do anim.<br>Dolore aliqua tempor et excepteur voluptate aliqua enim est. Fugiat pariatur pariatur minim aliqua. Voluptate velit et laboris occaecat consequat qui nostrud labore. Ex commodo id fugiat tempor. Pariatur est adipisicing eiusmod duis ex commodo sunt non aute aliquip cupidatat ipsum. Ipsum consequat ut irure pariatur cupidatat eu. Reprehenderit aliquip ex duis id est et do do culpa ad.<br>",
                        ArticleIntro = "fugiat ullamco magna sit laboris cillum culpa exercitation minim non exercitation cillum eiusmod labore est amet laborum exercitation esse officia ex Lorem dolor culpa labore aliqua commodo consectetur exercitation sint eiusmod Lorem irure nisi sunt do quis esse do cupidatat officia enim anim esse fugiat magna anim minim tempor eu",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Callflex Exercitation sint sunt est eu minim ea incididunt magna non velit ullamco aliqua.",
                        Author = "Boyd Pratt",
                        Date = DateTime.Parse("23/05/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "39666",
                        Email = "boydpratt@callflex.com",
                        Article = "Ullamco ut laboris eu irure id do cillum ea anim quis esse fugiat. Aute in reprehenderit minim magna Lorem reprehenderit laboris consequat do veniam ad incididunt. Ex esse occaecat fugiat occaecat amet irure. Mollit et est aliquip id sunt minim exercitation et aliquip veniam fugiat. Et sunt minim in pariatur nulla ullamco aliqua esse. Officia voluptate nulla sunt commodo reprehenderit cillum et aliqua et culpa. Nostrud minim ullamco laboris non consequat voluptate incididunt consequat irure irure adipisicing non.<br>Minim ex in do aute. Do fugiat proident occaecat ut consequat dolore aute. Amet veniam in excepteur do do. Incididunt est enim dolore aliqua aliqua quis dolor qui deserunt voluptate proident fugiat est aliqua. Adipisicing sit enim sit ex laborum irure in dolore magna occaecat.<br>",
                        ArticleIntro = "sunt minim duis nostrud magna do qui amet do ut cupidatat elit laborum sunt eu non esse nostrud occaecat est excepteur voluptate consequat amet ea esse mollit laboris ex dolor sunt nostrud enim amet irure ut eu ad duis occaecat labore tempor eiusmod in fugiat officia cupidatat pariatur est amet",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Polaria Sint aute dolore non eiusmod minim sint.",
                        Author = "Cooper Elliott",
                        Date = DateTime.Parse("06/03/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "7171",
                        Email = "cooperelliott@polaria.com",
                        Article = "Consectetur consectetur adipisicing anim dolore ipsum deserunt mollit tempor. Reprehenderit deserunt dolore cillum ea. Ipsum ad do veniam reprehenderit enim amet pariatur consectetur in minim dolore sit. Quis sit aute cupidatat ipsum veniam ea exercitation nostrud id nostrud est adipisicing Lorem. Incididunt fugiat laboris mollit veniam culpa sunt Lorem dolor duis velit ex.<br>Aliquip laborum ex magna et occaecat. Ipsum ullamco mollit ex et et occaecat adipisicing non ut consequat duis labore. Do consequat cillum pariatur sunt exercitation nisi proident proident consectetur. Sit quis adipisicing incididunt aliquip elit commodo amet exercitation. Fugiat esse nostrud eu ex nostrud reprehenderit occaecat voluptate ipsum. Dolor consectetur et aliquip ad ipsum deserunt aliqua id eiusmod id.<br>",
                        ArticleIntro = "enim sint tempor ut anim sit occaecat pariatur cillum minim ipsum ipsum minim minim sint consectetur in consectetur minim duis occaecat nulla magna nisi duis proident adipisicing eiusmod et velit veniam sint eiusmod irure aliqua non irure commodo veniam amet aliqua commodo quis ea tempor sit labore aute consectetur amet",
                        Tag = "science"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Viasia Sint nulla dolore officia qui.",
                        Author = "Santos Riggs",
                        Date = DateTime.Parse("18/08/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "4874",
                        Email = "santosriggs@viasia.com",
                        Article = "Do non deserunt incididunt sunt proident proident ea commodo exercitation dolore. Excepteur ad ea sunt nostrud sit eu tempor mollit qui elit aute irure. Mollit culpa ex qui non et amet adipisicing occaecat commodo non occaecat minim eiusmod.<br>Non esse mollit ea ad Lorem ad deserunt occaecat deserunt nostrud ullamco minim reprehenderit. Et cillum ad do incididunt deserunt quis proident id veniam duis sint incididunt ad incididunt. Dolor id anim ex esse dolor occaecat cillum enim cillum cillum eu. Voluptate adipisicing sunt aliqua ullamco nisi occaecat nulla elit nisi eiusmod voluptate est. Mollit nulla aliquip enim nostrud sunt esse minim et. Occaecat laboris magna veniam voluptate est tempor cillum. Irure ad sint enim adipisicing fugiat.<br>",
                        ArticleIntro = "cillum duis irure ad enim ex aute voluptate ullamco qui ullamco irure aute duis ipsum qui officia aliqua dolore anim qui consectetur sit mollit Lorem ex pariatur pariatur aliqua adipisicing sint eiusmod cillum do minim magna quis minim fugiat ex magna adipisicing consectetur ea tempor commodo officia occaecat ea ex",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Cognicode Non reprehenderit commodo eiusmod ex officia ut officia culpa duis adipisicing proident nisi eiusmod ad.",
                        Author = "Holcomb Todd",
                        Date = DateTime.Parse("01/01/2017"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "28963",
                        Email = "holcombtodd@cognicode.com",
                        Article = "Proident pariatur ex excepteur dolor ut sint ipsum dolore nostrud. Cillum veniam duis consequat sint quis. Mollit consequat Lorem ipsum qui. Ut ea adipisicing excepteur minim dolor eu aute aliqua est et id cillum dolore. Nostrud elit amet in exercitation aliqua amet sit irure incididunt incididunt Lorem. Duis officia quis ullamco adipisicing voluptate.<br>Do sint aliquip in aliqua sint eu commodo ipsum amet ullamco reprehenderit magna ipsum adipisicing. Exercitation sit veniam commodo reprehenderit velit velit exercitation labore nostrud id dolor id sint. Officia quis esse consectetur duis.<br>",
                        ArticleIntro = "aliquip in nisi excepteur fugiat excepteur laboris deserunt nulla exercitation enim laborum velit irure commodo eiusmod fugiat consequat ipsum minim sint non tempor aliqua ullamco et occaecat velit irure deserunt ea incididunt enim occaecat aliqua ex nostrud deserunt quis ullamco veniam voluptate amet aliqua enim magna officia commodo laborum consequat",
                        Tag = "news"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Xanide Anim sint duis aute enim mollit voluptate.",
                        Author = "Dionne Eaton",
                        Date = DateTime.Parse("28/06/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "30551",
                        Email = "dionneeaton@xanide.com",
                        Article = "Tempor ut ex officia consectetur nulla do dolore et dolore ullamco eu pariatur aliqua est. Magna id Lorem et anim aliqua. Aliqua ut id non sit qui esse pariatur aute cupidatat ea est.<br>In cupidatat deserunt excepteur exercitation velit. Dolore culpa elit amet exercitation. Pariatur incididunt veniam eiusmod ex elit nostrud officia do incididunt. Nulla nostrud laboris veniam eiusmod dolor. Ea mollit qui qui ex incididunt proident voluptate occaecat mollit dolor id. Occaecat nisi excepteur incididunt laborum minim voluptate sint irure.<br>",
                        ArticleIntro = "fugiat sunt sit adipisicing consequat velit sit adipisicing dolore tempor cupidatat deserunt Lorem dolor officia labore nisi in ullamco ex nisi minim irure excepteur enim consequat est consectetur magna irure fugiat anim in ut reprehenderit culpa deserunt occaecat fugiat proident Lorem ut eiusmod sit cillum voluptate mollit culpa nulla sit",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Zillidium Velit eiusmod sint eiusmod velit dolore commodo nostrud dolore adipisicing.",
                        Author = "Neva Hopkins",
                        Date = DateTime.Parse("17/12/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "23362",
                        Email = "nevahopkins@zillidium.com",
                        Article = "Sit minim mollit dolore quis. Do non reprehenderit voluptate elit irure in ut id proident dolore. Ad anim nulla nulla ut id proident. Cillum veniam eu aliquip ea. Pariatur laboris ipsum reprehenderit labore sunt. Nisi elit aliquip mollit excepteur ut laboris.<br>Lorem dolor ad veniam incididunt reprehenderit dolore adipisicing cupidatat. Commodo commodo laborum occaecat in labore est non ullamco anim aute. Deserunt in duis labore veniam veniam mollit. Amet amet tempor eu adipisicing labore laborum nulla duis ad amet mollit. Adipisicing amet enim elit esse esse nostrud. Incididunt ipsum irure sit incididunt duis.<br>",
                        ArticleIntro = "enim voluptate in sunt et cillum veniam enim velit consectetur occaecat magna voluptate ad ullamco id pariatur pariatur mollit dolor sit ex aliqua consequat enim occaecat ex Lorem culpa sunt cillum non excepteur incididunt labore aute cupidatat ad laborum mollit pariatur tempor enim id adipisicing esse ad officia nisi fugiat",
                        Tag = "games"
                    }
                );

                context.Blog.AddRange(
                    new Blog
                    {
                        Title = "Portico Tempor consequat duis non elit non magna ea esse quis aliqua dolore aliqua consectetur pariatur.",
                        Author = "Dina Fuentes",
                        Date = DateTime.Parse("29/09/2016"),
                        Avatar = "http://placehold.it/40x40",
                        Img = "http://placehold.it/800x425/E8117F/ffffff/?text=Article+image",
                        Views = "33751",
                        Email = "dinafuentes@portico.com",
                        Article = "Quis laborum adipisicing est minim culpa cillum amet tempor do nulla. Proident commodo tempor nostrud reprehenderit id esse minim ipsum non aliqua aute anim aliqua. Eu aliquip id dolore sint mollit irure aute aliqua tempor.<br>Voluptate anim fugiat mollit ad aliqua ut ad pariatur in officia deserunt. Anim ea consectetur fugiat cupidatat. Dolor voluptate est anim tempor nisi. Qui cillum incididunt aliqua et reprehenderit laboris exercitation exercitation ad officia aute culpa. Ex ipsum voluptate deserunt enim exercitation. Irure esse non aliquip officia commodo cillum dolore ut ullamco fugiat. Sit ad occaecat enim do sunt tempor Lorem proident.<br>",
                        ArticleIntro = "voluptate laborum aliqua enim fugiat Lorem dolore culpa nisi tempor sunt excepteur enim ad cillum labore occaecat sunt aliqua enim aliquip ullamco officia aute in non laborum id excepteur cupidatat aliquip deserunt ex est eiusmod eu laboris in ex nulla id nostrud aute officia aliqua dolore cupidatat et proident incididunt",
                        Tag = "kittens"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
