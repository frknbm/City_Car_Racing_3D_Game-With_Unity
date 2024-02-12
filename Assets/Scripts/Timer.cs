using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    [Header("Timer")]
    public float countDowntimer = 5f;

    [Header("Things to stop")]
    public PlayerCarController playerCarController;
    public OpponentCar opponentCar;
    public OpponentCar opponentCar1;
    public OpponentCar opponentCar2;
    public OpponentCar opponentCar3;
    public OpponentCar opponentCar4;

    public Text countDownText;

    void Start()
    {
        StartCoroutine(TimeCount());
    }

    void Update()
    {
        if (countDowntimer > 1)
        {
            playerCarController.accelerationForce = 0f;
            opponentCar.movingSpeed = 0f;
            opponentCar1.movingSpeed = 0f;
            opponentCar2.movingSpeed = 0f;
            opponentCar3.movingSpeed = 0f;
            opponentCar4.movingSpeed = 0f;
        }
        else if(countDowntimer == 0)
        {
            playerCarController.accelerationForce = 300f;
            opponentCar.movingSpeed = 13f;
            opponentCar1.movingSpeed = 10f;
            opponentCar2.movingSpeed = 15f;
            opponentCar3.movingSpeed = 9f;
            opponentCar4.movingSpeed = 10f;
        }

    }

    IEnumerator TimeCount()
    {
        while (countDowntimer > 0)
        {
            countDownText.text = countDowntimer.ToString();
            yield return new WaitForSeconds(0f);
            countDowntimer--;
        }
        countDownText.text = "Go";
        yield return new WaitForSeconds(1f);
        countDownText.gameObject.SetActive(false);
    }



}
