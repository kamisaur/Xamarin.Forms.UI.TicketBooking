using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanCardView;
using Xamarin.Forms;

namespace Xamarin.Forms.UI.TicketBooking
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            mainCoverFlowView.UserInteracted += MainCoverFlowView_UserInteracted;
        }

        private void MainCoverFlowView_UserInteracted(CardsView view, PanCardView.EventArgs.UserInteractedEventArgs args)
        {
            if (args.Status == PanCardView.Enums.UserInteractionStatus.Running)
            {
                backgroundCoverFlow.CurrentDiff = view.CurrentDiff * 10;
            }
        }

    }
}
