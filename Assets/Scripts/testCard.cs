using UnityEngine;

public class testCard : MonoBehaviour
{
    public enum typeCard { Water, Fire, Ground };

    [SerializeField] private typeCard _typeThisCard;

    [SerializeField] private bool _isOpen;

    public void AssignmentType(int number)
    {
        string[] nameThisTypeCard = System.Enum.GetNames(typeof(typeCard));
        _typeThisCard = (typeCard)System.Enum.Parse(typeof(typeCard), nameThisTypeCard[number]);
    }

    public void OpenAndCloseCard()
    {
        _isOpen = !_isOpen;
    }

    private void OnMouseDown()
    {
        Click();
    }

    private void Click()
    {
        print("yes");
    }
}
