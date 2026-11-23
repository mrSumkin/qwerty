using System;
using System.Text;

// Token: 0x020000CB RID: 203
public static class e5j
{
	// Token: 0x0600047E RID: 1150 RVA: 0x00014678 File Offset: 0x00012878
	public static bool c(this object A_0, params object[] A_1)
	{
		foreach (object obj in A_1)
		{
			if (A_0 == obj)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600047F RID: 1151 RVA: 0x000146A8 File Offset: 0x000128A8
	public static bool b(this object A_0, params object[] A_1)
	{
		foreach (object obj in A_1)
		{
			if (obj != null && A_0.Equals(obj))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000480 RID: 1152 RVA: 0x000146E4 File Offset: 0x000128E4
	public static bool a(this object A_0, params object[] A_1)
	{
		foreach (object obj in A_1)
		{
			if (A_0 == obj)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x00014714 File Offset: 0x00012914
	public static string a(this string A_0)
	{
		StringBuilder stringBuilder = new StringBuilder(A_0);
		for (int i = 0; i < stringBuilder.Length; i++)
		{
			char c = stringBuilder[i];
			if (i != 0 && c >= 'A' && c <= 'Z')
			{
				stringBuilder.Insert(i++, " ");
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000482 RID: 1154 RVA: 0x00014774 File Offset: 0x00012974
	public static string a(this object A_0)
	{
		czh.a(A_0, "obj");
		return A_0.ToString().a();
	}
}
