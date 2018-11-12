using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateDataManager : MonoBehaviour
{
    private StateDataList mStateDataList;
    // Use this for initialization
    private void Start() {
        LoadData();
    }

    private void LoadData() {
        TextAsset textAsset = Resources.Load<TextAsset>("StatesData");
        mStateDataList = JsonUtility.FromJson<StateDataList>(textAsset.text);
    }

    // Update is called once per frame
    private void Update() {

    }

    public StateData GetStateData(int index_){
        return mStateDataList.dataList[index_];
    }

}
