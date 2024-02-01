using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // 벽에 부딪힐때 정보를 출력하는 메소드(oncollisionenter)
   private void OnCollisionEnter(Collision other) 
   {
          if(other.gameObject.tag == "Player")
          {
                // 컴포넌트<원하는 컴포넌트>().물질.색 = 색을 빨강색으로 바꾸는 기능
                GetComponent<MeshRenderer>().material.color = Color.red;
                gameObject.tag = "Hit";
          }
       
   }
}
