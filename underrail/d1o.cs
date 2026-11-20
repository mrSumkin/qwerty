using System;
using System.Linq;
using System.Reflection;
using Microsoft.Xna.Framework.Input;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000685 RID: 1669
public static class d1o
{
	// Token: 0x06002AE0 RID: 10976 RVA: 0x000F5330 File Offset: 0x000F3530
	public static string c(Hotkey A_0)
	{
		string text = dh9.a(A_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		MemberInfo memberInfo = Enumerable.FirstOrDefault<MemberInfo>(typeof(Hotkey).GetMember(A_0.ToString()));
		if (memberInfo != null)
		{
			cgf cgf = Enumerable.FirstOrDefault<object>(memberInfo.GetCustomAttributes(typeof(cgf), true)) as cgf;
			if (cgf != null)
			{
				return cgf.a();
			}
		}
		return "????";
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000F53B4 File Offset: 0x000F35B4
	public static string b(Hotkey A_0)
	{
		return d1o.a(d1o.a(A_0));
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000F53C4 File Offset: 0x000F35C4
	public static string a(Keys A_0)
	{
		if (A_0 == Keys.None)
		{
			return "";
		}
		if (A_0 != Keys.Space)
		{
			char c = b5u.a(A_0, false, true);
			if (c != '\0')
			{
				return c.ToString();
			}
		}
		return A_0.ToString();
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000F540C File Offset: 0x000F360C
	public static Keys a(Hotkey A_0)
	{
		cnk cnk = ces.a();
		if (cnk != null)
		{
			Keys result;
			cnk.aq1().e().c().TryGetValue(A_0, out result);
			return result;
		}
		return Keys.None;
	}
}
