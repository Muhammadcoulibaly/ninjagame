using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

 

public class ScoreBoard : MonoBehaviour 

{ 

    TMP_Text scoreText; 

    int score; 

    // Start is called before the first frame update 

    void Start() 

    { 

        scoreText = GetComponent<TMP_Text>(); 

        scoreText.text = ""; 

         

    } 

 

    // Update is called once per frame 

   public void IncreaseScore(int amountToIncrease){ 

       score += amountToIncrease; 

       scoreText.text = score.ToString(); 

       Debug.Log($"fails is : {score}");}

} 
