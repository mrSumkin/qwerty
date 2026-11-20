using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001176 RID: 4470
public static class ciz
{
	// Token: 0x06005F92 RID: 24466 RVA: 0x0029A714 File Offset: 0x00298914
	public static List<ecs> a(string A_0, dsu A_1, Color? A_2, Color? A_3)
	{
		bool flag = false;
		dsu dsu;
		if (A_1 == dsu.a && !string.IsNullOrEmpty(A_0) && A_0.StartsWith("::") && A_0.EndsWith("::"))
		{
			if (Enumerable.Count<char>(A_0, new Func<char, bool>(ciz.a.a.a)) == 4)
			{
				dsu = dsu.b;
				flag = true;
				goto IL_6C;
			}
		}
		dsu = A_1;
		IL_6C:
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		string a_;
		string a_2;
		ciz.a(serviceOrThrow.aq1().b().l(), dsu, out a_, out a_2);
		ecs ecs = cm3.a(InterfaceElementSize2.Auto, A_0, A_2, A_3, a_, a_2);
		if (flag)
		{
			ecs.b.Add("forceNarration");
		}
		double num;
		switch (serviceOrThrow.aq1().b().l())
		{
		case InterfaceElementSize2.Large:
			num = 1.5;
			goto IL_119;
		case InterfaceElementSize2.ExtraLarge:
			num = 1.75;
			goto IL_119;
		case InterfaceElementSize2.Huge:
			num = 2.0;
			goto IL_119;
		}
		num = 1.0;
		IL_119:
		if (dsu == dsu.a)
		{
			return ecs.a((int)((double)aju.ac * num), (int)((double)aju.ad * num));
		}
		return ecs.a((int)((double)aju.ae * num), (int)((double)aju.af * num));
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x0029A878 File Offset: 0x00298A78
	private static void a(InterfaceElementSize2 A_0, dsu A_1, out string A_2, out string A_3)
	{
		switch (A_0)
		{
		case InterfaceElementSize2.Large:
			A_2 = ((A_1 == dsu.b) ? egg.av : egg.@as);
			A_3 = ((A_1 == dsu.b) ? egg.av : egg.at);
			return;
		case InterfaceElementSize2.ExtraLarge:
			A_2 = ((A_1 == dsu.b) ? egg.az : egg.aw);
			A_3 = ((A_1 == dsu.b) ? egg.az : egg.ax);
			return;
		case InterfaceElementSize2.Huge:
			A_2 = ((A_1 == dsu.b) ? egg.a3 : egg.a0);
			A_3 = ((A_1 == dsu.b) ? egg.a3 : egg.a1);
			return;
		}
		A_2 = ((A_1 == dsu.b) ? egg.ae : egg.ad);
		A_3 = ((A_1 == dsu.b) ? egg.ae : egg.ac);
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x0029A968 File Offset: 0x00298B68
	public static double b(ecs A_0)
	{
		string text = "";
		foreach (dl6 dl in A_0.a)
		{
			foreach (bph bph in dl.a)
			{
				text = text + bph.b + " ";
			}
		}
		return ciz.a(text);
	}

	// Token: 0x06005F95 RID: 24469 RVA: 0x0029AA18 File Offset: 0x00298C18
	public static double a(string A_0)
	{
		int num = A_0.Split(new char[]
		{
			' '
		}, StringSplitOptions.RemoveEmptyEntries).Length;
		return Math.Max(aju.aa, (double)num * aju.ab);
	}

	// Token: 0x06005F96 RID: 24470 RVA: 0x0029AA4C File Offset: 0x00298C4C
	public static bool a(ecs A_0)
	{
		bool result = false;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		KeyValuePair<string, string>[] array = new KeyValuePair<string, string>[2];
		foreach (object obj in Enum.GetValues(typeof(dsu)))
		{
			dsu dsu = (dsu)obj;
			string key;
			string value;
			ciz.a(serviceOrThrow.aq1().b().l(), dsu, out key, out value);
			array[(int)dsu] = new KeyValuePair<string, string>(key, value);
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		foreach (object obj2 in Enum.GetValues(typeof(dsu)))
		{
			dsu dsu2 = (dsu)obj2;
			for (int i = 1; i <= 4; i++)
			{
				if (i != (int)serviceOrThrow.aq1().b().l())
				{
					string key2;
					string key3;
					ciz.a((InterfaceElementSize2)i, dsu2, out key2, out key3);
					dictionary[key2] = array[(int)dsu2].Key;
					dictionary[key3] = array[(int)dsu2].Value;
				}
			}
		}
		foreach (dl6 dl in A_0.a)
		{
			foreach (bph bph in dl.a)
			{
				string a;
				if (dictionary.TryGetValue(bph.a.a, out a))
				{
					bph.a.a = a;
					result = true;
				}
			}
		}
		return result;
	}

	// Token: 0x02001177 RID: 4471
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06005F99 RID: 24473 RVA: 0x0029AC74 File Offset: 0x00298E74
		internal bool a(char A_0)
		{
			return A_0 == ':';
		}

		// Token: 0x040027F7 RID: 10231
		public static readonly ciz.a a = new ciz.a();

		// Token: 0x040027F8 RID: 10232
		public static Func<char, bool> b;
	}
}
