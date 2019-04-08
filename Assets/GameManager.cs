using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    float xMin = 0.5f, xMax = 12f;
     float yMin = 0.5f, yMax = 9.5f;


    public Text scoreText;
    public Text timerText;

    int score = 0;
    float time = 30f;

   
    public GameObject target;
    Vector2 offset = new Vector2(30f,30f);

    public Texture2D crossHair;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Cursor.SetCursor(crossHair, offset, CursorMode.Auto);

        CountDownTimer();
        int totalTarget = GameObject.FindGameObjectsWithTag("Target").Length;

        if (totalTarget == 0)
       
        {
            Vector3 ranomdLocation = Random2DVector();
            if (time > 0)
            {
                Instantiate(target, ranomdLocation, Quaternion.identity);
            }

        }
		
	}
    private void CountDownTimer()
    {
        time = time - Time.deltaTime;
        scoreText.text = score.ToString();
        if (time > 0)
        {
            timerText.text = Mathf.RoundToInt(time).ToString();
        }
    }

    private Vector3 Random2DVector()
    {
        float xRange = Random.Range(xMin, xMax);
        float yRange = Random.Range(yMin, yMax);
        Vector3 randomLocation = new Vector3(xRange, yRange, transform.position.z);
        return randomLocation;
    }

    public void IncrementScore()
    {
        score++;
    }
}
