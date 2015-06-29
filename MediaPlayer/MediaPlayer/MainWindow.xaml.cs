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
using System.Collections.ObjectModel;
using System.Windows.Shapes;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Threading;
using System.Runtime;
namespace MediaPlayer
{
    public partial class MainWindow : Window
    {
        
        private Playlist brain;
        private PlaylistForm form2 = new PlaylistForm();
        public  bool offsetMoveMode;
        public bool form2loaded=false;
        public MainWindow()
        {
            
            InitializeComponent();
            this.brain = new Playlist(this.player);
            this.button_add.Click += new RoutedEventHandler(button_add_Click);
            this.button_back.Click += new RoutedEventHandler(button_back_Click);
            this.button_forward.Click += new RoutedEventHandler(button_forward_Click);
            this.button_play.Click += new RoutedEventHandler(button_play_Click);
            this.button_repeat.Click += new RoutedEventHandler(button_repeat_Click);
            this.button_shuffle.Click += new RoutedEventHandler(button_shuffle_Click);
            this.button_stop.Click += new RoutedEventHandler(button_stop_Click);
            this.player.MediaOpened += new RoutedEventHandler(mediaElement_MediaOpened);
            CompositionTarget.Rendering += new EventHandler(CompositionTarget_Rendering);
            this.offsetSlider.PreviewMouseLeftButtonDown += new MouseButtonEventHandler(offsetSlider_PreviewMouseLeftButtonDown);
            this.offsetSlider.PreviewMouseLeftButtonUp   += new MouseButtonEventHandler(offsetSlider_PreviewMouseLeftButtonUp);
            this.button_list.Click += new RoutedEventHandler(button_list_Click);
            this.offsetSlider.Minimum = 0;
            this.offsetSlider.IsMoveToPointEnabled = true;
           
           
        }
       
        

        void button_stop_Click(object sender, RoutedEventArgs e)
        {
            this.brain.Stop();
        }

        void button_shuffle_Click(object sender, RoutedEventArgs e)
        {
            this.brain.ToggleShuffle();
        }

        void button_repeat_Click(object sender, RoutedEventArgs e)
        {
            this.brain.ToggleRepeat();
        }

        void button_play_Click(object sender, RoutedEventArgs e)
        {
            this.brain.Play();
            

        }

        void button_forward_Click(object sender, RoutedEventArgs e)
        {
            this.brain.Next();
        }

        void button_back_Click(object sender, RoutedEventArgs e)
        {
            this.brain.Prev();
        }
        void button_list_Click(object sender, RoutedEventArgs e)
        {
            if (form2loaded == false)
            {
               
                form2.Visible = true;
                form2loaded = true;
                
            }
            else
            {
                form2.Visible=false;
                form2loaded = false;
            }
        }

        void button_add_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dialog = new System.Windows.Forms.OpenFileDialog();
            dialog.Filter = "MP3's (*.mp3)|*.mp3|All files (*.*)|*.*";
            dialog.Multiselect = true;
            System.Windows.Forms.DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string filename in dialog.FileNames)
                {
                    if (System.IO.File.Exists(filename))
                    {
                        this.brain.AddSong(filename);
                    }
                }
            }
        }

//configuration of the offset slider ()


        void offsetSlider_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (!this.offsetMoveMode)
            {
                Point pts = e.GetPosition(this.offsetSlider);
                double total = this.offsetSlider.Maximum;
                double res = ((pts.X * 100) / ((double)this.offsetSlider.ActualWidth)) / 100;
                this.player.Position = TimeSpan.FromMilliseconds(total * res);
                double duration=this.player.NaturalDuration.TimeSpan.TotalMilliseconds;
                
            }
            else
            {
                this.player.Position = TimeSpan.FromMilliseconds(this.offsetSlider.Value);
            }
            
            this.offsetMoveMode = false;
        }

        void offsetSlider_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.offsetMoveMode = true;
        }


        void mediaElement_MediaOpened(object sender, RoutedEventArgs e)
        {
            if (this.player.NaturalDuration.HasTimeSpan)
            {
                this.offsetSlider.Maximum = this.player.NaturalDuration.TimeSpan.TotalMilliseconds;
                Time.Text = ("0" + Convert.ToString(this.player.NaturalDuration.TimeSpan.Minutes + ":" + Convert.ToString((this.player.NaturalDuration.TimeSpan.Seconds))));
            }
        }




//composition rendering (this is the key of your problem !)

    void CompositionTarget_Rendering(object sender, EventArgs e)
        {
            if ((this.player != null) && this.player.NaturalDuration.HasTimeSpan && (!this.offsetMoveMode))
            {
                this.offsetSlider.Value = this.player.Position.TotalMilliseconds;
            }
        }


        public ObservableCollection<Song> Songs
        {
            get { return this.brain.Songs; }
        }

        




    }

        }
    
