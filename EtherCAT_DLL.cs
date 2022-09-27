using System;
using System.Text;
using System.Runtime.InteropServices;

namespace EtherCAT_DLL
{
    public class CEtherCAT_DLL
    {


        //=========Master==============	Master Initial & Get��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Open")]
        public static extern ushort CS_ECAT_Master_Open(ref ushort existcard);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Initial")]
        public static extern ushort CS_ECAT_Master_Initial(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Reset")]
        public static extern ushort CS_ECAT_Master_Reset(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Close")]
        public static extern ushort CS_ECAT_Master_Close();
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_CardSeq")]
        public static extern ushort CS_ECAT_Master_Get_CardSeq(ushort CardNo_seq, ref ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_SlaveNum")]
        public static extern ushort CS_ECAT_Master_Get_SlaveNum(ushort CardNo, ref ushort SlaveNum);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Slave_Info")]
        public static extern ushort CS_ECAT_Master_Get_Slave_Info(ushort CardNo, ushort SeqID, ref ushort NodeID, ref uint VendorID, ref uint ProductCode, ref uint RevisionNo, ref uint DCTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DC_Status")]
        public static extern ushort CS_ECAT_Master_Get_DC_Status(ushort CardNo, ref uint State, ref int DCTime, ref int OffsetTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Connect_Status")]
        public static extern ushort CS_ECAT_Master_Get_Connect_Status(ushort CardNo, ref ushort Status);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Api_BufferLength")]
        public static extern ushort CS_ECAT_Master_Get_Api_BufferLength(ushort CardNo, ushort NodeID, ref ushort Length);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Cycle_SpendTime")]
        public static extern ushort CS_ECAT_Master_Get_Cycle_SpendTime(ushort CardNo, ref double Tx_Time, ref double Tx_MaxTime, ref double Rx_Time, ref double Rx_MaxTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Check_Initial_Done")]
        public static extern ushort CS_ECAT_Master_Check_Initial_Done(ushort CardNo, ref ushort InitDone);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Initial_ErrorCode")]
        public static extern ushort CS_ECAT_Master_Get_Initial_ErrorCode(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Check_Working_Counter")]
        public static extern ushort CS_ECAT_Master_Check_Working_Counter(ushort CardNo, ref ushort Abnormal_Flag, ref ushort Working_Slave_Cnt);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_Return_Code_Message")]
        public static extern ushort CS_ECAT_Master_Get_Return_Code_Message(ushort ReturnCode, string Message);

        //=========Master==============	Master Config
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Set_CycleTime")]
        public static extern ushort CS_ECAT_Master_Set_CycleTime(ushort CardNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_CycleTime")]
        public static extern ushort CS_ECAT_Master_Get_CycleTime(ushort CardNo, ref ushort CycleTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DLL_SeqID")]
        public static extern ushort CS_ECAT_Master_Get_DLL_SeqID(ushort CardNo, ref ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_SerialNo")]
        public static extern ushort CS_ECAT_Master_Get_SerialNo(ushort CardNo, ref UInt32 SerialNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_NodeID_Alias_Enable")]
        public static extern ushort CS_ECAT_Master_NodeID_Alias_Enable(ushort CardNo, ushort Enable);

        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Open_File")]
        public static extern ushort CS_ECAT_Autoconfig_Open_File(ushort CardNo, string FilePath);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Save_File")]
        public static extern ushort CS_ECAT_Autoconfig_Save_File(ushort CardNo, string FilePath);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Set_Slave_DCTime")]
        public static extern ushort CS_ECAT_Autoconfig_Set_Slave_DCTime(ushort CardNo, ushort NodeID, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Clear_ConfigFile")]
        public static extern ushort CS_ECAT_Autoconfig_Clear_ConfigFile(ushort CardNo);

        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Set_NodeID_Alias")]
        public static extern ushort CS_ECAT_Autoconfig_Set_NodeID_Alias(ushort CardNo, ushort NodeID, ushort MapNodeID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Get_NodeID_Alias")]
        public static extern ushort CS_ECAT_Autoconfig_Get_NodeID_Alias(ushort CardNo, ushort RealNodeID, ref ushort MapNodeID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Autoconfig_Save_NodeID_Alias")]
        public static extern ushort CS_ECAT_Autoconfig_Save_NodeID_Alias(ushort CardNo);

        //========Normal Slave========= Slave(������)�q��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Send_Message")]
        public static extern ushort CS_ECAT_Slave_SDO_Send_Message(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Index, ushort SubIndex, ushort Datasize, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Read_Message")]
        public static extern ushort CS_ECAT_Slave_SDO_Read_Message(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Index, ushort SubIndex, ushort Datasize, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Quick_Send_Message")]
        public static extern ushort CS_ECAT_Slave_SDO_Quick_Send_Message(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Index, ushort SubIndex, ushort Datasize, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Quick_Read_Message")]
        public static extern ushort CS_ECAT_Slave_SDO_Quick_Read_Message(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Index, ushort SubIndex, ushort Datasize);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Read_Response")]
        public static extern ushort CS_ECAT_Slave_SDO_Read_Response(ushort CardNo, ushort NodeID, ushort SlotID, ref ushort Done, ref byte Data, ref UInt32 ErrorCode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Wait_All_Done")]
        public static extern ushort CS_ECAT_Slave_SDO_Wait_All_Done(ushort CardNo, ushort AxisNum, ref ushort NodeID, ref ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Check_Done")]
        public static extern ushort CS_ECAT_Slave_SDO_Check_Done(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Done);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_SDO_Get_ErrorCode")]
        public static extern ushort CS_ECAT_Slave_SDO_Get_ErrorCode(ushort CardNo, ushort NodeID, ushort SlotNo, ref uint ErrorCode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Get_OD_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Get_OD_Data(ushort CardNo, ushort NodeID, ushort SlotNo, ushort IOType, ushort ODIndex, ushort ODSubIndex, ushort ByteSize, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Set_OD_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Set_OD_Data(ushort CardNo, ushort NodeID, ushort SlotNo, ushort ODIndex, ushort ODSubIndex, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Get_Information")]
        public static extern ushort CS_ECAT_Slave_PDO_Get_Information(ushort CardNo, ushort NodeID, ushort SlotNo, ushort IOType, ref ushort ODCnt, ref ushort StartIndex);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Get_Detail_Mapping")]
        public static extern ushort CS_ECAT_Slave_PDO_Get_Detail_Mapping(ushort CardNo, ushort NodeID, ushort SlotNo, ushort IOType, ushort ODSeqID, ref ushort ODIndex, ref ushort ODsubIndex, ref ushort ODBitSize, ref ushort ODStartIndex);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Get_Rx_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Get_Rx_Data(ushort CardNo, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Get_Tx_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Get_Tx_Data(ushort CardNo, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Set_Tx_Detail_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Set_Tx_Detail_Data(ushort CardNo, ushort NodeID, ushort SlotNo, ushort ODStartIndex, ushort Bytesize, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PDO_Set_Tx_Data")]
        public static extern ushort CS_ECAT_Slave_PDO_Set_Tx_Data(ushort CardNo, ref byte Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Get_EMCY_Data")]
        public static extern ushort CS_ECAT_Slave_Get_EMCY_Data(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort ErrorCode, ref byte ErrorRegister, byte[] Data);


        //========Motion Salve========= Slave(Motion����)�q��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_MoveMode")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_MoveMode(ushort CardNo, ushort NodeID, ushort SlotNo, ref byte Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_ControlWord")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_ControlWord(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort ControllWord);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_StatusWord")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_StatusWord(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort StatusWord);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Command")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Command(ushort CardNo, ushort NodeID, ushort SlotNo, ref int Cmd);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Position")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Position(ushort CardNo, ushort NodeID, ushort SlotNo, ref int Pos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Actual_Command")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Actual_Command(ushort CardNo, ushort NodeID, ushort SlotNo, ref int ActualCommand);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Actual_Position")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Actual_Position(ushort CardNo, ushort NodeID, ushort SlotNo, ref int ActualPosition);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Mdone")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Mdone(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Mdone);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Current_Speed")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Current_Speed(ushort CardNo, ushort NodeID, ushort SlotNo, ref int Speed);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Torque")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Torque(ushort CardNo, ushort NodeID, ushort SlotNo, ref short Torque);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Target_Command")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Target_Command(ushort CardNo, ushort NodeID, ushort SlotNo, ref int TargetCommand);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_Buffer_Length")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_Buffer_Length(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort BufferLength);

        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_MoveMode")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_MoveMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort OpMode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_Svon")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_Svon(ushort CardNo, ushort NodeID, ushort SlotNo, ushort On_Off);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Ralm")]
        public static extern ushort CS_ECAT_Slave_Motion_Ralm(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_Position")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_Position(ushort CardNo, ushort NodeID, ushort SlotNo, int Pos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_Command")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_Command(ushort CardNo, ushort NodeID, ushort SlotNo, int Cmd);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Emg_Stop")]
        public static extern ushort CS_ECAT_Slave_Motion_Emg_Stop(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Sd_Stop")]
        public static extern ushort CS_ECAT_Slave_Motion_Sd_Stop(ushort CardNo, ushort NodeID, ushort SlotNo, double Tdec);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_Alm_Reaction")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_Alm_Reaction(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Fault_Type, ushort WR_Type);

        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_TouchProbe_Config")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_TouchProbe_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort TriggerMode, ushort Signal_Source);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_TouchProbe_QuickStart")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_TouchProbe_QuickStart(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_TouchProbe_QuickDone")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_TouchProbe_QuickDone(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Set_TouchProbe_Disable")]
        public static extern ushort CS_ECAT_Slave_Motion_Set_TouchProbe_Disable(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_TouchProbe_Status")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_TouchProbe_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Status);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Motion_Get_TouchProbe_Position")]
        public static extern ushort CS_ECAT_Slave_Motion_Get_TouchProbe_Position(ushort CardNo, ushort NodeID, ushort SlotNo, ref int LatchPosition);

        //========Motion Salve CSP Command======== Slave(Motion����) CSP�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int Dist, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_V_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_V_Move(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Dir, int StrVel, int ConstVel, double Tacc, ushort m_curve);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Arc_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Arc_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotNo, ref int CenterPoint, double Angle, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Arc2_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Arc2_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotNo, ref int EndPoint, double Angle, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Arc3_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Arc3_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotNo, ref int CenterPoint, ref int EndPoint, ushort Dir, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Spiral_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Spiral_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotID, ref int CenterPoint, int Spiral_Interval, double Angle, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_Curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Spiral2_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Spiral2_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotID, ref int CenterPoint, ref int EndPoint, ushort Dir, ushort CycleNum, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_Curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Sphere_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Sphere_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotNo, ref int Target1Point, ref int Target2Point, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Heli_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Heli_Move(ushort CardNo, ref ushort NodeID, ref ushort SlotNo, ref int CenterPoint, int Depth, int Pitch, ushort Dir, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Msbrline_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Msbrline_Move(ushort CardNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ushort ArcNodeBit, ref int Target1Point, ref int Target2Point, ushort Mode, double Parameter, double ArcAngle1, double ArcAngle2, double SpdRatio, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Mabrline_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Mabrline_Move(ushort CardNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ref int Target1Point, ref int Target2Point, int StrVel, int FirstVel, int SecondVel, int EndVel, double Tacc_Step1, double Tacc_Step2, ushort Absflag);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_Multiaxes_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_Multiaxes_Move(ushort CardNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ref int Dist, int StrVel, int ConstVel, int EndVel, double Tacc, double Tdec, ushort m_curve, ushort m_abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_2Segment_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_2Segment_Move(ushort CardNo, ushort NodeID, ushort SlotNo, ushort SegMode, int Dist, int Dist2, int StrVel, int MaxVel, int MaxVel2, int EndVel, double Tacc, double Tsec, double Tdec, ushort SCurve, ushort IsAbs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_PVT_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_PVT_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int DataCnt, ref int TargetPos, ref int TargetTime, ref int TargetVel);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_PVTComplete_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_PVTComplete_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int DataCnt, ref int TargetPos, ref int TargetTime, int StrVel, int EndVel);
        //========Motion Slave ECAM Set========= Slave(Motion����) CSP�Ҧ��]�w��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_Parameters")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_Parameters(ushort CardNo, ushort ECAMNo, int Gear_numerator, int Gear_denominator, double Slave_mm_PUU, double Master_mm_Pulse, ushort Engage_Mode, int Engage_PreLed, int Cycle_PreLead, int DisEngage_Position, ushort DI_DisEngage, ushort DisEngage_Mode, ushort DisEngage_TurnOff);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_SingleMove")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_SingleMove(ushort CardNo, ushort ECAMNo, int Dist, int ConstVel, int EndVel, double Tacc, double Tdec, ushort Abs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Disable")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Disable(ushort CardNo, ushort ECAMNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Get_Status")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Get_Status(ushort CardNo, ushort ECAMNo, ref ushort Status);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_MasterSource")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_MasterSource(ushort CardNo, ushort ECAMNo, ushort SourceType, ushort MasterNodeID, ushort MasterSlotID, ushort Master_Source);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_EngageSource")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_EngageSource(ushort CardNo, ushort ECAMNo, ushort SourceType, ushort NodeID, ushort SlotID, ushort SourceNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_CompensateSource")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_CompensateSource(ushort CardNo, ushort ECAMNo, ushort SourceType, ushort NodeID, ushort SlotID, ushort SourceNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Set_Compensate_Parameters")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Set_Compensate_Parameters(ushort CardNo, ushort ECAMNo, int TargetPos, int Max_Compensate_Ratio, int MaskRatio, double CompensateTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Table_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Table_Move(ushort CardNo, ushort ECAMNo, ushort NodeID, ushort SlotID, int RegionNum, ref int DataArray, int Master_Pulse);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Velocity_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Velocity_Move(ushort CardNo, ushort ECAMNo, ushort NodeID, ushort SlotID, int RegionNum, ref int[] Percent, int SCurveRegion, int TotalLength, int Master_Pulse_P, ushort Construct_Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Flying_Shears_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Flying_Shears_Move(ushort CardNo, ushort ECAMNo, ushort NodeID, ushort SlotID, double GearNum_A, double GearNum_B, int KnifeNUm, double SlaveDiameter, double EncoderDiameter, int EncoderPulseRev, int SlavePUURev, int CutLength, int RegionNum, ref int[]region, int Slave_Prelead, ushort PreLeadMode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Start_ECAM_Intermittence_Print_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Start_ECAM_Intermittence_Print_Move(ushort CardNo, ushort ECAMNo, ushort NodeID, ushort SlotID, int RegionNum, int PrintLength, int BlankLength, double GearNum_A, double GearNum_B, int SlavePUURev, double SlaveDiameter, int MasterPulseRev, double MasterDiameter, int HoldingAreaDeg, int SCurveDeg, int SynIncreaseDeg);

        //========Motion Slave CSV Command====== Slave(Motion����) CSV�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSV_Start_Move")]
        public static extern ushort CS_ECAT_Slave_CSV_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int Target_Velocity, double Acceleration, ushort Curve_Mode, ushort Acc_Type);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSV_Multi_Start_Move")]
        public static extern ushort CS_ECAT_Slave_CSV_Multi_Start_Move(ushort CardNo, ushort AxisNum, ref ushort NodeID, ref ushort SlotNo, ref int Target_Velocity, ref double Acceleration, ushort Curve_Mode, ushort Acc_Type);

        //========Motion Slave CSV Command====== Slave(Motion����) CSV�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CST_Start_Move")]
        public static extern ushort CS_ECAT_Slave_CST_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, short Target_Torque, uint Slope, ushort Curve_Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CST_Multi_Start_Move")]
        public static extern ushort CS_ECAT_Slave_CST_Multi_Start_Move(ushort CardNo, ushort AxisNum, ref ushort NodeID, ref ushort SlotNo, ref short Target_Torque, ref uint Slope, ushort Curve_Mode);

        //========Motion Slave CSP Set========= Slave(Motion����) CSP�Ҧ��]�w��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Set_Gear")]
        public static extern ushort CS_ECAT_Slave_CSP_Set_Gear(ushort CardNo, ushort NodeID, ushort SlotNo, double Numerator, double Denominator, short Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Set_Softlimit")]
        public static extern ushort CS_ECAT_Slave_CSP_Set_Softlimit(ushort CardNo, ushort NodeID, ushort SlotNo, int PosiLimit, int NegaLimit, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_TargetPos_Change")]
        public static extern ushort CS_ECAT_Slave_CSP_TargetPos_Change(ushort CardNo, ushort NodeID, ushort SlotNo, int NewPos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Velocity_Change")]
        public static extern ushort CS_ECAT_Slave_CSP_Velocity_Change(ushort CardNo, ushort NodeID, ushort SlotNo, int NewSpeed, double Tsec);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Feedrate_Overwrite")]
        public static extern ushort CS_ECAT_Slave_CSP_Feedrate_Overwrite(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode, int NewSpeed, double Tsec);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Speed_Continue_Enable")]
        public static extern ushort CS_ECAT_Slave_CSP_Speed_Continue_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Speed_Continue_Set_Mode")]
        public static extern ushort CS_ECAT_Slave_CSP_Speed_Continue_Set_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Speed_Continue_Set_Combine_Ratio")]
        public static extern ushort CS_ECAT_Slave_CSP_Speed_Continue_Set_Combine_Ratio(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Ratio);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Scurve_Rate")]
        public static extern ushort CS_ECAT_Slave_CSP_Scurve_Rate(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Scurve_Rate);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Linear_Speed_Master")]
        public static extern ushort CS_ECAT_Slave_CSP_Linear_Speed_Master(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Mask_Axis")]
        public static extern ushort CS_ECAT_Slave_CSP_Mask_Axis(ushort CardNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotNoArray);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Sync_Config")]
        public static extern ushort CS_ECAT_Slave_CSP_Sync_Config(ushort CardNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Sync_Move")]
        public static extern ushort CS_ECAT_Slave_CSP_Sync_Move(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Virtual_Set_Enable")]
        public static extern ushort CS_ECAT_Slave_CSP_Virtual_Set_Enable(ushort CardNo, ushort NodeID, ushort SlotID, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Virtual_Set_Command")]
        public static extern ushort CS_ECAT_Slave_CSP_Virtual_Set_Command(ushort CardNo, ushort NodeID, ushort SlotID, int Command);
        

        //========Motion Slave CSP Get========= Slave(Motion����) CSP�Ҧ����o��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Get_SoftLimit_Status")]
        public static extern ushort CS_ECAT_Slave_CSP_Get_SoftLimit_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Status);

        //========Motion Slave CSP TargetReach========= Slave(Motion����) CSP�Ҧ���
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Set_SoftTargetReach")]
        public static extern ushort CS_ECAT_Slave_CSP_Set_SoftTargetReach(ushort CardNo, ushort NodeID, ushort SlotID, ushort Window_Time, uint Position_Window, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Get_SoftTargetReach_Status")]
        public static extern ushort CS_ECAT_Slave_CSP_Get_SoftTargetReach_Status(ushort CardNo, ushort NodeID, ushort SlotID, ref ushort Status);
       
        
        //========Motion Slave CSP Pitch========= Slave(Motion����) CSP�Ҧ����o��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_InterVal")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_InterVal(ushort CardNo, ushort NodeID, ushort SlotID, uint InterVal);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_Mode")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_Mode(ushort CardNo, ushort NodeID, ushort SlotID, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_Org")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_Org(ushort CardNo, ushort NodeID, ushort SlotID, ushort Dir, int OrgPos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_Rel_Table")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_Rel_Table(ushort CardNo, ushort NodeID, ushort SlotID, ushort Dir, ref int table, ushort Num);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_Abs_Table")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_Abs_Table(ushort CardNo, ushort NodeID, ushort SlotID, ushort Dir, ref int table, ushort Num);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Pitch_Set_Enable")]
        public static extern ushort CS_ECAT_Slave_CSP_Pitch_Set_Enable(ushort CardNo, ushort NodeID, ushort SlotID, ushort Enable);
        
        
        //========Motion Slave CSP Backlash========= Slave(Motion����) CSP�Ҧ���
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Backlash_Set_Info")]
        public static extern ushort CS_ECAT_Slave_CSP_Backlash_Set_Info(ushort CardNo, ushort NodeID, ushort SlotID, short Backlash, ushort AccStep, ushort ConstStep, ushort DecStep);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_CSP_Backlash_Enable")]
        public static extern ushort CS_ECAT_Slave_CSP_Backlash_Enable(ushort CardNo, ushort NodeID, ushort SlotID, ushort Mode);
    

        //========Motion Slave Home =========== Slave(Motion����) Home�Ҧ��q��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Home_Config")]
        public static extern ushort CS_ECAT_Slave_Home_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode, int Offset, uint FirstVel, uint SecondVel, uint Acceleration);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Home_Move")]
        public static extern ushort CS_ECAT_Slave_Home_Move(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Home_Status")]
        public static extern ushort CS_ECAT_Slave_Home_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Status);

        //========User Motion Control=========== Slave(Motion����) Motion User Define
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Set_Type")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Set_Type(ushort CardNo, ushort GroupNo, ushort AxisNum, ref ushort AxisNo, ref ushort SlotNo, ushort MotionType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Set_Enable_Mode")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Set_Enable_Mode(ushort CardNo, ushort GroupNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Get_Enable_Mode")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Get_Enable_Mode(ushort CardNo, ushort GroupNo, ref ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Set_Data")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Set_Data(ushort CardNo, ushort GroupNo, ref int CmdPulse);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Get_DataCnt")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Get_DataCnt(ushort CardNo, ushort GroupNo, ref ushort Counter);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Clear_Data")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Clear_Data(ushort CardNo, ushort GroupNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Ralm")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Ralm(ushort CardNo, ushort GroupNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Svon")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Svon(ushort CardNo, ushort GroupNo, ushort ON_OFF);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_User_Motion_Control_Get_Alm")]
        public static extern ushort CS_ECAT_Slave_User_Motion_Control_Get_Alm(ushort CardNo, ushort GroupNo, ref ushort Alm);

        //========Normal Slave - Record Data========== Slave(������)�q�� - �^����ƨt�C
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Set_Type")]
        public static extern ushort CS_ECAT_Slave_Record_Set_Type(ushort CardNo, ushort NodeID, ushort SlotNo, ushort MonitorIndex, ushort IOType, ushort OD_Index, ushort OD_SubIndex);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Set_Enable")]
        public static extern ushort CS_ECAT_Slave_Record_Set_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Get_Data_Cnt")]
        public static extern ushort CS_ECAT_Slave_Record_Get_Data_Cnt(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Cnt);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Read_Data")]
        public static extern ushort CS_ECAT_Slave_Record_Read_Data(ushort CardNo, ushort NodeID, ushort SlotNo, ref uint Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Clear_Data")]
        public static extern ushort CS_ECAT_Slave_Record_Clear_Data(ushort CardNo, ushort NodeID, ushort SlotNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Multi_Set_Enable")]
        public static extern ushort CS_ECAT_Slave_Record_Multi_Set_Enable(ushort CardNo, ushort NodeNum, ref ushort NodeIDArray, ref ushort SlotNoArray, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_Record_Multi_Clear_Data")]
        public static extern ushort CS_ECAT_Slave_Record_Multi_Clear_Data(ushort CardNo, ushort NodeNum, ref ushort NodeIDArray, ref ushort SlotNoArray);

        //======MR_J4_ABS=======
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_MR_J4_ABS_Set_Mode")]
        public static extern ushort CS_ECAT_Slave_MR_J4_ABS_Set_Mode(ushort CardNo, ushort GroupNo, ushort AxisNum, ushort DI_NodeID, ushort DI_SlotID, ushort DO_NodeID, ushort DO_SlotID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_MR_J4_ABS_Set_Enable")]
        public static extern ushort CS_ECAT_Slave_MR_J4_ABS_Set_Enable(ushort CardNo, ushort GroupNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_MR_J4_ABS_Get_State")]
        public static extern ushort CS_ECAT_Slave_MR_J4_ABS_Get_State(ushort CardNo, ushort GroupNo, ref ushort State);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_MR_J4_ABS_Get_Data")]
        public static extern ushort CS_ECAT_Slave_MR_J4_ABS_Get_Data(ushort CardNo, ushort GroupNo, ushort AxisIndex, ref int Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_MR_J4_ABS_Reset")]
        public static extern ushort CS_ECAT_Slave_MR_J4_ABS_Reset(ushort CardNo, ushort GroupNo, ushort AxisIndex);


        //========Motion Slave PP Command========= Slave(Motion����) PP�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PP_Start_Move")]
        public static extern ushort CS_ECAT_Slave_PP_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int TargetPos, uint ConstVel, uint Acceleration, uint Deceleration, ushort Abs_Rel);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PP_Advance_Config")]
        public static extern ushort CS_ECAT_Slave_PP_Advance_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort SetBit, uint End_Vel, int Min_Range_Limit, int Max_Range_Limit, int Min_Soft_Limit, int Max_Soft_Limit);

        //========Motion Slave PV Command=== Slave(Motion����)	 Velocity�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PV_Start_Move")]
        public static extern ushort CS_ECAT_Slave_PV_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int TargetVel, uint Acceleration, uint Deceleration);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PV_Advance_Config")]
        public static extern ushort CS_ECAT_Slave_PV_Advance_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort SetBit, ushort Max_Torque, ushort Velocity_Window, ushort Velocity_Window_Time, ushort Velocity_Threshold, ushort Velocity_Threshold_Time);

        //========Motion Slave VL Command=== Slave(Motion����)	 Velocity�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_VL_Start_Move")]
        public static extern ushort CS_ECAT_Slave_VL_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, int TargetVel, uint Acceleration, uint Deceleration);
   
        //========Motion Slave PT Command===== Slave(Motion����) Torque�Ҧ��B�ʫ��O
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PT_Start_Move")]
        public static extern ushort CS_ECAT_Slave_PT_Start_Move(ushort CardNo, ushort NodeID, ushort SlotNo, short Target_Torque, uint Slope);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_PT_Advance_Config")]
        public static extern ushort CS_ECAT_Slave_PT_Advance_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort SetBit, ushort Max_Current, short Torque_Profile);

        //========IO Slave===============	Slave(IO����) �q��
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Get_Input_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Get_Input_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Get_Output_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Get_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Set_Output_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Set_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Get_Single_Input_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Get_Single_Input_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitNum, ref ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Get_Single_Output_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Get_Single_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitNum, ref ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Set_Single_Output_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Set_Single_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitNum, ushort value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Set_Output_Error_Mode")]
        public static extern ushort CS_ECAT_Slave_DIO_Set_Output_Error_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitMode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DIO_Set_Output_Error_Value")]
        public static extern ushort CS_ECAT_Slave_DIO_Set_Output_Error_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitMode);

        //=======AIO Slave===============
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_AIO_Get_Input_Value")]
        public static extern ushort CS_ECAT_Slave_AIO_Get_Input_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_AIO_Set_Output_Value")]
        public static extern ushort CS_ECAT_Slave_AIO_Set_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_AIO_Get_Output_Value")]
        public static extern ushort CS_ECAT_Slave_AIO_Get_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Value);

        //======ECAT Module R1-EC5614========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5614_Set_MJ_Config")]
        public static extern ushort CS_ECAT_Slave_R1_EC5614_Set_MJ_Config(ushort CardNo, ushort MJNo, ushort MJType, ushort NodeID, ushort SlotNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ref int MaxSpeed, ref double TAcc, ref double Ratio);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5614_Set_MJ_Enable")]
        public static extern ushort CS_ECAT_Slave_R1_EC5614_Set_MJ_Enable(ushort CardNo, ushort MJNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5614_Get_IO_Status")]
        public static extern ushort CS_ECAT_Slave_R1_EC5614_Get_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Status);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5614_Get_MPG_Counter")]
        public static extern ushort CS_ECAT_Slave_R1_EC5614_Get_MPG_Counter(ushort CardNo, ushort NodeID, ushort SlotNo, ref int Counter);

        //======ECAT Module R1-EC5621========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_Output_Mode")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_Output_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_Input_Mode")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_Input_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_ORG_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_ORG_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_QZ_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_QZ_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_Home_SpMode")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_Home_SpMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_MEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_MEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_PEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_PEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_Svon_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_Svon_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_Home_Slow_Down")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_Home_Slow_Down(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable, ushort SlowDoneTime, ushort WaitTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Get_IO_Status")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Get_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort IOStatus);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Get_Single_IO_Status")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Get_Single_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitNo, ref ushort IOStatus);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC5621_Set_ALM_Clean_Time")]
        public static extern ushort CS_ECAT_Slave_R1_EC5621_Set_ALM_Clean_Time(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Ms);

        //======ECAT Module R1-ECx62x========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_Output_Mode")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_Output_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_Input_Mode")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_Input_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_ORG_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_ORG_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_QZ_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_QZ_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_MEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_MEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_PEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_PEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_Svon_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_Svon_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_Home_Slow_Down")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_Home_Slow_Down(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable, ushort SlowDoneTime, ushort WaitTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Get_IO_Status")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Get_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort IOStatus);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Get_Single_IO_Status")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Get_Single_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ushort BitNo, ref ushort IOStatus);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_ECx62x_Set_ALM_Inverse")]
        public static extern ushort CS_ECAT_Slave_R1_ECx62x_Set_ALM_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);

        //======ECAT Module R1-EC70E2========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC70E2_Set_Output_Enable")]
        public static extern ushort CS_ECAT_Slave_R1_EC70E2_Set_Output_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Eanble);


        //======ECAT Module R1-EC70X2========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC70X2_Set_Output_Enable")]
        public static extern ushort CS_ECAT_Slave_R1_EC70X2_Set_Output_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Eanble);

        //======ECAT Module R1-EC8124========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Set_Input_RangeMode")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Set_Input_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Set_Input_ConvstFreq_Mode")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Set_Input_ConvstFreq_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Set_Input_Enable")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Set_Input_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Get_Input_RangeMode")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Get_Input_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Set_Input_AverageMode")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Set_Input_AverageMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Avg_Times);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC8124_Get_Input_Value")]
        public static extern ushort CS_ECAT_Slave_R1_EC8124_Get_Input_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ushort AIType, ref double Value);

        //======ECAT Module R1-EC9144========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC9144_Set_Output_RangeMode")]
        public static extern ushort CS_ECAT_Slave_R1_EC9144_Set_Output_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort RangeMode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC9144_Set_Output_Enable")]
        public static extern ushort CS_ECAT_Slave_R1_EC9144_Set_Output_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC9144_Get_Output_ReturnCode")]
        public static extern ushort CS_ECAT_Slave_R1_EC9144_Get_Output_ReturnCode(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort ReturnCode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC9144_Set_Output_Value")]
        public static extern ushort CS_ECAT_Slave_R1_EC9144_Set_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, double Value);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_R1_EC9144_Get_Output_Value")]
        public static extern ushort CS_ECAT_Slave_R1_EC9144_Get_Output_Value(ushort CardNo, ushort NodeID, ushort SlotNo, ref double Value);

        //======Delta Servo========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Write_Parameter")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Write_Parameter(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Page, ushort Index, int WriteData);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Read_Parameter")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Read_Parameter(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Page, ushort Index, ref int ReadData);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Read_Parameter_Info")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Read_Parameter_Info(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Page, ushort Index, ref ushort ParaType, ref ushort DataSize, ref ushort DataType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Set_Velocity_Limit")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Set_Velocity_Limit(ushort CardNo, ushort NodeID, ushort SlotNo, uint LimitValue);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Set_Compare_Enable")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Set_Compare_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable, ushort CompareSource, ushort SignalLength, ushort SignalPolarity);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Get_Compare_Enable")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Get_Compare_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Enable, ref ushort CompareSource, ref ushort SignalLength, ref ushort SignalPolarity);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_DeltaServo_Set_Compare_Config")]
        public static extern ushort CS_ECAT_Slave_DeltaServo_Set_Compare_Config(ushort CardNo, ushort NodeID, ushort SlotNo, ushort CompareNum, ref int ComparePos);
        

        
        //======Security========//0:ok, 1:fail, 2:busy, 3:no-check, 4:security timeout
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Check_Verifykey")]
        public static extern ushort CS_ECAT_Security_Check_Verifykey(ushort CardNo, ref uint VerifyKey);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Get_Check_Verifykey_State")]
        public static extern ushort CS_ECAT_Security_Get_Check_Verifykey_State(ushort CardNo, ref ushort State);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Write_Verifykey")]
        public static extern ushort CS_ECAT_Security_Write_Verifykey(ushort CardNo, ref uint VerifyKey);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Get_Write_Verifykey_State")]
        public static extern ushort CS_ECAT_Security_Get_Write_Verifykey_State(ushort CardNo, ref ushort State);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Check_UserPassword")]
        public static extern ushort CS_ECAT_Security_Check_UserPassword(ushort CardNo, ref uint UserPassword);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Get_Check_UserPassword_State")]
        public static extern ushort CS_ECAT_Security_Get_Check_UserPassword_State(ushort CardNo, ref ushort State);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Write_UserPassword")]
        public static extern ushort CS_ECAT_Security_Write_UserPassword(ushort CardNo, ref uint UserPassword);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Security_Get_Write_UserPassword_State")]
        public static extern ushort CS_ECAT_Security_Get_Write_UserPassword_State(ushort CardNo, ref ushort State);


        
        //======MRAM======= Index:0~0x10000 Range:ByteNum
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_MRAM_Write_Word_Data")]
        public static extern ushort CS_ECAT_Master_MRAM_Write_Word_Data(ushort CardNo, uint Index, uint DataNum, ref ushort Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_MRAM_Read_Word_Data")]
        public static extern ushort CS_ECAT_Master_MRAM_Read_Word_Data(ushort CardNo, uint Index, uint DataNum, ref ushort Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_MRAM_Write_DWord_Data")]
        public static extern ushort CS_ECAT_Master_MRAM_Write_DWord_Data(ushort CardNo, uint Index, uint DataNum, ref uint Data);        
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_MRAM_Read_DWord_Data")]
        public static extern ushort CS_ECAT_Master_MRAM_Read_DWord_Data(ushort CardNo, uint Index, uint DataNum, ref uint Data);

        //======�b�dGPIO========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_GPIO_Set_Output")]
        public static extern ushort CS_ECAT_GPIO_Set_Output(ushort CardNo, ushort OnOff);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_GPIO_Get_Output")]
        public static extern ushort CS_ECAT_GPIO_Get_Output(ushort CardNo, ref ushort OnOff);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_GPIO_Get_Input")]
        public static extern ushort CS_ECAT_GPIO_Get_Input(ushort CardNo, ref ushort OnOff);

        //======�b�dCompare========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Position")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Position(ushort CardNo, ushort CompareChannel, int Position);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Get_Channel_Position")]
        public static extern ushort CS_ECAT_Compare_Get_Channel_Position(ushort CardNo, ushort CompareChannel, ref int Position);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Ipulser_Mode")]
        public static extern ushort CS_ECAT_Compare_Set_Ipulser_Mode(ushort CardNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Direction")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Direction(ushort CardNo, ushort CompareChannel, ushort Dir);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Trigger_Time")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Trigger_Time(ushort CardNo, ushort CompareChannel, uint TimeUs);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_One_Shot")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_One_Shot(ushort CardNo, ushort CompareChannel);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Source")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Source(ushort CardNo, ushort CompareChannel, ushort Source);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Enable")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Enable(ushort CardNo, ushort CompareChannel, ushort Enable);
        //Dir 1: Negativeu, 0:Positive 
        //TriggerCount 0:infinity trigger
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Channel0_Position")]
        public static extern ushort CS_ECAT_Compare_Channel0_Position(ushort CardNo, int Start, ushort Dir, ushort Interval, uint TriggerCount);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel0_Trigger_By_GPIO")]
        public static extern ushort CS_ECAT_Compare_Set_Channel0_Trigger_By_GPIO(ushort CardNo, ushort Dir, ushort Interval, int TriggerCount);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel1_Output_Enable")]
        public static extern ushort CS_ECAT_Compare_Set_Channel1_Output_Enable(ushort CardNo, ushort OnOff);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel1_Output_Mode")]
        public static extern ushort CS_ECAT_Compare_Set_Channel1_Output_Mode(ushort CardNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Get_Channel1_IO_Status")]
        public static extern ushort CS_ECAT_Compare_Get_Channel1_IO_Status(ushort CardNo, ref ushort IOStatus);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel1_GPIO_Out")]
        public static extern ushort CS_ECAT_Compare_Set_Channel1_GPIO_Out(ushort CardNo, ushort OnOff);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel1_Position_Table")]
        public static extern ushort CS_ECAT_Compare_Set_Channel1_Position_Table(ushort CardNo, ref int PosTable, uint TableSize);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel1_Position_Table_Level")]
        public static extern ushort CS_ECAT_Compare_Set_Channel1_Position_Table_Level(ushort CardNo, ref int PosTable, ref uint LevelTable, uint TableSize);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Get_Channel1_Position_Table_Count")]
        public static extern ushort CS_ECAT_Compare_Get_Channel1_Position_Table_Count(ushort CardNo, ref uint pCount);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Set_Channel_Polarity")]
        public static extern ushort CS_ECAT_Compare_Set_Channel_Polarity(ushort CardNo, ushort Inverse);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Reuse_Channel1_Position_Table")]
        public static extern ushort CS_ECAT_Compare_Reuse_Channel1_Position_Table(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Compare_Reuse_Channel1_Position_Table_Level")]
        public static extern ushort CS_ECAT_Compare_Reuse_Channel1_Position_Table_Level(ushort CardNo);

        //======�b�dCE========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Card_CE_Operate_Enable")]
        public static extern ushort CS_ECAT_Card_CE_Operate_Enable(ushort CardNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Card_CE_Write_PC_Data")]
        public static extern ushort CS_ECAT_Card_CE_Write_PC_Data(ushort CardNo, ushort Index, uint Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Card_CE_Read_PC_Data")]
        public static extern ushort CS_ECAT_Card_CE_Read_PC_Data(ushort CardNo, ushort Index, ref uint Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Card_CE_Write_Device_Data")]
        public static extern ushort CS_ECAT_Card_CE_Write_Device_Data(ushort CardNo, ushort Index, uint Data);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Card_CE_Read_Device_Data")]
        public static extern ushort CS_ECAT_Card_CE_Read_Device_Data(ushort CardNo, ushort Index, ref uint Data);
   
   
        //======RTX========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Open_Rtss")]
        public static extern ushort CS_ECAT_Master_RTX_Open_Rtss(ushort CardNo, string FilePath, ref ushort Flag);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Create_Shared_Memory")]
        public static extern ushort CS_ECAT_Master_RTX_Create_Shared_Memory(ushort CardNo, uint MaxSize, string SpaceName, ref IntPtr location, ref IntPtr Sharedmemory_Handle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Open_Shared_Memory")]
        public static extern ushort CS_ECAT_Master_RTX_Open_Shared_Memory(ushort CardNo, string SpaceName, ref IntPtr location, ref IntPtr Sharedmemory_Handle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Create_Event")]
        public static extern ushort CS_ECAT_Master_RTX_Create_Event(ushort CardNo, ushort ManualReset, ushort InitialState, string EventName, ref IntPtr Event_Handle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Open_Event")]
        public static extern ushort CS_ECAT_Master_RTX_Open_Event(ushort CardNo, string EventName, ref IntPtr Event_Handle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Set_Event")]
        public static extern ushort CS_ECAT_Master_RTX_Set_Event(ushort CardNo, IntPtr Event_Handle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_RTX_Close_Handle")]
        public static extern ushort CS_ECAT_Master_RTX_Close_Handle(ushort CardNo, IntPtr A_Handle);

        //======Errorlog========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Set_Enable")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Set_Enable(ushort CardNo, ushort Enable, ushort Mode, ushort Level);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Get_Enable")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Get_Enable(ushort CardNo, ref ushort Enable, ref ushort Mode, ref ushort Level);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Get_FunIDToString")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Get_FunIDToString(ushort CardNo, ushort FunID, string FunName);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Clear")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Clear(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Get_ErrorCnt")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Get_ErrorCnt(ushort CardNo, ref ushort ErrorCnt);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Get_ErrorData")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Get_ErrorData(ushort CardNo, ref ushort NodeID, ref ushort SlotID, ref ushort FunID, ref ushort ErrorCode, ref double ErrorTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_Get_Single_ErrorData")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_Get_Single_ErrorData(ushort CardNo, ushort Count, ref ushort NodeID, ref ushort SlotID, ref ushort FunID, ref ushort ErrorCode, ref double ErrorTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_API_DumpData")]
        public static extern ushort CS_ECAT_Master_Errorlog_API_DumpData(ushort CardNo, string FilePath);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Set_Enable")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Set_Enable(ushort CardNo, ushort Enable, ushort RecordMask);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Get_Enable")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Get_Enable(ushort CardNo, ref ushort Enable, ref ushort RecordMask);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Clear")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Clear(ushort CardNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Get_ErrorCnt")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Get_ErrorCnt(ushort CardNo, ref ushort ErrorCnt);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Get_ErrorData")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Get_ErrorData(ushort CardNo, ref ushort ErrorCode, ref ushort ErrorData, ref double ErrorTime);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Errorlog_Status_Get_Single_ErrorData")]
        public static extern ushort CS_ECAT_Master_Errorlog_Status_Get_Single_ErrorData(ushort CardNo, ushort Count, ref ushort ErrorCode, ref ushort ErrorData, ref double ErrorTime);



        //======DLL��T========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DLL_Path")]
        public static extern ushort CS_ECAT_Master_get_DLL_path(ref sbyte lpFilePath, uint nSize, ref uint nLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DLL_Version")]
        public static extern ushort CS_ECAT_Master_get_DLL_version(ref sbyte lpBuf, uint nSize, ref uint nLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DLL_Path_Single")]
        public static extern ushort CS_ECAT_Master_get_DLL_path_Single(ushort CardNo, ref sbyte lpFilePath, uint nSize, ref uint nLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Master_Get_DLL_Version_Single")]
        public static extern ushort CS_ECAT_Master_get_DLL_version_Single(ushort CardNo, ref sbyte lpBuf, uint nSize, ref uint nLength);


        //======SYN-TEK Module ESC-5614========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5614_Set_MJ_Config")]
        public static extern ushort CS_ECAT_Slave_ESC5614_Set_MJ_Config(ushort CardNo, ushort MJNo, ushort MJType, ushort NodeID, ushort SlotNo, ushort AxisNum, ref ushort AxisArray, ref ushort SlotArray, ref int MaxSpeed, ref double TAcc, ref double Ratio);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5614_Set_MJ_Enable")]
        public static extern ushort CS_ECAT_Slave_ESC5614_Set_MJ_Enable(ushort CardNo, ushort MJNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5614_Get_IO_Status")]
        public static extern ushort CS_ECAT_Slave_ESC5614_Get_IO_Status(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Status);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5614_Get_MPG_Counter")]
        public static extern ushort CS_ECAT_Slave_ESC5614_Get_MPG_Counter(ushort CardNo, ushort NodeID, ushort SlotNo, ref int Counter);

        //======SynTek Module ESC-5621========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_Output_Mode")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_Output_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_Input_Mode")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_Input_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_ORG_Inverse")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_ORG_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_QZ_Inverse")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_QZ_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_Home_SpMode")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_Home_SpMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_MEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_MEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_PEL_Inverse")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_PEL_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC5621_Set_Svon_Inverse")]
        public static extern ushort CS_ECAT_Slave_ESC5621_Set_Svon_Inverse(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
       
        
      
        //======SynTek Module ESC-70E2========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC70E2_Set_Output_Enable")]
        public static extern ushort CS_ECAT_Slave_ESC70E2_Set_Output_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Eanble);
        

        //======SynTek Module ESC-8124========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC8124_Set_Input_RangeMode")]
        public static extern ushort CS_ECAT_Slave_ESC8124_Set_Input_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC8124_Set_Input_ConvstFreq_Mode")]
        public static extern ushort CS_ECAT_Slave_ESC8124_Set_Input_ConvstFreq_Mode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC8124_Set_Input_Enable")]
        public static extern ushort CS_ECAT_Slave_ESC8124_Set_Input_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC8124_Get_Input_RangeMode")]
        public static extern ushort CS_ECAT_Slave_ESC8124_Get_Input_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort Mode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC8124_Set_Input_AverageMode")]
        public static extern ushort CS_ECAT_Slave_ESC8124_Set_Input_AverageMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Avg_Times);

        
        //======SynTek Module ESC-9144========
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC9144_Set_Output_RangeMode")]
        public static extern ushort CS_ECAT_Slave_ESC9144_Set_Output_RangeMode(ushort CardNo, ushort NodeID, ushort SlotNo, ushort RangeMode);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC9144_Set_Output_Enable")]
        public static extern ushort CS_ECAT_Slave_ESC9144_Set_Output_Enable(ushort CardNo, ushort NodeID, ushort SlotNo, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Slave_ESC9144_Get_Output_ReturnCode")]
        public static extern ushort CS_ECAT_Slave_ESC9144_Get_Output_ReturnCode(ushort CardNo, ushort NodeID, ushort SlotNo, ref ushort ReturnCode);



       
        //==========Robot=========
        //Initial Class

        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Initial")]
        public static extern ushort CS_ECAT_Group_Robot_Initial(ushort CardNo, ushort GroupNo, ushort RobotType, ref ushort AxisArray, ref ushort SlotArray);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Parameter_Initial")]
        public static extern ushort CS_ECAT_Group_Robot_Parameter_Initial(ushort CardNo, ushort GroupNo);
        //Close Class
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Group_Close")]
        public static extern ushort CS_ECAT_Group_Robot_Group_Close(ushort CardNo, ushort GroupNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Close")]
        public static extern ushort CS_ECAT_Group_Robot_Close(ushort CardNo);
        //ALM Conduct
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_System_Ralm")]
        public static extern ushort CS_ECAT_Group_Robot_System_Ralm(ushort CardNo, ushort GroupNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Servo_Ralm")]
        public static extern ushort CS_ECAT_Group_Robot_Servo_Ralm(ushort CardNo, ushort GroupNo);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Alm")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Alm(ushort CardNo, ushort GroupNo, ref ushort ErrorReturnCode);

        //Setting Class
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Joint_Angle_Limit")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Joint_Angle_Limit(ushort CardNo, ushort GroupNo, ushort JointNo, double PLimit, double NLimit);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Joint_Speed_SoftLimit")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Joint_Speed_SoftLimit(ushort CardNo, ushort GroupNo, ushort JointNo, int SpdLimit);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Joint_Acc_SoftLimit")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Joint_Acc_SoftLimit(ushort CardNo, ushort GroupNo, ushort JointNo, double AccLimit);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Real_Barrier")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Real_Barrier(ushort CardNo, ushort GroupNo, ushort BarrierNo, ushort BarrierType, ushort InOutType, ref double PointPara, ushort Enable);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Arm_Length")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Arm_Length(ushort CardNo, ushort GroupNo, ushort ArmNo, double ArmLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Joint_Dir")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Joint_Dir(ushort CardNo, ushort GroupNo, ushort JointNo, short Dir);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Joint_Gear")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Joint_Gear(ushort CardNo, ushort GroupNo, ushort JointNo, uint PulseOnLength, uint UnitLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Base_HandType")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Base_HandType(ushort CardNo, ushort GroupNo, ref ushort BaseHandType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Corr_Ratio")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Corr_Ratio(ushort CardNo, ushort GroupNo, double CorrRatio);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Position")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Position(ushort CardNo, ushort GroupNo, ref double RealPos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Smooth_Type")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Smooth_Type(ushort CardNo, ushort GroupNo, ushort SmoothType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Arm_Offset")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Arm_Offset(ushort CardNo, ushort GroupNo, ushort ArmNo, ref double OffestLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Set_Target_Type")]
        public static extern ushort CS_ECAT_Group_Robot_Set_Target_Type(ushort CardNo, ushort GroupNo, ushort TargetType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Change_Velocity_Ratio")]
        public static extern ushort CS_ECAT_Group_Robot_Change_Velocity_Ratio(ushort CardNo, ushort GroupNo, ushort Ratio, double Tacc);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_SixAxes_ToolPlane_VectorKeep")]
        public static extern ushort CS_ECAT_Group_Robot_SixAxes_ToolPlane_VectorKeep(ushort CardNo, ushort GroupNo, ushort Enable);
        //Get Class
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_BufferLength")]
        public static extern ushort CS_ECAT_Group_Robot_Get_BufferLength(ushort CardNo, ushort GroupNo, ref ushort BufferLength);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Motion_SeqID")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Motion_SeqID(ushort CardNo, ushort GroupNo, ref ushort SeqID);
        //	Robot System Information
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Position")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Position(ushort GroupNo, ref double Pos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Joint_Pulse")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Joint_Pulse(ushort GroupNo, ref int Command);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Joint_Position")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Joint_Position(ushort GroupNo, ushort JointNo, ref double RealCommand);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Joint_Angle")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Joint_Angle(ushort GroupNo, ref double Angle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Joint_Speed")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Joint_Speed(ushort GroupNo, ref int Speed);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Sys_Joint_AccSpd")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Sys_Joint_AccSpd(ushort GroupNo, ushort JointNo, ref double AccSpd);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Vector_Speed")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Vector_Speed(ushort GroupNo, ref double VectorSpd);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Target_Position")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Target_Position(ushort GroupNo, ref double TargetPos);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_HandType")]
        public static extern ushort CS_ECAT_Group_Robot_Get_HandType(ushort GroupNo, ref ushort HandType);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Motion_State")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Motion_State(ushort GroupNo, ref ushort State);

        //	Servo Information
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Servo_Position")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Servo_Position(ushort GroupNo, ref double RealCommand);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Servo_Joint_Pulse")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Servo_Joint_Pulse(ushort GroupNo, ushort JointNo, ref int Pulse);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Servo_Joint_Angle")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Servo_Joint_Angle(ushort GroupNo, ref double Angle);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Get_Servo_Joint_Speed")]
        public static extern ushort CS_ECAT_Group_Robot_Get_Servo_Joint_Speed(ushort GroupNo, ushort JointNo, ref double Spd);

        //Stop Class
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Sd_Stop")]
        public static extern ushort CS_ECAT_Group_Robot_Sd_Stop(ushort GroupNo, double Tdec);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Emg_Stop")]
        public static extern ushort CS_ECAT_Group_Robot_Emg_Stop(ushort GroupNo);
        //Move Class
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_P2P_Move")]
        public static extern ushort CS_ECAT_Group_Robot_P2P_Move(ushort GroupNo, ref double TargetPos, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, ushort T_S_Curve, ushort Rel_Abs, ushort WaitMDone, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Line_Move")]
        public static extern ushort CS_ECAT_Group_Robot_Line_Move(ushort GroupNo, ref double TargetPos, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, ushort T_S_Curve, ushort Rel_Abs, ushort WaitMDone, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Arc_Move")]
        public static extern ushort CS_ECAT_Group_Robot_Arc_Move(ushort GroupNo, ref ushort PlaneAxis, ref double CenterPos, double Angle, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, ushort T_S_Curve, ushort Rel_Abs, ushort WaitMDone, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_V_Move")]
        public static extern ushort CS_ECAT_Group_Robot_V_Move(ushort GroupNo, ushort Mode, ushort Dir, double StartVel, double ConstVel, double Tacc, ushort T_S_Curve, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Joint_Move")]
        public static extern ushort CS_ECAT_Group_Robot_Joint_Move(ushort GroupNo, ushort JointNo, double Angle, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, ushort T_S_Curve, ushort Rel_Abs, ushort WaitMDone, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Scara_ChHand_Move")]
        public static extern ushort CS_ECAT_Group_Robot_Scara_ChHand_Move(ushort GroupNo, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, ushort T_S_Curve, ushort WaitMDone, ushort SeqID);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_SixAxes_ChHand_Move")]
        public static extern ushort CS_ECAT_Group_Robot_SixAxes_ChHand_Move(ushort GroupNo, ushort ShoulderType, ushort ElbowType, ushort WristType, double StartVel, double ConstVel, double EndVel, double Tacc, double Tdec, short T_S_Curve, short MDoneFlag);
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Svon")]
        public static extern ushort CS_ECAT_Group_Robot_Svon(ushort GroupNo, ushort Enable);

        //Other
        [DllImport("EtherCAT_DLL_x64.dll", EntryPoint = "_ECAT_Group_Robot_Debug_Mode")]
        public static extern ushort CS_ECAT_Group_Robot_Debug_Mode(ushort GroupNo, ushort Enable);


    }
}
