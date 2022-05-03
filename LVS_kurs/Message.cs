using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LVSkurs
{
    public class Message
    {
        //String state;
        SortedDictionary<String, Int32> commands;
        SortedDictionary<String, Int32> modes;
        SortedDictionary<Int32, String> IntStr;
        //String type;
        //int address_from;
        //int address_to;

        public Message()
        {
            commands = new SortedDictionary<String, Int32>();
            modes = new SortedDictionary<String, Int32>();
            IntStr = new SortedDictionary<Int32, String>();
            commands.Add("give_response", 1);
            commands.Add("block", 2);
            commands.Add("unblock", 3);
            modes.Add("command", 31);
            modes.Add("subaddr", 30);
            IntStr.Add(0, "00000");
            IntStr.Add(1, "00001");
            IntStr.Add(2, "00010");
            IntStr.Add(3, "00011");
            IntStr.Add(4, "00100");
            IntStr.Add(5, "00101");
            IntStr.Add(6, "00110");
            IntStr.Add(7, "00111");
            IntStr.Add(8, "01000");
            IntStr.Add(9, "01001");
            IntStr.Add(10, "01010");
            IntStr.Add(11, "01011");
            IntStr.Add(12, "01100");
            IntStr.Add(13, "01101");
            IntStr.Add(14, "01110");
            IntStr.Add(15, "01111");
            IntStr.Add(16, "10000");
            IntStr.Add(17, "10001");
            IntStr.Add(18, "10010");
            IntStr.Add(30, "11110");
            IntStr.Add(31, "11111");
        }

        public String encodeMessage(int address, int type, String mode_name, String command)
        {
            String message = "";
            String synchr = "111"; // Синхросигнал
            string addrTo;
            IntStr.TryGetValue(address, out addrTo); // Адрес ОУ
            String K = "0"; // Разряд "Прием/Передача"
            String mode; // Подадрес или режим управления
            String wordCount; // Количество СД или КУ
            int lastbit = 0; // Бит четности
            switch (type)
            {
                case 1:
                    //Кодирование режима управления
                    int nmode;
                    modes.TryGetValue(mode_name, out nmode);
                    IntStr.TryGetValue(nmode, out mode);
                    //Кодирование КУ или числа СД
                    if (nmode == 30) IntStr.TryGetValue(12, out wordCount);
                    else
                    {
                        commands.TryGetValue(command, out int nCom);
                        IntStr.TryGetValue(nCom, out wordCount);
                    }
                    message = synchr + addrTo + K + mode + wordCount;
                    break;
                case 2:
                    message = synchr + "0110101001010010";
                    break;
                case 3:
                    message = synchr + addrTo + "010000000000";
                    break;
            }
            for (int i = 0; i < 19; i++)
            {
                int bit = (message[i] == '1') ? 1 : 0;
                lastbit += bit;
            }
            message += (lastbit % 2).ToString();
            return message;
        }
    }
}
