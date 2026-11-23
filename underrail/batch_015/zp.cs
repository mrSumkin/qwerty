using System;
using TimelapseVertigo.Generators;

// Token: 0x02000715 RID: 1813
public static class zp
{
	// Token: 0x06002F03 RID: 12035 RVA: 0x0011DA60 File Offset: 0x0011BC60
	public static double a()
	{
		return zp.a.NextDouble();
	}

	// Token: 0x06002F04 RID: 12036 RVA: 0x0011DA6C File Offset: 0x0011BC6C
	public static bool a(double A_0)
	{
		return zp.a.NextDouble() < A_0;
	}

	// Token: 0x06002F05 RID: 12037 RVA: 0x0011DA7C File Offset: 0x0011BC7C
	public static fv b(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("PlasmaCore", int.MinValue, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return zp.a("EnergyCores\\" + text);
		}
		return null;
	}

	// Token: 0x06002F06 RID: 12038 RVA: 0x0011DAC8 File Offset: 0x0011BCC8
	public static fv a(string A_0)
	{
		if (ez2.GetItemDefinition<a1k>("Components\\" + A_0, true) != null)
		{
			return new fv(ez2.CreateDefinitonProvider<a1k>("Components\\" + A_0));
		}
		return null;
	}

	// Token: 0x06002F07 RID: 12039 RVA: 0x0011DAF8 File Offset: 0x0011BCF8
	public static fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("SoftFoamPadding", int.MinValue, int.MaxValue, 1);
		itemPoolForQuality.a("HighDensityFoamPadding", 35, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return zp.a("Padding\\" + text);
		}
		return null;
	}

	// Token: 0x06002F08 RID: 12040 RVA: 0x0011DB54 File Offset: 0x0011BD54
	public static fv d(int A_0, string A_1 = null)
	{
		string text;
		if (A_1 != null)
		{
			text = A_1;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("Steel", int.MinValue, int.MaxValue, 4);
			itemPoolForQuality.a("TungstenSteel", 55, int.MaxValue, 2);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return zp.a("MetalPlates\\" + text);
		}
		return null;
	}

	// Token: 0x06002F09 RID: 12041 RVA: 0x0011DBC0 File Offset: 0x0011BDC0
	public static fv c(int A_0, string A_1 = null)
	{
		string text;
		if (A_1 != null)
		{
			text = A_1;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(d05.a(1, A_0, 40));
			itemPoolForQuality.a("RathoundLeather", 21, 40, 15);
			itemPoolForQuality.a("CaveHopperLeather", int.MinValue, 25, 11);
			itemPoolForQuality.a("MutatedDogLeather", 35, 50, 1);
			itemPoolForQuality.a("PigLeather", 30, 50, 7);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return zp.a("Leather\\" + text);
		}
		return null;
	}

	// Token: 0x06002F0A RID: 12042 RVA: 0x0011DC50 File Offset: 0x0011BE50
	public static fv b(int A_0, string A_1 = null)
	{
		string text;
		if (!string.IsNullOrEmpty(A_1))
		{
			text = A_1;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("BlackCloth", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("AluminizedCloth", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return zp.a("Fabric\\" + text);
		}
		return null;
	}

	// Token: 0x06002F0B RID: 12043 RVA: 0x0011DCC0 File Offset: 0x0011BEC0
	public static fv a(int A_0, string A_1 = null)
	{
		string text;
		if (A_1 != null)
		{
			text = A_1;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("LaminatedFabric", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("ReinforcedFabric", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return zp.a("BallisticPanels\\" + text);
		}
		return null;
	}

	// Token: 0x06002F0C RID: 12044 RVA: 0x0011DD2C File Offset: 0x0011BF2C
	public static fv a(int A_0, double A_1)
	{
		if (zp.a.NextDouble() < A_1)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("MetalArmorEnhancements\\SteelSpikes", 35, int.MaxValue, 4);
			itemPoolForQuality.a("MetalArmorEnhancements\\SerratedSteelBlade", 35, int.MaxValue, 4);
			itemPoolForQuality.a("MetalPlates\\Steel", 25, int.MaxValue, 4);
			itemPoolForQuality.a("MetalArmorEnhancements\\TungstenSteelSpikes", 50, int.MaxValue, 2);
			itemPoolForQuality.a("MetalArmorEnhancements\\SerratedTungstenSteelBlade", 50, int.MaxValue, 2);
			itemPoolForQuality.a("MetalPlates\\TungstenSteel", 50, int.MaxValue, 2);
			itemPoolForQuality.a("MetalArmorEnhancements\\TiChromeSpikes", 85, int.MaxValue, 1);
			itemPoolForQuality.a("MetalArmorEnhancements\\SerratedTiChromeBlade", 85, int.MaxValue, 1);
			itemPoolForQuality.a("MetalPlates\\TiChrome", 85, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return zp.a(text);
			}
		}
		return null;
	}

	// Token: 0x04001A19 RID: 6681
	public static Random a = new Random();
}
