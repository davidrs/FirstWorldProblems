using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace FirstWorldProblems
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();

            if (!App.ViewModel.categoryViewModel.IsDataLoaded)
            {
                App.ViewModel.categoryViewModel.LoadData();
            }            

            if (!App.ViewModel.IsDataLoaded)
            {   
                App.ViewModel.LoadData();
            }
            
        }

        //These next three methods are responsible for navigating the user to jokes. The user may want to see his favorited jokes, a filtered list of jokes based on the categories
        //he has selcted, or all of the jokes. I must set the joke type in this mainPage and not when I have navigated to the JokePage itself because
        //of a race condition that would cause an exception to be thrown when I try to add jokes to the recently cleared jokesToDisplayCollection.
        //The exception was occuring because the JokePage may have already rendered the pivot that was bound to the observerable collection.

        private void AllJokes_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.JokePageType = MainViewModel.PageType.AllJokes;
            this.NavigationService.Navigate(new Uri("/JokePage.xaml?id=" + MainViewModel.PageType.AllJokes, UriKind.Relative));
        }

        private void FavoriteJokes_Click(object sender, RoutedEventArgs e)
        {
            App.ViewModel.JokePageType = MainViewModel.PageType.Favorites;
            this.NavigationService.Navigate(new Uri("/JokePage.xaml?id=" + MainViewModel.PageType.Favorites, UriKind.Relative));
        }

        private void FilterByCategory_Click(object sender, RoutedEventArgs e)
        {
            //App.ViewModel.JokePageType = MainViewModel.PageType.FilteredCategoryJokes; NICK this code shouldn't be called until we're done choosing filters and we want to view jokes, I've moved it there
            this.NavigationService.Navigate(new Uri("/FilterByCategoryPage.xaml", UriKind.Relative));
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/AboutPage.xaml", UriKind.Relative));
        }      
    }
}