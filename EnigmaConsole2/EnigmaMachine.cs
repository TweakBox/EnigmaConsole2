using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaConsole2
{
    public class EnigmaMachine
    {
        private RotorBox rb = new RotorBox();
        private Plugboard p = new Plugboard();

        public string Encrypt(string plainText)
        {
            return "";
        }

        public string Decrypt(string cipherText)
        {
            return Encrypt(cipherText);
        }

        public bool AddPlug(Plug plug)
        {
            return p.AddPlug(plug);
        }


        public bool RemovePlug(Plug plug)
        {
            return p.RemovePlug(plug);
        }

        public void SetRotorBox(RotorBox rotorBox)
        {
            rb = rotorBox;
        }
    }
}
