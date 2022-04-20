using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalseSwiper
{
    public partial class MainPage : ContentPage
    {
        private IList<string> questionList = new List<string>() {"Thursday was once known as Thors Day","Cats have nine lives"};
        private IList<Boolean> answerList = new List<Boolean>() {true, false};
        private IList<string> imageList = new List<string>() {"doggy.jpg", "taco.png"};

        private int Index = 0;
        private int CountCorrect = 0;
        
        public MainPage()
        {
            InitializeComponent();
            Questions.Text = questionList[Index];
            theImage.Source = imageList[Index];
        }

        void True()
        {
            if (answerList[Index++] == true) CountCorrect++;
            if (Index < questionList.Count)
            {
                Questions.Text = questionList[Index];
                theImage.Source = imageList[Index];
            }
            else
            {
                IsVisible = false;
                IsVisible = false;
                theImage.IsVisible = false;
                Questions.Text = $"Correctly Answered: {CountCorrect}";
            }

        }

        void False()
        {
            if (answerList[Index++] == false) CountCorrect++;
            if (Index < questionList.Count)
            {
                Questions.Text = questionList[Index];
            }            
            else
            {
               IsVisible = false;
               IsVisible = false;
                theImage.IsVisible = false;
                Questions.Text = $"Correctly Answered: {CountCorrect}";
            }


        }


        void OnSwiped(object sender, SwipedEventArgs e)
        {
            if (e.Direction == SwipeDirection.Right)
            {
                True();
            }
            else
            {
                False();
            }
        }
    }
}
