using System;
using Microsoft.Xna.Framework;

// Token: 0x02000722 RID: 1826
public static class dcl
{
	// Token: 0x06002F67 RID: 12135 RVA: 0x0011F3C0 File Offset: 0x0011D5C0
	public static int a()
	{
		int num = (int)((DateTime.Now - default(DateTime)).TotalMilliseconds % 600.0 / 101.0);
		if (num > 3)
		{
			num = 6 - num;
		}
		return num;
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x0011F40C File Offset: 0x0011D60C
	public static Color a(ci8? A_0)
	{
		if (A_0.GetValueOrDefault() == ci8.c)
		{
			return Color.Red;
		}
		if (A_0.GetValueOrDefault() == ci8.b)
		{
			return Color.SkyBlue;
		}
		return adi.c;
	}
}
