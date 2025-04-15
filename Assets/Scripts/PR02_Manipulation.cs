using UnityEngine;

public class PR02_Manipulation : MonoBehaviour
{
    public GameObject targetPrefab; // original cube
    private GameObject spawnedObject;

    void Update()
    {
        // A) Hide/Show with H key
        if (Input.GetKeyDown(KeyCode.H))
        {
            targetPrefab.SetActive(!targetPrefab.activeSelf);
        }

        // B) Create a new cube with C key
        if (Input.GetKeyDown(KeyCode.C) && spawnedObject == null)
        {
            spawnedObject = Instantiate(targetPrefab, new Vector3(2, 1, 0), Quaternion.identity);
            spawnedObject.name = "SpawnedCube";
        }

        // C) Destroy it with D key
        if (Input.GetKeyDown(KeyCode.D) && spawnedObject != null)
        {
            Destroy(spawnedObject);
        }
    }
}
