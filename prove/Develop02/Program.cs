using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string _menuInput = "";
        Menu myMenu = new Menu();

        while (_menuInput != "5")
        {
            _menuInput = myMenu.DisplayMenu();

            if (_menuInput == "1")
            {
            }
            if (_menuInput == "2")
            {
            }
            if ( == "3")
            {
            }
            if ( == "4")
            {
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }
    }
}