﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace FirstWorldProblems
{
    public class Joke
    {
        public int JokeID { get; set; }
        public string JokeText { get; set;}
        public string Author { get; set; }
        public string Statistic { get; set; }
        public string StatisticURL { get; set; }
        public DateTime DateAdded { get; set; }
        public string Charity { get; set; }
        public string CharityURL { get; set; }
        public bool Favorite { get; set;}
        public int CategoryID { get; set; }  //NICK: this should be an enum, otherwise we have to memorise which numbers are which categories
        public string CategoryImage { get; set; }

    }
}
