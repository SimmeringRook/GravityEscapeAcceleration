using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurfaceGravityCalculator
{
    public partial class AstronomicalDataForm : Form
    {
        private List<AstronomicalObject> _AstronomicalObjectData;
        private AstronomicalObject _SelectedAstronomicalObject;
        private AstronomicalObject _CreatedAstronomicalObject;
        public AstronomicalDataForm()
        {
            InitializeComponent();
            //Restrict Track Bar to correct values
            distanceTrackBar.SetRange(1, 10);
            distanceTrackBar.Value = 1;
            //Restrict Track Bar to correct values
            add_DistanceTrackBar.SetRange(1, 10);
            add_DistanceTrackBar.Value = 1;
            //Load data
            _AstronomicalObjectData = DataHandler.ReadDataFile();
            UpdateExistingData();

        }

        /// <summary>
        /// Ensures the "loadedObjectsCombo" Box has the correct list 
        /// upon launching or if the list has been altered
        /// </summary>
        private void UpdateExistingData()
        {
            BindingList<AstronomicalObject> bindinglist = new BindingList<AstronomicalObject>();
            foreach (AstronomicalObject aO in _AstronomicalObjectData)
            {
                bindinglist.Add(aO);
            }

            BindingSource bSource = new BindingSource();
            bSource.DataSource = bindinglist;

            loadedObjectsCombo.DataSource = bSource;
            loadedObjectsCombo.DisplayMember = "Name";
        }

        /// <summary>
        /// Allows the program to save any newly created Astronomical Objects before exiting.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
                DataHandler.WriteDataFile(_AstronomicalObjectData);
            }
            base.Dispose(disposing);
        }

        #region View Data
        /// <summary>
        /// Display the corresponding information in the corresponding fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadedObjectsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected Astronomical Object
            _SelectedAstronomicalObject = _AstronomicalObjectData[loadedObjectsCombo.SelectedIndex];

            nameTextBox.Text = _SelectedAstronomicalObject.Name;
            //Mass
            ExponentionalValues mass = _SelectedAstronomicalObject.Mass;
            massTextBox.Text = mass.value.ToString();
            massExponentTextBox.Text = mass.exponent.ToString();
            massUnitsCombo.SelectedItem = (mass.units.Equals(SIUnit.kg)) ? "kilograms" : "Solar Masses";

            //Radius
            ExponentionalValues radius = _SelectedAstronomicalObject.Radius;
            radiusTextBox.Text = radius.value.ToString();
            radiusExponentTextBox.Text = radius.exponent.ToString();
            radiusUnitsCombo.SelectedItem = (radius.units.Equals(SIUnit.m)) ? "meters" : "kilometers";

            gravityOutputTextBox.Text = _SelectedAstronomicalObject.SurfaceGravityToString();
            DisplayDistance(distanceTrackBar.Value);
        }

        private void distanceTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar distanceAway = (TrackBar)sender;
            DisplayDistance(distanceAway.Value);
        }

        private void DisplayDistance(int distanceModifier)
        {
            float intensity = (_SelectedAstronomicalObject.SurfaceGravity.value) / (distanceModifier * distanceModifier);

            distanceTextBox.Text = distanceModifier.ToString() + " * ("
                + _SelectedAstronomicalObject.Radius.value.ToString() + " * 10^"
                + _SelectedAstronomicalObject.Radius.exponent + ") "
                + _SelectedAstronomicalObject.Radius.units.ToString();
            gravityOutputTextBox.Text = intensity.ToString();
        }
        #endregion

        #region Add New Data
        /// <summary>
        /// If the "save" check box is clicked; create a new entry in the list of Astronomical Objects
        /// Given the user input.
        /// Will calculate the Intesity of Gravity regardless if the object is being saved.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void add_CalculateButton_Click(object sender, EventArgs e)
        {
            string[] celestialBodyDescriptors = new string[] {
                add_NameTextBox.Text,
                add_MassTextBox.Text,
                add_MassExponentTextBox.Text,
                add_MassUnitComboBox.SelectedItem.ToString(),
                add_RadiusTextBox.Text,
                add_RadiusExponentTextBox.Text,
                add_RadiusUnitComboBox.SelectedItem.ToString()
            };

            _CreatedAstronomicalObject = new AstronomicalObject(celestialBodyDescriptors);

            if (saveCheckBox.Checked && !_AstronomicalObjectData.Contains(_CreatedAstronomicalObject))
            {
                _AstronomicalObjectData.Add(_CreatedAstronomicalObject);
                UpdateExistingData();
            }
            Add_DisplayDistance(1);
            //add_GravityOutputTextBox.Text = _CreatedAstronomicalObject.SurfaceGravityToString();
        }

        /// <summary>
        /// Ensures only numbers and one decimal may be inputted into the add_Mass and add_Radius text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void ValidateInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Only [0-9] and '.' are valid inputs.");
                textBox.BackColor = Color.LightPink;
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("You can only have one decimal point.");
                textBox.BackColor = Color.LightPink;
                e.Handled = true;
            }

            textBox.BackColor = SystemColors.Window;
            e.Handled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            add_NameTextBox.Text = "";

            add_MassTextBox.Text = "";
            add_MassExponentTextBox.Text = "";
            add_MassUnitComboBox.SelectedIndex = 0;

            add_RadiusTextBox.Text = "";
            add_RadiusExponentTextBox.Text = "";
            add_RadiusUnitComboBox.SelectedIndex = 0;

            add_IntensityTextBox.Text = "";
            add_DistanceTextBox.Text = "";
        }

        private void add_DistanceTrackBar_Scroll(object sender, EventArgs e)
        {
            TrackBar distanceAway = (TrackBar)sender;
            Add_DisplayDistance(distanceAway.Value);
        }

        private void Add_DisplayDistance(int distanceModifier)
        {
            float intensity = (_CreatedAstronomicalObject.SurfaceGravity.value) / (distanceModifier * distanceModifier);

            add_DistanceTextBox.Text = distanceModifier.ToString() + " * ("
                + _CreatedAstronomicalObject.Radius.value.ToString() + " * 10^"
                + _CreatedAstronomicalObject.Radius.exponent + ") "
                + _CreatedAstronomicalObject.Radius.units.ToString();
            add_IntensityTextBox.Text = intensity.ToString();
        }
        #endregion

    }
}
