﻿using UnityEngine;
using System.Collections;
using GameDrinker.Tools;

namespace GameDrinker.Decks
{

    /// <summary>
    /// Card Class
    /// </summary>
    [RequireComponent(typeof(GDDeck))]
    [System.Serializable]
    public class GDCard
    {
        [SerializeField]
        private string rank;
        public string Rank
        {
            get { return rank; }
            set
            {
                if (value == "11")
                { rank = "Jack"; }
                else if(value == "12")
                { rank = "Queen"; }
                else if(value == "13")
                { rank = "King"; }
                else
                { rank = value; }
            }
        }

        [SerializeField]
        private SUITS suit;
        public SUITS Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        [SerializeField]
        private bool isOnUse;
        public bool IsOnUse
        {
            get { return isOnUse; }
            set { isOnUse = value; }
        }

        [SerializeField]
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        [SerializeField]
        private GDCARDCOLOR cardColor;
        public GDCARDCOLOR CardColor
        {
            get { return cardColor; }
            set
            {
                if (suit == SUITS.CLUBS || suit == SUITS.SPADES)
                { cardColor = GDCARDCOLOR.BLACK; }
                else if (suit == SUITS.HEARTS || suit == SUITS.DIAMONDS)
                { cardColor = GDCARDCOLOR.RED; }
            }
        }

        public GameObject prefab;

        GDCard()
        {
            Rank = "0";
            Suit = SUITS.SPADES;
        }

        public GDCard(string n, SUITS s)
        {
            Rank = n;
            Suit = s;
        }

    }
}