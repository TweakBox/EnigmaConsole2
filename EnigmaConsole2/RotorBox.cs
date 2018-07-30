using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaConsole2
{
    public class RotorBox
    {
        Reflector reflector = new Reflector();
        Rotor[] rotors = new Rotor[0];
        bool DoubleStep;

        public RotorBox(bool doubleStep, Reflector reflector, params Rotor[] rotors)
        {
            DoubleStep = doubleStep;
            this.reflector = reflector;
            this.rotors = rotors;
        }

        public void Encode()
        {
            s
        }
    }

    public struct Rotor
    {
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        readonly Number number;

        public Rotor(int number, char position)
        {
            this.number = (Number)number;
            Offset = position.ToString().ToUpper()[0];
        }

        public string AToZ
        {
            get
            {
                switch (number)
                {
                    case Number.X:
                        return alphabet;
                    case Number.I:
                        //     "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
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
        public int[] AToZIndexes { get { return AToZ.Select(c => alphabet.IndexOf(c)).ToArray(); } }
        public char NotchA
        {
            get
            {
                switch (number)
                {
                    case Number.X:
                        return '\0';
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
                    case Number.X:
                        return '\0';
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
        public char Offset;
        public int OffsetIndex
        {
            get { return alphabet.IndexOf(Offset); }
            set { Offset = alphabet[value]; }
        }

        public int EncodeFromRight(int i) { return AToZIndexes[(i + OffsetIndex) % 26]; }
        public int EncodeFromLeft(int i) { return AToZIndexes.ToList().IndexOf((i + OffsetIndex) % 26); }

        public void TurnRotor() { OffsetIndex %= 26; }

        public enum Number { X = 0, I = 1, II = 2, III = 3, IV = 4, V = 5, VI = 6, VII = 7, VIII = 8 };
    }

    public struct Reflector
    {
        public static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public ID id;

        public Reflector(int id) { this.id = (ID)id; }

        public string AToZ
        {
            get
            {
                switch (id)
                {
                    case ID.X:
                        return alphabet;
                    case ID.A:
                        return "EJMZALYXVBWFCRQUONTSPIKHGD";
                    case ID.B:
                        return "YRUHQSLDPXNGOKMIEBFZCWVJAT";
                    case ID.C:
                        return "FVPJIAOYEDRZXWGCTKUQSBNMHL";
                    default:
                        return "";
                }
            }
        }
        public int[] AToZIndexes { get { return AToZ.Select(c => alphabet.IndexOf(c)).ToArray(); } }

        public int Encode(int i) { return AToZIndexes[i % 26]; }

        public enum ID { X = 0, A = 1, B = 2, C = 3 }
    }
}
