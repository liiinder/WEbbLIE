using WEbbLIE.Models;
using static System.Net.WebRequestMethods;

namespace WEbbLIE
{
    public class ShowcaseService
    {
        public List<ShowcaseSites> GetSites() => new()
        {
            new ShowcaseSites { Name = "Neal.fun", Url = "https://neal.fun/absurd-trolley-problems/", Description = "Absurd Trolley Problem", ImageUrl = "Screenshot 2025-03-18 101630.png"},
            new ShowcaseSites { Name = "Cookie Clicker", Url = "https://orteil.dashnet.org/cookieclicker/", Description = "Roligt klick spel", ImageUrl = "Screenshot 2025-03-18 095301.png"},
            new ShowcaseSites { Name = "Horizonte", Url = "https://horizonte-village.com/?category=villas", Description = "Bostads hemsida", ImageUrl = "Screenshot 2025-03-18 101053.png"},
            new ShowcaseSites { Name = "J-Vers", Url = "https://www.j-vers.com/", Description = "Jobbannoserings hemsida", ImageUrl = "Screenshot 2025-03-18 100538.png"},
            new ShowcaseSites { Name = "PataTap", Url = "https://www.patatap.com/", Description = "Musik producering", ImageUrl = "Screenshot 2025-03-18 095714.png"},
            new ShowcaseSites { Name = "Picture of a hotdog", Url = "https://www.pictureofhotdog.com/", Description = "Inspirations hemsida för matlagning", ImageUrl = "Screenshot 2025-03-18 102339.png"},
            new ShowcaseSites { Name = "TheMostAmazingWebsiteonTheInternet", Url = "http://www.themostamazingwebsiteontheinternet.com/", Description = "Världens mest intressanta hemsida", ImageUrl = "Screenshot 2025-03-18 094104.png"},
            new ShowcaseSites { Name = "Unseen", Url = "https://unseen.co/", Description = "Detta går inte att beskriva...", ImageUrl = "Screenshot 2025-03-18 102736.png"},
            new ShowcaseSites { Name = "WeAreBreakfast", Url = "https://wearebreakfast.com/", Description = "Musik studio", ImageUrl = "Screenshot 2025-03-18 094312.png"},
        };
    }
}
