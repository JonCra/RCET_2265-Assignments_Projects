/*
 * Jonas Cram
 * RCET 2265
 * Fall 2025
 * Robotics and Comm. Systems Engineering Technology
 * https://github.com/JonCra/RCET_2265-Assignments_Projects.git
 */
using StansGrocery;

namespace Stan_sGrocery
{
    /* TODO:
     * [ ] Load item data from disk file into data structure.
     * [ ] Allow item search via:
     *      [ ] Text box
     *      [ ] Combo box
     *      [ ] List box
     * [ ] DiplayListbox should be alphabetized, filtered by current selection.
     * [ ] FilterCombobox should have:
     *      [ ] Always have "Show All" as default.
     *      [ ] Show unique aisle numbers in descending order when FilterRadioButton is checked.
     *      [ ] Show alphabetical unique category names when FilterByCategoryRadioButton is checked.
     *      [ ] Selected option displays all items based on Radio Button selection in the display box.
     * [ ] DisplayLabel format: "You will find {item} on aisle {aisleNumber} with the {similarItem}.
     * [ ] If the item is not found, tell the customer.
     * [ ] When "zzz"/"ZZZ" is typed in search box, program stops.
     * 
     * Additional Requirements:
     * [ ] Add the data file "Grocery.txt" to the project folder and load it at startup.
     * [ ] Use a temp array to parse/load the data into main data structure.
     * [ ] DisplayListbox should update based on filter and search criteria.
     * [ ] FilterComboBox and Radio buttons should interact as described above.
     * [ ] SearchTextBox and SearchButton should update the DisplayListBox and DisplayLabel appropriately.
     * [ ] DisplayLabel should always reflect the currently selected item in the DisplayListBox
     */
    public partial class StansGroceryForm : Form
    {
        // "Global" Variables ---------------
        SplashScreenForm sf = new SplashScreenForm();
        AboutForm af = new AboutForm();

        public StansGroceryForm()
        {
            // Show splash screen
            sf.Show();

            // Wait time in milliseconds
            Thread.Sleep(25);

            // Close splash screen (frees up any resources used)
            sf.Dispose();

            InitializeComponent();
            SetDefaults();
            LoadFile();
        }

        // Initializers ---------------------
        private void SetDefaults()
        {
            FilterByAisleRadioButton.Checked = true;
            FilterByCategoryRadioButton.Checked = false;
            DisplayListBox.Text = "";
            FilterComboBox.SelectedIndex = 0;
        }

        private void LoadFile()
        {
            // Load/index file data into appropriate data holder

        }

        // Program Logic --------------------
        private void SearchQuery()
        {
            if (SearchTextBox.Text == "zzz" || SearchTextBox.Text == "ZZZ")
            {
                this.Close();
            }

            // Search item list

        }

        // Event Handlers -------------------
        private void ExitProgram(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            SearchQuery();
        }
    }
}