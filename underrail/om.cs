using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;

// Token: 0x0200039D RID: 925
[fe("IceArchon")]
public class om : am2
{
	// Token: 0x0600197C RID: 6524 RVA: 0x00086DDC File Offset: 0x00084FDC
	public om(bm6 A_0)
	{
		om.a a = new om.a();
		a.a = A_0;
		base..ctor(a.a);
		a.b = this;
		List<c96> list = new List<c96>();
		list.Add(new byh("Autoattack", new Func<TimeSpan, double, bool>(a.c), new Func<TimeSpan, double, cst>(a.b), new Func<bool, float>(om.b.a.b), null)
		{
			e = false
		});
		list.Add(new byh("CastCryoOnPlayer", new Func<TimeSpan, double, bool>(a.a), new Func<TimeSpan, double, cst>(a.d), new Func<bool, float>(om.b.a.a), null)
		{
			e = false
		});
		list.Add(new aif("RestActivity"));
		base.a(list);
	}

	// Token: 0x0200039E RID: 926
	[CompilerGenerated]
	[Serializable]
	private new sealed class b
	{
		// Token: 0x0600197F RID: 6527 RVA: 0x00086EDC File Offset: 0x000850DC
		internal float b(bool A_0)
		{
			return 200f;
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00086EE4 File Offset: 0x000850E4
		internal float a(bool A_0)
		{
			return 100f;
		}

		// Token: 0x04000E88 RID: 3720
		public static readonly om.b a = new om.b();

		// Token: 0x04000E89 RID: 3721
		public static Func<bool, float> b;

		// Token: 0x04000E8A RID: 3722
		public static Func<bool, float> c;
	}

	// Token: 0x0200039F RID: 927
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06001982 RID: 6530 RVA: 0x00086EF8 File Offset: 0x000850F8
		internal bool c(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == this.a.a8().Area && aw1.b(c5x, this.a.a8()) <= 1.5)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00086F94 File Offset: 0x00085194
		internal cst b(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == this.a.a8().Area)
				{
					return this.b.Subject.a8().h.b.b(c5x.h.b);
				}
			}
			return null;
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x0008703C File Offset: 0x0008523C
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == this.a.a8().Area)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x000870BC File Offset: 0x000852BC
		internal cst d(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && !serviceOrThrow.aqu().v().Dead)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && c5x.Area == this.a.a8().Area)
				{
					eu7 eu = ecf.a(dgk.Get<h7>(), new eru(new EntityAspectReference<amc, amc>(this.b.h())), null) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, this.b.Subject.a8(), c5x);
					}
				}
			}
			return null;
		}

		// Token: 0x04000E8B RID: 3723
		public bm6 a;

		// Token: 0x04000E8C RID: 3724
		public om b;
	}
}
