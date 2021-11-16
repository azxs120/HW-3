using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameOverScreen : MonoBehaviour
{
    public Text PointsText;
    public void Setup()
    {
        gameObject.SetActive(true);
        //PointsText.text = score.ToString() + " POINTS";
    }
}
