using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{

    //delegate int Calculator(int num1, int num2);

    //int AddNumbers(int num1, int num2)
    //{
    //    return num1 + num2;
    //}

    //int SubNumbers(int num1, int num2)
    //{
    //    return num1 - num2;
    //}

    //int GetActions (int num1, int num2, Calculator mCalculator)
    //{
    //    return mCalculator(num1, num2);
    //}

    void ShowName()
    {
        Debug.Log("My name is EunWoo");
    }

    void ShowAge()
    {
        Debug.Log("My age is 17");
    }

    void ShowJob()
    {
        Debug.Log("My job is Student");
    }

    delegate void FunctionHandler();

    FunctionHandler mHandler;

    void Start()
    {
        ////Calculator mCalculator = new Calculator(AddNumbers);
        ////Debug.Log(mCalculator(10, 20));

        //int resultNum = GetActions(30, 40, new Calculator(AddNumbers));
        //Debug.Log(resultNum);

        mHandler = new FunctionHandler(ShowName);
        mHandler += new FunctionHandler(ShowAge);
        mHandler += new FunctionHandler(ShowJob);

        mHandler();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
