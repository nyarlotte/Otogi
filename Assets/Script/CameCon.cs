using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameCon : MonoBehaviour
{
  /*
  スクリプトにターゲット欄を追加
  ターゲットにオブジェクトを追加
  */
  public GameObject target =null;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
      /*
      ターゲットからポジションを取得
      ターゲットからY軸に1　Z軸に2mのところにカメラを設置する
      */
      Vector3 position = target.transform.position;
      position.y += 1f;
      position.z -= 2f;
      transform.position = position;
    }
}
