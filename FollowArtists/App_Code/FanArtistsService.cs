using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FanArtistsService" in code, svc and config file together.
public class FanArtistsService : IFanArtistsService
{
    ShowTrackerEntities ste = new ShowTrackerEntities();
    public int FollowArtist(int fkey, string aname)
    {
        int result = 1;

        Fan newFan = (from f in ste.Fans
                      where f.FanKey.Equals(fkey)
                      select f).First();

        Artist newArtist = (from a in ste.Artists
                            where a.ArtistName.Equals(aname)
                            select a).First();

        newFan.Artists.Add(newArtist);

        ste.SaveChanges();

        return result;
    }


 /*
    public List<ShowInfo> GetShowsForFanArtists(int fanKey)
    {
        Fan myFan = (from f in ste.Fans
                     where f.FanKey == fanKey
                     select f).First();

        List<ShowInfo> shows = new List<string>();

        
        foreach (Artist a in myFan.Artists)
        {
           
            var shws = from s in ste.Shows
                       from sd in s.ShowDetails
                       where sd.ArtistKey == a.ArtistKey
                       select new
                       {
                           s.ShowName,
                           s.ShowTime,
                           s.ShowDate,
                           s.ShowTicketInfo,
                           s.Venue.VenueName,
                           sd.Artist.ArtistName
                       };

            foreach (var sh in shws)
            {
                ShowInfo info = new ShowInfo();
                info.ShowName = sh.ShowName;
                info.ShowDate = sh.ShowDate;
                info.ShowTime = sh.ShowTime;
                info.ShowTicket = sh.ShowTicketInfo;
                info.VenueName = sh.VenueName;
                info.ArtistName = sh.ArtistName;

                shows.Add
            }

        }
        return shows;

    }
    */
}
