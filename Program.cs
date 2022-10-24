using System.CodeDom.Compiler;

using System.Collections.Generic;

using System.Collections;

using System.ComponentModel;

using System.Diagnostics.CodeAnalysis;

using System.Globalization;

using System.IO;

using System.Linq;

using System.Reflection;

using System.Runtime.Serialization;

using System.Text.RegularExpressions;

using System.Text;

using System;







class Solution

{

    public static void Main(string[] args)

    {

        

        function instance= new function();

       List<Values> list = new List<Values>();

        

        

        int loopvalue = (Convert.ToInt32(Console.ReadLine()));

        for (int i = 0; i < loopvalue; i++)

        {

            int transporta = Convert.ToInt32(Console.ReadLine());

            int transportb = Convert.ToInt32(Console.ReadLine());

            list.Add (new Values {FirstValue=transporta,SecondValue=transportb});

           

        }

        foreach (var item in list)

        {

            Console.WriteLine(Math.Pow(item.FirstValue,item.SecondValue));

        }
        string date = "07:05:45PM";

        DateTime abc = Convert.ToDateTime(date);
        Console.WriteLine(abc.ToString());




    }

    class function 

    {

       public void forloop(List<char> x, int y)

       {

        



       }



    }

 

 

    public static void Write(string x)

    {

        Console.WriteLine(x);



    }

    public static void Write(int x)

    {

        Console.WriteLine(x);



    }

    public static string ReadLine()

    {

      return Console.ReadLine();

    } 

    public static int ConvertReadLine()

    {

      return Convert.ToInt32(Console.ReadLine());

    }         

}

class Values

{

    public int FirstValue {get;set;}

    public int SecondValue {get;set;}

  

}

   

