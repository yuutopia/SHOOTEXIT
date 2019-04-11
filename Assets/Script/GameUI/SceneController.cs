using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するUI
using UnityEngine.UI;
//SceneManagerを使用するため、SceneManagementを追加
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    //以下でボタンクリックしてシーンを移動するメソッドをつくっておく
    public void ButtonClicked()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void ButtonClicked2()
    {
        SceneManager.LoadScene("TitleScene");
    }

}
