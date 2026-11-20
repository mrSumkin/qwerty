using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020007CD RID: 1997
public static class dkr
{
	// Token: 0x06003217 RID: 12823 RVA: 0x001341B0 File Offset: 0x001323B0
	public static int f()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(dkr.b, null);
			if (primitivePropertyValue != null)
			{
				return Math.Min(3, (int)(serviceOrThrow.aqu().p() - primitivePropertyValue.Value).TotalSeconds / dkr.e);
			}
		}
		return 0;
	}

	// Token: 0x06003218 RID: 12824 RVA: 0x00134228 File Offset: 0x00132428
	public static double[] e()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>(dkr.b, null);
			if (primitivePropertyValue != null)
			{
				int num = 0;
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_forger_gauntletRigged", new bool?(false)).Value)
				{
					num = 180;
				}
				int num2 = (int)Math.Max(1.0, serviceOrThrow.aqu().p().TotalSeconds - primitivePropertyValue.Value.TotalSeconds);
				int num3 = (int)((double)(dkr.g * dkr.f + num) * (0.75 + 0.5 * cuo.a.NextDouble()));
				int num4 = (int)((double)(dkr.g * dkr.f + num) * (0.75 + 0.5 * cuo.a.NextDouble()));
				double num5 = d05.b(0.1, (double)(num2 / num3) - 0.15 + 0.3 * cuo.a.NextDouble(), 2.0);
				double num6 = d05.b(0.1, (double)(num2 / num4) - 0.15 + 0.3 * cuo.a.NextDouble(), 2.0);
				return new double[]
				{
					num5,
					num6
				};
			}
		}
		return new double[]
		{
			2.0 * cuo.a.NextDouble(),
			2.0 * cuo.a.NextDouble()
		};
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x001343FC File Offset: 0x001325FC
	public static int d()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int num = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(dkr.a, new int?(0)).Value;
			num++;
			serviceOrThrow.aqu().r()[dkr.a] = num;
			return num;
		}
		return 0;
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x00134460 File Offset: 0x00132660
	public static void c()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = d5x.q();
			if (Directory.Exists(text))
			{
				string[] files = Directory.GetFiles(text, "cc_g*.uz");
				List<string> list = new List<string>();
				string[] array = files;
				for (int i = 0; i < array.Length; i++)
				{
					string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(array[i]);
					int num;
					if (fileNameWithoutExtension.Length > 4 && int.TryParse(fileNameWithoutExtension.Substring(4), NumberStyles.Number, CultureInfo.InvariantCulture, out num))
					{
						list.Add(fileNameWithoutExtension);
					}
				}
				List<string> list2 = new List<string>();
				for (int j = 0; j < dkr.g; j++)
				{
					int index = cuo.a.Next(list.Count);
					list2.Add(list[index]);
					list.RemoveAt(index);
				}
				List<string> list3 = new List<string>(dkr.h);
				List<string> list4 = new List<string>();
				int num2 = 0;
				while (num2 < dkr.g && list3.Count != 0)
				{
					int index2 = cuo.a.Next(list3.Count);
					list4.Add(list3[index2]);
					list3.RemoveAt(index2);
					num2++;
				}
				serviceOrThrow.aqu().r()[dkr.b] = serviceOrThrow.aqu().p();
				serviceOrThrow.aqu().r()[dkr.a] = 0;
				serviceOrThrow.aqu().r()[dkr.c] = list2;
				serviceOrThrow.aqu().r()[dkr.d] = list4;
			}
		}
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x0013460C File Offset: 0x0013280C
	public static coh b()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(dkr.a, new int?(0)).Value;
		List<string> list = serviceOrThrow.aqu().r()[dkr.d] as List<string>;
		if (list != null && value < list.Count)
		{
			string str = list[value];
			return new d48(new LibraryItemDefinitionProvider<a0z>("plot\\" + str));
		}
		return null;
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x00134690 File Offset: 0x00132890
	public static void a(aud A_0, params string[] A_1)
	{
		coh coh = dkr.b();
		if (coh != null)
		{
			List<c7j> list = new List<c7j>();
			for (int i = 0; i < A_1.Length; i++)
			{
				Guid a_;
				if (Guid.TryParse(A_1[i], out a_))
				{
					c7j c7j = new EntityAspectReference<c7j, bim>(A_0, a_).ao();
					if (c7j != null && !string.IsNullOrEmpty(c7j.a8().y8()))
					{
						list.Add(c7j);
					}
				}
			}
			if (list.Count > 0)
			{
				list[cuo.a.Next(list.Count)].ItemContainer.z3(coh, true);
			}
		}
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x00134738 File Offset: 0x00132938
	public static void a()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			int value = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<int>(dkr.a, new int?(0)).Value;
			List<string> classPropertyValue = serviceOrThrow.aqu().r().GetClassPropertyValue<List<string>>(dkr.c);
			if (classPropertyValue != null && classPropertyValue.Count > value)
			{
				c2w a_ = new c2w(classPropertyValue[value], "entrance");
				a0l.a(serviceOrThrow.aqu().v().b() as c5x, a_, 0, null);
				return;
			}
			c2w a_2 = new c2w("cc_gfin", "entrance");
			a0l.a(serviceOrThrow.aqu().v().b() as c5x, a_2, 0, null);
		}
	}

	// Token: 0x04001ADB RID: 6875
	public static readonly string a = "GauntletRoomsDone";

	// Token: 0x04001ADC RID: 6876
	public static readonly string b = "GauntletStarted";

	// Token: 0x04001ADD RID: 6877
	public static readonly string c = "GauntletMaps";

	// Token: 0x04001ADE RID: 6878
	public static readonly string d = "AvailableKeys";

	// Token: 0x04001ADF RID: 6879
	public static readonly int e = 480;

	// Token: 0x04001AE0 RID: 6880
	public static readonly int f = 360;

	// Token: 0x04001AE1 RID: 6881
	public static readonly int g = 4;

	// Token: 0x04001AE2 RID: 6882
	public static readonly string[] h = new string[]
	{
		"GauntletKeyBlue",
		"GauntletKeyGreen",
		"GauntletKeyRed",
		"GauntletKeyYellow"
	};
}
