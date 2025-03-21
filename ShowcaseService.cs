using WEbbLIE.Models;
using static System.Net.WebRequestMethods;

namespace WEbbLIE
{
    public class ShowcaseService
    {
        public List<ShowcaseSites> GetSites() => new()
        {
            new ShowcaseSites { Name = "Neal.fun", Url = "https://neal.fun/absurd-trolley-problems/", Description = "Absurd Trolley Problem", ImageUrl = "Showcases/AsburdTrolleyProblem/AbsurdTrollyProblem.png"},
            new ShowcaseSites { Name = "Cookie Clicker", Url = "https://orteil.dashnet.org/cookieclicker/", Description = "Roligt klick spel", ImageUrl = "Showcases/CookieClicker/CookieClicker.png"},
            new ShowcaseSites { Name = "Horizonte", Url = "https://horizonte-village.com/?category=villas", Description = "Bostads hemsida", ImageUrl = "Showcases/Horizonte-Village/Horizonte.png"},
            new ShowcaseSites { Name = "J-Vers", Url = "https://www.j-vers.com/", Description = "Jobbannoserings hemsida", ImageUrl = "Showcases/Jvers/Jvers.png"},
            new ShowcaseSites { Name = "PataTap", Url = "https://www.patatap.com/", Description = "Musik producering", ImageUrl = "Showcases/PataTap/PataTap.png"},
            new ShowcaseSites { Name = "Picture of a hotdog", Url = "https://www.pictureofhotdog.com/", Description = "Inspirations hemsida för matlagning", ImageUrl = "ShowCases/PictureOfAHotdog/PictureOfAHotdog.png"},
            new ShowcaseSites { Name = "TheMostAmazingWebsiteonTheInternet", Url = "http://www.themostamazingwebsiteontheinternet.com/", Description = "Världens mest intressanta hemsida", ImageUrl = "Showcases/TheMostAmazingWebsite/TMAW.png"},
            new ShowcaseSites { Name = "Unseen", Url = "https://unseen.co/", Description = "Detta går inte att beskriva...", ImageUrl = "Showcases/Unseen/Unseen.png"},
            new ShowcaseSites { Name = "WeAreBreakfast", Url = "https://wearebreakfast.com/", Description = "Musik studio", ImageUrl = "Showcases/WeAreBreakfast/WeAreBreakfast.png"},
        };
    }
}
