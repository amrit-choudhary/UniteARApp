using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateDataList
{
    [SerializeField]
    public List<StateData> dataList;

    public StateDataList() {
        dataList = new List<StateData>();
    }
}
