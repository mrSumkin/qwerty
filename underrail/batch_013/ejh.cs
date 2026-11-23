using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Ouroboros.Core.Logging;

// Token: 0x02001FCD RID: 8141
public sealed class ejh : apo
{
	// Token: 0x0600BF37 RID: 48951 RVA: 0x00422AC8 File Offset: 0x00420CC8
	public static c3i b(string A_0, cne A_1 = null)
	{
		if (string.IsNullOrWhiteSpace(A_0) || ejh.b.Contains(A_0))
		{
			return null;
		}
		if (ejh.a == null)
		{
			ejh.b();
		}
		bj8 bj = ejh.a(A_0);
		if (bj != null)
		{
			return ejh.a(bj, A_1);
		}
		return ejh.a(A_0, A_1);
	}

	// Token: 0x0600BF38 RID: 48952 RVA: 0x00422B20 File Offset: 0x00420D20
	private static bj8 a(string A_0)
	{
		if (string.IsNullOrWhiteSpace(A_0))
		{
			return null;
		}
		if (ejh.a == null)
		{
			ejh.b();
		}
		bj8 bj;
		ejh.a.TryGetValue(A_0, out bj);
		if (bj == null && ejh.a.TryGetValue(A_0.ToLowerInvariant(), out bj))
		{
			ejh.a[A_0] = bj;
		}
		return bj;
	}

	// Token: 0x0600BF39 RID: 48953 RVA: 0x00422B84 File Offset: 0x00420D84
	public static c3i a(coh A_0, cne A_1 = null)
	{
		if (A_0 == null)
		{
			return null;
		}
		return ejh.b(A_0.Definition.a3(), A_1);
	}

	// Token: 0x0600BF3A RID: 48954 RVA: 0x00422BA0 File Offset: 0x00420DA0
	public static c3i a(av A_0, cne A_1 = null, bool A_2 = false)
	{
		czh.a(A_0, "proxy");
		if (A_1 == null)
		{
			A_1 = bpo.GetService<cne>();
			if (A_1 == null)
			{
				return null;
			}
		}
		if (!A_2)
		{
			coh coh = A_0.b9() as coh;
			if (coh != null)
			{
				c3i c3i = ejh.a(coh, A_1);
				if (c3i != null)
				{
					A_0.i = coh.Definition.a3();
				}
				return c3i;
			}
			if (A_0.h != null && !string.IsNullOrEmpty(A_0.i))
			{
				return ejh.b(A_0.i, null);
			}
		}
		return ejh.b(A_0.y(), A_1);
	}

	// Token: 0x0600BF3B RID: 48955 RVA: 0x00422C38 File Offset: 0x00420E38
	public static void a(cp9 A_0, Rectangle A_1, coh A_2, Color A_3)
	{
		if (A_2 != null && A_2.ItemEffects != null && A_2.ItemEffects.Count > 0)
		{
			int num = 0;
			for (int i = 0; i < A_2.ItemEffects.Count; i++)
			{
				dbj dbj = A_2.ItemEffects[i];
				if (!string.IsNullOrEmpty(dbj.Icon))
				{
					c3i c3i = ejh.b(dbj.Icon, A_0.a);
					if (c3i != null)
					{
						int num2 = num % 3;
						int num3 = 2 - num / 3;
						Rectangle a_ = new Rectangle(A_1.X + num2 * (A_1.Width / 3), A_1.Y + num3 * (A_1.Height / 3), A_1.Width / 3, A_1.Height / 3);
						c3i.a(A_0, a_, A_3, 0, null);
						if (++num >= 9)
						{
							return;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF3C RID: 48956 RVA: 0x00422D24 File Offset: 0x00420F24
	public static void c()
	{
		d67 serviceOrThrow = bpo.GetServiceOrThrow<d67>();
		try
		{
			w3.a(Path.Combine(serviceOrThrow.lh().RootDirectory, "Icons"));
		}
		catch (Exception a_)
		{
			dux.a(LogSeverity.Error, a_, "Failed to preload icon assets.", new object[0]);
		}
	}

	// Token: 0x0600BF3D RID: 48957 RVA: 0x00422D80 File Offset: 0x00420F80
	public static void b()
	{
		ejh.a = new Dictionary<string, bj8>();
		i3 i = eoq.DeserializeFromBinaryFileCompressed<i3>(Path.Combine(dr3.d().lf(), ei.k), dds.a(), true);
		if (i != null && i.a() != null)
		{
			foreach (bj8 bj in i.a())
			{
				if (bj != null && !string.IsNullOrWhiteSpace(bj.c()))
				{
					ejh.a[bj.c().ToLowerInvariant()] = bj;
				}
			}
		}
		ejh.a();
	}

	// Token: 0x0600BF3E RID: 48958 RVA: 0x00422E40 File Offset: 0x00421040
	private static void a()
	{
		ei2 service = bpo.GetService<ei2>();
		if (service != null)
		{
			foreach (Type type in service.av2(new Func<Type, bool>(ejh.a.a.a)))
			{
				ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
				if (constructor != null)
				{
					bd3 bd = constructor.Invoke(null) as bd3;
					if (bd != null)
					{
						List<bj8> list = bd.bz();
						if (list != null && list.Count > 0)
						{
							foreach (bj8 bj in list)
							{
								ejh.a[bj.c().ToLowerInvariant()] = bj;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600BF3F RID: 48959 RVA: 0x00422F60 File Offset: 0x00421160
	private static c3i a(bj8 A_0, cne A_1)
	{
		if (A_1 == null)
		{
			A_1 = bpo.GetService<cne>();
			if (A_1 == null)
			{
				return null;
			}
		}
		if (A_0 != null && A_0.a() != null && A_0.a().Count > 0 && A_0.b().X >= 1f && A_0.b().Y >= 1f)
		{
			c3i c3i = new c3i();
			c3i.a = new esj((int)A_0.b().X, (int)A_0.b().Y);
			foreach (d8h d8h in A_0.a())
			{
				if (!string.IsNullOrEmpty(d8h.c()))
				{
					Texture2D resource = A_1.GetResource<Texture2D>(Path.Combine(d5x.j, d8h.c()), null);
					if (resource != null)
					{
						c3i.b.Add(new abu(resource, ejh.a(d8h.a().X, d8h.a().Y, c3i.a), d8h.b()));
					}
				}
			}
			if (c3i.b.Count > 0)
			{
				return c3i;
			}
		}
		return null;
	}

	// Token: 0x0600BF40 RID: 48960 RVA: 0x004230C4 File Offset: 0x004212C4
	private static c3i a(string A_0, cne A_1)
	{
		if (string.IsNullOrEmpty(A_0))
		{
			return null;
		}
		if (A_1 == null)
		{
			A_1 = bpo.GetService<cne>();
			if (A_1 == null)
			{
				return null;
			}
		}
		if (!string.IsNullOrEmpty(A_0))
		{
			try
			{
				string str;
				if (A_0[0] == '&')
				{
					A_0 = A_0.Substring(1);
					str = "gui\\icons\\";
				}
				else
				{
					str = "icons\\";
				}
				string[] array = A_0.Split(new char[]
				{
					'.'
				});
				if (array.Length > 1)
				{
					string text = array[0];
					int num;
					if (int.TryParse(array[1], NumberStyles.Number, CultureInfo.InvariantCulture, out num))
					{
						Texture2D resource = A_1.GetResource<Texture2D>(str + text, null);
						if (resource != null)
						{
							Point point = new Point(num % 10, num / 10);
							Rectangle a_ = ejh.a(point.X, point.Y, bj8.a);
							c3i c3i = new c3i();
							c3i.a = bj8.a;
							c3i.b.Add(new abu(resource, a_, 1f));
							bj8 bj = new bj8();
							bj.a(A_0);
							bj.a(bj8.a.b());
							bj.a().Add(new d8h(text, point, 1f));
							ejh.a[bj.c().ToLowerInvariant()] = bj;
							return c3i;
						}
					}
				}
			}
			catch
			{
				ejh.b.Add(A_0);
			}
		}
		ejh.b.Add(A_0);
		return null;
	}

	// Token: 0x0600BF41 RID: 48961 RVA: 0x00423274 File Offset: 0x00421474
	private static Rectangle a(int A_0, int A_1, esj A_2)
	{
		return new Rectangle(A_0 * (A_2.c + 1) + 1, A_1 * (A_2.d + 1) + 1, A_2.c, A_2.d);
	}

	// Token: 0x0600BF42 RID: 48962 RVA: 0x004232A0 File Offset: 0x004214A0
	public void as3(string A_0, cp9 A_1, Rectangle A_2, Color A_3, int A_4 = 0, int? A_5 = null)
	{
		c3i c3i = ejh.b(A_0, A_1.a);
		if (c3i != null)
		{
			c3i.a(A_1, A_2, A_3, A_4, A_5);
		}
	}

	// Token: 0x040044BC RID: 17596
	private static Dictionary<string, bj8> a;

	// Token: 0x040044BD RID: 17597
	private static HashSet<string> b = new HashSet<string>();

	// Token: 0x02001FCE RID: 8142
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600BF47 RID: 48967 RVA: 0x004232F8 File Offset: 0x004214F8
		internal bool a(Type A_0)
		{
			return A_0.IsClass && !A_0.IsAbstract && typeof(bd3).IsAssignableFrom(A_0);
		}

		// Token: 0x040044BE RID: 17598
		public static readonly ejh.a a = new ejh.a();

		// Token: 0x040044BF RID: 17599
		public static Func<Type, bool> b;
	}
}
