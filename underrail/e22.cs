using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x020004AA RID: 1194
internal static class e22
{
	// Token: 0x06001E4B RID: 7755 RVA: 0x000A8AA8 File Offset: 0x000A6CA8
	public static dn3 a(ecs A_0)
	{
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		dn3 dn = new dn3();
		int num = 0;
		int num2 = 0;
		if (A_0.a != null)
		{
			foreach (dl6 a_ in A_0.a)
			{
				av9 av = e22.a(a_, serviceOrThrow, num2);
				if (av != null)
				{
					dn.a.Add(av);
					num2 += av.b.d;
					if (av.b.c > num)
					{
						num = av.b.c;
					}
				}
			}
		}
		dn.b = new esj(num, num2);
		if (A_0.b != null)
		{
			dn.c.AddRange(A_0.b);
		}
		return dn;
	}

	// Token: 0x06001E4C RID: 7756 RVA: 0x000A8B8C File Offset: 0x000A6D8C
	public static List<ecs> a(ecs A_0, int A_1, int A_2)
	{
		cne serviceOrThrow = bpo.GetServiceOrThrow<cne>();
		dn3 dn = e22.a(A_0);
		if (A_0.a == null || A_0.a.Count == 0 || ((A_1 <= 0 || dn.b.c <= A_1) && (A_1 <= 0 || dn.b.d <= A_2)))
		{
			return new List<ecs>
			{
				A_0
			};
		}
		List<dn3> list = new List<dn3>();
		int num = 0;
		dn3 dn2 = new dn3();
		bool flag = true;
		foreach (av9 av in dn.a)
		{
			List<av9> list2;
			if (A_1 > 0 && av.b.c > A_1)
			{
				list2 = e22.a(av, A_1, serviceOrThrow);
			}
			else
			{
				list2 = new List<av9>
				{
					av
				};
			}
			for (int i = 0; i < list2.Count; i++)
			{
				av9 av2 = list2[i];
				num += av2.b.d;
				if (A_2 > 0 && num > A_2)
				{
					if (flag)
					{
						return new List<ecs>();
					}
					list.Add(dn2);
					num = 0;
					dn2 = new dn3();
				}
				dn2.a.Add(av2);
				flag = false;
			}
		}
		list.Add(dn2);
		List<ecs> list3 = new List<ecs>();
		foreach (dn3 dn3 in list)
		{
			ecs ecs = dn3.a();
			if (A_0.b != null)
			{
				ecs.b.AddRange(A_0.b);
			}
			list3.Add(ecs);
		}
		return list3;
	}

	// Token: 0x06001E4D RID: 7757 RVA: 0x000A8D88 File Offset: 0x000A6F88
	public static Vector2 b(bph A_0, cne A_1)
	{
		SpriteFont resource = A_1.GetResource<SpriteFont>(A_0.a.a, null);
		if (resource != null)
		{
			Vector2 vector;
			if (A_0.b == null || A_0.b.Trim() == string.Empty)
			{
				vector = resource.MeasureString(" ");
			}
			else
			{
				vector = resource.MeasureString(A_0.b);
			}
			if (!string.IsNullOrEmpty(A_0.c))
			{
				vector.X += vector.Y * 1.5f;
				vector.Y += vector.Y * 0.25f;
			}
			return vector;
		}
		return Vector2.Zero;
	}

	// Token: 0x06001E4E RID: 7758 RVA: 0x000A8E40 File Offset: 0x000A7040
	private static List<av9> a(av9 A_0, int A_1, cne A_2)
	{
		if (A_0.a == null || A_0.a.Count == 0)
		{
			return new List<av9>();
		}
		List<av9> list = new List<av9>();
		av9 av = new av9();
		int num = 0;
		int num2 = 0;
		List<d51> list2 = new List<d51>(A_0.a);
		for (int i = 0; i < list2.Count; i++)
		{
			d51 d = list2[i];
			SpriteFont resource = A_2.GetResource<SpriteFont>(d.d.a, null);
			if (resource != null)
			{
				if (d.c.X + (float)num > (float)A_1)
				{
					int num3 = 0;
					if (!string.IsNullOrEmpty(d.f))
					{
						num3 = Convert.ToInt32(d.c.Y * 1.5f);
					}
					List<string> list3 = ev7.a(d.e.b, resource, A_1, A_1 - num - num3);
					for (int j = 0; j < list3.Count; j++)
					{
						string text = list3[j];
						bph bph = new bph(d.d.a(), text, null);
						if (j == 0)
						{
							bph.c = d.f;
						}
						d51 d2 = new d51(bph, e22.b(bph, A_2));
						if (d2.c.Y > (float)num2)
						{
							num2 = (int)d2.c.Y;
						}
						if (!string.IsNullOrEmpty(text))
						{
							av.a.Add(d2);
						}
						if (j != list3.Count - 1)
						{
							av.b = new esj(num, num2);
							list.Add(av);
							av = new av9();
							num = 0;
							num2 = 0;
						}
						else
						{
							num2 = (int)d2.c.Y;
							num = (int)d2.c.X;
						}
					}
				}
				else if (d.c.X + (float)num > (float)(A_1 - 10))
				{
					av.a.Add(d);
					num += (int)d.c.X;
					if (d.c.Y > (float)num2)
					{
						num2 = (int)d.c.Y;
					}
					av.b = new esj(num, num2);
					list.Add(av);
					av = new av9();
					num = 0;
					num2 = 0;
				}
				else
				{
					av.a.Add(d);
					num += (int)d.c.X;
					if (d.c.Y > (float)num2)
					{
						num2 = (int)d.c.Y;
					}
				}
			}
		}
		av.b = new esj(num, num2);
		list.Add(av);
		return list;
	}

	// Token: 0x06001E4F RID: 7759 RVA: 0x000A90F4 File Offset: 0x000A72F4
	private static av9 a(dl6 A_0, cne A_1, int A_2)
	{
		int num = 0;
		int num2 = 0;
		if (A_0.a == null)
		{
			return null;
		}
		av9 av = new av9();
		foreach (bph a_ in A_0.a)
		{
			d51 d = e22.a(a_, A_1);
			if (d != null)
			{
				if (d.c.Y > (float)num)
				{
					num = (int)d.c.Y;
				}
				av.a.Add(d);
			}
		}
		if (av.a.Count > 0)
		{
			foreach (d51 d2 in av.a)
			{
				d2.a = new Point(num2, A_2 + (int)((float)num - d2.c.Y) + egg.b(d2.d.a));
				num2 += (int)d2.c.X;
			}
			av.b = new esj(num2, num);
			return av;
		}
		return null;
	}

	// Token: 0x06001E50 RID: 7760 RVA: 0x000A9240 File Offset: 0x000A7440
	private static d51 a(bph A_0, cne A_1)
	{
		if (A_1.GetResource<SpriteFont>(A_0.a.a, null) != null)
		{
			Vector2 a_ = e22.b(A_0, A_1);
			return new d51(A_0, a_);
		}
		return null;
	}
}
