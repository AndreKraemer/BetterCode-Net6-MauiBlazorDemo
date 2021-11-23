using BetterCodeMauiBlazorDemo.Models;
using System.Collections.Generic;

namespace BetterCodeMauiBlazorDemo.Services
{
    public interface IDataService
    {
        Session GetSession(int id);
        IEnumerable<Session> GetSessions();
        Speaker GetSpeaker(int id);
        IEnumerable<Speaker> GetSpeakers();
    }
}