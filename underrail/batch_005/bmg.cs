using System;
using System.IO;

// Token: 0x0200064F RID: 1615
public static class bmg
{
	// Token: 0x06002908 RID: 10504 RVA: 0x000EA1D4 File Offset: 0x000E83D4
	public static ccc b()
	{
		return bmg.b;
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x000EA1E8 File Offset: 0x000E83E8
	public static void a()
	{
		if (bmg.b != null)
		{
			bmg.b.Dispose();
		}
		bmg.b = new ccc();
	}

	// Token: 0x0600290B RID: 10507 RVA: 0x000EA208 File Offset: 0x000E8408
	public static void d(string A_0)
	{
		if (!Directory.Exists(A_0))
		{
			Directory.CreateDirectory(A_0);
		}
		bmg.b.g(A_0);
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x000EA22C File Offset: 0x000E842C
	public static void c(string A_0)
	{
		if (bmg.b != null)
		{
			bmg.b.Dispose();
			bmg.b = null;
		}
		try
		{
			if (ccc.b(A_0))
			{
				bmg.b = ccc.c(A_0);
			}
			else
			{
				bmg.b = bmg.a(A_0);
			}
		}
		catch (Exception ex)
		{
			try
			{
				string text = d5x.e();
				if (Directory.Exists(text))
				{
					string text2 = Path.Combine(text, string.Format("LoadError-{0}.txt", DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss")));
					string text3 = string.Format("Версия игры: {0}\r\nОшибка: {1}", dm9.d, ex.ToString());
					File.WriteAllText(text2, text3);
				}
			}
			catch
			{
			}
			throw;
		}
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x000EA2F8 File Offset: 0x000E84F8
	public static bool b(string A_0)
	{
		return bmg.b.d(A_0.ToLowerInvariant()) != null;
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x000EA310 File Offset: 0x000E8510
	public static void a(string A_0, string A_1)
	{
		bmg.a(bmg.b, A_0.ToLowerInvariant(), A_1);
	}

	// Token: 0x0600290F RID: 10511 RVA: 0x000EA324 File Offset: 0x000E8524
	private static ccc a(string A_0)
	{
		if (Directory.Exists(A_0))
		{
			ccc ccc = new ccc();
			string text = Path.Combine(A_0, d5x.y);
			string text2 = Path.Combine(A_0, d5x.x);
			if (Directory.Exists(text))
			{
				foreach (string text3 in Directory.GetFiles(text))
				{
					string fileName = Path.GetFileName(text3);
					string a_ = (d5x.y + "\\" + fileName).ToLowerInvariant();
					bmg.a(ccc, a_, text3);
				}
			}
			if (Directory.Exists(text2))
			{
				foreach (string text4 in Directory.GetFiles(text2))
				{
					string fileName2 = Path.GetFileName(text4);
					string a_2 = (d5x.x + "\\" + fileName2).ToLowerInvariant();
					bmg.a(ccc, a_2, text4);
				}
			}
			return ccc;
		}
		return null;
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x000EA418 File Offset: 0x000E8618
	private static void a(ccc A_0, string A_1, string A_2)
	{
		FileStream fileStream = File.OpenRead(A_2);
		try
		{
			byte[] array = dh4.c(fileStream.Length);
			try
			{
				fileStream.Read(array, 0, (int)fileStream.Length);
				A_0.a(A_1, array, 0L, fileStream.Length, null);
			}
			finally
			{
				dh4.a(array);
			}
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
	}

	// Token: 0x04001668 RID: 5736
	public static bool a;

	// Token: 0x04001669 RID: 5737
	private static ccc b = new ccc();
}
