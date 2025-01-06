using UnityEngine;

namespace MySampleEx
{
    /// <summary>
    /// 
    /// </summary>
    [CreateAssetMenu(fileName = "New Card", menuName = "Scriptable Objects/Card")]
    public class Card : ScriptableObject
    {
        new public string name;
        public string description;

        public int mana;
        public int attack;
        public int health;

        public Sprite artImage;
    }
}