using System;

namespace ObjectScripter
{
    [Serializable]
    public class Profiles
    {
        public SerializableDictionary<string, Profile> profiles;

        public Profiles()
        {
            profiles = new SerializableDictionary<string, Profile>();
        }
    }
}
