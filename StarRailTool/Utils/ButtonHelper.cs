using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StarRailTool.Utils
{
	/// <summary>
	/// 按钮助手
	/// </summary>
	internal static class ButtonHelper
	{
		[DllImport("user32.dll")]
		private static extern IntPtr SendMessage(HandleRef hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

		private const uint BCM_SETSHIELD = 0x0000160C;

		public static void AddUACIcon(this Button button)
		{
			button.FlatStyle = FlatStyle.System;
			SendMessage(new(button, button.Handle), BCM_SETSHIELD, new(0), new(1));
		}
	}
}
