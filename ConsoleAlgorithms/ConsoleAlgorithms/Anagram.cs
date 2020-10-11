using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAlgorithms
{
    /// <summary>
    /// Wiki:
    /// An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.
    /// For example, the word anagram can be rearranged into nag a ram, or the word binary into brainy or the word adobe into abode.    /// </summary>
    public class Anagram : IExecute
    {
        public void Execute(string[] args)
        {
            
        }

        public bool IsAnagrm(string lfs,string rhs)
        {
            var clhs = lfs.ToCharArray();
            var crhs = rhs.ToCharArray();

            int[] asciTable = new int[256];

            for (int i = 0; i < clhs.Length; i++)
            {

            }

            return true;
        }
    }
}
