using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace stationMeteo
{
    public partial class MeasurementConfiguration : Form
    {
        public Interface mainInterface;
        public List<Measure> measuresReceived {get; private set;}
        public MeasurementConfiguration(Interface mainInterface, List<Measure> measuresReceived)
        {
            InitializeComponent();
            this.measuresReceived = measuresReceived;
            this.mainInterface = mainInterface;

        }



        private void MeasurementConfiguration_Load(object sender, EventArgs e)
        {
            initComboBoxMeasurementID();
            initComboBoxMeasurementType();
            nu_min.Text = "0";
            nu_max.Text = "0";
        }

        //Affiche les ID qui peuent être configuré

        private void initComboBoxMeasurementID()
        {
            foreach (Measure measure in this.measuresReceived)
            {
                cb_ID.Items.Add(measure.ID);
            }
        }

        private void initComboBoxMeasurementType()
        {
            cb_type.Items.Add("ID System");
            cb_type.Items.Add("Temperature (°C)");
            cb_type.Items.Add("Humidity (%)");
            cb_type.Items.Add("Pressure (Pa)");
            cb_type.Items.Add("WindSpeed (m/s)");
            cb_type.SelectedIndex = 0;
        }




        /**
         * Si l'utilisateur à selectionner l'id, il peut load
         * Crée une nouvelle mesure avec les bonnes infos et la renvoie à l'interface principal
         */

        private void onLoadMeasure(object sender, EventArgs e) {
            Measure measure;
            int isIDSelected = cb_ID.SelectedIndex;
            int typeIndex = cb_type.SelectedIndex;
            if (isIDSelected != -1) {

                String units = "";

              
                Byte idSelected = (Byte) cb_ID.SelectedItem;
                Byte minValue = Byte.Parse(nu_min.Text);
                Byte maxValue = Byte.Parse(nu_max.Text);

                String typeSelected = (String )cb_type.SelectedItem;

                switch(typeIndex)
                {
                    case 0:
                        units = "%";
                        break;
                    case 1:
                        units = "%";
                        break;
                    case 2:
                        units = "Pa";
                        break;
                    case 3:
                        units = "m/s";
                        break;

                    default:
                        break;
                }

                if (typeIndex != 0)
                {
                    measure = new Measure(idSelected, typeSelected, units, "24bits", minValue, maxValue, 0, 0,null, null);
                    measure.alarmHighText = "OK";
                    measure.alarmLowText = "OK";

                } else
                {
                    measure = new Measure(idSelected, typeSelected, null, "24bits", 0, 0, null, 0, null, null);

                    mainInterface.loadNewIDSystem(measure.ID);
                }
                mainInterface.loadNewMeasure(measure);



            }

        }

        private void onSelectedTypeChanged(object sender, EventArgs e)
        {
            ComboBox cb_type = (ComboBox)sender;
            int selectedType = cb_type.SelectedIndex;

            if (selectedType == 0)
            {
                nu_min.Enabled = false;
                nu_max.Enabled = false;

            } else if (nu_max.Enabled != true && nu_max.Enabled != true)
            {
                nu_min.Enabled = true;
                nu_max.Enabled = true;
      

            }
        }

    }
}
