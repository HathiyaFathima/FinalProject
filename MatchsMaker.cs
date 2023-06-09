﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


/// <summary>
/// Summary description for MatchsMaker
/// </summary>
public delegate float Similarity(string s1, string s2);

public class MatchsMaker
{
    private string _lString, _rString;
    private string[] _leftTokens, _rightTokens;
    private int leftLen, rightLen;
    private float[,] cost;
    Similarity getSimilarity;

    private bool _accentInsensitive;

    public MatchsMaker(string left, string right) : this(left, right, false) { }
    public MatchsMaker(string left, string right, bool accentInsensitive)
    {
        _accentInsensitive = accentInsensitive;

        _lString = left;
        _rString = right;

        if (_accentInsensitive)
        {
            _lString = StripAccents(_lString);
            _rString = StripAccents(_rString);
        }

        MyInit();
    }


    private string StripAccents(string input)
    {
        string beforeConversion = "aAbBcCDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        string afterConversion = "aAbBcCDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

        System.Text.StringBuilder sb = new System.Text.StringBuilder(input);

        for (int i = 0; i < beforeConversion.Length; i++)
        {
            char beforeChar = beforeConversion[i];
            char afterChar = afterConversion[i];

            sb.Replace(beforeChar, afterChar);
        }

        return sb.ToString();
    }

    private void MyInit()
    {
        ISimilarity editdistance = new Leven();
        getSimilarity = new Similarity(editdistance.GetSimilarity);

        //ISimilarity lexical=new LexicalSimilarity() ;
        //getSimilarity=new Similarity(lexical.GetSimilarity) ;


        Tokeniser tokeniser = new Tokeniser();
        _leftTokens = tokeniser.Partition(_lString);
        _rightTokens = tokeniser.Partition(_rString);
        if (_leftTokens.Length > _rightTokens.Length)
        {
            string[] tmp = _leftTokens;
            _leftTokens = _rightTokens;
            _rightTokens = tmp;
            string s = _lString; _lString = _rString; _rString = s;
        }

        leftLen = _leftTokens.Length - 1;
        rightLen = _rightTokens.Length - 1;
        Initialize();

    }

    private void Initialize()
    {
        cost = new float[leftLen + 1, rightLen + 1];
        for (int i = 0; i <= leftLen; i++)
            for (int j = 0; j <= rightLen; j++)
                cost[i, j] = getSimilarity(_leftTokens[i], _rightTokens[j]);
    }


    public float GetScore()
    {
        BipartiteMatcher match = new BipartiteMatcher(_leftTokens, _rightTokens, cost);
        return match.Score;
    }


    public float Score
    {
        get
        {
            return GetScore();
        }
    }

}
