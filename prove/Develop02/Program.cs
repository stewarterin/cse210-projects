using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string _menuInput = "";

        while (_menuInput != "5")
        {
            Menu myMenu = new Menu();
            myMenu.DisplayMenu();
        }
    }
}