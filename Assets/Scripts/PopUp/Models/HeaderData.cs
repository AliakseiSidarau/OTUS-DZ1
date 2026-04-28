using UnityEngine;

namespace PopUp
{
    public class HeaderData
    {
        public string Name { get; }
        public Sprite Image { get; }
        public int Level { get; }

        public HeaderData(string name, Sprite image, int level)
        {
            Name = name;
            Image = image;
            Level = level;
        }
    }
}