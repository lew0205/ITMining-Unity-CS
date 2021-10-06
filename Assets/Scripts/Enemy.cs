using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy
{

    public int age { get; set; }
    public int hp { get; set; }
    public string name { get; set; }

    // Enemy 클래스의 생성자
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

        // 실행되지만 아무런 일이 일어나지 않는다.
        shout();
    }

    // 상속 받은 클래스만 override해서 사용할 수 있다.
    protected virtual void shout()
    {

    }
}
