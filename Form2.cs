using System;
using System.Drawing;
using System.Windows.Forms;
using ZDCore;
using ZDCore.Model;
using ZDNodeSystem.Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ZDWindowsFormsTest
{
    // Required Reference DLL's.
    // ZDCore.dll
    // ZDLog.dll
    // ZDNetwork.dll
    // ZDNodeSystem.dll
    // WindowsBase
   

       
   
    public partial class Form2 : Form
    {
		// This is our node graph instance. Create it.
        private ZDRootNodeGraph nodeGraph2 = new ZDRootNodeGraph();
        public event setTextValue setFormTextValue;
        public delegate void setTextValue(string textValue);
        public Form2()
        {
            InitializeComponent();
            ZDStudioWorld aWorld = new ZDStudioWorld(5, 2);
            nodeGraph2.World = aWorld;
        }
        public string EditedPropertise,ProType, Member;public int mark;
        public string animateName;
        //public  Dictionary<string, ZDNode> dic = new Dictionary<string, ZDNode>();
        //private ZDNode ProTemp;
        private string OriginalString;
        private float OriginalFloat;
        private Boolean OriginalBoolean;
        private int OriginalInt;
        private float TransLocationX;
        private float TransLocationY;
        private float TransLocationZ;
        private float TransRotationRoll;
        private float TransRotationYaw;
        private float TransRotationPitch;
        private float TransScaleX;
        private float TransScaleY;
        private float TransScaleZ;
        private float ColorR;
        private float ColorG;
        private float ColorB;
        private float ColorA;
        public Form2(string EditedPropertise,string Member, ZDRootNodeGraph nodeGraph,string ProType)
        {
            InitializeComponent();
            nodeGraph2 = nodeGraph;
            this.EditedPropertise = EditedPropertise;
            this.Member = Member;
            this.ProType = ProType;
            PropertiseName.Text = EditedPropertise;
            //数值显示
            var Proinstance = nodeGraph2.Nodes[Member];
            if (ProType.Equals("ADD"))
            {
                ConfirmEdit.Text = "添加";
            }
            if (ProType.Equals("PREVIEW"))
            {
                ConfirmEdit.Text = "确定";
            }
            var  ZDProType = nodeGraph2.Nodes[Member].Properties[EditedPropertise].DependencyObjectType.Name;//get type 
            switch (ZDProType)
            {
                case "ZDProperty_String":
                    var tstring = (Proinstance.Properties[EditedPropertise] as ZDProperty_String).Value;
                    OriginalString = tstring;
                    ChoosedPropertise.Text = tstring.ToString();
                     hideTransform();
                    hideColor();
                    hideBoolean();
                 /*   TextBox ProtextBox = new TextBox();
                    ProtextBox.Name = EditedPropertise;
                    ProtextBox.Text = tstring.ToString();
                    ProtextBox.Width = 100;
                    ProtextBox.Height = 25;
                    ProtextBox.Location = new Point(320,190);
                    this.Controls.Add(ProtextBox);*/
                    break;
                case "ZDProperty_Float":
                    var tfloat = (Proinstance.Properties[EditedPropertise] as ZDProperty_Float).Value;
                    OriginalFloat = tfloat;
                    ChoosedPropertise.Text = tfloat.ToString();
                    hideTransform();
                    hideColor();
                    hideBoolean();
                    break;

                case "ZDProperty_Boolean":
                    var tbool = (Proinstance.Properties[EditedPropertise] as ZDProperty_Boolean).Value;
                    OriginalBoolean = tbool;
                    BooleanStatus.Text = tbool.ToString();
                    hideTransform();
                    hideColor();
                    ChoosedPropertise.Hide();
                    break;
                case "ZDProperty_Integer":
                    var tinterger = (Proinstance.Properties[EditedPropertise] as ZDProperty_Integer).Value;
                    OriginalInt = tinterger;
                    ChoosedPropertise.Text = tinterger.ToString();
                    hideTransform();
                    hideColor();
                    hideBoolean();
                    break;
                case "ZDProperty_Transform":
                    ChoosedPropertise.Hide();
                    hideColor();
                    hideBoolean();
                    LocationX.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X.ToString();
                   LocationY.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y.ToString();
                   LocationZ.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z.ToString();
                   RotationRoll.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll.ToString();
                   RotationYaw.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw.ToString();
                  RotationPitch.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch.ToString();
                   ScaleX.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X.ToString();
                   ScaleY.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y.ToString();
                    ScaleZ.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z.ToString();

                    TransLocationX = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X;
                    TransLocationY = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y;
                    TransLocationZ = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z;
                    TransRotationRoll = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll;
                    TransRotationYaw = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw;
                    TransRotationPitch = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch;
                    TransScaleX = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X;
                    TransScaleY = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y;
                    TransScaleZ = (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z;
                    break;
                case "ZDProperty_Color":
                    R.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R.ToString();
                    G.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G.ToString();
                    B.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B.ToString();
                    A.Text = (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A.ToString();
                    ColorR=(Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R;
                    ColorG=(Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G;
                    ColorB=(Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B;
                    ColorA = (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A;
                    hideTransform();
                    hideBoolean();
                    break;

                default:break;
            }
        }

        private void editByZDType(string ZDProType)
        {
            PropertiseName.Text = EditedPropertise;
            var Proinstance = nodeGraph2.Nodes[Member];
            var t = (Proinstance.Properties[EditedPropertise] as ZDProperty_String).Value;
            ChoosedPropertise.Text = t.ToString();
        }


        private void hideTransform()
        {
            label1.Hide(); label4.Hide(); label7.Hide();
            label2.Hide(); label5.Hide(); label8.Hide();
            label3.Hide(); label6.Hide(); label9.Hide();
            LocationX.Hide(); LocationY.Hide(); LocationZ.Hide();
            RotationRoll.Hide(); RotationYaw.Hide(); RotationPitch.Hide();
            ScaleX.Hide(); ScaleY.Hide(); ScaleZ.Hide();
        }
        private void hideColor()
        {
            label10.Hide(); label11.Hide(); label12.Hide();
            label13.Hide(); 
            R.Hide(); G.Hide(); B.Hide();
            A.Hide();
            Color_button.Hide();
        }
        private void hideBoolean()
        {
            BooleanStatus.Hide();
        }
        private void editByZDType(float ZDProType)
        {

        }
        private void editByZDType(bool ZDProType)
        {

        }
        private void editByZDType(int ZDProType)
        {

        }
        public object Clone()
        {
            return new ZDNode() as object;
        }
        //添加
        private void Confirm_Edit(object sender, EventArgs e)
        {
            var ProName = PropertiseName.Text;
            var Proinstance = nodeGraph2.Nodes[Member];
            var ZDProType = nodeGraph2.Nodes[Member].Properties[EditedPropertise].DependencyObjectType.Name;
            var properitem = (Member + "," + EditedPropertise + "," + ChoosedPropertise.Text).ToString();
            if (ProType.Equals("ADD")){

                switch (ZDProType)
                {
                    case "ZDProperty_String":
                        if (EditedPropertise.Equals("NodeName"))
                        {
                            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                            DialogResult dr = MessageBox.Show("不可修改NodeName,若要修改请联系管理员", "退出", messButton);
                            if (dr == DialogResult.OK)  //如果点击“确定”按钮
                            {
                                this.Close();
                            }
                            else//如果点击“取消”按钮
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                         //   (Proinstance.Properties[EditedPropertise] as ZDProperty_String).Value = ChoosedPropertise.Text;
                            setFormTextValue(properitem);
                            //temp.FinalList.Items.Add(properitem);
                        }
                        this.Close();
                        break;
                    case "ZDProperty_Float":
                       // (Proinstance.Properties[EditedPropertise] as ZDProperty_Float).Value = Convert.ToSingle(ChoosedPropertise.Text);
                        setFormTextValue(properitem);

                        this.Close();
                        break;
                    case "ZDProperty_Boolean":
                        var tbool = false;
                        if (BooleanStatus.Text.Equals("true"))
                            tbool = true;
                       // (Proinstance.Properties[EditedPropertise] as ZDProperty_Boolean).Value = tbool;
                        var Boolproperitem = (Member + "," + EditedPropertise + "," + tbool).ToString();
                        setFormTextValue(Boolproperitem);
                        this.Close();

                        break;
                    case "ZDProperty_Integer":
                     //   (Proinstance.Properties[EditedPropertise] as ZDProperty_Integer).Value = Convert.ToInt32(ChoosedPropertise.Text);
                        this.Close();
                        setFormTextValue(properitem);
                        break;
                    case "ZDProperty_Transform":
                       /* (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X = Convert.ToSingle(LocationX.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y = Convert.ToSingle(LocationY.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z = Convert.ToSingle(LocationZ.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll = Convert.ToSingle(RotationRoll.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw = Convert.ToSingle(RotationYaw.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch = Convert.ToSingle(RotationPitch.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X = Convert.ToSingle(ScaleX.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y = Convert.ToSingle(ScaleY.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z = Convert.ToSingle(ScaleZ.Text);*/
                        var Transproperitem = (Member + "," + EditedPropertise + "," + LocationX.Text + "," + LocationY.Text + "," + LocationZ.Text + "," + RotationRoll.Text + "," + RotationYaw.Text + "," + RotationPitch.Text + "," + ScaleX.Text + "," + ScaleY.Text + "," + ScaleZ.Text).ToString();
                        setFormTextValue(Transproperitem);
                        this.Close();
                        break;
                    case "ZDProperty_Color":
                      /*  (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R = Convert.ToSingle(R.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G = Convert.ToSingle(G.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B = Convert.ToSingle(B.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A = Convert.ToSingle(A.Text);*/
                        var Colorproperitem = (Member + "," + EditedPropertise + "," + R.Text + "," + G.Text + "," + B.Text + "," + A.Text).ToString();

                        setFormTextValue(Colorproperitem);
                        this.Close();
                        break;
                    default: break;
                }
            }
            if (ProType.Equals("PREVIEW"))
            {
                switch (ZDProType)
                {
                    case "ZDProperty_String":
                        if (EditedPropertise.Equals("NodeName"))
                        {
                            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                            DialogResult dr = MessageBox.Show("不可修改NodeName,若要修改请联系管理员", "退出", messButton);
                            if (dr == DialogResult.OK)  //如果点击“确定”按钮
                            {
                                this.Close();
                            }
                            else//如果点击“取消”按钮
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            (Proinstance.Properties[EditedPropertise] as ZDProperty_String).Value = ChoosedPropertise.Text;
                          //  setFormTextValue(properitem);
                            //temp.FinalList.Items.Add(properitem);
                        }
                      //  this.Close();
                        break;
                    case "ZDProperty_Float":
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Float).Value = Convert.ToSingle(ChoosedPropertise.Text);
                      //  setFormTextValue(properitem);

                      //  this.Close();
                        break;
                    case "ZDProperty_Boolean":
                        var tbool = false;
                        if (BooleanStatus.Text.Equals("true"))
                            tbool = true;
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Boolean).Value = tbool;
                      //  var Boolproperitem = (Member + "," + EditedPropertise + "," + tbool).ToString();
                      //  setFormTextValue(Boolproperitem);
                      //  this.Close();

                        break;
                    case "ZDProperty_Integer":
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Integer).Value = Convert.ToInt32(ChoosedPropertise.Text);
                      //  this.Close();
                      //  setFormTextValue(properitem);
                        break;
                    case "ZDProperty_Transform":
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X = Convert.ToSingle(LocationX.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y = Convert.ToSingle(LocationY.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z = Convert.ToSingle(LocationZ.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll = Convert.ToSingle(RotationRoll.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw = Convert.ToSingle(RotationYaw.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch = Convert.ToSingle(RotationPitch.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X = Convert.ToSingle(ScaleX.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y = Convert.ToSingle(ScaleY.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z = Convert.ToSingle(ScaleZ.Text);
                      //  var Transproperitem = (Member + "," + EditedPropertise + "," + LocationX.Text + "," + LocationY.Text + "," + LocationZ.Text + "," + RotationRoll.Text + "," + RotationYaw.Text + "," + RotationPitch.Text + "," + ScaleX.Text + "," + ScaleY.Text + "," + ScaleZ.Text).ToString();
                      //  setFormTextValue(Transproperitem);
                      //  this.Close();
                        break;
                    case "ZDProperty_Color":
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R = Convert.ToSingle(R.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G = Convert.ToSingle(G.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B = Convert.ToSingle(B.Text);
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A = Convert.ToSingle(A.Text);
                     //   var Colorproperitem = (Member + "," + EditedPropertise + "," + R.Text + "," + G.Text + "," + B.Text + "," + A.Text).ToString();

                      //  setFormTextValue(Colorproperitem);
                      //  this.Close();
                        break;
                    default: break;
                }
            }

        }

        private void BooleanChange(object sender, EventArgs e)
        {
            if (BooleanStatus.Text.Equals("true"))
            {
                BooleanStatus.Text = "flase";
            }
            else
            {
                BooleanStatus.Text = "true";
            }
        }

        private void CancelEdit(object sender, EventArgs e)
        {






            this.Close();
        }
        public bool LocationXispress = false;
        public bool LocationYispress = false;
        public bool LocationZispress = false;

        public bool Rispress = false;
        public bool Gispress = false;
        public bool Bispress = false;
        public bool Aispress = false;

        public float tempLocationX = 0;
        public float tempLocationY = 0;
        public float tempLocationZ = 0;
       
        public float tempR = 0;
        public float tempG = 0;
        public float tempB = 0;
        public float tempA = 0;


        private void R_MouseMove(object sender, MouseEventArgs e)
        {
            if (Rispress)
            {
                Point point = R.PointToClient(Control.MousePosition);
                if ((point.X + tempR) < 0)
                {
                    R.Text = "0";
                }else if ((point.X + tempR) >255)
                {
                    R.Text = "255";
                }
                else
                {
                    R.Text = (point.X + tempR).ToString();
                    var Proinstance = nodeGraph2.Nodes[Member];
                    if (ProType.Equals("ADD")) { }
                    else
                    {
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R = Convert.ToSingle(R.Text);
                    }
                }
            }
        }
        private void R_MouseDown(object sender, MouseEventArgs e)
        {
            tempR = Convert.ToSingle(R.Text);
            Rispress = true;
        }
        private void R_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            Rispress = false;
        }




        private void G_MouseMove(object sender, MouseEventArgs e)
        {
            if (Gispress)
            {
                Point point = G.PointToClient(Control.MousePosition);
                if ((point.X + tempG) < 0)
                {
                    G.Text = "0";
                }
                else if ((point.X + tempG) > 255)
                {
                    G.Text = "255";
                }
                else
                {
                    G.Text = (point.X + tempG).ToString();
                    var Proinstance = nodeGraph2.Nodes[Member];
                    if (ProType.Equals("ADD")) { }
                    else
                    {
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G = Convert.ToSingle(G.Text);
                    }
                }
            }
        }
        private void G_MouseDown(object sender, MouseEventArgs e)
        {
            tempG = Convert.ToSingle(G.Text);
            Gispress = true;
        }
        private void G_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            Gispress = false;
        }
        private void B_MouseMove(object sender, MouseEventArgs e)
        {
            if (Bispress)
            {
                Point point = B.PointToClient(Control.MousePosition);
                if ((point.X + tempB) < 0)
                {
                    B.Text = "0";
                }
                else if ((point.X + tempB) > 255)
                {
                    B.Text = "255";
                }
                else
                {
                    B.Text = (point.X + tempB).ToString();
                    var Proinstance = nodeGraph2.Nodes[Member];
                    if (ProType.Equals("ADD")) { }
                    else
                    {
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B = Convert.ToSingle(B.Text);
                    }
                }
            }
        }
        private void B_MouseDown(object sender, MouseEventArgs e)
        {
            tempB = Convert.ToSingle(B.Text);
            Bispress = true;
        }
        private void B_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            Bispress = false;
        }

        private void A_MouseMove(object sender, MouseEventArgs e)
        {
            if (Aispress)
            {
                Point point = A.PointToClient(Control.MousePosition);
                if ((point.X + tempA) < 0)
                {
                    A.Text = "0";
                }
                else if ((point.X + tempA) > 255)
                {
                    A.Text = "255";
                }
                else
                {
                    A.Text = (point.X + tempA).ToString();
                    var Proinstance = nodeGraph2.Nodes[Member];
                    if (ProType.Equals("ADD")) { }
                    else
                    {
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A = Convert.ToSingle(A.Text);
                    }
                }
            }
        }
        private void A_MouseDown(object sender, MouseEventArgs e)
        {
            tempA = Convert.ToSingle(A.Text);
            Aispress = true;
        }
        private void A_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            Aispress = false;
        }

        private void LocationX_MouseMove(object sender, MouseEventArgs e)
        {
            if (LocationXispress)
            {
                Point point = LocationX.PointToClient(Control.MousePosition);

                LocationX.Text = (point.X + tempLocationX).ToString();
                var Proinstance=nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X = Convert.ToSingle(LocationX.Text);
                }
            }
        }
        private void LocationX_MouseDown(object sender, MouseEventArgs e) {
            tempLocationX = Convert.ToSingle(LocationX.Text);
            LocationXispress = true; }
        private void LocationX_MouseUp(object sender, MouseEventArgs e)
        {
           // tempLocationX = Convert.ToSingle(LocationX.Text);
            LocationXispress = false;
        }


        private void LocationY_MouseMove(object sender, MouseEventArgs e)
        {
            if (LocationYispress)
            {
                Point point = LocationY.PointToClient(Control.MousePosition);

                LocationY.Text = (point.X + tempLocationY).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y = Convert.ToSingle(LocationY.Text);
                }
            }
        }
        private void LocationY_MouseDown(object sender, MouseEventArgs e)
        {
            tempLocationY = Convert.ToSingle(LocationY.Text);
            LocationYispress = true;
        }
        private void LocationY_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            LocationYispress = false;
        }

        private void LocationZ_MouseMove(object sender, MouseEventArgs e)
        {
            if (LocationZispress)
            {
                Point point = LocationZ.PointToClient(Control.MousePosition);

                LocationZ.Text = (point.X + tempLocationZ).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z = Convert.ToSingle(LocationZ.Text);
                }
            }
        }
        private void LocationZ_MouseDown(object sender, MouseEventArgs e)
        {
            tempLocationZ = Convert.ToSingle(LocationZ.Text);
            LocationZispress = true;
        }
        private void LocationZ_MouseUp(object sender, MouseEventArgs e)
        {
            // tempLocationX = Convert.ToSingle(LocationX.Text);
            LocationZispress = false;
        }
        public bool RotationRollispress = false;
        public bool RotationYawispress = false;
        public bool RotationPitchispress = false;
        public bool ScaleXispress = false;
        public bool ScaleYispress = false;
        public bool ScaleZispress = false;
        public float tempRotationRoll = 0;
        public float tempRotationYaw = 0;
        public float tempRotationPitch = 0;
        public float tempScaleX = 0;
        public float tempScaleY = 0;
        public float tempScaleZ = 0;
        private void RotationRoll_MouseMove(object sender, MouseEventArgs e) {
            if (RotationRollispress)
            {
                Point point = RotationRoll.PointToClient(Control.MousePosition);
                RotationRoll.Text = (point.X + tempRotationRoll).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll = Convert.ToSingle(RotationRoll.Text);
                }
            }
        }
        private void RotationRoll_MouseDown(object sender,MouseEventArgs e){
            tempRotationRoll = Convert.ToSingle(RotationRoll.Text);
            RotationRollispress = true;
        }
        private void RotationRoll_MouseUp(object sender,MouseEventArgs e){
            RotationRollispress = false;
        }

        private void RotationYaw_MouseMove(object sender, MouseEventArgs e)
        {
            if (RotationYawispress)
            {
                Point point = RotationYaw.PointToClient(Control.MousePosition);
                RotationYaw.Text = (point.X + tempRotationYaw).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw = Convert.ToSingle(RotationYaw.Text);
                }
            }
        }
        private void RotationYaw_MouseDown(object sender, MouseEventArgs e)
        {
            tempRotationRoll = Convert.ToSingle(RotationYaw.Text);
            RotationYawispress = true;
        }
        private void RotationYaw_MouseUp(object sender, MouseEventArgs e)
        {
            RotationYawispress = false;
        }

        private void RotationPitch_MouseMove(object sender, MouseEventArgs e)
        {
            if (RotationPitchispress)
            {
                Point point = RotationPitch.PointToClient(Control.MousePosition);
                RotationPitch.Text = (point.X + tempRotationPitch).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch = Convert.ToSingle(RotationPitch.Text);
                }
            }
        }
        private void RotationPitch_MouseDown(object sender, MouseEventArgs e)
        {
            tempRotationPitch = Convert.ToSingle(RotationPitch.Text);
            RotationPitchispress = true;
        }
        private void RotationPitch_MouseUp(object sender, MouseEventArgs e)
        {
            RotationPitchispress = false;
        }

        private void ScaleX_MouseMove(object sender, MouseEventArgs e)
        {
            if (ScaleXispress)
            {
                Point point = ScaleX.PointToClient(Control.MousePosition);
                ScaleX.Text = (point.X + tempScaleX).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X = Convert.ToSingle(ScaleX.Text);
                }
            }
        }
        private void ScaleX_MouseDown(object sender, MouseEventArgs e)
        {
            tempScaleX = Convert.ToSingle(ScaleX.Text);
            ScaleXispress = true;
        }
        private void ScaleX_MouseUp(object sender, MouseEventArgs e)
        {
            ScaleXispress = false;
        }

        private void ScaleY_MouseMove(object sender, MouseEventArgs e)
        {
            if (ScaleYispress)
            {
                Point point = ScaleY.PointToClient(Control.MousePosition);
                ScaleY.Text = (point.X + tempScaleY).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y = Convert.ToSingle(ScaleY.Text);
                }
            }
        }
        private void ScaleY_MouseDown(object sender, MouseEventArgs e)
        {
            tempScaleY = Convert.ToSingle(ScaleY.Text);
            ScaleYispress = true;
        }
        private void ScaleY_MouseUp(object sender, MouseEventArgs e)
        {
            ScaleYispress = false;
        }

        private void ScaleZ_MouseMove(object sender, MouseEventArgs e)
        {
            if (ScaleZispress)
            {
                Point point = ScaleZ.PointToClient(Control.MousePosition);
                ScaleZ.Text = (point.X + tempScaleZ).ToString();
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z = Convert.ToSingle(ScaleZ.Text);
                }
            }
        }
        private void ScaleZ_MouseDown(object sender, MouseEventArgs e)
        {
            tempScaleZ = Convert.ToSingle(ScaleZ.Text);
            ScaleZispress = true;
        }
        /*
        private string OriginalString;
        private float OriginalFloat;
        private Boolean OriginalBoolean;
        private int OriginalInt;
        private float TransLocationX;
        private float TransLocationY;
        private float TransLocationZ;
        private float TransRotationRoll;
        private float TransRotationYaw;
        private float TransRotationPitch;
        private float TransScaleX;
        private float TransScaleY;
        private float TransScaleZ;
        private float ColorR;
        private float ColorG;
        private float ColorB;
        private float ColorA;*/
        private void ReSet_Click(object sender, EventArgs e)
        {
            var Proinstance = nodeGraph2.Nodes[Member];
            var ZDProType = nodeGraph2.Nodes[Member].Properties[EditedPropertise].DependencyObjectType.Name;
            switch (ZDProType)
            {
                case "ZDProperty_String":
                    if (EditedPropertise.Equals("NodeName"))
                    {
                        MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
                        DialogResult dr = MessageBox.Show("不可修改NodeName,若要修改请联系管理员", "退出", messButton);
                        if (dr == DialogResult.OK)  //如果点击“确定”按钮
                        {
                            this.Close();
                        }
                        else//如果点击“取消”按钮
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        (Proinstance.Properties[EditedPropertise] as ZDProperty_String).Value = OriginalString;
                        this.Close();

                    }
                    this.Close();
                    break;
                case "ZDProperty_Float":
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Float).Value = OriginalFloat;
                    this.Close();
                    break;
                case "ZDProperty_Boolean":
                   
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Boolean).Value = OriginalBoolean;
                    if (OriginalBoolean)
                    {
                        BooleanStatus.Text = "true";
                    }
                    else
                    {
                        BooleanStatus.Text = "false";
                    }
                    this.Close();
                    break;
                case "ZDProperty_Integer":
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Integer).Value =OriginalInt;
                    this.Close();
                    break;
                case "ZDProperty_Transform":
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.X = TransLocationX;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Y = TransLocationY;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Location.Z = TransLocationZ;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Roll = TransRotationRoll;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Yaw = TransRotationYaw;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Rotation.Pitch = TransRotationPitch;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.X = TransScaleX;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Y = TransScaleY;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Transform).Value.Scale.Z = TransScaleZ;
                    this.Close();
                    break;
                case "ZDProperty_Color":
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R = ColorR;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G = ColorG;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B = ColorB;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A = ColorA;
                    this.Close();
                    break;
                default: break;
            }
           
        }
        private void Color_button1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDia = new ColorDialog();

            if (colorDia.ShowDialog() == DialogResult.OK)
            {
                //获取所选择的颜色
                Color colorChoosed = colorDia.Color;
                var DiyR = colorChoosed.R.ToString();
                var DiyG = colorChoosed.G.ToString();
                var DiyB = colorChoosed.B.ToString();
                var DiyA = colorChoosed.A.ToString();
           //     MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
             //   DialogResult dr = MessageBox.Show(DiyR + "," + DiyG + "," + DiyB + "," + DiyA);
                R.Text = DiyR;
                G.Text = DiyG;
                B.Text = DiyB;
                A.Text = DiyA;
                var Proinstance = nodeGraph2.Nodes[Member];
                if (ProType.Equals("ADD")) { }
                else
                {
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.R = colorChoosed.R;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.G = colorChoosed.G;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.B = colorChoosed.B;
                    (Proinstance.Properties[EditedPropertise] as ZDProperty_Color).Value.A = colorChoosed.A;
                }
            }
        }

        private void ScaleZ_MouseUp(object sender, MouseEventArgs e)
        {
            ScaleZispress = false;
        }
    }
}
