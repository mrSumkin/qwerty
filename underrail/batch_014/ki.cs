using System;
using System.Globalization;

// Token: 0x020000B4 RID: 180
public static class ki
{
	// Token: 0x0600041C RID: 1052 RVA: 0x000138A0 File Offset: 0x00011AA0
	public static string a(string A_0, params object[] A_1)
	{
		return string.Format(CultureInfo.InvariantCulture, A_0, A_1);
	}
}
