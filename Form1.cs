using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using ZDCore;
using ZDCore.Model;
using ZDNodeSystem.Model;
using System.Collections.Generic;
using System.Linq;
/*using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
*/
namespace ZDWindowsFormsTest
{
	// Required Reference DLL's.
	// ZDCore.dll
	// ZDLog.dll
	// ZDNetwork.dll
	// ZDNodeSystem.dll
	// WindowsBase

	public partial class Form1 : Form
    {
		// This is our node graph instance. Create it.
        private ZDRootNodeGraph nodeGraph = new ZDRootNodeGraph();
        public Form1 form1;
        public string FinalListBeforeCombine;
        public string FinaListCombined;
        static int FinalListIndex;
        private bool FormStatusMark=false;
        public  Dictionary<string, ZDNode> dict = new Dictionary<string, ZDNode>();
        AutoSizeForm asf = new AutoSizeForm();
        public Form1()
        {
            InitializeComponent();

            ZDStudioWorld aWorld = new ZDStudioWorld(5, 2);

            nodeGraph.World = aWorld;
           // this.BackgroundImage = Image.FromFile(@"test.png");
          //  this.BackgroundImage = this.imageList1.Images[0]
            // Now initialize some properties & events.
         //   nodeGraph.NetworkIPAddress = "127.0.0.1"; // default ip is 127.0.0.1
		//	nodeGraph.NetworkPort = 6666; // default port is 6666
            nodeGraph.ConnectionClosed += NodeGraph_ConnectionClosed;
			nodeGraph.ConnectionEstablished += NodeGraph_ConnectionEstablished;
            MaterialList.Items.Add("1");
            MaterialList.Items.Add("2");
            MaterialList.Items.Add("3");
            MaterialList.Items.Add("4");
            MaterialList.Items.Add("5");

        }
        private ListBox lbSource = null;//拖拽数据来源
        private void NodeGraph_ConnectionEstablished(object sender, EventArgs e)
		{
			// connection established does not mean you have all the nodes at the moment.
			// it'll take time for node graph to update the nodes inside of it.
		}

		private void NodeGraph_ConnectionClosed(object sender, EventArgs e)
        {
			// whenever connection has gone, nodegraph.Nodes does not have any nodes.
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
			// this is our connection address.
			nodeGraph.NetworkIPAddress = "127.0.0.1";
			nodeGraph.NetworkPort = 6666;
            nodeGraph.Connect();
         
        }

        private void Form1_PropertyChanged(object sender, ZDNodeMemberEventArgs e)
		{
			var node = sender as ZDNode;
			// (node.Properties[e.MemberName, e.Index] as ZDProperty_Transform).Value
		}

		private void Value_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{

		}
		private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //clear list
        private void button3_Click(object sender, EventArgs e)
		{
            // get a function from a node.
            //	var function = nodeGraph.Nodes["CarElevator"].Functions["Open"];
            // set its properties.. 
            //	(function.Properties["Duration"] as ZDProperty_Float).Value = 5; // seconds
            // (function.Properties["EaseExponent"] as ZDProperty_Float).Value = 0.25f;
            FinalList.Items.Clear();
           FinalListBeforeCombine="";
         FinaListCombined="";
        // etc...
        // Send the network message to call the function on that node.
        //  nodeGraph.RequestCallNodeFunction("CarElevator", function);
    }

		private void timer1_Tick(object sender, EventArgs e)
		{
			// timer tick updates the node graph's node's state.
			if (nodeGraph.NetworkState == ZDNodeGraphNetworkState.Connected)
			{
                // Retrieve node graph nodes&classes&functions&properties and update the list boxes.

                //	label1.Text = "CONNECTED";
                //#####Color LightChange######如果连接灯的颜色改变
                StatusLight.BackColor = Color.FromArgb(24,242,39);

                foreach (var node in nodeGraph.Nodes)
				{
					if (!MaterialList.Items.Contains(node.MemberHolderName))
					{
                        if(node.DependencyObjectType.Name.Equals("ZDNode"))
						MaterialList.Items.Add(node.MemberHolderName);
					}
				}
				foreach (var item in MaterialList.Items)
				{
					if (nodeGraph.Nodes[item.ToString()] == null)
					{
						MaterialList.Items.Remove(item);
						break;
					}
				}

			/*	foreach (var nodeClass in nodeGraph.NodeClasses)
				{
					if (!listBox2.Items.Contains(nodeClass.NodeClassName))
					{
						listBox2.Items.Add(nodeClass.NodeClassName);
					}
				}*/

				var mixerNode = nodeGraph.Nodes["Mixer Default"];
				if (mixerNode != null)
				{
					foreach (var inputPin in mixerNode.InputPins)
					{
						if (inputPin.PinData == "Channel")
						{
						/*	if (!listBox3.Items.Contains(inputPin.PinName))
							{
								listBox3.Items.Add(inputPin.PinName);
							}
                            */
						}
					}
				}
			}
		}

       private void Animate_DragDrop(object sender, DragEventArgs e){            //GetDataPresent()确定此实例中存储的数据是否与指定的格式关联，或是否可以转换成指定的格式。 
            if (e.Data.GetDataPresent(DataFormats.StringFormat)){
                AnimateList.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            }
        }
//endregion        #region ListBox2拖拽   

        //首先执行1.当鼠标被按下时候发生      
        private void Aniamte_MouseDown(object sender, MouseEventArgs e){
            int index = AnimateList.SelectedIndex;//为-1表示没选中      
          
            if (index == -1){
                return;
            }
          
           
            string s = ((ListBox)sender).Items[index].ToString();//通过index索引找到的项，其实还是那个选中项     
           lbSource = AnimateList;            // DragDropEffects  指定拖放操作的可能效果      
           DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.Move);//2.开始拖拽操作，s为要拖拽的数据:当执行这句话时候开始拖拽，然后系统会转到drag事件里，顺序：dragEnter-->dragDragDrop，完成后会调回。如果在下一句打断点会卡死      
          
            /* if (dde1 == DragDropEffects.Move)//如果移动成功            
            {
                ((ListBox)sender).Items.RemoveAt(index);//是把自己位置的删除掉       
            }
            */
        }       
        //3.在用鼠标将某项拖拽到该控件的工作区时发生    
        private void FinalList_DragEnter(object sender, DragEventArgs e){            //GetDataPresent()确定此实例中存储的数据是否与指定的格式关联，或是否可以转换成指定的格式。      
            if (e.Data.GetDataPresent(DataFormats.Text) && (lbSource != FinalList))//是文本格式，并且拖动源不是当前listbox。    
            {
                e.Effect = DragDropEffects.Move;
            }
            else {
                e.Effect = DragDropEffects.None;
            }
        }        //4拖拽操作完成时发生   
        private void FinalList_DragDrop(object sender, DragEventArgs e){
            //GetDataPresent()确定此实例中存储的数据是否与指定的格式关联，或是否可以转换成指定的格式。   
            if (MaterialList.SelectedItems.Count > 0)
            {
                var selectedmemberName = MaterialList.SelectedItem.ToString();
                if (e.Data.GetDataPresent(DataFormats.StringFormat))
                {

                 //   testone.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
                    FinalList.Items.Add("#"+selectedmemberName + "," + e.Data.GetData(DataFormats.StringFormat).ToString());
                }
            }
        }
     
            private void label1_Click(object sender, EventArgs e)
        {

        }

        //素材节点定位函数
        public int Nodenum_search(string name)
        {
            int num=0;
            if(nodeGraph.Nodes.Count>0)
            for(int i=0;i< nodeGraph.Nodes.Count; i++)
                    if (nodeGraph.Nodes[i].MemberHolderName.Equals(name))
                        num = i;
            return num;
        }
        //对应模板属性展列
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MaterialList.SelectedItems.Count > 0)
            {
                var selectedmemberName = MaterialList.SelectedItem.ToString();
                AnimateList.Items.Clear();
                PropertiseList.Items.Clear();
                PropertiseAddList.Items.Clear();
                AnimatePreviewList.Items.Clear();
                var number = Nodenum_search(selectedmemberName);
                if (nodeGraph.Nodes[number].Functions.Count > 0)
                    for (var z = 0; z < nodeGraph.Nodes[number].Functions.Count; z++)
                    {
                        //nodeGraph.Nodes[number].Functions[z].DisplayName = "qwe";
                        AnimateList.Items.Add(nodeGraph.Nodes[number].Functions[z].MemberName);
                        AnimatePreviewList.Items.Add(nodeGraph.Nodes[number].Functions[z].MemberName);


                    }


                //  (functionNametest.Functions[1].MemberName as ZDProperty_String).Value =;
                if (nodeGraph.Nodes[number].Properties.Count > 0)
                    for (var j = 0; j < nodeGraph.Nodes[number].Properties.Count; j++)
                    {
                        PropertiseList.Items.Add(nodeGraph.Nodes[number].Properties[j].MemberName);
                        PropertiseAddList.Items.Add(nodeGraph.Nodes[number].Properties[j].MemberName);
                        // PropertiseListAdd.Items.Add(nodeGraph.Nodes[number].Properties[j].MemberName);
                        //    ZDProperty zDProperty;
                        //   var transformChange = nodeGraph.Nodes[number];
                        //   (transformChange.Properties["Transform"] as ZDProperty_Transform).Value.Location.X=100;
                        // (transformChange.Properties["EnableChildren"] as ZDProperty_Boolean).Value = false;
                        // (function.Properties["Duration"] as ZDProperty_Float).Value = 5; // seconds
                        // nodeGraph.Nodes[number];
                        // transformChange.GetLocalValueEnumerator();
                    }
            }
        }

        private void FinalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (FinalList.SelectedItems.Count > 0)
            {
                String selectedMaterial = FinalList.SelectedItem.ToString();
                string [] ModulesBlocks = selectedMaterial.Split(new char[] { '|' });
                if (ModulesBlocks.Count()<1)
                {

                }
                else
                {

                }
              
            }
        }
        //SPACE DOWN 
        private void PressSpaceKeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyCode == Keys.Space)
            {
                //TODO:
                var finalcount = FinalList.Items.Count;
                var selectedindex = FinalList.SelectedIndex;
                
                if (selectedindex  < finalcount)
                { 
                  
                    String selectedMaterial = FinalList.SelectedItem.ToString();
                    string[] s = selectedMaterial.Split(new char[] { '|' });
                    var ExecuteNum = s.Length;
                    for(int i = 0; i < ExecuteNum; i++)
                    {
                        if (s[i][0] == '#')
                        {
                            string[] AnimateS = s[i].Split(new char[] { ',' });
                            string[] stemp = AnimateS[0].Split(new char[] { '#' });
                            AnimateExecute(stemp[1], AnimateS[1]);
                        }
                        else
                        {
                            string[] PropertiseS = s[i].Split(new char[] { ',' });
                            var Proinstance = nodeGraph.Nodes[PropertiseS[0]];
                            var ZDProType = nodeGraph.Nodes[PropertiseS[0]].Properties[PropertiseS[1]].DependencyObjectType.Name;
                            switch (ZDProType)
                            {
                                case "ZDProperty_String":
                                    if (PropertiseS[1].Equals("NodeName"))
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
                                        (Proinstance.Properties[PropertiseS[1]] as ZDProperty_String).Value = PropertiseS[2];
                                    
                                    }
                                   
                                    break;
                                case "ZDProperty_Float":
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Float).Value = Convert.ToSingle(PropertiseS[2]);
                                  

                                  
                                    break;
                                case "ZDProperty_Boolean":
                                    var tbool = false;
                                    if (PropertiseS[2].Equals("true"))
                                        tbool = true;
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Boolean).Value = tbool;
                                  

                                    break;
                                case "ZDProperty_Integer":
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Integer).Value = Convert.ToInt32(PropertiseS[2]);
                                 
                                    break;
                                case "ZDProperty_Transform":
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Location.X = Convert.ToSingle(PropertiseS[2]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Location.Y = Convert.ToSingle(PropertiseS[3]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Location.Z = Convert.ToSingle(PropertiseS[4]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Rotation.Roll = Convert.ToSingle(PropertiseS[5]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Rotation.Yaw = Convert.ToSingle(PropertiseS[6]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Rotation.Pitch = Convert.ToSingle(PropertiseS[7]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Scale.X = Convert.ToSingle(PropertiseS[8]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Scale.Y = Convert.ToSingle(PropertiseS[9]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Transform).Value.Scale.Z = Convert.ToSingle(PropertiseS[10]);
                                  
                                    break;
                                case "ZDProperty_Color":
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Color).Value.R = Convert.ToSingle(PropertiseS[2]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Color).Value.G = Convert.ToSingle(PropertiseS[3]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Color).Value.B = Convert.ToSingle(PropertiseS[4]);
                                    (Proinstance.Properties[PropertiseS[1]] as ZDProperty_Color).Value.A = Convert.ToSingle(PropertiseS[5]);
                                   
                                    break;
                                default: break;

                            }
                          
                        }
                    }

                    if (selectedindex + 1 == finalcount) {


                    }
                    else
                    {
                        FinalList.SetSelected(selectedindex + 1, true);
                    }

                }
            }
            else
            {
            }
        }

        //AnimateExecute
        private void AnimateExecute(String MaterialName,String AnimateName)
        {

            var function = nodeGraph.Nodes[MaterialName].Functions[AnimateName];
            if (dict.Count > 0)
            {
                ZDNode zdnodetemp = dict[AnimateName];
                nodeGraph.Nodes[MaterialName].Properties = zdnodetemp.Properties;
            }
            nodeGraph.RequestCallNodeFunction(MaterialName, function);
        }


        //属性实时预览列表点击事件
        private void PropertisesEditList(object sender, EventArgs e)
        {
            if (PropertiseList.SelectedItems.Count > 0 && MaterialList.SelectedItems.Count > 0)
            {
                var selectedpropertise = PropertiseList.SelectedItem.ToString();
                var selectedMember = MaterialList.SelectedItem.ToString();
                var ProperType = "PREVIEW";
                Form2 f2 = new Form2(selectedpropertise, selectedMember, nodeGraph, ProperType);
                f2.setFormTextValue += new Form2.setTextValue(form2_setFormTextValue);
                // f2.EditedPropertise = selectedpropertise;
                f2.ShowDialog(this);
            }
        }
         //属性添加列表点击事件
        private void PropertisesAddList(object sender, EventArgs e)
        {
            if (PropertiseAddList.SelectedItems.Count > 0 && MaterialList.SelectedItems.Count > 0)
            {
                var selectedpropertise = PropertiseAddList.SelectedItem.ToString();
                var selectedMember = MaterialList.SelectedItem.ToString();
                var ProperType = "ADD";
                Form2 f2 = new Form2(selectedpropertise, selectedMember, nodeGraph, ProperType);
                f2.setFormTextValue += new Form2.setTextValue(form2_setFormTextValue);
                // f2.EditedPropertise = selectedpropertise;
                f2.ShowDialog(this);
            }
        }
        void form2_setFormTextValue(string textValue)
        {
            //具体实现。
            FinalList.Items.Add(textValue);
        }
        private void 系统状态ToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private string ShowSaveFileDialog()
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog();
            //设置文件类型 
            sfd.Filter = "文本文件（*.txt）|*.txt";

            //设置默认文件类型显示顺序 
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录 
            sfd.RestoreDirectory = true;

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

               // System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

              //  fs.Flush();
              //  fs.Close();
                ////fs输出带文字或图片的文件，就看需求了 
            }

           
            return localFilePath;
        }
        private void Save_drama(object sender, EventArgs e)
        {

        }
        //listbox项合并
        private void FinaList_MouseDown(object sender, MouseEventArgs e)
        {
            FinalListIndex = FinalList.SelectedIndex;      //标记被复制的项
            if (FinalListIndex == -1) {
                if (FinalListBeforeCombine != null)
                   
                    FinalListBeforeCombine = "";
                return;
            }
            
            FinalListBeforeCombine = FinalList.Text;
        }
        private void FinaList_MouseUp(object sender, MouseEventArgs e)
        {
            if (FinalListIndex == -1) return;
            FinaListCombined = FinalList.Text + "|"+ FinalListBeforeCombine;
            int indexNow = FinalList.SelectedIndex;      //标记复制到的项
           
            if (indexNow == FinalListIndex|| indexNow == -1) return;  //不能自己复制自己 
           
                FinalList.Items.RemoveAt(indexNow);
                FinalList.Items.Insert(indexNow, FinaListCombined);
                FinalList.Items.RemoveAt(FinalListIndex);
            FinalList.ClearSelected();

        }

        private void FinaList_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void AnimateList_DoubleClick(object sender, EventArgs e)
        {

        }

        private void AnimatePreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AnimatePreviewList.SelectedItems.Count > 0 && MaterialList.SelectedItems.Count > 0)
            {
                var selectedAnimate = AnimatePreviewList.SelectedItem.ToString();
                var selectedMember = MaterialList.SelectedItem.ToString();
                AnimateExecute(selectedMember, selectedAnimate);
            }
        }
        //exit_complete
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            asf.controllInitializeSize(this);
        }
        private void Form1_Size_Change(object sender, EventArgs e)
        {
            asf.controlAutoSize(this);
        }

        private void MoveUpBt_Click(object sender, EventArgs e)
        {
            if (FinalList.SelectedItems.Count > 0)
            {
                int selectedId = FinalList.SelectedIndex;
                string insertContent = FinalList.SelectedItem.ToString();
                if (selectedId > 0)
                {

                    FinalList.Items.Insert(selectedId-1, insertContent);
                    FinalList.Items.RemoveAt(selectedId+1);
                    FinalList.SetSelected(selectedId - 1, true);
                }
            }
        }
        private void MoveDownBt_Click(object sender, EventArgs e)
        {
            if (FinalList.SelectedItems.Count > 0)
            {
                int selectedId = FinalList.SelectedIndex;
                string insertContent = FinalList.SelectedItem.ToString();
                if (selectedId <FinalList.Items.Count-1)
                {
                    FinalList.Items.RemoveAt(selectedId);
                    FinalList.Items.Insert(selectedId+1, insertContent);
                  
                    FinalList.SetSelected(selectedId+1, true);
                }
            }
         }
        private void DeleteBt_Click(object sender, EventArgs e)
        {
            if (FinalList.SelectedItems.Count > 0)
            {
                int selectedId = FinalList.SelectedIndex;
                FinalList.Items.RemoveAt(selectedId);
             /*   int[] selectid = new int[FinalList.SelectedIndex];
                for(int i = 0; i < FinalList.SelectedItems.Count; i++)
                {
                    //FinalList.Items.RemoveAt();
                }*/

            }
        }
        private Point mousePoint = new Point();

        private void panel_title_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.mousePoint.X = e.X;
            this.mousePoint.Y = e.Y;
        }

        private void panel_title_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Top = Control.MousePosition.Y - mousePoint.Y;
                this.Left = Control.MousePosition.X - mousePoint.X;
            }
        }
        //Close the window
        private void Shutdownform(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否退出？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //this.Dispose();
                Application.Exit();
            }
        }
        //minimize window
        private void Minform(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void MaxForm(object sender, EventArgs e)
        {
            if (!FormStatusMark)
            {
                this.WindowState = FormWindowState.Maximized;
                FormStatusMark = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                FormStatusMark = false;
            }
        }
      
        
   

  
    }
}
