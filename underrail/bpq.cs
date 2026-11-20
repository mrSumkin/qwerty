using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x020007C8 RID: 1992
public static class bpq
{
	// Token: 0x06003201 RID: 12801 RVA: 0x0013206C File Offset: 0x0013026C
	public static List<string> e(c5x A_0)
	{
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < 4; i++)
				{
					int num = cuo.a.Next(bpq.a.Length);
					list.Add(bpq.a[num]);
				}
				aspect.a()["Combo"] = list;
				aspect.a()["Attempts"] = 0;
				return list;
			}
		}
		return null;
	}

	// Token: 0x06003202 RID: 12802 RVA: 0x001320F0 File Offset: 0x001302F0
	public static List<string> d(c5x A_0)
	{
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null)
			{
				return aspect.a()["Combo"] as List<string>;
			}
		}
		return null;
	}

	// Token: 0x06003203 RID: 12803 RVA: 0x00132128 File Offset: 0x00130328
	public static int c(c5x A_0)
	{
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null)
			{
				return aspect.a().GetPrimitivePropertyValue<int>("Attempts", new int?(0)).Value;
			}
		}
		return 0;
	}

	// Token: 0x06003204 RID: 12804 RVA: 0x00132168 File Offset: 0x00130368
	public static int b(c5x A_0)
	{
		if (A_0 != null)
		{
			a3f aspect = A_0.GetAspect<a3f>();
			if (aspect != null)
			{
				int num = aspect.a().GetPrimitivePropertyValue<int>("Attempts", new int?(0)).Value;
				num++;
				aspect.a()["Attempts"] = num;
				return num;
			}
		}
		return 0;
	}

	// Token: 0x06003205 RID: 12805 RVA: 0x001321C4 File Offset: 0x001303C4
	public static void a(c5x A_0)
	{
		if (A_0 != null && A_0.Area != null && A_0.Zone != null)
		{
			List<string> list = bpq.d(A_0);
			if (list != null)
			{
				c5x c5x = new ar7(new Guid("bc0f7907-4630-432c-af2c-84054542867d"), A_0.Area).ao() as c5x;
				c5x c5x2 = new ar7(new Guid("eba841eb-1f26-42b9-8070-ac993189f71b"), A_0.Area).ao() as c5x;
				c5x c5x3 = new ar7(new Guid("737973f5-4955-4b82-bf98-91fe3bd3c5e3"), A_0.Area).ao() as c5x;
				c5x c5x4 = new ar7(new Guid("d9e01e7c-3ae8-48df-9c30-b34dbd2921ee"), A_0.Area).ao() as c5x;
				c5x c5x5 = new ar7(new Guid("bf794868-2aa2-47f1-96a2-d0c872c27f20"), A_0.Area).ao() as c5x;
				c5x c5x6 = new ar7(new Guid("de989d65-9774-4452-b7fe-64e8f05ea0b3"), A_0.Area).ao() as c5x;
				c5x c5x7 = new ar7(new Guid("584703c0-1cb9-47e5-8839-58d7cd8fd230"), A_0.Area).ao() as c5x;
				c5x c5x8 = new ar7(new Guid("5295793d-16d5-46a5-b9a5-500dc5ed25a5"), A_0.Area).ao() as c5x;
				ah7 ah = A_0.Zone.i("skocko1");
				ah7 ah2 = A_0.Zone.i("skocko2");
				ah7 ah3 = A_0.Zone.i("skocko3");
				ah7 ah4 = A_0.Zone.i("skocko4");
				List<c7j> list2 = Enumerable.ToList<c7j>(Enumerable.Select<c5x, c7j>(new c5x[]
				{
					c5x,
					c5x2,
					c5x3,
					c5x4
				}, new Func<c5x, c7j>(bpq.a.a.a)));
				List<alv> list3 = Enumerable.ToList<alv>(Enumerable.Select<c5x, alv>(new c5x[]
				{
					c5x5,
					c5x6,
					c5x7,
					c5x8
				}, new Func<c5x, alv>(bpq.a.a.b)));
				List<ah7> list4 = new List<ah7>
				{
					ah,
					ah2,
					ah3,
					ah4
				};
				if (c5x != null && c5x2 != null && c5x3 != null && c5x4 != null && c5x5 != null && c5x6 != null && c5x7 != null && c5x8 != null && ah != null && ah2 != null && ah3 != null && ah4 != null)
				{
					bool flag = true;
					foreach (c7j c7j in list2)
					{
						if (c7j.ItemContainer.z2().Count != 1 || c7j.ItemContainer.z2()[0].Definition.a5() == null || !Enumerable.Contains<string>(bpq.a, c7j.ItemContainer.z2()[0].Definition.a5()))
						{
							flag = false;
							break;
						}
					}
					if (!flag)
					{
						for (int i = 0; i < 4; i++)
						{
							list4[i].Enabled = false;
							list4[i].d();
							list3[i].a[1].c = null;
							list3[i].a[2].c = null;
						}
						return;
					}
					int num = bpq.b(A_0);
					int num2 = 0;
					List<string> list5 = new List<string>(list);
					HashSet<int> hashSet = new HashSet<int>();
					for (int j = 0; j < 4; j++)
					{
						if (list2[j].ItemContainer.z2()[0].Definition.a5() == list[j])
						{
							list4[num2].Light = new ae8(new Color(50, 255, 50), 1f, LightType.Increment);
							list4[num2].Enabled = true;
							list4[num2].d();
							list3[num2].a[1].c = new Color?(new Color(50, 255, 50));
							list3[num2].a[2].c = new Color?(new Color(50, 255, 50));
							hashSet.Add(j);
							list5[j] = null;
							num2++;
						}
					}
					if (num2 == 4)
					{
						crx crx = new crx();
						crx.a("cc_g8");
						crx.a(bbo.b);
						crx.a(new List<Guid>
						{
							new Guid("8b243266-b63f-4b58-980f-207550028bbf"),
							new Guid("e87168bb-8ac1-4572-9633-79273e8c55fd"),
							new Guid("e1da2f24-27b9-4524-896c-b72a9a53472e"),
							new Guid("7d3aaac2-37ae-4c3a-b6d6-463bf6dc90bc")
						});
						crx.ym(A_0, null, null);
					}
					else
					{
						for (int k = 0; k < 4; k++)
						{
							if (!hashSet.Contains(k))
							{
								string item = list2[k].ItemContainer.z2()[0].Definition.a5();
								int num3 = list5.IndexOf(item);
								if (num3 != -1)
								{
									list5[num3] = null;
									list4[num2].Light = new ae8(Color.Yellow, 1f, LightType.Increment);
									list4[num2].Enabled = true;
									list4[num2].d();
									list3[num2].a[1].c = new Color?(Color.Yellow);
									list3[num2].a[2].c = new Color?(Color.Yellow);
									num2++;
								}
							}
						}
						if (num == 4)
						{
							crx crx2 = new crx();
							crx2.a("cc_g8");
							crx2.a(bbo.b);
							crx2.a(new List<Guid>
							{
								new Guid("5be64817-36e6-4ced-bab0-c1a125c20065"),
								new Guid("41166478-4973-4fe4-a4ec-30fcd8ac16ff"),
								new Guid("bc2d1cb0-c5d1-4082-932f-53d54763792b"),
								new Guid("c3a9f253-fb63-49c0-a6fe-7339314dc975")
							});
							crx2.ym(A_0, null, null);
						}
					}
					for (int l = num2; l < 4; l++)
					{
						list4[l].Enabled = false;
						list4[l].d();
						list3[l].a[1].c = null;
						list3[l].a[2].c = null;
					}
				}
			}
		}
	}

	// Token: 0x04001AD5 RID: 6869
	public static readonly string[] a = new string[]
	{
		"acid.regular",
		"blood",
		"poison.BurrowerPoison",
		"morphine",
		"tranquilizer.Midazolam",
		"psionicCatalyst",
		"blackVitreous"
	};

	// Token: 0x020007C9 RID: 1993
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06003208 RID: 12808 RVA: 0x001328E8 File Offset: 0x00130AE8
		internal c7j a(c5x A_0)
		{
			return A_0.s.b as c7j;
		}

		// Token: 0x06003209 RID: 12809 RVA: 0x001328FC File Offset: 0x00130AFC
		internal alv b(c5x A_0)
		{
			return A_0.p.b;
		}

		// Token: 0x04001AD6 RID: 6870
		public static readonly bpq.a a = new bpq.a();

		// Token: 0x04001AD7 RID: 6871
		public static Func<c5x, c7j> b;

		// Token: 0x04001AD8 RID: 6872
		public static Func<c5x, alv> c;
	}
}
