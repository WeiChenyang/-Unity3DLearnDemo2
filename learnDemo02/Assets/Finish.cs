using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    //��С������յ�����ʱ
    private void OnTriggerEnter(Collider other)
    {
        //ʹ��GameObject.Find������ȡUnity����SampleScene���Ѵ�������GM������GM�ű����е�GamePass����
        GameObject.Find("GM").GetComponent<GM>().GamePass();
    }
}
