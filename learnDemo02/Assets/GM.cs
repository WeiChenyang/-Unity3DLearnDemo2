using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//����Unity ���� SampleScene ����
using UnityEngine.UI;//�Խ������ ����UI

public class GM : MonoBehaviour
{
    //�����Ӧ���� ����Untiy���� GM �ű� ����������ָ��Panel����ʵ�廯
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        //panel��������
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //�Զ�����Ϸ��������
    public void GameOver() {
        //����Ϸͣ����    ��Ϸ����ʱ��ֹͣ
        Time.timeScale = 0;
        //panel������ʾ
        panel.SetActive(true);
        //�޸Ľ�����ʾ����
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "Game Over!";
    }

    //�Զ�����Ϸ���¿�ʼ����
    public void GameRestart() {
        //��Ϸ����ʱ�����¿�ʼ
        Time.timeScale = 1;
        //���¿�ʼ
        SceneManager.LoadScene(0);
    }

    //��Ϸ����
    public void GamePass() {
        //����Ϸͣ����    ��Ϸ����ʱ��ֹͣ
        Time.timeScale = 0;
        //panel������ʾ
        panel.SetActive(true);
        //�޸Ľ�����ʾ����
        Text t = panel.transform.Find("Text").GetComponent<Text>();
        t.text = "ͨ��!";
    }
}
