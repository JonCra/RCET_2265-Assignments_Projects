namespace RollOfTheDice_ListBox
{
    public partial class RollOfTheDiceForm : Form
    {
        public RollOfTheDiceForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        // Program Logic -----------------------------------------
        private static int rollOneValue;
        private static int rollTwoValue;
        string Line4 = "";
        private int padding = 4;

        private void SetDefaults()
        {
            DisplayRichTextBox.Text = "";
            Line4 = "";
        }
        private void InitiateRoll()
        {
            Display();
        }
        
        // TODO: Reformat this code to display in the Display text
        void Display()
        {            
            int[] results = new int[13];
            string header = "Roll of the Dice";
            int totalWidth = 6 * (padding);
            string hDivider = new string('-', totalWidth);
            string otherDivider = new string('-', (totalWidth * 3));

            string Line0 = header.PadLeft(55);
            string Line1 = (hDivider + hDivider + hDivider);
            string Line2 = "";

            for (int roll = 2; roll < 13; roll++)
            {
                Line2 += ((roll).ToString().PadLeft(padding + 2) + "| ");
            }
            string Line3 = otherDivider;

            DiceTally();

            // Write the roll results
            string[] text = {Line0, Line1, Line2, Line3, Line4};
            DisplayRichTextBox.Lines = text;
        }

        void DiceTally()
        {
            // Initialize results array and local variables
            int[] results = new int[13];
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            int sum6 = 0;
            int sum7 = 0;
            int sum8 = 0;
            int sum9 = 0;
            int sum10 = 0;
            int sum11 = 0;
            int sum12 = 0;

            for (int i = 0; i < 1000; i++)
            {
                DiceRollerOne();
                DiceRollerTwo();
                int rollResults = rollOneValue + rollTwoValue;
                if (rollResults == 2)
                {
                    sum2++;
                }
                else if (rollResults == 3)
                {
                    sum3++;
                }
                else if (rollResults == 4)
                {
                    sum4++;
                }
                else if (rollResults == 5)
                {
                    sum5++;
                }
                else if (rollResults == 6)
                {
                    sum6++;
                }
                else if (rollResults == 7)
                {
                    sum7++;
                }
                else if (rollResults == 8)
                {
                    sum8++;
                }
                else if (rollResults == 9)
                {
                    sum9++;
                }
                else if (rollResults == 10)
                {
                    sum10++;
                }
                else if (rollResults == 11)
                {
                    sum11++;
                }
                else if (rollResults == 12)
                {
                    sum12++;
                }                
            }

            // Index results into 1-D array
            results[2] = sum2;
            results[3] = sum3;
            results[4] = sum4;
            results[5] = sum5;
            results[6] = sum6;
            results[7] = sum7;
            results[8] = sum8;
            results[9] = sum9;
            results[10] = sum10;
            results[11] = sum11;
            results[12] = sum12;

            for (int i = 2; i < 13; i++)
            {
                Line4 += ((results[i]).ToString().PadLeft(padding + 1) + "| ");
            }
        }

        static int DiceRollerOne()
        {
            // Rolls First 1d6
            Random rollTwo = new Random();
            switch (rollTwo.Next(1, 7))
            {
                case 1:
                    rollTwo.Next(1);
                    rollOneValue = 1;
                    break;
                case 2:
                    rollTwo.Next(2);
                    rollOneValue = 2;
                    break;
                case 3:
                    rollTwo.Next(3);
                    rollOneValue = 3;
                    break;
                case 4:
                    rollTwo.Next(4);
                    rollOneValue = 4;
                    break;
                case 5:
                    rollTwo.Next(5);
                    rollOneValue = 5;
                    break;
                case 6:
                    rollTwo.Next(6);
                    rollOneValue = 6;
                    break;
                default:
                    Console.WriteLine("out of bounds");
                    break;
            }
            return rollOneValue;
        }

        static int DiceRollerTwo()
        {
            // Rolls Second 1d6
            Random rollOne = new Random();
            switch (rollOne.Next(1, 7))
            {
                case 1:
                    rollOne.Next(1);
                    rollTwoValue = 1;
                    break;
                case 2:
                    rollOne.Next(2);
                    rollTwoValue = 2;
                    break;
                case 3:
                    rollOne.Next(3);
                    rollTwoValue = 3;
                    break;
                case 4:
                    rollOne.Next(4);
                    rollTwoValue = 4;
                    break;
                case 5:
                    rollOne.Next(5);
                    rollTwoValue = 5;
                    break;
                case 6:
                    rollOne.Next(6);
                    rollTwoValue = 6;
                    break;
                default:
                    Console.WriteLine("out of bounds");
                    break;
            }
            return rollTwoValue;
        }

        // Event Handlers ----------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Clear display
            SetDefaults();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            // Start again
            SetDefaults();
            InitiateRoll();
        }
    }
}