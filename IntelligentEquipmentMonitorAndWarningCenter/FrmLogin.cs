using Common.Encrypt;
using IEMAWC.BLL;
using Org.BouncyCastle.Tls;

namespace IntelligentEquipmentMonitorAndWarningCenter
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        //调用业务逻辑层
        UserBLL userBLL = new UserBLL();

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //鼠标拖动事件
            this.MouseDown += FrmLogin_MouseDown;
            this.MouseUp += FrmLogin_MouseUp;
            this.MouseMove += FrmLogin_MouseMove;
            //界面初始化
            txtUserName.Clear();
            txtUserPwd.Clear();
            //聚焦不起作用
            txtUserName.Focus();
            //账号和密码框事件
            txtUserName.TextChanged += TxtBox_TextChanged;
            txtUserPwd.TextChanged += TxtBox_TextChanged;

        }

        private void TxtBox_TextChanged(object? sender, EventArgs e)
        {
            // 把object 类转换为 TextBox 类
            TextBox txt = sender as TextBox;
            //账号和密码输入框输入内容时候触发
            if (!string.IsNullOrEmpty(txt.Text))
            {
                SetError("", false);
            }
        }
        private void SetError(string errMsg, bool isVisible)
        {
            lblMsg.Text = errMsg;
            lblMsg.Visible = isVisible;
        }
        private void SetSuccess(string Msg)
        {
            lblMsg.Text = Msg;
            lblMsg.Visible = true;
            lblMsg.ForeColor = Color.Orange;
        }

        //登录按钮的实现
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string userPwd = txtUserPwd.Text.Trim();

            //检查登录信息 判断用户名是否为null 
            if (string.IsNullOrEmpty(userName))
            {
                SetError("请输入账号", true);
                txtUserName.Focus();
                return;
            }
            //判断用户密码是否为null   IsNullOrEmpty 
            if (string.IsNullOrEmpty(userPwd))
            {
                SetError("请输入密码", true);
                txtUserPwd.Focus();
                return;
            }

            // 对密码进行加密处理MD5
            //enPwd 加密后的密码
            string enPwd = MD5Encrypt.Encrypt(userPwd);
            //调用登录方法
            bool bLogin = userBLL.LoginSystem(userName, enPwd);
            if (bLogin)
            {
                SetSuccess("登录成功");
                Task.Run(() =>
                {
                    Thread.Sleep(500);
                    for (int i = 2; i > 0; i--)
                    {
                        // 切回主线程 ui 页面显示
                        this.Invoke(new Action(() =>
                        {
                            SetSuccess($"倒计时 : {i}s");
                        }));
                        Thread.Sleep(500);
                    }

                    //切回主线程 ui 页面显示
                    this.Invoke(new Action(() =>
                    {
                        FrmMain frmMain = new FrmMain();
                        frmMain.Tag = userName;
                        // 显示frmMain 页面
                        frmMain.Show();
                        // 隐藏当前登录窗体 不关闭
                        this.Hide();
                    }));
                });

            }
            else
            {
                SetError("登录失败", true);
            }

        }

        #region  实现页面的拖动
        Point p;
        bool isMove = false;
        private void FrmLogin_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isMove == true)
            {
                //平移给定的效果 
                this.Location += new Size(e.Location.X - p.X, e.Location.Y - p.Y);
            }
        }

        private void FrmLogin_MouseUp(object? sender, MouseEventArgs e)
        {
            isMove = false;
        }

        private void FrmLogin_MouseDown(object? sender, MouseEventArgs e)
        {
            p = e.Location;
            isMove = true;
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
