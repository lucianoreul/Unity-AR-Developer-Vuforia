using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateObject : MonoBehaviour
{
    public GameObject gameObjectPrefab;
    public Button createBtn;
    public TMP_InputField positionX;
    public TMP_InputField positionY;
    public TMP_InputField positionZ;
    public TMP_InputField rotationX;
    public TMP_InputField rotationY;
    public TMP_InputField rotationZ;

    private void Start()
    {
        createBtn.onClick.AddListener(delegate
        {
            var postitotion = new Vector3(float.Parse(positionX.text), float.Parse(positionY.text), float.Parse(positionZ.text));
            Quaternion rotation = Quaternion.Euler(float.Parse(rotationX.text), float.Parse(rotationY.text), float.Parse(rotationZ.text));
            CreateGameObjectFromPositionAndRotation(
                gameObjectPrefab,
                postitotion,
                rotation);
        });
    }

    private void CreateGameObjectFromPositionAndRotation(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        var newObject = Instantiate(prefab, position, rotation);
    }
}
