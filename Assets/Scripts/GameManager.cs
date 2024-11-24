
using System.Collections.Generic;

using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private List<Player> _allPlayers;

    [SerializeField] private List<Card> _allCards;

    [SerializeField] private int _numberRound;

    private void Awake()
    {
        GameObject[] _gameObjectPlayer = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject player in _gameObjectPlayer)
        {
            Player isPlayer = player.GetComponent<Player>();
            _allPlayers.Add(isPlayer);
        }
    }

    private void Start()
    {
        StartRound();
    }


    private void StartRound()
    {
        _numberRound++;

        PurposeCards();
    }


    private void PurposeCards()
    {
        string[] typeCards = System.Enum.GetNames(typeof(Card.typeCard));

        int numberCard = 0;


        for (int i = 0; i < _allPlayers.Count; i++)
        {
            for (int k = 0; k < 3; k++)
            {
                typeCards[numberCard] = typeCards[Random.Range(0, typeCards.Length)];

                Card.typeCard typeCard = (Card.typeCard)System.Enum.Parse(typeof(Card.typeCard), typeCards[numberCard]);

                _allCards[numberCard].AssignCard(typeCard);

                _allPlayers[i].thisPlayerCards.Add(_allCards[numberCard]);

                numberCard++;
            }
        }
    }
}
