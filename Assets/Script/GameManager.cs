using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] private int playerScore;
    //Prop keyshortcut
    public int PlayerScore { get; set; }
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private GameObject[] ballPositions;

    [SerializeField] private GameObject cueBall;
    [SerializeField] private GameObject ballLine;

    [SerializeField] private float xInput;
    [SerializeField] private float ballspeed;
    [SerializeField] private GameObject FollowCamera;
    [SerializeField] private TMP_Text scoreText;
     
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        FollowCamera = Camera.main.gameObject;
        CameraBehindBall();
        
        UpdateScoreText();
        
        //set balls on the table
        SetBalls(Ballcolor.White, 0);
        SetBalls(Ballcolor.Red, 1);
        SetBalls(Ballcolor.Yellow, 2);
        SetBalls(Ballcolor.Green, 3);
        SetBalls(Ballcolor.Brown, 4);
        SetBalls(Ballcolor.Blue, 5);
        SetBalls(Ballcolor.Pink, 6);
        SetBalls(Ballcolor.Nigga, 7);
    }

    // Update is called once per frame
    void Update()
    {
        RotateBall();
         
        UpdateScoreText();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall();
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            StopBall();
        }
    }

    public void UpdateScoreText()
    {
        scoreText.text = $"Player Score: {PlayerScore}";
    }

    void SetBalls(Ballcolor color, int pos)
    {
        GameObject ball = Instantiate(ballPrefab, 
            ballPositions[pos].transform.position, 
            Quaternion.identity);
        Ball b = ball.GetComponent<Ball>();
        b.SetColorAndPoint(color);
    }

    void RotateBall()
    {
        xInput = Input.GetAxis("Horizontal");
        cueBall.transform.Rotate(new Vector3(0f,xInput/10,0f));
    }

    void ShootBall()
    {
        FollowCamera.transform.parent = null;
        Rigidbody rd = cueBall.GetComponent<Rigidbody>();
        rd.AddRelativeForce(Vector3.forward * ballspeed, ForceMode.Impulse);
        ballLine.SetActive(false);
    }

    void CameraBehindBall()
    {
        FollowCamera.transform.parent = cueBall.transform;
        FollowCamera.transform.position = cueBall.transform.position + new Vector3(0f, 20,-15f);
    }

    void StopBall()
    {
        Rigidbody rd = cueBall.GetComponent<Rigidbody>();
        rd.velocity = Vector3.zero;
        rd.angularVelocity = Vector3.zero;

        cueBall.transform.eulerAngles = Vector3.zero;
        CameraBehindBall();
        FollowCamera.transform.eulerAngles = new Vector3(40f, 0, 0);
        ballLine.SetActive(true);
    }
}