using System;

// Token: 0x020018D3 RID: 6355
public static class l4
{
	// Token: 0x060086C9 RID: 34505 RVA: 0x0037D0C4 File Offset: 0x0037B2C4
	public static int a(double A_0)
	{
		return (int)Math.Ceiling(A_0 / (double)d0u.b);
	}

	// Token: 0x060086CA RID: 34506 RVA: 0x0037D0D8 File Offset: 0x0037B2D8
	public static string c(double A_0, bool A_1)
	{
		string text;
		if (A_1)
		{
			text = l4.a(l4.a(A_0), false);
		}
		else
		{
			double num = A_0 / 1000.0;
			int num2 = 0;
			int num3 = 0;
			int num4 = 0;
			if (num4 >= 3600)
			{
				num2 = (int)(num / 3600.0);
			}
			double num5 = num - (double)(num2 * 3600);
			if (num5 >= 60.0)
			{
				num3 = (int)(num5 / 60.0);
			}
			num4 = (int)(num5 - (double)(num3 * 60));
			text = "";
			if (num2 > 0)
			{
				text = text + num2.ToString() + dh9.c("HoursLetter");
			}
			if (num3 > 0)
			{
				if (text.Length > 0)
				{
					text += " ";
				}
				text = text + num3.ToString() + dh9.c("MinutesLetter");
			}
			if (num4 > 0)
			{
				if (text.Length > 0)
				{
					text += " ";
				}
				text = text + num4.ToString() + dh9.c("SecondsLetter");
			}
		}
		return text;
	}

	// Token: 0x060086CB RID: 34507 RVA: 0x0037D1F4 File Offset: 0x0037B3F4
	public static string a(int A_0, bool A_1 = false)
	{
		string str;
		if (A_1)
		{
			str = dh9.c("TurnsLetter");
		}
		else
		{
			str = dh9.c(dh9.a("Turn", (double)A_0, true));
		}
		return A_0.ToString() + " " + str;
	}

	// Token: 0x060086CC RID: 34508 RVA: 0x0037D23C File Offset: 0x0037B43C
	public static string b(double A_0, bool A_1 = false)
	{
		string str;
		if (A_1)
		{
			str = dh9.c("TurnsLetter");
		}
		else
		{
			str = dh9.c(dh9.a("Turn", A_0, true));
		}
		return A_0.ToString() + " " + str;
	}

	// Token: 0x060086CD RID: 34509 RVA: 0x0037D284 File Offset: 0x0037B484
	public static string a(double A_0, bool A_1 = false)
	{
		return l4.a(l4.a(A_0), A_1);
	}
}
