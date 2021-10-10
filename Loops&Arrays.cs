using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoop : MonoBehaviour
//ForLoop//
{
    int NUMeNEMIES = 5;
    void start ()
    { for(int j = 0; j < NUMeNEMIES; j++)
        {
            Debug.Log("creating enemey under: " + j);

        }
    }
}

//WhileLoop//

public class WhileLoop: MonoBehaviour
{
    int cupsInTheSink = 8;

    void Start ()
    {
        while(cupsInTheSink > 0)
        {
            Debug.Log("I've washed a cup! LOL XD");
            cupsInTheSink--;
        }
    }
}
//DoWhileLoop

public class DoWhileLoop : MonoBehaviour
{
    void Start ()
    {
        bool shouldContinue = false;

        do
        {
            print("Sup d00d");

        } while (shouldContinue == true);

    }
}
//ForeachLoop
public class ForeachLoop : MonoBehaviour
{
    void Start ()
    {
        string[] strings = new strings[3];

        strings[0] = "First string";
        strings[1] = "Second String";
        strings[2] = "Third string";

        foreach(string item in strings)
        {
            print(item);
        }
    }
}