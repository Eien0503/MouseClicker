using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class Form1 : Form
    {
        // 引入外部函式來模擬滑鼠點擊
        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        private Thread clickThread;
        private bool clicking = false;

        // 引入全局鍵盤鉤子的外部函式
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int VK_PAUSE = 0x13;

        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        public Form1()
        {
            InitializeComponent();
            // 設定全局鍵盤鉤子
            _hookID = SetHook(_proc);
            // 設定快捷鍵
            //this.KeyPreview = true;
            //this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }
        private void btnStartStop2_Click(object sender, EventArgs e)
        {
            
        }
        private void ToggleClicking()
        {
            if (!clicking)
            {
                // 開始連點，連點間隔為 30 毫秒
                clicking = true;
                clickThread = new Thread(() => ClickMouse(Cursor.Position.X, Cursor.Position.Y, 30));
                clickThread.Start();
                btnStartStop2.Text = "連點中";
            }
            else
            {
                // 停止連點
                clicking = false;
                if (clickThread != null && clickThread.IsAlive)
                {
                    clickThread.Join();
                }
                btnStartStop2.Text = "停止中";
            }
        }
        private void ClickMouse(int x, int y, int interval)
        {
            // 設定滑鼠位置
            Cursor.Position = new System.Drawing.Point(x, y);

            while (clicking)
            {
                // 模擬滑鼠按下和釋放
                mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);

                // 等待指定的間隔時間
                Thread.Sleep(interval);
            }
        }
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = System.Diagnostics.Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == VK_PAUSE)
                {
                    // 切換連點狀態
                    ((Form1)Application.OpenForms[0]).ToggleClicking();
                }
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // 釋放全局鍵盤鉤子
            UnhookWindowsHookEx(_hookID);
            // 停止連點
            clicking = false;
            if (clickThread != null && clickThread.IsAlive)
            {
                clickThread.Join();
            }
            base.OnFormClosed(e);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
