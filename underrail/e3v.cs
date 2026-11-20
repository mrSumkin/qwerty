using System;
using System.IO;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x0200009D RID: 157
public static class e3v
{
	// Token: 0x060003A3 RID: 931 RVA: 0x000114A0 File Offset: 0x0000F6A0
	public static Texture2D a(GraphicsDevice A_0, string A_1)
	{
		FileStream fileStream = null;
		Texture2D result;
		try
		{
			fileStream = File.OpenRead(A_1);
			result = Texture2D.FromStream(A_0, fileStream);
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Dispose();
			}
		}
		return result;
	}
}
