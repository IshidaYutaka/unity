using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text Text;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("a");
        if (other.transform.CompareTag("Player"))
        {
            Text.text = "Game Clear";
            Time.timeScale = 0;
        }
    }
}
