using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTImer : MonoBehaviour
{


    public float currentTime = 0f;
   [SerializeField]  float startingTime = 5f;

    public GameObject Player;

    [SerializeField] Text countdownText;


    private void Start()
    {
        currentTime = startingTime;
    }

    private void Update()
    {

        currentTime -= 1 * Time.deltaTime;
        countdownText.text = "Time left: " + currentTime.ToString("0");

        
        if(currentTime <= 0)
        {
            currentTime = 0;
            Player.GetComponent<Health>().TakeDamage(1);
            currentTime = startingTime;


        }
    }
}
