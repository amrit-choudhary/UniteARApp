using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class StateData
{
    public int id;
    [SerializeField]
    public StateType stateType;
    public string name;
    public string capital;
    public string establishedIn;
    public string info1, info2, info3, info4, info5, info6;

    public StateData() {
        id = 0;
        stateType = StateType.State;
        name = "";
        capital = "";
        establishedIn = "";
        info1 = "";
        info2 = "";
        info3 = "";
        info4 = "";
        info5 = "";
        info6 = "";
    }
}

[System.Serializable]
public enum StateType
{
    State,
    UT,
}
