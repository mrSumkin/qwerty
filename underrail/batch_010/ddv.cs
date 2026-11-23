using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001E0F RID: 7695
public static class ddv
{
	// Token: 0x0600AA5F RID: 43615 RVA: 0x003F3B80 File Offset: 0x003F1D80
	static ddv()
	{
		ddv.a();
	}

	// Token: 0x0600AA60 RID: 43616 RVA: 0x003F3BA0 File Offset: 0x003F1DA0
	private static void a()
	{
		foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
		{
			if (type.IsClass && !type.IsAbstract && typeof(csn).IsAssignableFrom(type))
			{
				a1 a = Enumerable.FirstOrDefault<object>(type.GetCustomAttributes(typeof(a1), false)) as a1;
				if (a != null)
				{
					ddv.a[type] = a.Name;
				}
			}
		}
	}

	// Token: 0x0600AA61 RID: 43617 RVA: 0x003F3C30 File Offset: 0x003F1E30
	public static string b(Type A_0)
	{
		string text;
		ddv.a.TryGetValue(A_0, out text);
		string text2 = dh9.a("SkillEnum." + text);
		if (!string.IsNullOrEmpty(text2))
		{
			text = text2;
		}
		return text;
	}

	// Token: 0x0600AA62 RID: 43618 RVA: 0x003F3C6C File Offset: 0x003F1E6C
	public static bool a(Type A_0)
	{
		csn csn = ddv.b.a(A_0);
		return csn != null && (csn.DLC == null || dk2.b(csn.DLC));
	}

	// Token: 0x0600AA63 RID: 43619 RVA: 0x003F3CA8 File Offset: 0x003F1EA8
	public static bool a(PsiSchool A_0)
	{
		return A_0 != PsiSchool.TemporalManipulation || ddv.a(typeof(p5));
	}

	// Token: 0x04003FBF RID: 16319
	private static Dictionary<Type, string> a = new Dictionary<Type, string>();

	// Token: 0x04003FC0 RID: 16320
	private static axp b = new axp();
}
