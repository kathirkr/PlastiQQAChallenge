using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlastiQQAChallenge.TestClient
{
    public interface ITestClient
    {
        void Connect(BrowserType btype = BrowserType.Chrome);
        void GoToURL(string url);
        void ClickSafe(string path, int waitTimeSpan);
        string PageTitle { get; }
        void SendKeys(string path, string text);
    }
    public enum BrowserType { IE, Chrome, FireFox};

}
