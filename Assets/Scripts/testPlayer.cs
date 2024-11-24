using System.Collections.Generic;
using UnityEngine;

public class testPlayer : MonoBehaviour
{
    [SerializeField] private int _playerHealthPoints = 3;



    [SerializeField] private Card _card;

    public bool playerMoves;

    [SerializeField] private List<Card> _thisPlayerCards;



    [SerializeField] private int _playerID;

    bool oneUse;



    //private void OnEnable()
    //{
    //    GameManager.StartRound += ShuffleCards;
    //}
    //private void OnDisable()
    //{
    //    GameManager.StartRound -= ShuffleCards;
    //}

    public bool SelectCard()
    {
        if (!oneUse)
        {
            oneUse = true;
            playerMoves = true;
        }

        return playerMoves;
    }

    public Card SearchCard()
    {
        return _card;
    }



    private void Update()
    {
        if (_card != null)
        {
            playerMoves = false;
        }

        if (Input.GetMouseButtonDown(0) && playerMoves == true)
        {
            CastRay();
        }
    }

    void CastRay()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit))
        {

            foreach (Card card in _thisPlayerCards)
            {
                if (card == hit.collider.gameObject.GetComponent<Card>())
                {

                    _card = hit.collider.gameObject.GetComponent<Card>();


                }

            }


        }
    }


    private void ShuffleCards()
    {
        for (int i = 0; i < _thisPlayerCards.Count; i++)
        {
            int j = UnityEngine.Random.Range(0, _thisPlayerCards.Count);
            Card shuffleList = _thisPlayerCards[i];
            _thisPlayerCards[i] = _thisPlayerCards[j];
            _thisPlayerCards[j] = shuffleList;
        }

        int k = 0;

        foreach (Card card in _thisPlayerCards)
        {
            //card.AssignmentType(k++);
            //card.OpenAndCloseCard();
        }
    }

    public void AssignmentID(int thisPlayerID)
    {
        _playerID = thisPlayerID;
    }
}
