using System;

// Token: 0x020018F1 RID: 6385
public static class bsr
{
	// Token: 0x06008798 RID: 34712 RVA: 0x00380688 File Offset: 0x0037E888
	public static string c(cs5 A_0)
	{
		string text = "";
		if (A_0 != cs5.a)
		{
			if ((A_0 & cs5.b) != cs5.a)
			{
				text += " оружием ближнего боя";
			}
			else if ((A_0 & cs5.c) != cs5.a)
			{
				text += " оружием дальнего боя";
			}
			else if ((A_0 & cs5.d) != cs5.a)
			{
				text += "рукопашного боя и кулачного оружия";
			}
			text += "";
		}
		else
		{
			text += "оружием и без оружия";
		}
		return text;
	}

	// Token: 0x06008799 RID: 34713 RVA: 0x00380708 File Offset: 0x0037E908
	public static string b(cs5 A_0)
	{
		string text = "";
		if (A_0 != cs5.a)
		{
			if ((A_0 & cs5.b) != cs5.a)
			{
				text += " оружием ближнего боя";
			}
			else if ((A_0 & cs5.c) != cs5.a)
			{
				text += " оружием дальнего боя";
			}
			else if ((A_0 & cs5.d) != cs5.a)
			{
				text += "рукопашного боя и кулачного оружия";
			}
			text += "";
		}
		else
		{
			text += "оружием";
		}
		return text;
	}

	// Token: 0x0600879A RID: 34714 RVA: 0x00380788 File Offset: 0x0037E988
	public static string a(cs5 A_0)
	{
		string text = "";
		if (A_0 != cs5.a)
		{
			if ((A_0 & cs5.b) != cs5.a)
			{
				text += " оружием ближнего боя";
			}
			else if ((A_0 & cs5.c) != cs5.a)
			{
				text += " оружием дальнего боя";
			}
			else if ((A_0 & cs5.d) != cs5.a)
			{
				text += "рукопашного боя и кулачного оружия";
			}
			text += "";
		}
		else
		{
			text += "оружием и без оружия";
		}
		return text;
	}
}
