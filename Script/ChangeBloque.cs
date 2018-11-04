using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBloque : MonoBehaviour {

    public GameObject []bloques;
    public static int contador = 0;
    public Material colorMaterial;

    private void Start()
    {
        GameController.ChangeColor += ChangeBlockColor;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Player")
        {
            GameController.ChangeBlocksColor();
            contador++;
        } 
    }

    public void ChangeBlockColor ()
    {
        if (contador % 2 == 0)
        {
            gameObject.GetComponent<Renderer>().material.color = new UnityEngine.Color(0, 0, 0);
        }
        else
        {
            gameObject.GetComponent<Renderer>().material = colorMaterial;
        }
    }
}
