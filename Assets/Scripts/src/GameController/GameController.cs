using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Players
{
    X = 0,
    O = 1
}

public class GameController : MonoBehaviour
{
    public static int[,] winningCombinations =  
    {
        { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, // rows
        { 1, 4, 7 }, { 2, 5, 6 }, { 3, 6, 9 }, // columns
        { 1, 5, 9 }, { 3, 5, 7 }, // diagonals
    };

    // do i need a gameboard?
    int[,] gameBoard = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 9 }
    };
    public Players currentPlayer = Players.X;
    public Scoreboard scoreboard;

    void Start()
    {
        this.scoreboard = new Scoreboard();
        Debug.Log("hi daniel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

[System.Serializable]
public class Scoreboard
{
    public int X = 0;
    public int O = 0;

    public void AddWinTo(Players player)
    {
        if (player == Players.X)
        {
            this.X = this.X + 1;
        }
        else if (player == Players.O)
        {
            this.O = this.O + 1;
        }
    }
}