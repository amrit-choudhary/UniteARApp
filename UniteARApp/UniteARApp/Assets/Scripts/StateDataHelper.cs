using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

// used to initialize the json file
// used only if the StateData class changes
public class StateDataHelper : MonoBehaviour
{

    // Use this for initialization
    private void Start() {

    }

    private void InitCreateJSON() {
        StateDataList stateDataList = new StateDataList();
        StateData temp;
        for(int i = 0; i < 36; i++){
            temp = new StateData();
            temp.id = i.ToString();
            stateDataList.dataList.Add(temp);
        }

        string dataAsJSON = JsonUtility.ToJson(stateDataList, true);
        File.WriteAllText("Assets/Resources/StatesData.json", dataAsJSON);
    }

    // Update is called once per frame
    private void Update() {

    }
}
