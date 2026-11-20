using System;
using System.IO;

// Token: 0x02000688 RID: 1672
public static class bdo
{
	// Token: 0x06002AE9 RID: 10985 RVA: 0x000F5860 File Offset: 0x000F3A60
	public static string a(string A_0)
	{
		string text = A_0;
		int num = 1;
		while (Directory.Exists(d5x.d(text)) && num < 2147483647)
		{
			num++;
			text = A_0 + "-" + num.ToString();
		}
		if (num == 2147483647)
		{
			text = A_0 + "-" + Guid.NewGuid().ToString("N") + Guid.NewGuid().ToString("N");
		}
		return text;
	}
}
