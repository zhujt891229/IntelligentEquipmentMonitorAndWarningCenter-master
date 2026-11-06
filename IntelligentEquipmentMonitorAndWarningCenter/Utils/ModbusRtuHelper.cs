using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.ModBus;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class ModbusRtuHelper
    {
        private ModbusRtu _modbusRtu;

        //获取所有的端口
        public string[] GetPortNames()
        {
            return SerialPort.GetPortNames();
        }

        // 连接 PLC (RTU)
        public bool Connect(string portName, int baudRate = 9600, int dataBits = 8,
                             StopBits stopBits = StopBits.One, Parity parity = Parity.None, byte station = 1)
        {
            try
            {
                // 1. 初始化串口参数 (COM口, 波特率, 数据位, 停止位, 校验位)
                _modbusRtu = new ModbusRtu();
                _modbusRtu.SerialPortInni(portName, baudRate, dataBits, stopBits, parity);

                // 2. 设置从站地址 (PLC的站号)
                _modbusRtu.Station = station;

                // 3. 打开串口
                OperateResult result = _modbusRtu.Open();


                return result.IsSuccess;
            }
            catch { return false; }
        }

        // 读取保持寄存器 (返回 short 数组，对应 PLC 的 4xxxx 地址)
        public OperateResult<short[]> ReadRegisters(ushort startAddress, ushort count)
        {
            return _modbusRtu.ReadInt16(startAddress.ToString(), count);
        }

        // 写入单个寄存器
        public OperateResult WriteRegister(ushort address, short value)
        {
            return _modbusRtu.Write(address.ToString(), value);
        }

        //读取线圈 (01 Function Code) ---
        public OperateResult<bool[]> ReadCoils(ushort startAddress, ushort count)
        {
            return _modbusRtu.ReadBool(startAddress.ToString(), count);
        }

        // 写入单个线圈 (05 Function Code) ---
        public OperateResult WriteCoil(ushort address, bool value)
        {
            return _modbusRtu.Write(address.ToString(), value);
        }


        // 关闭连接
        public void Close()
        {
            _modbusRtu?.Close();
        }
    }
}
