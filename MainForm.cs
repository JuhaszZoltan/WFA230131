namespace WFA230131
{
    public partial class MainForm : Form
    {
        public HomeUserControl homeUserControl { get; set; }
        public ImagesUserControl imagesUserControl { get; set; }
        public UserControl ActiveControl { get; set; } = null;

        public MainForm()
        {
            InitializeComponent();
            Icon = Properties.Resources.home;
            this.Load += OnHomeToolStripMenuItemClick;
            this.Resize += OnMainFormResize;
            colorToolStripMenuItem.Click += OnColorToolStripMenuItemClick;
            imagesToolStripMenuItem.Click += OnImagesToolStripMenuItemClick;
            homeToolStripMenuItem.Click += OnHomeToolStripMenuItemClick;
            
        }

        private void OnHomeToolStripMenuItemClick(object? sender, EventArgs e)
        {
            homeUserControl = new();
            SetActiveControl(homeUserControl);
        }

        private void OnImagesToolStripMenuItemClick(object? sender, EventArgs e)
        {
            imagesUserControl = new();
            SetActiveControl(imagesUserControl);
        }

        private void OnColorToolStripMenuItemClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException("TODO");
        }

        private void SetActiveControl(UserControl us)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(us);
            ActiveControl = us;
            CenterUserControl(us);
        }

        private void OnMainFormResize(object? sender, EventArgs e) 
            => CenterUserControl(ActiveControl);

        private void CenterUserControl(UserControl uc)
        {
            uc.Location = new(
                x: mainPanel.Width / 2 - uc.Width / 2,
                y: mainPanel.Height / 2 - uc.Height / 2);
        }
    }
}