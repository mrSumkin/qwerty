using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;

// Token: 0x0200115F RID: 4447
public static class egy
{
	// Token: 0x06005F28 RID: 24360 RVA: 0x00285974 File Offset: 0x00283B74
	public static eg2 a(c5x A_0)
	{
		List<b0b> list = bpo.GetServiceOrThrow<cnk>().aqw().GetAddon<d60>().ab4(new string[]
		{
			"telekineticProxy"
		});
		if (list != null)
		{
			foreach (b0b b0b in list)
			{
				eg2 aspect = b0b.GetAspect<eg2>();
				if (aspect != null && aspect.f() != null && aspect.f().ao() == A_0)
				{
					return aspect;
				}
			}
		}
		return null;
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x00285A1C File Offset: 0x00283C1C
	public static bool a(c5x A_0, c5x A_1)
	{
		if (A_0 != null && A_1 != null)
		{
			eg2 eg = egy.a(A_0);
			if (eg != null && eg.a8().Area == A_1.Area)
			{
				bbg bbg = new bbg();
				bbg.a().Add(new egy.a(A_1.Area));
				bbg.a(float.MaxValue);
				bbg.a(true);
				Vector2 a_ = eg.a8().Location.b() + new Vector2(0.5f, 0.5f);
				foreach (ak1 ak in eg.a8().l)
				{
					foreach (ak1 ak2 in A_1.l)
					{
						if (ak == ak2)
						{
							return true;
						}
					}
				}
				bool flag = new exm(bbg, a_, A_1.Location.b() + new Vector2(0.5f, 0.5f)).a(null).b();
				if (!flag && (A_1.Size.X > 1f || A_1.Size.Y > 1f))
				{
					foreach (ak1 ak3 in A_1.l)
					{
						flag = new exm(bbg, a_, ak3.Location.b() + new Vector2(0.5f, 0.5f)).a(null).b();
						if (flag)
						{
							break;
						}
					}
				}
				if (flag)
				{
					foreach (ak1 ak4 in A_1.l)
					{
						if (aw1.a((float)Math.Sqrt(Math.Pow((double)((float)ak4.Location.X - eg.a8().Location.X), 2.0) + Math.Pow((double)((float)ak4.Location.Y - eg.a8().Location.Y), 2.0)), (float)ci5.g))
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
		}
		return false;
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x00285CFC File Offset: 0x00283EFC
	public static void a(eg2 A_0)
	{
		if (A_0 != null && A_0.a8().p.b != null && A_0.a8().i.b != null)
		{
			A_0.a8().p.b.a[0].b = new Point(0, 2);
			A_0.a8().p.b.a[1].b = new Point(0, 3);
			dha aspect = A_0.a8().GetAspect<dha>();
			if (aspect != null)
			{
				aspect.g();
			}
			ddg ddg = new ddg(A_0.a8().p.b);
			ddg.b(0);
			ddg.a(70.0);
			ddg.a(1);
			ddg.c(8);
			ddg ddg2 = ddg;
			egy.b @object = new egy.b();
			ddg2.q(new EventHandler<EventArgs>(@object.a));
			ddg2.o(new EventHandler<EventArgs>(@object.a));
			ddg2.l(new EventHandler<EventArgs>(@object.a));
			A_0.a8().i.b.b(ddg2, atp.a);
		}
	}

	// Token: 0x02001160 RID: 4448
	private class a : ok
	{
		// Token: 0x06005F2B RID: 24363 RVA: 0x00285E30 File Offset: 0x00284030
		public a(aud A_0)
		{
			this.a = A_0;
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x00285E40 File Offset: 0x00284040
		public bool g5(anl A_0)
		{
			ak1 ak = this.a.a(A_0.d());
			return ak != null && !ak.Formation.c(4L);
		}

		// Token: 0x040025DE RID: 9694
		private aud a;
	}

	// Token: 0x02001161 RID: 4449
	[eiz("XTPH")]
	[Serializable]
	private sealed class b : ISerializable
	{
		// Token: 0x06005F2D RID: 24365 RVA: 0x00285E78 File Offset: 0x00284078
		private b(SerializationInfo A_0, StreamingContext A_1)
		{
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x00285E80 File Offset: 0x00284080
		public void GetObjectData(SerializationInfo info, StreamingContext ctx)
		{
		}

		// Token: 0x06005F2F RID: 24367 RVA: 0x00285E84 File Offset: 0x00284084
		public b()
		{
		}

		// Token: 0x06005F30 RID: 24368 RVA: 0x00285E90 File Offset: 0x00284090
		[dcc("XTPH:mOTSAF")]
		public void a(object A_0, EventArgs A_1)
		{
			ddg ddg = A_0 as ddg;
			if (ddg != null && ddg.g() != null && ddg.g().a8() != null)
			{
				ddg.g().a[0].b = new Point(0, 0);
				ddg.g().a[1].b = new Point(0, 1);
				dha aspect = ddg.g().a8().GetAspect<dha>();
				if (aspect != null)
				{
					aspect.h();
				}
			}
		}
	}
}
