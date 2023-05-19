using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
/// <summary>
/// Summary description for Soundex
/// </summary>
internal class Soundex : ISimilarity
{
    public float GetSimilarity(string string1, string string2)
    {
        return 0;
    }
    public Soundex()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
