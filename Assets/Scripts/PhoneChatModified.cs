using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class PhoneChatModified : MonoBehaviour
{
    public GameObject emojiMessagePrefabLeft;  // Prefab for a single emoji message
    public GameObject emojiMessagePrefabRight;   // Prefab for a my text message
    public Transform messageArea;          // The area where messages are displayed
    public ScrollRect scrollRect;          // Scroll Rect to handle scrolling
    public Image image;
    public Sprite[] responseEmoji1;
    public Sprite[] responseEmoji2;
    public Sprite[] responseEmoji3;
    public Sprite[] responseEmoji4;
    public Sprite[] responseEmoji5;
    public Sprite[] responseEmoji6;
    public Sprite[] responseEmoji7;
    public Sprite[] responseEmoji8;
    public Sprite[] responseEmoji9;
    public Sprite[] responseEmoji10;
    public Sprite[] responseEmoji11;
    public Sprite[] responseEmoji12;
    public LevelLoader levelLoader;
    private int chattime;
    private bool hasClicked = false;  // 标识是否已经点击过
    public GameObject etan;
    public GameObject nate;
    public GameObject etan2;
    public GameObject nate2;
    public GameObject etan3;
    public GameObject nate3;
    public GameObject emojipanel1;
    public GameObject emojipanel2;
    public GameObject emojipanel3;

    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject button10;
    public GameObject button11;
    public GameObject button12;
    
    // Called when an emoji button is pressed
    public void OnEmojiButtonClicked1(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse1());
    }

    public void OnEmojiButtonClicked2(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse2());
    }

    public void OnEmojiButtonClicked3(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse3());
    }

    public void OnEmojiButtonClicked4(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse4());
    }

    public void OnEmojiButtonClicked5(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse5());
    }

    public void OnEmojiButtonClicked6(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse6());
    }

    public void OnEmojiButtonClicked7(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse7());
    }

    public void OnEmojiButtonClicked8(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse8());
    }

    public void OnEmojiButtonClicked9(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse9());
    }

    public void OnEmojiButtonClicked10(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse10());
    }

    public void OnEmojiButtonClicked11(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse11());
    }

    public void OnEmojiButtonClicked12(Sprite emojiSprite)
    {
        // 如果已经点击过一次，直接返回，不处理后续点击
        if (hasClicked) return;

        // 第一次点击后处理
        hasClicked = true;
        AddEmojiMessage(emojiSprite, true);

        // Simulate a response from Etan
        StartCoroutine(SimulateResponse12());
    }

    void AddEmojiMessage(Sprite emojiSprite, bool isPlayer)
    {
        //Debug.Log(chattime);
        chattime++;
        if (chattime > 23)
        {
            levelLoader.LoadNextLevel();
        }
        if (chattime > 7)
        {
            //change sprite
            nate.GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
            nate2.SetActive(true);
            etan.GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
            etan2.SetActive(true);
            emojipanel1.SetActive(false);
            emojipanel2.SetActive(true);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            button4.SetActive(false);
            button5.SetActive(true);
            button6.SetActive(true);
            button7.SetActive(true);
            button8.SetActive(true);
        }
        if (chattime > 15)
        {
            //change sprite
            nate2.GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
            nate3.SetActive(true);
            etan2.GetComponent<Image>().color -= new Color(0f, 0f, 0f, 1f);
            etan3.SetActive(true);
            emojipanel2.SetActive(false);
            emojipanel3.SetActive(true);
            button5.SetActive(false);
            button6.SetActive(false);
            button7.SetActive(false);
            button8.SetActive(false);
            button9.SetActive(true);
            button10.SetActive(true);
            button11.SetActive(true);
            button12.SetActive(true);
        }
        GameObject prefabToUse = isPlayer ? emojiMessagePrefabRight : emojiMessagePrefabLeft;
        GameObject newMessage = Instantiate(prefabToUse, messageArea);
        newMessage.SetActive(true);

        image = newMessage.transform.GetChild(0).GetComponent<Image>();
        var tempColor = image.color;
        tempColor.a = 255f;
        image.color = tempColor;

        newMessage.transform.GetChild(0).GetComponent<Image>().sprite = emojiSprite;
        //responseEmoji = emojiSprite;

        LayoutRebuilder.ForceRebuildLayoutImmediate(messageArea as RectTransform);

        // Scroll to the bottom to show the new message
        Canvas.ForceUpdateCanvases();
        scrollRect.verticalNormalizedPosition = 0;
    }

    // Simulate a response from Etan
    IEnumerator SimulateResponse1()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji1();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse2()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji2();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse3()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji3();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse4()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji4();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse5()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji5();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse6()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji6();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse7()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji7();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse8()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji8();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse9()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji9();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse10()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji10();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse11()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji11();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }

    IEnumerator SimulateResponse12()
    {
        yield return new WaitForSeconds(1.0f);

        // Select an emoji for the response (this can be randomized or based on logic)
        Sprite responseEmoji = GetRandomEmoji12();
        AddEmojiMessage(responseEmoji, false);

        // 回复结束后重置点击标志位，允许再次点击
        hasClicked = false;
    }



    // Example method to get a random emoji (You should replace this with your own logic)
    Sprite GetRandomEmoji1()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji1.Length);
        return responseEmoji1[index];
    }

    Sprite GetRandomEmoji2()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji2.Length);
        return responseEmoji2[index];
    }

    Sprite GetRandomEmoji3()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji3.Length);
        return responseEmoji3[index];
    }

    Sprite GetRandomEmoji4()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji4.Length);
        return responseEmoji4[index];
    }

    Sprite GetRandomEmoji5()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji5.Length);
        return responseEmoji5[index];
    }

    Sprite GetRandomEmoji6()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji6.Length);
        return responseEmoji6[index];
    }

    Sprite GetRandomEmoji7()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji7.Length);
        return responseEmoji7[index];
    }

    Sprite GetRandomEmoji8()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji8.Length);
        return responseEmoji8[index];
    }

    Sprite GetRandomEmoji9()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji9.Length);
        return responseEmoji9[index];
    }

    Sprite GetRandomEmoji10()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji10.Length);
        return responseEmoji10[index];
    }

    Sprite GetRandomEmoji11()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji11.Length);
        return responseEmoji11[index];
    }

    Sprite GetRandomEmoji12()
    {
        //Sprite[] responseEmojis = { responseEmoji };
        int index = Random.Range(0, responseEmoji12.Length);
        return responseEmoji12[index];
    }
}
