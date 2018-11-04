using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public float offset;
    public Text scoreText;

    private void Start()
    {
        offset = player.position.x;
    }

    // Update is called once per frame
    void Update () {
        float aux = player.position.x - offset;
        if (!FindObjectOfType<GameManager>().gameHasEnd)
        {
        scoreText.text = aux.ToString("0");
        }
	}

    public void EndGame ()
    {
        
    }
}
