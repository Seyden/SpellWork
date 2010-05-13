﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpellWork
{
    public static class TreeViewExtensions
    {
        public static uint[] GetMask(this TreeView tv)
        {
            uint[] val = new uint[3];
            foreach (TreeNode node in tv.Nodes)
            {
                if (node.Checked)
                {
                    if(node.Index < 32)
                        val[0] += 1U << node.Index;
                    else if(node.Index < 64)
                        val[1] += 1U << (node.Index - 32);
                    else
                        val[2] += 1U << (node.Index - 64);
                }
            }
            return val;
        }
    }
}
