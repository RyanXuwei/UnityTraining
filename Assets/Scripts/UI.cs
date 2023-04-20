using System.Runtime.InteropServices.ComTypes;
/*************************************************
  * 名稱：UI
  * 作者：RyanHsu
  * 功能說明：
  * ***********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System;

[RequireComponent(typeof(UIDocument))]
public class UI : MonoBehaviour
{
    [SerializeField] SwitchColor _switcher;
    public ISwitchColor switcher { get => _switcher ??= FindObjectOfType<SwitchColor>(); }

    void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        Dictionary<Button, SwitchColor.colorNum> dic = new Dictionary<Button, SwitchColor.colorNum>();

        dic.Add(root.Q<Button>("Color1_btn"), SwitchColor.colorNum.color1);
        dic.Add(root.Q<Button>("Color2_btn"), SwitchColor.colorNum.color2);
        dic.Add(root.Q<Button>("Color3_btn"), SwitchColor.colorNum.color3);

        foreach (var m in dic)
        {
            m.Key.clicked += () => switcher.Switch(m.Value);
        }

    }

    void OnDisable()
    {

    }

}
