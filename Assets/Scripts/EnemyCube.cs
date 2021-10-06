using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCube : MonoBehaviour
{

    Enemy mySelf;

    void Start()
    {

        Monster myMonster = new Monster();
        Animal myAnimal = new Animal();

        GameObject monster = GameObject.Find("Monster");
        monster.GetComponent<EnemyCube>().SetParam(myMonster);

        GameObject animal = GameObject.Find("Animal");
        animal.GetComponent<EnemyCube>().SetParam(myAnimal);
    }

    public void SetParam(Enemy enemy)
    {
        mySelf = enemy;
    }

    private void OnMouseDown()
    {
        if (mySelf != null)
            mySelf.Hit();
    }

    void Update()
    {

    }
}
