using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HNDunit20
{
    class CDNode
    {
        private String artist;
        private int duration;
        private CDNode previous;
        public String Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }
        public CDNode Previous
        {
            get
            {
                return previous;
            }
            set
            {
                previous = value;
            }
        }
    }
}
