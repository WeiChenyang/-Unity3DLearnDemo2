using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ӽǸ���С���� ����ŷ���
public class Follow : MonoBehaviour
{
    public Transform t;//���� ����һ���� ��unity ���� Follow �ű������ж�t�������ʵ�廯
    Vector3 o;//������һ��������
    // Start is called before the first frame update
    void Start()
    {
        //����Ϸ�տ�ʼ��ʱ��ȷ���÷����ߵĳ��ȡ��Ƕȵ���Ϣ
        o = transform.position - t.position;
    }

    // Update is called once per frame
    void Update()
    {
        //��ÿʱÿ�̷��ݶ����˺���������
        transform.position = t.position + o;

        float h = Input.GetAxis("Horizontal");



    }
}
