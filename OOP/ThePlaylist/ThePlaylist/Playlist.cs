namespace ThePlaylist
{
    internal class Playlist
    {
        private string _playlistName;

        internal LinkedList<Track> playlist = new LinkedList<Track>();
        internal LinkedList<Track> playlist2 = new LinkedList<Track>();

        internal Playlist()
        {
            
                playlist.AddFirst(new Track("Rockstar Made", "3:13", "Whole Lotta Red", "Playboi Carti", "25. Decemeber 2020"));
                playlist.AddLast(new Track("Stop Breathing", "3:38", "Whole Lotta Red", "Playboi Carti", "25. Decemeber 2020"));
                playlist.AddLast(new Track("if looks could kill", "3:14", "if looks could kill", "Destroy Lonely", "3. March 2023"));


                playlist2.AddLast(new Track("Freestyle 2", "2:18", "X", "Ken Carson", "8. July 2022"));
                playlist2.AddLast(new Track("Go", "1:50", "X", "Ken Carson", "8. July 2022"));
                playlist2.AddLast(new Track("FE!N", "3:11", "Utopia", "Travis Scott, Playboi Carti", "28. July 2023"));


        }

        internal string PlayListName
        {
            get { return _playlistName; }
            set { _playlistName = value; }
        }
    }
}
