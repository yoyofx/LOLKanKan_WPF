using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using System.Collections.ObjectModel;
using System.Linq;
namespace ExtendPropertyLib.XAML.UI.CoverFlow
{
    public partial class FlowControl : UserControl
    {

        public static DependencyProperty IndexProperty = DependencyProperty.Register("Index", typeof(int), typeof(FlowControl), new FrameworkPropertyMetadata(0,FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));



        public int Index
        {
            set { SetValue(IndexProperty, value); }
            get { return (int)GetValue(IndexProperty); }
        }

        public static DependencyProperty ItemsSourceProperty = DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<string>), typeof(FlowControl), new FrameworkPropertyMetadata(new ObservableCollection<string>(),FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(OnItemsSourceChanged)));
        public ObservableCollection<string> ItemsSource
        {
            set { SetValue(ItemsSourceProperty, value); }
            get
            {
                
                return (ObservableCollection<string>)GetValue(ItemsSourceProperty);
            }
        }
        
        static void OnItemsSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var fc = d as FlowControl;
            var list = e.NewValue as ObservableCollection<string>;
            if (list != null && list.Count > 0)
            {
                fc.Load(list.ToList());

            }

        }


        #region Fields
        
        private readonly List<Cover> coverList = new List<Cover>();
        #endregion
        #region Private stuff
        private void RotateCover(int pos)
        {
            coverList[pos].Animate(Index);
        }
        private void UpdateIndex(int newIndex)
        {
            if (Index != newIndex)
            {
                int oldIndex = Index;
                Index = newIndex;
                if (Index > oldIndex)
                    for (int i = oldIndex; i <= Index; i++)
                        RotateCover(i);
                else
                    for (int i = oldIndex; i >= Index; i--)
                        RotateCover(i);
                camera.Position = new Point3D(Cover.CoverStep * Index, camera.Position.Y, camera.Position.Z);

            
            }
        }
        private void viewPort_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var rayMeshResult = (RayMeshGeometry3DHitTestResult)VisualTreeHelper.HitTest(viewPort, e.GetPosition(viewPort));
            if (rayMeshResult != null)
            {
                for (int i = 0; i < coverList.Count; i++)
                {
                    if (coverList[i].Matches(rayMeshResult.MeshHit))
                    {
                        UpdateIndex(i);
                        break;
                    }
                }
            }
        }
        #endregion
        public FlowControl()
        {
            InitializeComponent();
        }
        public void Load(string imagePath)
        {
            visualModel.Children.Clear();
            coverList.Clear();
            var imageDir = new DirectoryInfo(imagePath);
            int doneImages = 0;
            foreach (FileInfo image in imageDir.GetFiles("*.jpg"))
            {
                var cover = new Cover(image.FullName, doneImages++);
                coverList.Add(cover);
                visualModel.Children.Add(cover);
            }
        }

        public void Load(List<string> images)
        {
           
            coverList.Clear();

            int doneImages = 0;
            foreach (string img in images)
            {
                var cover = new Cover(img, doneImages++);
                coverList.Add(cover);
                visualModel.Children.Add(cover);
            }
        }


        public void GoToNext()
        {
            if (Index < coverList.Count - 1)
                UpdateIndex(Index + 1);
        }
        public void GoToPrevious()
        {
            if (Index > 0)
                UpdateIndex(Index - 1);
        }
    }
}
