﻿namespace Translator.LexicalAnalyzer
{
    class InitTable
    {
        public char[]   Delimeters      { get; set; }

        public string[] MultiDelimeters { get; set; }

        public string[] CoreWords       { get; set; }

        public string[] Constants       { get; set; }

        public string[] Identifiers     { get; set; }
    }
}
