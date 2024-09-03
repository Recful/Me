using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
public class PhoneChat : MonoBehaviour
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

    private bool hasClicked = false;  // 标识是否已经点击过

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

    void AddEmojiMessage(Sprite emojiSprite, bool isPlayer)
    {
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
}
