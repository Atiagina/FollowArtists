using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFanArtistsService" in both code and config file together.
[ServiceContract]
public interface IFanArtistsService
{
    [OperationContract]
    int FollowArtist(int fkey, string aname);

   /* [OperationContract]
    List<ShowInfo> GetShowsForFanArtists(int fanKey); */
}

/*
[DataContract]

public class ShowInfo
{
    [DataMember]
    public string ShowName { set; get; }

    [DataMember]
    public DateTime ShowDate { set; get; }

    [DataMember]
    public TimeSpan ShowTime { set; get; }

    [DataMember]
    public string ShowTicket { set; get; }

    [DataMember]
    public int VenueKey { set; get; }

    [DataMember]
    public string ArtistName { set; get; }

    [DataMember]
    public string VenueName { set; get; }


}
 */
