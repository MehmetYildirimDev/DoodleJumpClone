using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformEditor : MonoBehaviour
{

    public GameObject PlatformPrafab;
    [SerializeField] int Count = 200;

    private void Start()
    {
        AddPlatform();
    }

    public void AddPlatform()
    {
        Vector2 PlatformVector = new Vector2();
        for (int i = 0; i < Count; i++)
        {
            PlatformVector.x = Random.Range(-3f, 3f);
            PlatformVector.y += Random.Range(1.8f, 2.2f);
            GameObject tempPlatform = Instantiate(PlatformPrafab);
            tempPlatform.transform.position = PlatformVector;

        }
    }

}
