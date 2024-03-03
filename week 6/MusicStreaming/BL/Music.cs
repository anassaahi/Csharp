using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStreaming
{
    internal class Music
    {
        private string Name;
        private string Type;
        private int Len;
        public Music(string name, string type, int len)
        {
            this.Name = name;
            this.Type = type;
            this.Len = len;
        }
        public bool SetName(string name)
        {
            if(name != " ")
            {
                this.Name = name;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetName(string name)
        {
            return this.Name;
        }
        public bool SetType(string type)
        {
            if (type != " ")
            {
                this.Type = type;
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetType(string type)
        {

            return this.Type;
        }
        public bool SetLen(int len)
            {
                if (len != 0)
                {
                    this.Len = len ;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public int GetLen(int len)
            {
                return this.Len;
            }
            

    }
}
