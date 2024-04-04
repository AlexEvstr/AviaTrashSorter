using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    [SerializeField] private GameObject _platfrom;
    [SerializeField] private GameObject[] _allTrash;
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

            int CountOfTrashOnPlatform = Random.Range(0, _allTrash.Length);
            for (int i = 0; i < CountOfTrashOnPlatform; i++)
            {
                GameObject newTrash = Instantiate(_allTrash[Random.Range(0, _allTrash.Length)]);
                newTrash.transform.position = new Vector2(newPlatform.transform.position.x, newPlatform.transform.position.y + 0.5f);
            }




            index++;
        }
    }
}
