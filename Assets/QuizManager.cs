using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    //public ToggleGroup answerGroup;
    public GameObject correctCanvas;
    public GameObject wrongCanvas;
    public GameObject quizManager;

    private int currentQuestionIndex = 0;  
    

    private string[] correctAnswers = {
        "a",
    };

    public void Start()
    {
        
    }

    public void CheckAnswer()
    {
        //Toggle selectedToggle = answerGroup.ActiveToggles().FirstOrDefault();

        // if (selectedToggle != null)
        // {
        //     string selectedAnswer = selectedToggle.GetComponentInChildren<Text>().text;
        //
        //     
        //     if (selectedAnswer == correctAnswers[currentQuestionIndex])
        //     {
        //         ShowCorrectCanvas();
        //         Debug.Log("Hello "+selectedAnswer);
        //     }
        //     else
        //     {
        //         ShowWrongCanvas();
        //     }
        // }
    }
    
    public void ShowCorrectCanvas()
    {
        quizManager.gameObject.SetActive(false);
        correctCanvas.gameObject.SetActive(true);
        wrongCanvas.gameObject.SetActive(false);
    }

    public void ShowWrongCanvas()
    {
        quizManager.gameObject.SetActive(false);
        correctCanvas.gameObject.SetActive(false);
        wrongCanvas.gameObject.SetActive(true);
    }

    public void TryAgain()
    {
        quizManager.gameObject.SetActive(true);
        correctCanvas.gameObject.SetActive(false);
        wrongCanvas.gameObject.SetActive(false);
    }
    public void Exit()
    {
        quizManager.gameObject.SetActive(false);
        correctCanvas.gameObject.SetActive(false);
        wrongCanvas.gameObject.SetActive(false);
    }
    
    
    
}