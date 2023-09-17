namespace ThePlaylist
{
    internal class Track
    {
        private string _trackName;
        private string _trackLength;
        private string _trackAlbum;
        private string _trackArtists;
        private string _trackReleaseDate;

        internal Track(string trackName, string trackLength, string trackAlbum, string trackArtists, string trackReleaseDate)
        {
            _trackName = trackName;
            _trackLength = trackLength;
            _trackAlbum = trackAlbum;
            _trackArtists = trackArtists;
            _trackReleaseDate = trackReleaseDate;
        }
        

        internal string TrackName { get { return _trackName; } set { _trackName = value; } }
        internal string TrackLength { get {return _trackLength; } set { _trackLength = value; }}
        internal string TrackAlbum { get { return _trackAlbum; } set { _trackAlbum = value; } }
        internal string TrackArtists { get { return _trackArtists; } set { _trackArtists = value; } }
        internal string TrackReleaseDate {  get { return _trackReleaseDate; } set { _trackReleaseDate = value; } }

    }
}
