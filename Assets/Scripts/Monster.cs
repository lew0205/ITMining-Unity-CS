using System.Collections;
using UnityEngine;

class Monster : Enemy
{
    protected override void shout()
    {
        // base = parent Enemy class
        base.shout();

        // print 명령어는 Monobehaviour꺼라 사용 불가
        Debug.Log("Monster");
    }
}

