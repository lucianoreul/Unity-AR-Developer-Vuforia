using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LitJson;

public class CreateObject : MonoBehaviour
{
    public GameObject gameObjectPrefab;
    public Button createBtn;
    //public TMP_InputField positionX;
    //public TMP_InputField positionY;
    //public TMP_InputField positionZ;
    //public TMP_InputField rotationX;
    //public TMP_InputField rotationY;
    //public TMP_InputField rotationZ;

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

    private void CreateGameObjectFromPositionAndRotation(GameObject prefab, Vector3 position, Quaternion rotation)
    {
        Instantiate(prefab, position, rotation);
    }

    private IEnumerator GetPositionAndRotation()
    {
        string url = "https://raw.githubusercontent.com/lucianoreul/Unity-AR-Developer-Vuforia/master/Assets/PositionAndRotation.txt";
        WWW w = new WWW(url);
        yield return w;
        if (w.error != null)
        {
            Debug.Log(w.error);
        }
        else
        {
            JsonData data = JsonMapper.ToObject(w.text);
            var position = new Vector3(float.Parse(data["position"]["x"].ToString()),
                                       float.Parse(data["position"]["y"].ToString()),
                                       float.Parse(data["position"]["z"].ToString()));
            var rotation = Quaternion.Euler(float.Parse(data["rotation"]["x"].ToString()),
                                            float.Parse(data["rotation"]["y"].ToString()),
                                            float.Parse(data["rotation"]["z"].ToString()));
            gameObjectPrefab.transform.localPosition = position;
            gameObjectPrefab.transform.localRotation = rotation;
            Debug.Log(position);
        }
    }
}
