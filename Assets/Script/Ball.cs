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
      [SerializeField] private MeshRenderer rd;
      
      private void Awake() 
      {
        rd = GetComponent<MeshRenderer>();
      }
      
      public void SetColorAndPoint(Ballcolor color) 
      {
        switch (color)
        {
            case Ballcolor.White:
                point =0;
                rd.material.color = Color.white;
                break;
                
           case Ballcolor.Red:
                point =1;
                rd.material.color = Color.red;
                break;
                
           case Ballcolor.Yellow:
                point =2;
                rd.material.color = Color.yellow;
                break;
                
           case Ballcolor.Green:
                point =3;
                rd.material.color = Color.green;
                break;
                
           case Ballcolor.Brown:
                point =4;
                rd.material.color = new Color32(145, 81,9,255);
                break; 
                
           case Ballcolor.Blue:
                point =5;
                rd.material.color = Color.blue;
                break;
           case Ballcolor.Pink:
                point =6;
                rd.material.color = Color.magenta;
                break;    
           case Ballcolor.Nigga:
                point =7;
                rd.material.color = Color.black;
                break;                                                     
        }
      }
}
