# Reality based Video player（Zero Density）

### Description

 		This project is based on the full investigation and analysis of the current relevant radio and television markets, including major CCTV stations, and units that need program production, such as e-sports broadcast companies, film and television production units, and universities, and uses Reality (based on Unreal Engine 4 ) and WindowsForm to develop a set of efficient, practical and concise media broadcast control system.

### Main Interface and Functional structure diagram

<img src="https://tva1.sinaimg.cn/large/00831rSTly1gd339tt1zfj30rs0fu7i9.jpg" alt="WeChat04b19fdcc82f910ba04deb8baf09bce3" style="zoom:50%;" />

<center><img src="https://tva1.sinaimg.cn/large/00831rSTly1gd336d36tcj30ky0900ui.jpg" alt="WeChata403ec0e671c1a3e344950b587bb3137" style="zoom:50%;" /></center>
The main innovations of this system are as follows:

* (1) **Reality and model communication:** The system communicates data through IP and ports, connects Reality, collects model data, and uses Reality to render object models. Reality uses Unreal Engine 4 as a real-time rendering tool for screens to achieve advanced virtual and augmented reality effects. Using anti-tooth algorithm, vector field GPU particle system and depth of field, lighting HDR, screen space reflection, refraction rendering method, suitable for many different forms of broadcast and television program design, such as: real-time virtual shooting, augmented reality, online data graphics display And support 3D tracking masks for custom keying range, so as to achieve "force fill" and "eliminate overflow".
* (2) **Model motion control:** After accessing the model data read through communication, this project implements the motion control of the model within the project, such as the model animation execution motion and the corresponding effect preview.
* (3) **Portrait of the operator:** In the process of connecting the broadcast control system to Reality, the operator analyzes the data by collecting operator operation data, iterates through the machine learning model, and performs data analysis to obtain the operating habits and preferences.
* (4) **Model feature editing: **By reading the model data, get the basic attributes of the model and model actions, edit the attributes in different states of the model, update the model state preview in real time, and perform attribute presets based on the current model state, including Model space position, markers, colors, including editing of text attributes, to achieve accurate operation and positioning of the model during broadcast control operations. At the same time, the target state of the model can be set to prepare for the subsequent broadcast control operation.
* (5) **Broadcast control script arrangement / playback: **By pulling model action information and model attribute information, perform broadcast control script arrangement. The script arrangement process can modularize the existing model, and can manually pull modules based on time and logical order. Merging and moving can make it more convenient for users to arrange the programs and screens. At the same time, it is more concise to use in the broadcast state. After the script has been arranged, perform the playback operation and one-step key transfer. For domestic operators, The operation is clearer and easier to use.
* (6) **IP offloading:** In the process of connecting the broadcast control system and Reality, multiple IPs and multiple bits can be started. Different projects correspond to different connections.



> The Software copyright is under request