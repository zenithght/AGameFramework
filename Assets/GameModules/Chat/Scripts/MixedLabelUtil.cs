﻿using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;


public class MixedLabelUtil
{
    public const string eChunk = "e-";
    public const string iChunk = "i-";
    public const string hChunk = "h-";


    /// <summary>
    /// 表情占用width,height固定大小
    /// </summary>
    public static int s_emojiSize = 24;


    public static string assetBundlePath = Application.dataPath + "/../AssetBundles/StandaloneWindows/emoji";
    static AssetBundle s_emojiBundle;

    /// <summary>
    /// 正则表达，获取聊天特殊转移符号
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static List<string> RegexMatch(string str)
    {
        List<string> regexStr = new List<string>();
        Regex reg = new Regex(@"\[[ehi]\-\w+\]");
        var match = reg.Matches(str);

        for (int i = 0; i < match.Count; i++)
            regexStr.Add(match[i].Value);

        return regexStr;
    }

    /// <summary>
    /// 获取字符宽度
    /// </summary>
    /// <param name="ch"></param>
    /// <param name="font"></param>
    /// <param name="fontSize"></param>
    /// <returns></returns>
    public static int GetCharacterSize(char ch, Font font, int fontSize)
    {
        CharacterInfo info;
        font.RequestCharactersInTexture(ch.ToString(), fontSize);
        font.GetCharacterInfo(ch, out info, fontSize, FontStyle.Normal);
        return info.advance;
    }

    public static string[] GetHtmlInfo(string str)
    {
        str = str.Substring(2, str.Length - 2);
        return str.Split('_');
    }

    /// <summary>
    /// 这段代码只是为了测试方便用的，将来等资源管理器写完以后要去除
    /// </summary>
    public static void LoadEmojiBundle()
    {
        if (s_emojiBundle == null)
            s_emojiBundle = AssetBundle.LoadFromFile(assetBundlePath);
    }

    public static bool SpriteContains(string sprName)
    {
        if (s_emojiBundle != null)
            return s_emojiBundle.Contains(sprName);

        return false;
    }

    public static Sprite GetSpriteByName(string sprName)
    {
        if (s_emojiBundle != null && s_emojiBundle.Contains(sprName))
            return s_emojiBundle.LoadAsset<Sprite>(sprName);

        return null;
    }
}