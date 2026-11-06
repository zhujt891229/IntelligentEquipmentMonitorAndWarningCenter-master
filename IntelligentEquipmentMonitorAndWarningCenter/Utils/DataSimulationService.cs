using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using IEMAWC.DAL;
using IntelligentDeviceMonitorAndWarningCenter.SysConfigs;

namespace IntelligentEquipmentMonitorAndWarningCenter.Utils
{
    public class DataSimulationService
    {
        // 模拟数据生成间隔：3分钟 (180秒)。为了方便测试，你可以暂时改成 3 秒 (3000毫秒)
        private const int GenerateIntervalMs = 3000;// 3 * 60 * 1000;

        //设置取消令牌
        private CancellationTokenSource _cts;

        public DataSimulationService()
        {
            // 在构造函数中，或者启动服务的方法中，去获取配置
            LoadThresholds();
            CommonHelper.AlarmSetsUpdated += () => LoadThresholds();

        }

        private void LoadThresholds()
        {
            if (CommonHelper.alarmsets == null)
            {
                // 如果为空，给一个默认值兜底
                TempMin = 5.0; TempMax = 35.0;
                HumMin = 30.0; HumMax = 65.0;
                BrightMin = 30.0; BrightMax = 75.0;
                return;
            }
            // 2. 从全局变量中读取阈值
            var conditions = CommonHelper.alarmsets.Conditions;
            // 找温度
            var tempCon = conditions.Find(c => c.ConditionType == "温度");
            if (tempCon != null)
            {
                TempMin =  tempCon.MinValue;
                TempMax =  tempCon.MaxValue; 
            }

            // 找湿度
            var humCon = conditions.Find(c => c.ConditionType == "湿度");
            if (humCon != null)
            {
                HumMin = humCon.MinValue;
                HumMax = humCon.MaxValue;
            }

            // 找亮度
            var brightCon = conditions.Find(c => c.ConditionType == "亮度");
            if (brightCon != null)
            {
                BrightMin = brightCon.MinValue;
                BrightMax = brightCon.MaxValue;
            }
        }

        // 定义阈值范围（可移至配置文件）
        private double TempMin, TempMax;
        private double HumMin, HumMax;
        private double BrightMin, BrightMax;


        // 定义一个事件，当有新数据生成时通知UI更新（可选，如果你需要在界面上显示）
        public event Action<DataInfo> OnDataGenerated;
        // 定义一个事件，当产生报警时触发
        public event Action<AlarmLog> OnAlarmGenerated;

        public event Action<BindingList<DataInfo>> OnUpdateDataed;

        DataInfoDAL dataInfoDAL = new DataInfoDAL();

        AlarmLogDAL alarmLogDAL = new AlarmLogDAL();

        public void StartSimulation()
        {
            if (_cts != null) return;
            _cts = new CancellationTokenSource();
            CancellationToken token = _cts.Token;
           

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    try
                    {
                        DataInfo newData = GenerateRandomData();
                        OnDataGenerated?.Invoke(newData);

                        BindingList<DataInfo> list = dataInfoDAL.GetTenNewDataFromDataInfos();
                        OnUpdateDataed?.Invoke(list);

                        CheckThresholds(newData);
                    }
                    catch (Exception ex)
                    {
                        // 捕获本次循环异常，不中断下一轮模拟
                        Console.WriteLine($"模拟数据生成异常：{ex.Message}");
                    }

                    // 4. 等待 3 s或直到任务被取消
                    try
                    {
                        await Task.Delay(GenerateIntervalMs, token);
                    }
                    catch (TaskCanceledException)
                    {
                        break; // 任务被取消，退出循环
                    }
                }
            }, token);
        }

        public void StopSimulation()
        {
            if (_cts == null) return;
            _cts?.Cancel();
            _cts.Dispose();
        }

        /// <summary>
        /// 生成在阈值范围内+- 5 的随机模拟数据
        /// </summary>
        ///
        //定义在外面，不用每次都new 对象
        private readonly Random rnd = new Random();
        private DataInfo GenerateRandomData()
        {

            // 为了能触发+ -5的报警，我们让数据的生成范围稍微扩大一点 (Min - 5 到 Max + 5)
            // 这样就有一定概率生成出报警数据
            double temp = Math.Round(TempMin - 5 + (rnd.NextDouble() * ((TempMax + 5) - (TempMin - 5))), 1);
            double hum = Math.Round(HumMin - 5 + (rnd.NextDouble() * ((HumMax + 5) - (HumMin - 5))), 1);
            double bright = Math.Round(BrightMin - 5 + (rnd.NextDouble() * ((BrightMax + 5) - (BrightMin - 5))), 1);

            return new DataInfo
            {
                CollectionTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                Temperature = temp,
                Humidity = hum,
                Brightness = bright
            };
        }

        /// <summary>
        /// 检查阈值，触发报警
        /// </summary>
        private void CheckThresholds(DataInfo data)
        {
            // 检查温度
            if (data.Temperature > TempMax  || data.Temperature < TempMin )
            {
                TriggerAlarm(0, data.Temperature, TempMin, TempMax);
            }
            // 检查湿度
            if (data.Humidity > HumMax  || data.Humidity < HumMin )
            {
                TriggerAlarm(1, data.Humidity, HumMin, HumMax);
            }
            // 检查亮度
            if (data.Brightness > BrightMax  || data.Brightness < BrightMin )
            {
                TriggerAlarm(2, data.Brightness, BrightMin, BrightMax);
            }
        }

        private void TriggerAlarm(int infoType, double value, double min, double max)
        {
            string state = value > max ? "1" : "0"; // 1为高值异常，0为低值异常
            // 0 为温度，1为湿度，2为亮度
            string typeName = infoType == 0 ? "温度" : infoType == 1 ? "湿度" : "亮度";
            string note = $"当前{typeName}值 {value} 超出阈值范围 [+5/-5] 警戒线。正常范围: {min}~{max}";

            AlarmLog alarm = new AlarmLog
            {
                InfoType = infoType,
                AlarmTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                AlarmType = 0, // 0为实时报警
                AlarmState = state,
                AlarmValue = value,
                AlarmNote = note
            };

            // 触发报警事件，通知UI或调用数据库写入
            OnAlarmGenerated?.Invoke(alarm);
        }

        /// <summary>
        /// 将生成的正常数据写入数据库
        /// </summary>
        public void InsertDataToDatabase(DataInfo data)
        {
            dataInfoDAL.InsertDataToDataInfos(data);
        }

        /// <summary>
        /// 将报警数据写入数据库
        /// </summary>
        public void InsertAlarmToDatabase(AlarmLog alarm)
        {
            alarmLogDAL.InsertAlarmToDatabase(alarm);
        }
    }
}