using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody r;//�����������   �������ģ����ʵ��������˶��������ٶ�
    public float speed = 10;//�ٶ� Ĭ��10
    float p = 1.5f;
    float l = 0;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();//��ȡ����������
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");//��ȡ�������������ֵ
        float z = Input.GetAxis("Vertical");//��ȡ���������
        if (z > 0)
        {
            speed = speed + 3;
        }
        else if (z < 0)
        {
            speed = speed <= 0? 0:(speed - 3);
        }
        else {
            speed = 6;
        }

        r.velocity = new Vector3(x*8,r.velocity.y,speed);//�ٶ� x,y,z 
        if (Time.time >= l+p) {
            Vector3 f = new Vector3(0,5,0);
            r.AddForce(f,ForceMode.Impulse);//��С��ʩ����f
            l = Time.time;
        }
    }
}
