/*************************************************
  * 名稱：SwitchColor
  * 作者：RyanHsu
  * 功能說明：
  * ***********************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ISwitchColor
{
    void Switch(SwitchColor.colorNum color);
}

public class SwitchColor : MonoBehaviour, ISwitchColor
{
    [SerializeField] Material mat;

    public Color m_Color1;
    public Color m_Color2;
    public Color m_Color3;

    public enum colorNum
    {
        color1, color2, color3
    }

    private void Awake()
    {
        mat ??= GetComponent<MeshRenderer>()?.material;
    }

    public void Switch(colorNum color)
    {
        switch (color)
        {
            case colorNum.color1: mat.color = m_Color1; break;
            case colorNum.color2: mat.color = m_Color2; break;
            case colorNum.color3: mat.color = m_Color3; break;
        }

    }

}
