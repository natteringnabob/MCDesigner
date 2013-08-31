using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using ChartReader;
using NUnit.Framework;
using HorizontalAlignment = System.Windows.HorizontalAlignment;

namespace MCDesigner
{
   public class GridMethods
    {
        public Grid FillLyricLineGrid(LyricLine line)
        {
            // Create the Grid
            var grid = new Grid();
            grid.Width = 500; //TODO: Auto width
            
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.ShowGridLines = false;
            grid.Background = new SolidColorBrush(Colors.LightSteelBlue);

            // Create Columns
            foreach (var word in line.Lyrics)
            {
                var column = new ColumnDefinition{Width = GridLength.Auto};
                grid.ColumnDefinitions.Add(column);
            }

            // Create Rows
            var chordRow = new RowDefinition {Height = GridLength.Auto};
            var wordRow = new RowDefinition {Height = GridLength.Auto};
           
            grid.RowDefinitions.Add(chordRow);
            grid.RowDefinitions.Add(wordRow);

            // Create chord row
            for (var i = 0; i < line.Lyrics.Count(); i++)
            {
                var lyric = line.Lyrics.ToList()[i];
                var chordText = new TextBlock {Text = lyric.Chord, FontSize = 12, FontWeight = FontWeights.Bold, Foreground = new SolidColorBrush(Colors.Red)};
                Grid.SetRow(chordText, 0);
                Grid.SetColumn(chordText,i);
                grid.Children.Add(chordText);
            }
  
            // Create lyric row
            for (var i = 0; i < line.Lyrics.Count(); i++)
            {
                var lyric = line.Lyrics.ToList()[i];
                var lyricText = new TextBlock { Text = lyric.Text, FontSize = 12 };
                Grid.SetRow(lyricText, 1);
                Grid.SetColumn(lyricText, i);
                grid.Children.Add(lyricText);
            }
            return grid;
        }

       public void FillMasterGrid(IEnumerable<Grid> lyricGrids, Grid masterGrid)
       {
           // Create the Grid
           
           masterGrid.Width = 510; //TODO: Auto width

           masterGrid.HorizontalAlignment = HorizontalAlignment.Left;
           masterGrid.VerticalAlignment = VerticalAlignment.Top;
           masterGrid.ShowGridLines = false;
           masterGrid.Background = new SolidColorBrush(Colors.LightSteelBlue);

           //add one column
           var column = new ColumnDefinition { Width = GridLength.Auto };
           masterGrid.ColumnDefinitions.Add(column);

           // Create Rows
           var row = new RowDefinition { Height = GridLength.Auto };
          
           masterGrid.RowDefinitions.Add(row);

           // fill rows with lyric grids
           var lGrids = lyricGrids.ToList();
           for (var i = 0; i < lGrids.Count(); i++)
           {
               var lyricGrid = lGrids[i];
               
               Grid.SetRow(lyricGrid, i);
               Grid.SetColumn(lyricGrid, 0);
               masterGrid.Children.Add(lyricGrid);
           }

       }
    }
}
