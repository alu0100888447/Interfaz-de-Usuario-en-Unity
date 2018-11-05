using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public delegate void BallGame();
    public static event BallGame ChangeColor;
    public static event BallGame ChangeScale;
    public static event BallGame BallForceD;
    public static event BallGame BallForceA;
    public static event BallGame IncrementPower;
    public static event BallGame DecrementPower;
    public static event BallGame EndGame;
    public static event BallGame TurnOn;
    public static event BallGame TurnOff;
    public static event BallGame ScoreUI;
    public static event BallGame CompleteLevel;
    public static event BallGame FollowP;


    public static void ChangeBlocksColor ()
    {
        if (ChangeColor != null)
        {
            ChangeColor();
        }
    }

    public static void ChangeBlocksScale()
    {
        if (ChangeScale != null)
        {
            ChangeScale();
        }
    }

    public static void Increment ()
    {
        if (IncrementPower != null)
        {
            IncrementPower();
        }
    }

    public static void Decrement ()
    {
        if (DecrementPower != null)
        {
            DecrementPower();
        }
    }

    public static void End ()
    {
        if (EndGame != null)
        {
            EndGame();
        }
    }

    public static void Complete ()
    {
        if (CompleteLevel != null)
        {
            CompleteLevel();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            if (BallForceD != null)
            {
                BallForceD();
            }
        }
        if (Input.GetKey("a"))
        {
            if (BallForceA != null)
            {
                BallForceA();
            }
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
           if (TurnOn != null)
            {
                TurnOn();
            }
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (TurnOff != null)
            {
                TurnOff();
            }
        }
        if (!FindObjectOfType<GameManager>().gameHasEnd)
        {
            if (ScoreUI != null)
            {
                ScoreUI();
            }
        }
        if (FollowP != null)
        {
            FollowP();
        }
    }

    public void OnMouseDown()
    {
        ChangeBlocksScale();
    }
}
