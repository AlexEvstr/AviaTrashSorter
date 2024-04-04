using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    [SerializeField] private GameObject _platfrom;
    private void Start()
    {
        SpawnPlatform();
    }

    private void SpawnPlatform()
    {
        int index = 0;
        float xInterval = 7.0f;
        float yInterval = 1.0f;
        
        while (index < 20)
        {
            Vector2 position = new Vector2(xInterval, transform.position.y + Random.Range(-yInterval, yInterval));
            xInterval += 7;
            GameObject newPlatform = Instantiate(_platfrom);
            newPlatform.transform.position = position;
            index++;
        }
    }
}
