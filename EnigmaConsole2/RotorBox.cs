using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaConsole2
{
    public class RotorBox
    {
        Rotor[] Rotors = new Rotor[0];

        public RotorBox()
        {

        }

        public void SetRotorBox()
        {

        }
    }

    public struct Rotor
    {
        public const string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Number number;

        public string AToZ
        {
            get
            {
                switch (number)
                {
                    case Number.I:
                        return "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
                    case Number.II:
                        return "AJDKSIRUXBLHWTMCQGZNPYFVOE";
                    case Number.III:
                        return "BDFHJLCPRTXVZNYEIWGAKMUSQO";
                    case Number.IV:
                        return "ESOVPZJAYQUIRHXLNFTGKDCMWB";
                    case Number.V:
                        return "VZBRGITYUPSDNHLXAWMJQOFECK";
                    case Number.VI:
                        return "JPGVOUMFYQBENHZRDKASXLICTW";
                    case Number.VII:
                        return "NZJHGRCXMYSWBOUFAIVLPEKQDT";
                    case Number.VIII:
                        return "FKQHTLXOCBJSPDZRAMEWNIUYGV";
                    default:
                        return "";
                }
            }
        }
        public int[] AToZIndexes { get { return alphabet.Select(c => alphabet.IndexOf(c)).ToArray(); } }
        public char NotchA
        {
            get
            {
                switch (number)
                {
                    case Number.I:
                        return 'Q';
                    case Number.II:
                        return 'E';
                    case Number.III:
                        return 'V';
                    case Number.IV:
                        return 'J';
                    case Number.V:
                        return 'Z';
                    case Number.VI:
                        return 'Z';
                    case Number.VII:
                        return 'Z';
                    case Number.VIII:
                        return 'Z';
                    default:
                        return '\0';
                }
            }
        }
        public int NotchAIndex { get { return alphabet.IndexOf(NotchA); } }
        public char NotchB
        {
            get
            {
                switch (number)
                {
                    case Number.I:
                        return '\0';
                    case Number.II:
                        return '\0';
                    case Number.III:
                        return '\0';
                    case Number.IV:
                        return '\0';
                    case Number.V:
                        return '\0';
                    case Number.VI:
                        return 'M';
                    case Number.VII:
                        return 'M';
                    case Number.VIII:
                        return 'M';
                    default:
                        return '\0';
                }
            }
        }
        public int NotchBIndex { get { return alphabet.IndexOf(NotchB); } }
        public char Position;
        public int PositionIndex { get { return alphabet.IndexOf(Position); } }

        public Rotor(int number, char position)
        {
            this.number = (Number)number;
            Position = position.ToString().ToUpper()[0];
        }

        public int Encode(int i)
        {
            int meh = AToZIndexes[i + PositionIndex];

            return meh;
        }

        public enum Number { I = 1, II = 2, III = 3, IV = 4, V = 5, VI = 6, VII = 7, VIII = 8 };
    }
}
