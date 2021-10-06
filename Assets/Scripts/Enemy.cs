using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{

    public int age { get; set; }
    public int hp { get; set; }
    public string name { get; set; }

    // Enemy Ŭ������ ������
    public Enemy()
    {
        age = 10;
        hp = 100;
        name = "Hwang";
    }

    public void Hit()
    {
        int damage = 10;
        hp -= damage;

        // ��������� �ƹ��� ���� �Ͼ�� �ʴ´�.
        shout();
    }

    // ��� ���� Ŭ������ override�ؼ� ����� �� �ִ�.
    protected virtual void shout()
    {

    }
}
