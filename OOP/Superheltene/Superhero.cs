namespace Superhero
{
    /// <summary>
    /// These are the properties of the object Superhero which can be set according to what superhero object is being made.
    /// </summary>
    internal class Superhero
    {
        private string _secretName = string.Empty;
        private string _heroName = string.Empty;
        private string _powers = string.Empty;
        private bool _wearsMask;
        private bool _wearsCostume;
        private bool _fightsAlone;
        private bool _hasStrongMoralComplex;
        private bool _hasNemesis;
        private bool _hasPrivateAnxiety;
        private bool _hasSecretIdentiy;

        public string SecretName
        {
            get {return _secretName;}
            set {_secretName = value;}
        }

        public bool HasSecretIdentity
        {
            get {return _hasSecretIdentiy;}
            set {_hasSecretIdentiy = value;}
        }

        public string HeroName
        {
            get {return _heroName;}
            set {_heroName = value;}
        }

        public string Powers
        {
            get {return _powers;}
            set {_powers = value;}
        }

        public bool WearsMask
        {
            get {return _wearsMask;}
            set {_wearsMask = value;}
        }

        public bool WearsCostume
        {
            get {return _wearsCostume;}
            set {_wearsCostume = value;}
        }

        public bool FightsAlone
        {
            get {return _fightsAlone;}
            set {_fightsAlone = value;}
        }

        public bool HasStrongMoralComplex
        {
            get {return _hasStrongMoralComplex;}
            set {_hasStrongMoralComplex = value;}
        }

        public bool HasNemesis
        {
            get {return _hasNemesis;}
            set {_hasNemesis = value;}
        }

        public bool HasPrivateAnxiety
        {
            get {return _hasPrivateAnxiety;}
            set {_hasPrivateAnxiety = value;}
        }
    }
}