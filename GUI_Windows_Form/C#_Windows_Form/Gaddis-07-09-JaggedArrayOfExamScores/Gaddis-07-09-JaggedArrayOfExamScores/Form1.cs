/*
Jagged Array of Exam Scores Dr.Hunter teaches three sections of her Intro to Computer Science class. She has 12 students in section 1, 8 students in section 2, and 10 students in section 3. In the Chap07 folder of the Student Sample Programs, you will find the following files: 
• Section1.txt—This file contains the final exam scores for each student in section 1. (There are 12 integer scores in the file.) 
• Section2.txt—This file contains the final exam scores for each student in section 2. (There are 8 integer scores in the file.) 
• Section3.txt—This file contains the final exam scores for each student in section 3. (There are 10 integer scores in the file.) 
Create an application that reads these three files and stores their contents in a jagged array.The array’s first row should hold the exam scores for the students in section 1, the second row should hold the exam scores for the students in section 2, and the third row should hold the exam scores for the students in section 3. The application should display each section’s exam scores in a separate ListBox control and then use the jagged array to determine the following: 
• The average exam score for each individual section 
• The average exam score for all the students in the three sections 
• The highest exam score among all three sections and the section number in which that score was found 
• The lowest exam score among all three sections and the section number in which that score was found
*/
using System;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_09_JaggedArrayOfExamScores
{
  public partial class grmExamScores : Form
  {
    public grmExamScores()
    {
      InitializeComponent();
    }

    int[][] sections = new int[3][];
    double totalSum = 0;
    int smallest;
    int largest;
    int smallestSection = 0;
    int largestSection = 0;

    private void btnDisplayData_Click(object sender, EventArgs e)
    {

      try
      {
        sections[0] = new int[12];
        sections[1] = new int[8];
        sections[2] = new int[10];

        CreateArray();
        SmallestAndLargest();

        lstOutput.Items.Add("Average of section 1: " + GetAverages(0).ToString("n2"));
        lstOutput.Items.Add("Average of section 2: " + GetAverages(1).ToString("n2"));
        lstOutput.Items.Add("Average of section 3: " + GetAverages(2).ToString("n2"));
        lstOutput.Items.Add("Total Average of all 3 sections: " + (totalSum / 30).ToString("n2"));
        lstOutput.Items.Add("Smallest Score: " + smallest + " is in section " + smallestSection);
        lstOutput.Items.Add("Largest Score: " + largest + " is in section " + largestSection);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }      
    }

    private double GetAverages(int level)
    {
      int sum = 0;
      int numOfElements = sections[level].Length;

      for (int i = 0; i < numOfElements; i++)
      {
        sum += sections[level][i];
        totalSum += sections[level][i];
      }

      return sum * 1.0 / numOfElements;
    }

    private void SmallestAndLargest()
    {
      smallest = sections[0][0];
      largest = sections[0][0];

      for (int i = 0; i < 12; i++)
      {
        if (sections[0][i] < smallest)
        {
          smallest = sections[0][i];
          smallestSection = 1;
        }

        if (sections[0][i] > largest)
        {
          largest = sections[0][i];
          largestSection = 1;
        }
      }

      for (int i = 0; i < 8; i++)
      {
        if (sections[1][i] < smallest)
        {
          smallest = sections[1][i];
          smallestSection = 2;
        }

        if (sections[1][i] > largest)
        {
          largest = sections[1][i];
          largestSection = 2;
        }
      }

      for (int i = 0; i < 10; i++)
      {
        if (sections[2][i] < smallest)
        {
          smallest = sections[2][i];
          smallestSection = 3;
        }

        if (sections[2][i] > largest)
        {
          largest = sections[2][i];
          largestSection = 3;
        }
      }
    }

    private void CreateArray()
    {
      StreamReader sr = new StreamReader("Section1.txt");
      int counter = 0;

      while (!sr.EndOfStream)
      {
        sections[0][counter] = Convert.ToInt32(sr.ReadLine());
        counter++;
      }

      sr = new StreamReader("Section2.txt");
      counter = 0;
      while (!sr.EndOfStream)
      {
        sections[1][counter] = Convert.ToInt32(sr.ReadLine());
        counter++;
      }

      sr = new StreamReader("Section3.txt");
      counter = 0;
      while (!sr.EndOfStream)
      {
        sections[2][counter] = Convert.ToInt32(sr.ReadLine());
        counter++;
      }

    }
  }
}
