using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[ExecuteInEditMode]
public class InstantiateExample : MonoBehaviour
{
    private static int quantity = 10;
    private static string prefabName = "ball";

    [MenuItem("Custom Actions/Instantiate objects randomly")]
    public static void Instantiate() {
        
        for (int i = 0; i < quantity; i++) {
            GameObject instance = Instantiate(Resources.Load(prefabName, typeof(GameObject))) as GameObject;
            instance.transform.position = generateRandomPosition();
        }
    }

    private static Vector3 generateRandomPosition() {
        float x = Random.Range(-10.0f, 10.0f);
        float y = 1;
        float z = Random.Range(-10.0f, 10.0f);
        return new Vector3(x, y, z);
    }
}
