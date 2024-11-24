using UnityEngine;

public class Card : MonoBehaviour
{
    public enum typeCard { Fire, Water, Earth, Air, Vegetation, Ethereal}; 

    [SerializeField] private typeCard _typeThisCard;

    public void AssignCard(typeCard typeCard)
    {
        _typeThisCard = typeCard;
    }


}
