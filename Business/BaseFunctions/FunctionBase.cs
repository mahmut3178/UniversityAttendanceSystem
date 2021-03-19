using Karebase.Entities.Helper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business.BaseFunctions
{
	public static class FunctionBase
	{
		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		public extern static void ReleaseCapture();

		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		public static DataTable ToDataTable<T>(this IList<T> list)
		{
			PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
			var json = JsonConvert.SerializeObject(list, new DecimalFormatConverter());
			DataTable dataTable = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
			return dataTable;
		}
		
	}
}
