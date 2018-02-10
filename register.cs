using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Data;

namespace MultiFaceRec
{
    public partial class register : Form
    {
        //Declararation of all variables, vectors and haarcascades
        Image<Bgr, Byte> currentFrame;
        Capture grabber;
        HaarCascade face;
        int flag = 0;

        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null, nam = null;

        public register()
        {
            InitializeComponent();
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception)
            {
                //MessageBox.Show(e.ToString());

                MessageBox.Show("Student database empty, please add students!!", "face load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");


            //Get the current frame form capture device
            currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.1,
          5,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {
                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       0,
                       ref termCrit);

                    name = recognizer.Recognize(result);

                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();

                //check if number of person >1 then show exeption "only one person at a time"
                if (facesDetected[0].Length > 1)
                    MessageBox.Show("ERROR : Only One Person at a time !!");

            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                //names = names + NamePersons[nnn] + ", ";
                names = names + NamePersons[nnn];
                nam = names;
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            label4.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();
            
       }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            flag = 0;
            //Initialize the FrameGraber event            
            Application.Idle += new EventHandler(FrameGrabber);            
            //update table 'register' login = currnt systm time                           

            button1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            //Initialize the capture device
            grabber = new Capture();
            grabber.QueryFrame();
            flag = 1;
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            //update table register 'logout' = currnt systm time           
            
            button2.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            if (flag == 0)
            {
                SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1");

                try
                {
                    myConnection.Open();

                    SqlCommand mycomand = new SqlCommand("insert into LogRegisters (LoginTime,StudentId)" +
                    "values (@in_time,@sid)", myConnection);

                    mycomand.Parameters.Add("@in_time", SqlDbType.DateTime);
                    mycomand.Parameters["@in_time"].Value = dt;

                    mycomand.Parameters.Add("@sid", SqlDbType.NChar);
                    mycomand.Parameters["@sid"].Value = nam;

                    mycomand.ExecuteNonQuery();

                    MessageBox.Show("Hello ID : " + nam + "!!    you are loged in!!", "loged in to library", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
                catch (Exception ie)
                {
                    MessageBox.Show(ie.Message);
                }
                finally
                {
                    myConnection.Close();

                }
 
            }
            else if (flag == 1)
            {
                SqlConnection myConnection = new SqlConnection("User ID=sa;Initial Catalog=UckLibMgr;Password=Sqlserver2008;Data Source=127.0.0.1;MultipleActiveResultSets=true");

                try
                {
                    myConnection.Open();

                    DateTime time1;
                    
                    SqlCommand mycmnd = new SqlCommand("select LoginTime,LogoutTime from LogRegisters where StudentId=" + nam+" order by LoginTime desc", myConnection);
                    SqlDataReader reader = mycmnd.ExecuteReader();
                    reader.Read();
                    time1 = reader.GetDateTime(0);
                    

                   // if (time2 == null)
                   // {
                    SqlCommand mycomand = new SqlCommand("Update Logregisters set logouttime = @logOutTime "
                        +"where logintime = @logintime", myConnection);

                    mycomand.Parameters.Add("@logOutTime", SqlDbType.DateTime);
                    mycomand.Parameters["@logOutTime"].Value = DateTime.Now;

                    mycomand.Parameters.Add("@logintime", SqlDbType.DateTime);
                    mycomand.Parameters["@logintime"].Value = time1;

                    String txt = mycomand.CommandText;

                        // mycomand.Parameters.Add("@LogoutTime", SqlDbType.DateTime);
                        //mycomand.Parameters["@LogoutTime"].Value = dt;

                        //                        mycomand.Parameters.Add("@sid", SqlDbType.NChar);
                        //                      mycomand.Parameters["@sid"].Value = nam;

                        mycomand.ExecuteNonQuery();
                        MessageBox.Show("Hello ID : " + nam + "!!    you are loged out!!", "log out from library", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.Close();
//                    }
                }

                catch (Exception ie)
                {
                    MessageBox.Show(ie.Message);
                }
                finally
                {
                    myConnection.Close();

                }
 
            }
            button1.Enabled = false; button2.Enabled = false; button3.Enabled = false;
        }

    }

}
