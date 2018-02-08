using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookandFeel
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new WindowsLookandFeel());
            client.Run();
            Client client1 = new Client(new MotifLookandFeel());
            client.Run();
        }
    }

    abstract class LookandFeel
    {
        public abstract Button createButton();
        public abstract EditBox createTextfield();
    }

    class WindowsLookandFeel : LookandFeel
    {
        public override Button createButton()
        {
            return new WindowsButton();
        }

        public override EditBox createTextfield()
        {
            return new WindowsEditBox();
        }
    }

    class MotifLookandFeel : LookandFeel
    {
        public override Button createButton()
        {
            return new MotifButton();
        }

        public override EditBox createTextfield()
        {
            return new MotifEditBox();
        }
    }

    abstract class Button
    {
    }
    class WindowsButton:Button
    {
    }

    class MotifButton:Button
    {
    }

    abstract class EditBox
    {
    }

    class WindowsEditBox:EditBox
    {
    }

    class MotifEditBox:EditBox
    {
    }

    class Client
    {
        Button button;
        EditBox edit;
        public Client(LookandFeel lookandFeel)
        {
            button = lookandFeel.createButton();
            edit = lookandFeel.createTextfield();
        }

        public void Run()
        {
            Console.WriteLine(button + " " + edit);
        }
    }
}