using UnityEngine;

namespace PopUp
{
    [System.Serializable]
    public sealed class Hero
    {
        public string name = "@JaneWizzard";
        public Sprite image;
        public int level = 99;
        public string description = "I'm the best of the best";
        public float moveSpeed = 10;
        public float intelligence = 30;
        public float stamina = 13;
        public float damage = 57;
        public float dexterity = 24;
        public float regeneration = 17;
        public Sprite xpImage;
    }
}