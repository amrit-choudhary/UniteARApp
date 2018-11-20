using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{

    public StateDataManager stateDataManager;

    public GameObject mapPanel;
    public GameObject statePanel;

    public GameObject buttonPrefab;
    public Transform buttonsParentPanel1;
    public Transform buttonsParentPanel2;

    public Text nameText;
    public Text typeText;
    public Text vehicleCodeText;
    public Text mainLanguageText;
    public Text formedInText;
    public Text capitalText;
    public Text introText;
    public Text detailsText;
    public Text ambassarods;

    // Use this for initialization
    private void Start() {
        FillStateButtons();
    }

    // Update is called once per frame
    private void Update() {

    }

    private void FillStateButtons(){

        for(int i = 0; i < 36; i++){
            StateData stateData = stateDataManager.GetStateData(i);
            GameObject temp = Instantiate(buttonPrefab);

            if(i > 17)
                temp.transform.SetParent(buttonsParentPanel1);
            else
                temp.transform.SetParent(buttonsParentPanel2);
            
            temp.GetComponentInChildren<Text>().text = stateData.name;
            int tempIndex = i;
            temp.GetComponent<Button>().onClick.AddListener(() => ShowState(tempIndex));         
        }
    }

    public void ShowState(int index_) {
        StateData stateData = stateDataManager.GetStateData(index_);
        PopulateStateUI(stateData);
    }

    private void PopulateStateUI(StateData stateData_) {
        nameText.text = stateData_.name.ToUpper();
        vehicleCodeText.text = stateData_.vehicleCode;
        mainLanguageText.text = stateData_.mainLanguage;
        formedInText.text = stateData_.formedIn;
        capitalText.text = stateData_.capital;
        introText.text = stateData_.intro;
        detailsText.text = stateData_.history + "\n\n" + stateData_.geography + "\n\n" +  stateData_.economy;
        ambassarods.text = stateData_.ambassadors;

        ShowStateUI();
    }

    private void ShowStateUI() {
        mapPanel.SetActive(false);
        statePanel.SetActive(true);
    }

    public void CloseState() {
        statePanel.SetActive(false);
        mapPanel.SetActive(true);
    }

}
