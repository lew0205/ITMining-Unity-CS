using System.Collections;
using System.Collections.Generic;
using UnityEngine;

delegate void EventHandler(Color color);

class OrcParams
{
    public event EventHandler eventHandler;

    int _hp = 100;

    public int hp
    {
        get { return _hp; }
        set {
            _hp = value;

            if (hp <= 50) eventHandler(Color.red);
        }
    }
}

public class Orc : MonoBehaviour
{

    void ChangeColor(Color color){
        this.GetComponent<Renderer>().material.color = Color.red;
    }

    void ShowColor(Color color)
    {
        print(color);
    }

    OrcParams orcParams = new OrcParams();
    
    void Start()
    {
        orcParams.eventHandler += new EventHandler(ChangeColor);
        orcParams.eventHandler += new EventHandler(ShowColor);
    }

    private void OnMouseDown()
    {
        orcParams.hp -= 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
