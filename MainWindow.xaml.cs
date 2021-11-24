using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestSQL.DAO;
using TestSQL.music;
using Microsoft.EntityFrameworkCore;

namespace TestSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DAO_Artist daoart;
        public MainWindow()
        {
            InitializeComponent();
            daoart = new DAO_Artist();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //BDD.ItemsSource = daoart.GetArtists();
        }

        private void Image1_Drop(object sender, DragEventArgs e)
        {

        }

        //private void BDD_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        //{
        //    if (BDD.SelectedIndex != -1)
        //    {
        //        Artist artist = new Artist();
        //        artist = BDD.SelectedValue as Artist;
        //        //IdArtist = artist.IdArtist;
        //        TB_Nom.Text = artist.Name;
        //        TB_Desc.Text = artist.Discription;
        //        TB_Annee.Text = artist.Annee;

        //        //GetArtistsAlbums();
        //    }
        //}
    }
}
