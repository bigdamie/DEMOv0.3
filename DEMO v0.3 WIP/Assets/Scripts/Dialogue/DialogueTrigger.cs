using UnityEngine;


public class DialogueTrigger : MonoBehaviour
{
    [SerializeField] public DialogueManager ui;
    [SerializeField] NPC theNPC;

    private void Start()
    {
        ui = DialogueManager.instance;

    }

    private void Update()
    {
        if(Input.GetButtonDown("Interact"))
        {

            ui.currentNPC = theNPC;
            ui.inDialogue = true;
            ui.FadeUI(true, .2f, .65f);
            
        }
    }
}
