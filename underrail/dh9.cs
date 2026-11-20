using System;
using System.Collections.Generic;

// Token: 0x020018EF RID: 6383
public static class dh9
{
	// Token: 0x0600878E RID: 34702 RVA: 0x00380448 File Offset: 0x0037E648
	public static string c(string A_0)
	{
		return qv.b("ui/" + A_0);
	}

	// Token: 0x0600878F RID: 34703 RVA: 0x0038045C File Offset: 0x0037E65C
	public static string b(string A_0)
	{
		return qv.b("combatLog/" + A_0);
	}

	// Token: 0x06008790 RID: 34704 RVA: 0x00380470 File Offset: 0x0037E670
	public static string a(string A_0)
	{
		return qv.b("enums/" + A_0);
	}

	// Token: 0x06008791 RID: 34705 RVA: 0x00380484 File Offset: 0x0037E684
	public static string b(object A_0)
	{
		string text = dh9.a(A_0);
		if (!string.IsNullOrEmpty(text))
		{
			return text.ToLowerInvariant();
		}
		return null;
	}

	// Token: 0x06008792 RID: 34706 RVA: 0x003804AC File Offset: 0x0037E6AC
	public static string a(object A_0)
	{
		if (A_0 == null)
		{
			return null;
		}
		string str = A_0.GetType().Name + "." + A_0.ToString();
		string text = qv.b("enums/" + str);
		if (string.IsNullOrEmpty(text))
		{
			return A_0.ToString().a();
		}
		return text;
	}

	// Token: 0x06008793 RID: 34707 RVA: 0x00380508 File Offset: 0x0037E708
	public static string a(string A_0, string A_1)
	{
		if (string.IsNullOrEmpty(A_0) || string.IsNullOrEmpty(A_1))
		{
			return A_1;
		}
		string text = dh9.a(A_0 + "." + A_1);
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		return A_1;
	}

	// Token: 0x06008794 RID: 34708 RVA: 0x00380550 File Offset: 0x0037E750
	public static string a(string A_0, double A_1, bool A_2 = false)
	{
		string text;
		if (A_1 > 4.0)
		{
			text = A_0 + "";
		}
		else if (A_1 > 1.0)
		{
			text = A_0 + "s4";
		}
		else
		{
			text = A_0;
		}
		if (A_2)
		{
			text += "L";
		}
		return text;
	}

	// Token: 0x06008795 RID: 34709 RVA: 0x003805B4 File Offset: 0x0037E7B4
	public static string a(List<string> A_0)
	{
		string text = "";
		for (int i = 0; i < A_0.Count; i++)
		{
			if (i != 0 && A_0.Count > 2)
			{
				if (i == A_0.Count - 1)
				{
					text = text + ", " + dh9.c("и") + " ";
				}
				else
				{
					text += ", ";
				}
			}
			else if (i != 0 && A_0.Count == 2)
			{
				text = text + " " + dh9.c("и") + " ";
			}
			text += A_0[i];
		}
		return text;
	}
}
