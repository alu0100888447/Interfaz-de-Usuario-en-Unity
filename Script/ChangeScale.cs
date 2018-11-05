using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeScale : MonoBehaviour {

    public float increase = 1.2f;

    private void Start()
    {
        GameController.ChangeScale += increaseScale;
    }

    private void increaseScale () {
		gameObject.GetComponent<Transform> ().localScale *= increase;
	}
}
