using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKey(KeyCode.W)){
        transform.Translate(transform.forward*0.1f);
        //Wを押すと前に進みます 0.1fの数字を大きくすれば前に進むスピードが上がります。
      }
      if (Input.GetKey(KeyCode.S)){
        transform.Translate(transform.forward*-0.1f);
        //Sを押すと後ろに進みます 0.1fの数字を大きくすれば後ろに進むスピードが上がります。
      }
      if (Input.GetKey(KeyCode.D)){
        transform.Translate(transform.right*0.1f);
        //Dを押すと右に進みます 0.1fの数字を大きくすれば右に進むスピードが上がります。
      }
      if (Input.GetKey(KeyCode.A)){
        transform.Translate(transform.right*-0.1f);
        //Aを押すと左に進みます 0.1fの数字を大きくすれば左に進むスピードが上がります。
      }
    }
}
