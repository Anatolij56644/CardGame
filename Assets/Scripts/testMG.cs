using System.Collections.Generic;
using UnityEngine;

public class testMG : MonoBehaviour
{
    [SerializeField] private List<Player> _allPlayers;
    [SerializeField] private List<Card> _allCards;

    [SerializeField] private List<Card> _selectedCards;

    [SerializeField] private Camera mainCamera;

   // public static Action StartRound;

    [SerializeField] private int _roundNumber;



    [SerializeField] private bool start;

    int numberPlayer = 0;

    private void Start()
    {
        Round();
    }

    private void Round()
    {
        //StartRound?.Invoke();

        start = true;
    }

    //private void Fight(bool oneUse)
    //{

    //    if (!oneUse)
    //    {
    //        oneUse = true;
    //        foreach (Player player in _allPlayers)
    //        {
    //            _selectedCards.Add(player.SearchCard());
    //        }
    //    }
    //}
    private void Update()
    {
        if (start == true)
        {

            bool test = false;

            if (numberPlayer < _allPlayers.Count && test == false)
            {
                test = true;

              //  test = _allPlayers[numberPlayer].SelectCard();

                if (!test)
                {
                    if (numberPlayer != _allPlayers.Count)
                    {
                        numberPlayer++;
                    }

                }

            }
            else if (numberPlayer == _allPlayers.Count)
            {
                start = false;
              //  Fight(start);
            }
        }
    }



    private void Awake()
    {
        GameObject[] _gameObjectPlayer = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] _gameObjectCard = GameObject.FindGameObjectsWithTag("Card");

        foreach (GameObject player in _gameObjectPlayer)
        {
            Player isPlayer = player.GetComponent<Player>();
            _allPlayers.Add(isPlayer);
        }

        foreach (GameObject card in _gameObjectCard)
        {
            Card isCard = card.GetComponent<Card>();
            _allCards.Add(isCard);
        }

        if (_allPlayers.Count > 1)
        {
            ShuffleList(_allPlayers);
        }
    }

    private void ShuffleList(List<Player> players)
    {
        for (int i = 0; i < players.Count; i++)
        {
            int j = UnityEngine.Random.Range(0, players.Count);
            Player shuffleList = players[i];
            players[i] = players[j];
            players[j] = shuffleList;
        }

        int playerID = 0;

        foreach (Player player in players)
        {
            //player.AssignmentID(playerID++);
        }
        return;
    }


}
