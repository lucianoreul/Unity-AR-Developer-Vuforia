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

    private string url = "https://github.com/lucianoreul/Unity-AR-Developer-Vuforia/blob/f5f35bfcda11e0b73ae8800bcfd7d68ad72dcbe5/Assets/PositionAndRotation.txt";

    private void Start()
    {
        //createBtn.onClick.AddListener(delegate
        //{
        //    var postitotion = new Vector3(float.Parse(positionX.text), float.Parse(positionY.text), float.Parse(positionZ.text));
        //    Quaternion rotation = Quaternion.Euler(float.Parse(rotationX.text), float.Parse(rotationY.text), float.Parse(rotationZ.text));
        //    CreateGameObjectFromPositionAndRotation(
        //        gameObjectPrefab,
        //        postitotion,
        //        rotation);
        //});
        createBtn.onClick.AddListener(delegate
        {
            StartCoroutine(GetPositionAndRotation());
        });
    }

    /// <summary>
    /// Method to create a GameObject by passing the prefab, position and rotate
    /// </summary>
    /// <param name="prefab"> The GameObject that goes spawn </param>
    /// <param name="position"> The Vector3 for the position parameter </param>
    /// <param name="rotation"> The Quaternion for tem rotation parameter </param>
    private void CreateGameObjectFromPositionAndRotation(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        var newObject = Instantiate(prefab, position, rotation);
    }

    private IEnumerator GetPositionAndRotation()
    {
        WWW www = new WWW(url);
        yield return www;
        if(www.error != null)
        {
            Debug.Log("Error .. " + www.error);
            yield break;
        }
        else
        {
            Debug.Log("Found ... ==>" + www.text + "<==");
        }
    }
}
