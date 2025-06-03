using UnityEngine;
using UnityEngine.UI;

public class MuteUnmute : MonoBehaviour
{
    public void ToggleMute(AudioSource audioSource)
    {
        audioSource.mute = !audioSource.mute;
    }

    public Image muteButton;
    public Sprite muteSprite;
    public Sprite unmuteSprite;
    private bool isMute = false;

    public void ToggleSprite()
    {
        muteButton.sprite = isMute ? unmuteSprite : muteSprite;
        isMute = !isMute;
    }
}
