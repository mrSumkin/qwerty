using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020000C5 RID: 197
public static class b3p
{
	// Token: 0x0600046B RID: 1131 RVA: 0x00014310 File Offset: 0x00012510
	public static void a(this Texture2D A_0, string A_1)
	{
		int num = A_0.Width * A_0.Height * 4;
		byte[] array = dh4.c((long)num);
		try
		{
			if (array == null || array.Length < num)
			{
				array = new byte[num];
			}
			A_0.GetData<byte>(array, 0, num);
			for (int i = 0; i < array.Length - 2; i += 4)
			{
				byte b = array[i];
				array[i] = array[i + 2];
				array[i + 2] = b;
			}
			GCHandle gchandle = GCHandle.Alloc(array, GCHandleType.Pinned);
			Bitmap bitmap = new Bitmap(A_0.Width, A_0.Height, A_0.Width * 4, PixelFormat.Format32bppArgb, gchandle.AddrOfPinnedObject());
			bitmap.Save(A_1, ImageFormat.Png);
			bitmap.Dispose();
			gchandle.Free();
		}
		finally
		{
			dh4.a(array);
		}
	}
}
