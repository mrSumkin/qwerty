using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TimelapseVertigo.Common.Settings;

// Token: 0x02001FC5 RID: 8133
public static class czo
{
	// Token: 0x0600BF17 RID: 48919 RVA: 0x00421A78 File Offset: 0x0041FC78
	public static bg1 a(esj A_0)
	{
		double num = (double)A_0.c / (double)A_0.d;
		double num2 = Math.Round(num, 2);
		bool flag;
		double num3 = czo.a(num, out flag);
		string str = num3.ToString("0.00", CultureInfo.InvariantCulture).Replace(".", "p");
		MainMenuTheme mainMenuTheme = bpo.GetServiceOrThrow<cnk>().aq1().b().q();
		string str2;
		if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.HeavyDuty) && dk2.e())
		{
			str2 = "xphw_mm";
		}
		else if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.Expedition) && dk2.f())
		{
			str2 = "xpbl_mm";
		}
		else
		{
			str2 = "mm";
		}
		string text = string.Format("concept\\" + str2 + "\\" + str, new object[0]);
		bg1 bg = new bg1();
		bg.a = true;
		bg.b = text;
		bg.Text = null;
		bg.Location = new Point(0, 0);
		bg.Size = A_0;
		bg.IsPrivateComponent = false;
		bg.e = true;
		if (!flag)
		{
			Texture2D resource = bpo.GetServiceOrThrow<cne>().GetResource<Texture2D>(text, null);
			if (text != null)
			{
				Rectangle value;
				if (num3 > num2)
				{
					value = new Rectangle(0, 0, (int)((double)resource.Height * num), resource.Height);
				}
				else
				{
					value = new Rectangle(0, 0, resource.Width, (int)((double)resource.Width / num));
				}
				bg.d = new Rectangle?(value);
			}
		}
		return bg;
	}

	// Token: 0x0600BF18 RID: 48920 RVA: 0x00421C0C File Offset: 0x0041FE0C
	public static string c()
	{
		MainMenuTheme mainMenuTheme = bpo.GetServiceOrThrow<cnk>().aq1().b().q();
		string result;
		if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.HeavyDuty) && dk2.e())
		{
			result = null;
		}
		else if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.Expedition) && dk2.f())
		{
			result = "xpbl_MainOpener";
		}
		else
		{
			result = "MainOpener";
		}
		return result;
	}

	// Token: 0x0600BF19 RID: 48921 RVA: 0x00421C78 File Offset: 0x0041FE78
	public static string b()
	{
		MainMenuTheme mainMenuTheme = bpo.GetServiceOrThrow<cnk>().aq1().b().q();
		string result;
		if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.HeavyDuty) && dk2.e())
		{
			result = "xphw_Main";
		}
		else if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.Expedition) && dk2.f())
		{
			result = "xpbl_MainLoop";
		}
		else
		{
			result = "MainLoop";
		}
		return result;
	}

	// Token: 0x0600BF1A RID: 48922 RVA: 0x00421CE8 File Offset: 0x0041FEE8
	public static int a()
	{
		MainMenuTheme mainMenuTheme = bpo.GetServiceOrThrow<cnk>().aq1().b().q();
		int result;
		if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.HeavyDuty) && dk2.e())
		{
			result = 0;
		}
		else if ((mainMenuTheme == MainMenuTheme.Default || mainMenuTheme == MainMenuTheme.Expedition) && dk2.f())
		{
			result = 40;
		}
		else
		{
			result = 40;
		}
		return result;
	}

	// Token: 0x0600BF1B RID: 48923 RVA: 0x00421D4C File Offset: 0x0041FF4C
	private static double a(double A_0, out bool A_1)
	{
		double num = Math.Round(A_0, 2);
		double num2;
		if (czo.a.Contains(num))
		{
			num2 = num;
			A_1 = true;
		}
		else
		{
			A_1 = false;
			num2 = czo.a[0];
			foreach (double num3 in czo.a)
			{
				if (Math.Abs(num3 - A_0) < Math.Abs(num2 - A_0))
				{
					num2 = num3;
				}
			}
		}
		return num2;
	}

	// Token: 0x040044B4 RID: 17588
	private static readonly List<double> a = new List<double>
	{
		1.6,
		1.78,
		1.33,
		1.25,
		2.37
	};
}
