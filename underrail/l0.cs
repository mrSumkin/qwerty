using System;
using System.Runtime.CompilerServices;

// Token: 0x02000E75 RID: 3701
[e79("Fo_EvelynSeduces")]
public sealed class l0 : dgy
{
	// Token: 0x06004D2A RID: 19754 RVA: 0x0021FD84 File Offset: 0x0021DF84
	public l0()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqw() != null)
		{
			l0.a a = new l0.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			aud a_ = serviceOrThrow.aqw().n("fo3");
			if (a.a != null)
			{
				a.c = (new ar7(new Guid("7bb1cb5e-f09b-4554-b9d3-74a7d7e5224f"), a.a.Area).ao() as c5x);
				a.b = (new ar7(new Guid("4bcde423-0f1c-4e2d-88bd-93404e9653ea"), a_).ao() as c5x);
				a.d = (new ar7(new Guid("412a2418-8ade-48d6-b7fe-fa08c346ceba"), a_).ao() as c5x);
				a.b.GetAspect<d2b>();
				if (a.c != null && a.b != null && a.d != null)
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
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					dve dve = new dve();
					dve.a(asp.c7);
					array2[num2] = new ace(dve)
					{
						TargetRef = new ar7(a.c)
					};
					base.a(array2);
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(2.0))
					});
					btm[] array3 = new btm[1];
					int num3 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array3[num3] = c8s;
					base.a(array3);
					base.a(new btm[]
					{
						new dva(null, new Func<e6d, bool>(a.a), null, null, null)
					});
					base.a(new btm[]
					{
						new ace(new e80(true))
					});
				}
			}
		}
	}

	// Token: 0x02000E76 RID: 3702
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004D2C RID: 19756 RVA: 0x0021FFDC File Offset: 0x0021E1DC
		internal bool b(e6d A_0)
		{
			c7j c7j = this.b.s.b as c7j;
			if (c7j != null)
			{
				ke.a(this.a.h.b.aa(), c7j.ItemContainer, false, true);
			}
			if (this.a.h.b.aa().Feats.Contains<c3v>())
			{
				this.a.h.b.aa().Offense.d(-100000, false);
				this.a.h.b.aa().StatusEffects.a(new dns(0), false, false, false);
			}
			a0l.a(this.c, "global:fo_evelyn:bedroom", true);
			this.c.t.b.y6()[ddq.ay] = new bt4("global:fo_evelyn:bedroom");
			a0l.a(this.a, "player_attack", true);
			d2b aspect = this.b.GetAspect<d2b>();
			if (aspect != null)
			{
				aspect.b(true, false);
				aspect.a(d1c.a);
			}
			d2b aspect2 = this.d.GetAspect<d2b>();
			if (aspect2 != null)
			{
				aspect2.b(true, false);
				aspect2.a(d1c.a);
			}
			(this.d.GetAspect<bim>() as cnb).d(false);
			return true;
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00220140 File Offset: 0x0021E340
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.c.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x04001F7A RID: 8058
		public c5x a;

		// Token: 0x04001F7B RID: 8059
		public c5x b;

		// Token: 0x04001F7C RID: 8060
		public c5x c;

		// Token: 0x04001F7D RID: 8061
		public c5x d;
	}
}
