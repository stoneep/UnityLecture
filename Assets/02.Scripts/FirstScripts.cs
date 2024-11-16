using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class FirstScripts : MonoBehaviour
{

    // int thisYear; 
    // public float pi;
    // public string myName = "홍길동";
    public bool isGameover = false;
	test
    private int hp = 100;
    
    void Start()
    {
        // thisYear = 2024;
        // print("이번연도는 :" + thisYear);
        // pi = 3.14f;
        // print("파이값은 :" + pi);
        //
        // print(" 내 이름은 :" + myName);
        //
        // if(isGameover.Equals(true))
        //     print(" 게임상태 :" + isGameover);
            // print(8 > 10);
            // print(2 > 5);
            // print(5 == 5);
            // print(6 == 5);
            // print(7 != 5);
            // print(7 != 7);
            // print(3 <= 5);
            // print(3 <= 3);
            // print(4 >= 4);
            // print(2 >= 4);
        
            // print(2 != 4 || 6 != 6);
            // print(2 != 4 && 6 != 6);
            // print(false == false);
            // print(false != true);
            // print(2 != 4);
            // print(6 != 6);
            // print(7 != 14);
            // print(!false);
    }
    void Update()
    {
        //print("이번연도는 :" + lastYear);
        //print("파이값은 :" +pi);
        if (Input.GetKeyDown(KeyCode.Space) && + hp >= 0)
        {
            hp = hp - 20;

            if (hp <= 0)
            { 
                print("게임오버");
            }
            else if (hp <= 40)
            {
                print("현재hp :" + hp);
                print("비상!!!");
            } 
            else if (hp <= 60)
            {
                print("현재hp :" + hp);
                print("조심하세요!");
            } 
            else
            {
                print("현재hp :" + hp);
            }
            
        }
    }
}
