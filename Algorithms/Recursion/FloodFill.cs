/********************************************************************************************
 * Flood fill Algorithm.
 * 
 * Source     : Geeks for Geeks(Must Do)
 * Difficulty : Recursion - Medium
 * Problem    : https://practice.geeksforgeeks.org/problems/flood-fill-algorithm1856/1 
 * Solution   : 
 * 
 * Time Complexity  : O(n*m)        
 * Space complexity : O(n*m) 
 ********************************************************************************************/

namespace Algorithms.Recursion
{
    public class FloodFill : IExecute
    {
        int[,] FloodFillAlgorithm(int[,] image, int sr, int sc, int newColor)
        {
            if (image[sr, sc] == newColor)
                return image;

            Fill(image, sr, sc, image[sr, sc], newColor);

            return image;
        }

        private void Fill(int[,] image, int sr, int sc, int color, int newColor)
        {
            if (sr < 0 || sr >= image.GetLength(0) || sc < 0 || sc >= image.GetLength(1)
                || image[sr, sc] != color)
            {
                return;
            }

            image[sr, sc] = newColor;
            Fill(image, sr - 1, sc, color, newColor);// North
            Fill(image, sr + 1, sc, color, newColor);// South
            Fill(image, sr, sc - 1, color, newColor);// West
            Fill(image, sr, sc + 1, color, newColor);// East

            return;
        }

        public void Execute()
        {
            int[,] image = new int[3, 3]
            {
                { 1, 1, 1 },
                { 1, 1, 0 },
                { 1, 0, 1 }
            };

            var result = FloodFillAlgorithm(image, 1, 1, 2);

            for (int i = 0; i < image.GetLength(0); i++)
            {
                for (int j = 0; j < image.GetLength(1); j++)
                {
                    Console.WriteLine("image[{0},{1}] = {2}", i, j, image[i, j]);
                }
            }
        }
    }
}
