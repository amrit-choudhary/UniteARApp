using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateDataList
{
    public List<StateData> stateDataList;

    public StateDataList() {
        stateDataList = new List<StateData>();
    }
}
