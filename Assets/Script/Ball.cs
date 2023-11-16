using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Ballcolor
{
    White,
    Red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pink,
    Nigga,
}


public class Ball : MonoBehaviour
{
      [SerializeField] private int point;
      public int Point 
      {
        get { return point; }
      } 
      
      [SerializeField] private Ballcolor ballcolor;
      [SerializeField] private MeshRenderer;
      
      private void Awake() 
      {
        rd = GetComponent<MeshRenderer> rd;
      }
      
      public void SetColorAndPoint(BallColors color) 
      {
        swtich (color)
        {
            case BallColor.White:
                point =0;
                rd.material.color = color.white;
                break;
                
           case BallColor.Red:
                point =1;
                rd.material.color = color.red;
                break;
                
           case BallColor.Yellow:
                point =2;
                rd.material.color = color.yellow;
                break;
                
           case BallColor.Green:
                point =3;
                rd.material.color = color.green;
                break;
                
           case BallColor.Brown:
                point =4;
                rd.material.color = new Color32(145, 81,9,255);
                break; 
                
           case BallColor.Blue:
                point =5;
                rd.material.color = color.blue;
                break;
           case BallColor.Pink:
                point =0;
                rd.material.color = color.magenta;
                break;    
           case BallColor.Nigga:
                point =0;
                rd.material.color = color.black;
                break;                                                     
        }
      }
    
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
