namespace DeviceDetails
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            devId.Text = new GetDeviceInfo().GetDeviceID();
        }
    }

}
