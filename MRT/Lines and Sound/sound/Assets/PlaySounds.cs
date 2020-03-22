using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySounds : MonoBehaviour
{

    int ListIndex = 0;
    int timer = 0;
    public float currentTime;
    public List<string> SongName = new List<string>();

    public Button PlaySoundsButton;
    public AudioSource Sounds;
    //public Button PlaySoundsButton;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CountTimer");

        PlaySoundsButton.GetComponent<Button>();
        PlaySoundsButton.onClick.AddListener(PlaySound);

        SongName.Add("Dua Lipa - Physical (feat. Hwa Sa)");
        SongName.Add("又是吳海英OST");

        Sounds.GetComponent<AudioSource>();
        //Sounds.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PlaySound()
    {
        
        Sounds.clip = Resources.Load<AudioClip>(SongName[ListIndex]);
        ListIndex++;
        
        Sounds.Play();
    }

    // FixedUpdate執行的間隔時間是相同的
    /*private void FixedUpdate() {
        currentTime += Time.fixedDeltaTime;
        Debug.Log(currentTime);
    }*/

    // 搭配 StartCoroutine 使用
    IEnumerator CountTimer()
    {
        for(float i = 0 ; i < 5 ; i+=Time.deltaTime)
        {
            Debug.Log(i + "second");
            yield return 0;
        }
        Debug.Log("Finish");
        PlaySound();
    }
}
