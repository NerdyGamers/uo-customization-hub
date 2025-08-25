using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArtAssetStudio
{
    public class MainForm : Form
    {
        private readonly ArtAssetManager _manager = new();
        private readonly TextBox _idTextBox = new();
        private readonly PictureBox _artPictureBox = new();
        private readonly Button _loadButton = new();
        private readonly Button _replaceButton = new();
        private readonly Button _removeButton = new();
        private readonly Button _saveButton = new();

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Text = "Art Asset Studio";
            Width = 800;
            Height = 600;

            Label idLabel = new()
            {
                Text = "Static ID:",
                Location = new Point(10, 15),
                AutoSize = true
            };
            Controls.Add(idLabel);

            _idTextBox.Location = new Point(80, 10);
            _idTextBox.Width = 100;
            Controls.Add(_idTextBox);

            _loadButton.Text = "Load";
            _loadButton.Location = new Point(200, 8);
            _loadButton.Click += LoadButton_Click;
            Controls.Add(_loadButton);

            _replaceButton.Text = "Replace";
            _replaceButton.Location = new Point(280, 8);
            _replaceButton.Click += ReplaceButton_Click;
            Controls.Add(_replaceButton);

            _removeButton.Text = "Remove";
            _removeButton.Location = new Point(360, 8);
            _removeButton.Click += RemoveButton_Click;
            Controls.Add(_removeButton);

            _saveButton.Text = "Save";
            _saveButton.Location = new Point(440, 8);
            _saveButton.Click += SaveButton_Click;
            Controls.Add(_saveButton);

            _artPictureBox.Location = new Point(10, 40);
            _artPictureBox.Size = new Size(512, 512);
            _artPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(_artPictureBox);
        }

        private void LoadButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(_idTextBox.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            if (!_manager.IsValidStatic(id))
            {
                MessageBox.Show("Art not found.");
                return;
            }

            _artPictureBox.Image?.Dispose();
            _artPictureBox.Image = _manager.GetStaticArt(id);
        }

        private void ReplaceButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(_idTextBox.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            using OpenFileDialog dialog = new()
            {
                Filter = "Image Files|*.bmp;*.png;*.jpg;*.jpeg"
            };

            if (dialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            using Bitmap bmp = new(dialog.FileName);
            _manager.ReplaceStaticArt(id, bmp);
            _artPictureBox.Image?.Dispose();
            _artPictureBox.Image = _manager.GetStaticArt(id);
        }

        private void RemoveButton_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(_idTextBox.Text, out int id))
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            _manager.RemoveStaticArt(id);
            _artPictureBox.Image?.Dispose();
            _artPictureBox.Image = null;
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            using SaveFileDialog dialog = new()
            {
                Filter = "UOP Files|*.uop|MUL Files|*.mul|All Files|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _manager.Save(dialog.FileName);
            }
        }
    }
}
