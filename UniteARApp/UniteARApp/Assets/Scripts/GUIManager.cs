using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{

    public StateDataManager stateDataManager;

    public GameObject mapPanel;
    public GameObject statePanel;

    public Text nameText;
    public Text capitalText;
    public Text typeText;
    public Text establishedText;
    public Text info1Text;
    public Text info2Text;
    public Text info3Text;

    // Use this for initialization
    private void Start() {

    }

    // Update is called once per frame
    private void Update() {

    }

    public void ShowState(int index_) {
        StateData stateData = stateDataManager.GetStateData(index_);
        PopulateStateUI(stateData);
    }

    private void PopulateStateUI(StateData stateData_) {
        nameText.text = stateData_.name;
        capitalText.text = "Capital: " + stateData_.capital;
        typeText.text = "Type: " + stateData_.stateType;
        establishedText.text = "Established In: " + stateData_.establishedIn;
        info1Text.text = stateData_.info1;
        info2Text.text = stateData_.info2;
        info3Text.text = stateData_.info3;

        ShowStateUI();
    }

    private void ShowStateUI(){
        mapPanel.SetActive(false);
        statePanel.SetActive(true);
    }

    public void CloseState(){
        statePanel.SetActive(false);
        mapPanel.SetActive(true);    
    }

}
