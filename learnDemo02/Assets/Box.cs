using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    //��С��ײ���ϰ���
    private void OnCollisionEnter(Collision collision)
    {
        //����Ϸͣ����    ��Ϸ����ʱ��ֹͣ
        //Time.timeScale = 0;

        //ʹ��GameObject.Find������ȡUnity����SampleScene���Ѵ�������GM������GM�ű����е�GameOver����
        GameObject.Find("GM").GetComponent<GM>().GameOver();
    }
}
