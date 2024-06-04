using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr4
{
    class CountVisitWebSite
    {
        string addressWebsite;
        string ipAddress;
        string webBrowser;
        DateTime dateVisit;
        TimeSpan timeVisit;
        static public int count;

        public string AddressWebsite { get => addressWebsite; set => addressWebsite = value; }
        public string IpAddress { get => ipAddress; set => ipAddress = value; }
        public string WebBrowser { get => webBrowser; set => webBrowser = value; }
        public DateTime DateVisit { get => dateVisit; set => dateVisit = value; }
        public TimeSpan TimeVisit { get => timeVisit; set => timeVisit = value; }
        static CountVisitWebSite()
        {
            count = 0;
        }
        public CountVisitWebSite() { }
        public CountVisitWebSite(string addressWebsite, string ipAddress, string webBrowser, DateTime dateVisit, TimeSpan timeVisit)
        {
            this.AddressWebsite = addressWebsite;
            this.IpAddress = ipAddress;
            this.WebBrowser = webBrowser;
            this.DateVisit = dateVisit;
            this.TimeVisit = timeVisit;
            count++;
        }

    }
}
