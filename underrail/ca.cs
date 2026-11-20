using System;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x02000E0F RID: 3599
[e79("Tch_FacelessSurvivorApproaches")]
public sealed class ca : dgy
{
	// Token: 0x06004C5C RID: 19548 RVA: 0x002155C0 File Offset: 0x002137C0
	public ca()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			ca.b b = new ca.b();
			b.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (b.a != null)
			{
				b.a.i.b.a(true, false);
				b.b = b.a.Area;
				if (b.b != null)
				{
					ca.c c = new ca.c();
					c.c = b;
					c.a = (new ar7(new Guid("a8b58099-bb40-49c4-8581-76a825cddc81"), c.c.a.Area).ao() as c5x);
					c.b = (new ar7(new Guid("501027b5-1195-4ffc-afa9-192737cac376"), c.c.a.Area).ao() as c5x);
					if (c.b != null)
					{
						base.a(new btm[]
						{
							new ace(new e80(false))
						});
						btm[] array = new btm[1];
						int num = 0;
						dky dky = new dky();
						dky.a(0.2f);
						dky.a(false);
						array[num] = dky;
						base.a(array);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(1.0))
						});
						btm[] array2 = new btm[1];
						int num2 = 0;
						kw kw = new kw();
						kw.a(new bt4("tch-ww5", new Vector3(10f, 30f, 0f)));
						kw.IsAsync = false;
						kw.a(true);
						array2[num2] = kw;
						base.a(array2);
						btm[] array3 = new btm[1];
						int num3 = 0;
						dva dva = new dva(null, null, null, null, null);
						dva.a(new Func<e6d, bool>(ca.a.a.a));
						array3[num3] = dva;
						base.a(array3);
						if (c.a != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(c.c), null, null, null)
							});
						}
						btm[] array4 = new btm[1];
						int num4 = 0;
						c8s c8s = new c8s();
						c8s.a(0.2f);
						c8s.IsAsync = false;
						array4[num4] = c8s;
						base.a(array4);
						btm[] array5 = new btm[1];
						int num5 = 0;
						s5 s = new s5();
						s.a(new ar7(c.b));
						s.a(new bt4("guard_savedFaceless2"));
						s.IsAsync = false;
						s.a(true);
						array5[num5] = s;
						base.a(array5);
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(2.0))
						});
						if (c.a != null)
						{
							base.a(new btm[]
							{
								new dva(null, new Func<e6d, bool>(c.b), null, null, null)
							});
						}
						base.a(new btm[]
						{
							new dva(null, new Func<e6d, bool>(c.a), null, null, null)
						});
						base.a(new btm[]
						{
							new os(TimeSpan.FromSeconds(0.1))
						});
						btm[] array6 = new btm[1];
						int num6 = 0;
						dva dva2 = new dva(null, null, null, null, null);
						dva2.a(new Func<e6d, bool>(c.c.a));
						array6[num6] = dva2;
						base.a(array6);
						base.a(new btm[]
						{
							new ace(new e80(true))
						});
					}
				}
			}
		}
	}

	// Token: 0x02000E10 RID: 3600
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06004C5F RID: 19551 RVA: 0x0021593C File Offset: 0x00213B3C
		internal bool a(e6d A_0)
		{
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.a);
			}
			return true;
		}

		// Token: 0x04001EE4 RID: 7908
		public static readonly ca.a a = new ca.a();

		// Token: 0x04001EE5 RID: 7909
		public static Func<e6d, bool> b;
	}

	// Token: 0x02000E11 RID: 3601
	[CompilerGenerated]
	private new sealed class b
	{
		// Token: 0x06004C61 RID: 19553 RVA: 0x0021596C File Offset: 0x00213B6C
		internal bool a(e6d A_0)
		{
			c5x c5x = new ar7(new Guid("fa4af03c-26e5-4107-93ea-bb94815b0be0"), this.b).ao() as c5x;
			if (c5x != null && c5x.t.b != null)
			{
				c5x.t.b.y6()[ddq.bv] = "defensePerimeterEidein";
			}
			ps service = bpo.GetService<ps>();
			if (service != null)
			{
				service.anf(edg.b);
			}
			return true;
		}

		// Token: 0x04001EE6 RID: 7910
		public c5x a;

		// Token: 0x04001EE7 RID: 7911
		public aud b;
	}

	// Token: 0x02000E12 RID: 3602
	[CompilerGenerated]
	private sealed class c
	{
		// Token: 0x06004C63 RID: 19555 RVA: 0x002159EC File Offset: 0x00213BEC
		internal bool c(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.Southeast;
			return true;
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x002159FC File Offset: 0x00213BFC
		internal bool b(e6d A_0)
		{
			this.a.VisualDirection = HorizontalDirection.North;
			return true;
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x00215A0C File Offset: 0x00213C0C
		internal bool a(e6d A_0)
		{
			this.c.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, true);
			return true;
		}

		// Token: 0x04001EE8 RID: 7912
		public c5x a;

		// Token: 0x04001EE9 RID: 7913
		public c5x b;

		// Token: 0x04001EEA RID: 7914
		public ca.b c;
	}
}
