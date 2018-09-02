using System;
using Microsoft.CognitiveServices.Speech;

namespace LessonObserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            var factory = SpeechFactory.FromSubscription("9097559d41b44e09895fedc53e1a2c69", "eastasia");
        }
    }
}