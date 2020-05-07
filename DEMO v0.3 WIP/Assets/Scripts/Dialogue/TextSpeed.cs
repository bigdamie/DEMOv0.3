using UnityEngine;

namespace TMPro
{
    public class TextSpeed : MonoBehaviour
    {
        [SerializeField] float coolTextSpeed;

        public void GiveSpeed(CoolTMP animatedText)
        {
            animatedText.textSpeed = coolTextSpeed;
        }

    }
}