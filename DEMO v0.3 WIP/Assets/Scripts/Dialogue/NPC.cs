using TMPro;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //private CoolTMP animatedText;
    [SerializeField] public TextAsset inkJSON;

    private void Start()
    {
        //animatedText = DialogueManager.instance.animatedText;
        //animatedText.onEmotionChange.AddListener((newEmote) => EmotionChanger(newEmote));
    }

    public void EmotionChanger(string emotion)
    {
        //if emotion==something
        // doSomething();
    }

  
}
