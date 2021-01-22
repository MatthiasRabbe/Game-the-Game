using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    #region UI Elements that we need to fill/control
    public Text npcNameField;
    public Text dialogTextField;
    public GameObject acceptQuestBtn;
    public GameObject dialogPanel;
    #endregion

    #region Dialog-Variables
    private Dialog currentDialog;
    private List<string> conversation;
    private int dialogPos;
    #endregion

    void Start()
    {
        dialogPanel.SetActive(false);
        acceptQuestBtn.SetActive(false);
    }

    public void StartDialog(Dialog diag)
    {
        Cursor.lockState = CursorLockMode.None;
        npcNameField.text = diag.npcName;
        conversation = diag.dialogLines;
        dialogPos = 0;
        currentDialog = diag;        
        dialogPanel.SetActive(true);//Activate Panel
        ShowDialog();
    }

    public void AcceptQuest()
    {
        if (currentDialog.quest != null && !currentDialog.isQuestAccepted)
        {
            GameObject.Find("Questlog").GetComponent<Questlog>().questList.Add(currentDialog.quest);
            currentDialog.isQuestAccepted = true;
            acceptQuestBtn.SetActive(false);
           
            StopDialog();
        }
    }


    public void ShowDialog()
    {
        dialogTextField.text = conversation[dialogPos];
    }

    //Special Case
    public void ShowAwaitingQuestDialog()
    {
        dialogTextField.text = currentDialog.awaitingQuestCompletion;
    }

    public void StopDialog()
    {
        dialogPanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Next()
    {
        if ( dialogPos < conversation.Count - 1)
        {
            dialogPos++;
            ShowDialog();
            acceptQuestBtn.SetActive(false);
        }
        //Show the Accept Quest button if the Dialog has reached its final line of text && the dialog has a quest && the quest hasn't been accepted
        if (dialogPos == conversation.Count - 1 && currentDialog.quest != null && !currentDialog.isQuestAccepted)
        {
            acceptQuestBtn.SetActive(true);

        }
        //If the quest exists and it has been accepted: Show the "awaiting Quest completion text"
        if (currentDialog.quest != null && currentDialog.isQuestAccepted)
        {
            ShowAwaitingQuestDialog();
        }
        
    }
}
