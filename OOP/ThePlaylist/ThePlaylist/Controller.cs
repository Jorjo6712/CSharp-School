namespace ThePlaylist
{
    internal class Controller
    {
        internal void MainController()
        {
            View view = new View();
            Playlist playlist1 = new Playlist();
            Playlist playlist2 = new Playlist();
            
            playlist1.PlayListName = "Opium";
            playlist2.PlayListName = "Opium++";

            view.Text($"\t Playlist {playlist1.PlayListName} contents: \n");
            foreach (Track track in playlist1.playlist) 
            {
                view.Text("\t Track name: " + track.TrackName);
                view.Text("\t Track length: " + track.TrackLength);
                view.Text("\t Track artists: " + track.TrackArtists);
                view.Text("\t Track album: " + track.TrackAlbum);
                view.Text("\t Track release date: " + track.TrackReleaseDate);
                view.Text("\t-----------------------------");
            }

            view.Text($"\n\t Playlist {playlist2.PlayListName} contents: \n");
            foreach (Track track in playlist2.playlist2)
            {
                view.Text("\t Track name: " + track.TrackName);
                view.Text("\t Track length: " + track.TrackLength);
                view.Text("\t Track artists: " + track.TrackArtists);
                view.Text("\t Track album: " + track.TrackAlbum);
                view.Text("\t Track release date: " + track.TrackReleaseDate);
                view.Text("\t-----------------------------");
            }

        }
    }
}
