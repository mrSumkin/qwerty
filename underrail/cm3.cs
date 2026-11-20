using System;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02000492 RID: 1170
public static class cm3
{
	// Token: 0x06001DEF RID: 7663 RVA: 0x000A6000 File Offset: 0x000A4200
	public static string a(InterfaceElementSize2 A_0, bool A_1 = false)
	{
		if (A_0 == InterfaceElementSize2.Huge)
		{
			if (A_1)
			{
				return egg.bi;
			}
			return egg.bg;
		}
		else if (A_0 == InterfaceElementSize2.ExtraLarge)
		{
			if (egg.v)
			{
				return egg.t;
			}
			if (A_1)
			{
				return egg.a6;
			}
			return egg.a4;
		}
		else if (A_0 == InterfaceElementSize2.Large)
		{
			if (egg.v)
			{
				return egg.t;
			}
			if (A_1)
			{
				return egg.at;
			}
			return egg.@as;
		}
		else
		{
			if (egg.v)
			{
				return egg.n;
			}
			if (A_1)
			{
				return egg.ah;
			}
			return egg.ag;
		}
	}

	// Token: 0x06001DF0 RID: 7664 RVA: 0x000A609C File Offset: 0x000A429C
	public static string a(InterfaceElementSize2 A_0)
	{
		if (A_0 == InterfaceElementSize2.Huge)
		{
			return egg.bi;
		}
		if (A_0 == InterfaceElementSize2.ExtraLarge)
		{
			if (egg.v)
			{
				return egg.q;
			}
			return egg.a6;
		}
		else if (A_0 == InterfaceElementSize2.Large)
		{
			if (egg.v)
			{
				return egg.q;
			}
			return egg.at;
		}
		else
		{
			if (egg.v)
			{
				return egg.q;
			}
			return egg.al;
		}
	}

	// Token: 0x06001DF1 RID: 7665 RVA: 0x000A6108 File Offset: 0x000A4308
	public static string a()
	{
		if (egg.v)
		{
			return egg.p;
		}
		return egg.ac;
	}

	// Token: 0x06001DF2 RID: 7666 RVA: 0x000A6120 File Offset: 0x000A4320
	public static ecs a(InterfaceElementSize2 A_0, string A_1, Color? A_2 = null, Color? A_3 = null, string A_4 = null, string A_5 = null)
	{
		if (A_1 == null)
		{
			return null;
		}
		d22 d = new d22((A_4 != null) ? A_4 : cm3.a(A_0, false), (A_2 != null) ? A_2.Value : Color.White);
		d22 d2 = new d22((A_4 != null) ? A_4 : cm3.a(A_0, false), (A_3 != null) ? A_3.Value : cm3.d);
		d22 d3 = new d22((A_5 != null) ? A_5 : cm3.a(A_0, true), (A_2 != null) ? A_2.Value : Color.White);
		d22 d4 = new d22((A_5 != null) ? A_5 : cm3.a(A_0, true), (A_3 != null) ? A_3.Value : cm3.d);
		ecs ecs = new ecs();
		bool flag = false;
		foreach (string text in A_1.Split(new string[]
		{
			"\r\n"
		}, StringSplitOptions.None))
		{
			dl6 dl = new dl6();
			ecs.a.Add(dl);
			bool flag2 = true;
			foreach (string text2 in text.Split(new string[]
			{
				"::"
			}, StringSplitOptions.None))
			{
				if (!flag2)
				{
					flag = !flag;
				}
				if (!string.IsNullOrEmpty(text2))
				{
					if (!flag)
					{
						bool flag3 = true;
						foreach (string text3 in text2.Split(new string[]
						{
							"*"
						}, StringSplitOptions.None))
						{
							flag3 = !flag3;
							if (!string.IsNullOrEmpty(text3))
							{
								bph item = new bph(flag3 ? d3 : d, text3, null);
								dl.a.Add(item);
							}
						}
					}
					else
					{
						bool flag4 = true;
						foreach (string text4 in text2.Split(new string[]
						{
							"*"
						}, StringSplitOptions.None))
						{
							flag4 = !flag4;
							if (!string.IsNullOrEmpty(text4))
							{
								bph item2 = new bph(flag4 ? d4 : d2, text4, null);
								dl.a.Add(item2);
							}
						}
					}
				}
				flag2 = false;
			}
			if (dl.a.Count == 0)
			{
				dl.a.Add(new bph(d, string.Empty, null));
			}
		}
		return ecs;
	}

	// Token: 0x0400128F RID: 4751
	public const string a = "::";

	// Token: 0x04001290 RID: 4752
	public const string b = "*";

	// Token: 0x04001291 RID: 4753
	public static readonly Color c = Color.Yellow;

	// Token: 0x04001292 RID: 4754
	public static readonly Color d = new Color(0, 255, 0);
}
