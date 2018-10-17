using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GenerateQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int answer;
    public string randomOperator;
    public GameObject question;
    public GameObject option1;
    public GameObject option2;
    public GameObject option3;
    public GameObject next;


    public void GenerateQuestion()
    {
        int a = Random.Range(0, 101);
        int b = Random.Range(0, 101);

        int operatorNumber = Random.Range(0, 3);

        if (operatorNumber == 0)
        {
            randomOperator = "+";
            answer = a + b;
        }


        else if(operatorNumber == 1)
        {
            randomOperator = "-";
            answer = a - b;
        }

        else
        {
            randomOperator = "*";
            answer = a * b;
        }


        int option = Random.Range(0, 3);
        if (option == 0)
        {
            option1.GetComponent<TextMesh>().text = answer.ToString();
            option2.GetComponent<TextMesh>().text = (answer + Random.Range(-13, 7)).ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(-10, 10)).ToString();
            option1.GetComponent<option>().isCorrect = true;
            option2.GetComponent<option>().isCorrect = false; 
            option3.GetComponent<option>().isCorrect = false;
            option1.GetComponent<option>().ans = option1;
            option2.GetComponent<option>().ans = option1;
            option3.GetComponent<option>().ans = option1;

        }
        else
        {
            option1.GetComponent<TextMesh>().text = (answer + Random.Range(-10, 10)).ToString();
            option2.GetComponent<TextMesh>().text = answer.ToString();
            option3.GetComponent<TextMesh>().text = (answer + Random.Range(-15, 8)).ToString();
            option1.GetComponent<option>().isCorrect = false;
            option2.GetComponent<option>().isCorrect = true;
            option3.GetComponent<option>().isCorrect = false;
            option2.GetComponent<option>().ans = option2;
            option1.GetComponent<option>().ans = option2;
            option3.GetComponent<option>().ans = option2;


        }
        question.GetComponent<TextMesh>().text = a + " " + randomOperator + " " + b + " = ?";
    }

   

}
