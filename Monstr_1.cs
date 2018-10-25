using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstr_1 : MonoBehaviour {

    public float speed;
    public int i;

    public void step_up()
    {
        transform.position = new Vector3(transform.position.x + (-1) * Time.deltaTime, transform.position.y, transform.position.z);
    }

    public void step_left()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (-1) * speed * Time.deltaTime);
    }

    public void step_down()
    {
        transform.position = new Vector3(transform.position.x - (-1) * speed * Time.deltaTime, transform.position.y, transform.position.z);
    }

    public void step_right()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - (-1) * speed * Time.deltaTime);
    }

    /*public void step()
    {
        int i = 1;
        while(true)
        {
            switch(i)
            {
                case 1:
                    
                    if (map.arr[(int)transform.position.x - 1, (int)transform.position.z] == -1)
                    {
                        System.Random rand = new System.Random();
                        i = System.Convert.ToInt32(rand.Next(4));
                        break;
                    }
                    step_up();
                    break;
                case 2:
                    
                    if (map.arr[(int)transform.position.x, (int)transform.position.z - 1] == -1)
                    {
                        System.Random rand = new System.Random();
                        i = System.Convert.ToInt32(rand.Next(4));
                        break;
                    }
                    step_left();
                    break;
                case 3:
                    
                    if (map.arr[(int)transform.position.x + 1, (int)transform.position.z] == -1)
                    {
                        System.Random rand = new System.Random();
                        i = System.Convert.ToInt32(rand.Next(4));
                        break;
                    }
                    step_down();
                    break;
                case 4:
                    
                    if (map.arr[(int)transform.position.x, (int)transform.position.z + 1] == -1)
                    {
                        System.Random rand = new System.Random();
                        i = System.Convert.ToInt32(rand.Next(4));
                        break;
                    }
                    step_right();
                    break;
            }
            
        }        
    }*/

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        switch (i)
        {
            case 1:

                if (map.arr[(int)transform.position.x - 1, (int)transform.position.z] == -1 || map.arr[(int)transform.position.x + 1, (int)transform.position.z] == 0)
                {
                    System.Random rand = new System.Random();
                    i = System.Convert.ToInt32(rand.Next(1,5));
                    break;
                }
                step_up();
                break;
            case 2:

                if (map.arr[(int)transform.position.x, (int)transform.position.z - 1] == -1 || map.arr[(int)transform.position.x + 1, (int)transform.position.z] == 0)
                {
                    System.Random rand = new System.Random();
                    i = System.Convert.ToInt32(rand.Next(1,5));
                    break;
                }
                step_left();
                break;
            case 3:

                if (map.arr[(int)transform.position.x + 1, (int)transform.position.z] == -1 || map.arr[(int)transform.position.x + 1, (int)transform.position.z] == 0)
                {
                    System.Random rand = new System.Random();
                    i = System.Convert.ToInt32(rand.Next(1,5));
                    break;
                }
                step_down();
                break;
            case 4:

                if (map.arr[(int)transform.position.x, (int)transform.position.z + 1] == -1 || map.arr[(int)transform.position.x + 1, (int)transform.position.z] == 0)
                {
                    System.Random rand = new System.Random();
                    i = System.Convert.ToInt32(rand.Next(1,5));
                    break;
                }
                step_right();
                break;
        }
    }
}
