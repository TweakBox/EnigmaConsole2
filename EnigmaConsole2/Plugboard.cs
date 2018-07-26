using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaConsole2
{
    class Plugboard
    {
        List<Plug> Plugs = new List<Plug>();

        public bool AddPlug(Plug plug)
        {
            if (Plugs.Count > 12)
                return false;
            if (Plugs.Count(p => p.IsConflicting(plug)) > 0)
                return false;

            Plugs.Add(plug);
            return true;
        }

        public bool RemovePlug(Plug plug)
        {
            return Plugs.Remove(Plugs.FirstOrDefault(p => p.Equals(plug)));
        }

        public char Encode(char c)
        {
            for (int i = 0; i < Plugs.Count; i++)
                if (Plugs[i].HasChar(c))
                    return Plugs[i].GetCompliment(c);

            return c;
        }
    }

    public struct Plug
    {
        public char Char1;
        public char Char2;

        public Plug(char char1, char char2)
        {
            Char1 = char1;
            Char2 = char2;
        }

        public bool IsConflicting(Plug plug)
        {
            return Char1 == plug.Char1 || Char1 == plug.Char2 ||
                Char2 == plug.Char1 || Char2 == plug.Char2;
        }

        public bool Equals(Plug plug)
        {
            return Char1 == plug.Char1 && Char2 == plug.Char2 ||
                Char2 == plug.Char1 && Char1 == plug.Char2;
        }

        public bool HasChar(char c)
        {
            return Char1 == c || Char2 == c;
        }

        public char GetCompliment(char c)
        {
            if (HasChar(c))
                return Char2 == c ? Char1 : Char2;
            else
                return '\0';
        }
    }
}
