using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stationMeteo
{
    public partial class Interface : Form
    {

        private Random random;
        private int CELL_SIZE = 30;
        private List<Measure> knownMeasures;
        private List<Measure> measuresReceived;
        private List<SystemID> knownSystemID;
        private List<Measure> alarms;
        private String[] alarmSources = { "0x55", "0" };
        private String[] alarmDetails = { "0x00", "0x55", "0xaa", "0xff" };
        private String[] alarmStatuses = { "0x00", "0x55", "0xaa", "0xff" };

        public Interface()
        {
            InitializeComponent();
            
        }

        private void Interface_Load(object sender, EventArgs e)
        {
            trame_timer.Start();
            watchdog_timer.Start();
            random = new Random();
            knownMeasures = new List<Measure>();
            measuresReceived = new List<Measure>();
            knownSystemID = new List<SystemID>();
            alarms = new List<Measure>();
            initUi();
            
        }

        private void initUi()
        {
            buildMeasureGrid();
            buildConfigurationGrid();
            buildAlarmGrid();
            fillComboBoxAlarmID();
        }

        private void buildMeasureGrid()
        {
            int columnCount = 6;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Last measure");
            dataTable.Columns.Add("Units");
            dataTable.Columns.Add("Time (ms)");
            dataTable.Columns.Add("Alarm Low");
            dataTable.Columns.Add("Alarm High");

            foreach (Measure measure in knownMeasures)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = measure.ID;
                dataRow[1] = measure.lastMeasure;
                dataRow[2] = measure.units;
                dataRow[3] = measure.time;
                dataRow[4] = measure.alarmLowText;
                dataRow[5] = measure.alarmHighText;
                dataTable.Rows.Add(dataRow);
            }

            dgv_measures.DataSource = dataTable;
            dgv_measures.RowTemplate.Height = CELL_SIZE;

            for (int x = 0; x < columnCount; x++)
            {
                dgv_measures.Columns[x].Width = dgv_measures.Width / columnCount;
            }

            for (int y = 0; y < knownMeasures.Count; y++)
            {
                dgv_measures.Rows[y].Height = CELL_SIZE;


            }

        }

        private void buildSystemIDGrid()
        {
            int columnCount = 4;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Alarm Source");
            dataTable.Columns.Add("Alarm Detail");
            dataTable.Columns.Add("Alarm Status");

            foreach(SystemID systemID in knownSystemID)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = systemID.ID;
                dataRow[1] = systemID.alarmSource;
                dataRow[2] = systemID.alarmDetail;
                dataRow[3] = systemID.alarmStatus;
                dataTable.Rows.Add(dataRow);
            }
            dgv_systemID.DataSource = dataTable;
            dgv_systemID.RowTemplate.Height = CELL_SIZE;

            for (int x = 0; x < columnCount; x++)
            {
                dgv_systemID.Columns[x].Width = dgv_systemID.Width / columnCount;
            }

            for (int y = 0; y < knownSystemID.Count; y++)
            {
                dgv_systemID.Rows[y].Height = CELL_SIZE;
            }
        }


        private void buildConfigurationGrid()
        {
            int columnCount = 5;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Measurement type");
            dataTable.Columns.Add("Format");
            dataTable.Columns.Add("Min.Value");
            dataTable.Columns.Add("Max.Value");


            foreach (Measure measure in measuresReceived)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = measure.ID;
                dataRow[1] = measure.measurementType == null ? "undefined" : measure.measurementType; 
                dataRow[2] = measure.format == null ? "undefined" : measure.format;
                dataRow[3] = measure.minValue == null ? 0 : measure.minValue;
                dataRow[4] = measure.maxValue == null ? 0 : measure.maxValue;

                dataTable.Rows.Add(dataRow);
            }


            dgv_configurations.DataSource = dataTable;
            dgv_configurations.RowTemplate.Height = CELL_SIZE;

            for (int x = 0; x < columnCount; x++)
            {
                dgv_configurations.Columns[x].Width = dgv_measures.Width / columnCount;
            }

            for (int y = 0; y < measuresReceived.Count; y++)
            {
                dgv_configurations.Rows[y].Height = CELL_SIZE;
            }

        }
        private void buildAlarmGrid()
        {
            int columnCount = 4;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Measurement type");
            dataTable.Columns.Add("Alarm Low");
            dataTable.Columns.Add("Alarm High");


            foreach (Measure measure in alarms)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow[0] = measure.ID;
                dataRow[1] = measure.measurementType;
                dataRow[2] = measure.alarmLow;
                dataRow[3] = measure.alarmHigh;

                dataTable.Rows.Add(dataRow);
            }


            dgv_alarm.DataSource = dataTable;
            dgv_alarm.RowTemplate.Height = CELL_SIZE;

            for (int x = 0; x < columnCount; x++)
            {
                dgv_alarm.Columns[x].Width = dgv_alarm.Width / columnCount;
            }

            for (int y = 0; y < alarms.Count; y++)
            {
                dgv_alarm.Rows[y].Height = CELL_SIZE;
            }

        }

        private void fillComboBoxAlarmID()
        {
            foreach (Measure measure in knownMeasures)
            {
                cb_alarmID.Items.Add(measure.ID);
            }
        }



        /**
         * Charge une nouvelle mesure, met à jour la fenetre de configuration & affiche dans la fenetre de mesures
         * Tri la fenetre des mesure à chaque nouveau ajout
         */
        public void loadNewMeasure(Measure newMeasure)
        {
            int oldMeasureIndex = measuresReceived.FindIndex(measureReceived => measureReceived.ID == newMeasure.ID);
            measuresReceived[oldMeasureIndex] = newMeasure;
            if (newMeasure.units != null)
            {
                knownMeasures.Add(newMeasure);
                knownMeasures.Sort((knownMeasure1, knownMeasure2) => knownMeasure1.ID.CompareTo(knownMeasure2.ID));
                cb_alarmID.Items.Add(newMeasure.ID);
                buildMeasureGrid();
                buildConfigurationGrid();
            }


        }

        public void loadNewIDSystem(Byte ID)
        {
            String alarmSource = alarmSources[random.Next(0, alarmSources.Length)] ;
            String alarmDetail = alarmDetails[random.Next(0, alarmDetails.Length)];
            String alarmStatus = alarmStatuses[random.Next(0, alarmStatuses.Length)];

            if (alarmSource == "0") {
                if (knownMeasures.Count > 0)
                {
                    alarmSource = knownMeasures[random.Next(0, knownMeasures.Count)].ID.ToString();
                    knownSystemID.Add(new SystemID(ID, alarmSource, alarmDetail, alarmStatus));
                } else
                {

                    knownSystemID.Add(new SystemID(ID, "none", alarmDetail, alarmStatus));
                }
   

            } else
            {

                knownSystemID.Add(new SystemID(ID, alarmSource, alarmDetail, alarmStatus));
            }

            buildSystemIDGrid(); 
        }

        private void updateMeasure(Measure measure, int value)
        {
            Byte? rightValue = (Byte) ((value / ((Math.Pow(256, 3)) - 1) * (measure.maxValue - measure.minValue) + measure.minValue));
            measure.lastMeasure = rightValue;
            if (rightValue > measure.alarmHigh)
            {
                measure.alarmHighText = "ALARM";
            }
            else
            {
                measure.alarmHighText = "OK";
            }
            if (rightValue < measure.alarmLow)
            {
                measure.alarmLowText = "ALARM";
            } else
            {
                measure.alarmLowText = "OK";
            }
            buildMeasureGrid();
        }



        private void sendTrame(object sender, EventArgs e)
        {
            Byte ID = (Byte) random.Next(1, 51); //Crée un id
            int value = random.Next(0, 16000000);



            Tram tram = new Tram(ID, value);
            Measure isKnownMeasure = knownMeasures.Find(knownMeasure => knownMeasure.ID == tram.ID); //Si la mesure à déjà été configuré, met à jour sa valeur sinon affiche la tram indefinie dans le tableau de configuration

            
            if (isKnownMeasure != null)
            {
                updateMeasure(isKnownMeasure, value);
            } else
            {
                displayIDToConfigurationTab(tram);
                
            }


            
        }



        /*
         * Crée une mesure inconnue uniquement identifiable par l'id reçue par la trame
         * Verifie si la mesure inconnue à déjà été envoyé par la trame
         * Si la mesure n'a pas encore été envoyé et que la liste n'est pas pleine, 
         * affiche la mesure incconu pour la configurer et trie la liste pour afficher les ID du plus petit au plus grand
         * Si la tram envoyé apartient au Systeme, pas besoin qu'elle soit inconnu ni configuré
         */
        private void displayIDToConfigurationTab(Tram tram)
        {
            Measure measure;
            measure = new Measure(tram.ID, null, null, "24bits", null, null, null, null, null, null);
            Measure measureAlreadyReceived = measuresReceived.Find(measureReceived => measure.ID == measureReceived.ID);
            if (measureAlreadyReceived == null && measuresReceived.Count < 50) 
            {
                measuresReceived.Add(measure);
                measuresReceived.Sort((measureReceived1, measureReceived2) => measureReceived1.ID.CompareTo(measureReceived2.ID));
                buildConfigurationGrid();
            }
        }

        private void sendWatchdog(object sender, EventArgs e)
        {
            Tram tram = new Tram(0, 0);
            displayIDToConfigurationTab(tram);

        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
         MeasurementConfiguration measurementConfigurationForm = new MeasurementConfiguration(this, measuresReceived);
        measurementConfigurationForm.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void onAlarmLoaded(object sender, EventArgs e)
        {
            Byte selectedID = (Byte)cb_alarmID.SelectedItem;
            Measure measure = knownMeasures.Find(knownMeasure => knownMeasure.ID == selectedID);
            measure.alarmLow = Byte.Parse(tb_alarmBelow.Text);
            measure.alarmHigh = Byte.Parse(tb_alarmUp.Text);
            alarms.Add(measure);
            buildAlarmGrid();

        }

        private void onSelectedAlarmIDChanged(object sender, EventArgs e)
        {
            Byte selectedID = (Byte) cb_alarmID.SelectedItem;
            Measure measure = knownMeasures.Find(knownMeasure => knownMeasure.ID == selectedID );
            tb_alarmBelow.Text = measure.alarmLow.ToString();
            tb_alarmUp.Text = measure.alarmHigh.ToString();
            lb_minMeasure.Text = measure.minValue.ToString();
            lb_maxMeasure.Text = measure.maxValue.ToString();
        }
    }
}
