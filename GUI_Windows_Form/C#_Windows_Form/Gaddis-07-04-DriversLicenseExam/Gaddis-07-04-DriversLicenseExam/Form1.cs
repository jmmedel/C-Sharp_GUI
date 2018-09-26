/*
Driver’s License Exam The local driver’s license office has asked you to create an application that grades the written portion of the driver’s license exam.The exam has 20 multiple-choice questions.Here are the correct answers: 
1. B 2. D 3. A 4. A 5. C 6. A 7. B 8. A 9. C 10. D 11. B 12. C 13. D 14. A 15. D 16. C 17. C 18. B 19. D 20. A 
Your program should store these correct answers in an array. The program should read the student’s answers for each of the 20 questions from a text file and store the answers in another array. (Create your own text file to test the application.) After the student’s answers have been read from the file, the program should display a message indicating whether the student passed or failed the exam. (A student must correctly answer 15 of the 20 questions to pass the exam.) It should then display the total number of correctly answered questions, the total number of incorrectly answered questions, and a list showing the question numbers of the incorrectly answered questions.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Gaddis_07_04_DriversLicenseExam
{
  public partial class frmDriversLicenseExam : Form
  {
    readonly string[] answers = {"B","D","A","A","C","A","B","A","C","D",
                                  "B","C","D","A","D","C","C","B","D","A"};

    public frmDriversLicenseExam()
    {
      InitializeComponent();
    }

    private void btnEvaluate_Click(object sender, EventArgs e)
    {
      List<int> wrongAnswers = new List<int>();
      int incorrectCount = 0;
      int numberCount = 0;

      try
      {
        string[] studentAnswers = File.ReadAllLines("StudentAnswers.txt");

        foreach (string value in studentAnswers)
        {
          if (value.ToUpper() != answers[numberCount].ToUpper())
          {
            incorrectCount++;
            wrongAnswers.Add(numberCount + 1);
          }
          numberCount++;
        }

        lstOutput.Items.Add("Correct Answers: " + (numberCount - incorrectCount));
        lstOutput.Items.Add("Incorrect Answers: " + incorrectCount);

        lstOutput.Items.Add("");

        if (incorrectCount > 0)
        {
          lstOutput.Items.Add("Wrong Answers: ");
          foreach(int value in wrongAnswers)
          {
            lstOutput.Items.Add(value);
          }
        }
        lstOutput.Items.Add("");
        lstOutput.Items.Add(incorrectCount > 5 ? "Sorry, you did not pass" : "Congrats, you passed!");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
