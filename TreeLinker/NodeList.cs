using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLinker
{
    public class NodeList
    {
        public int Depth { get; set; }
        public string Link { get; set; }

        public NodeList()
        {
            Depth = 0;
        }
        public NodeList(int depth, string link)
        {
            Depth = depth;
            Link = link;
        }
    }
}
