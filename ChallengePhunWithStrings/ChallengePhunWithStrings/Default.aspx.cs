using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //reverse name
            String name = "James Roper";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Label1.Text += name[i]; 
            }
            
            //reverse this string
            string names = "Luke,Leia,Han,Chewbacca";
            string[] rebels = names.Split(',');
            string result = "";
            for (int i = rebels.Length - 1; i >= 0; i--)
            {
                result += rebels[i] + ",";
            }
            result = result.Remove(result.Length - 1, 1);
            Label2.Text = result;
            
            //use sequence to create ascii art
            //*****Luke*****
            //*****Leia*****
            //*****Han******
            //**Chewbacca***
            string[] rebelScum = names.Split(',');
            string result2 = "";
            for (int i = 0; i < rebelScum.Length; i++)
            {
                int padleft = (14 - rebelScum[i].Length) / 2;
                string temp = rebelScum[i].PadLeft(rebelScum[i].Length + padleft, '*');
                result2 += temp.PadRight(14,'*');
                result2 += "<br />";
            }
            Label3.Text = result2;

            //use helper methods to fix
            //Now is the time for all good men to come to the aid of their country
            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO  ZHE AID OF ZHEIR COUNZRY";
            // make uppercase to lower case
            puzzle = puzzle.ToLower();
            //replace z with t
            puzzle = puzzle.Replace("z", "t");
            // remove "remove-me"
            string removeMe = "remove-me";
            int index = puzzle.IndexOf(removeMe);
            puzzle = puzzle.Remove(index, removeMe.Length);
            //capitalize n
            puzzle = puzzle.Remove( 0, 1);
            puzzle = puzzle.Insert(0, "N");


            Label4.Text = puzzle;


        }
    }
}