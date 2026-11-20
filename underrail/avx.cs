using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F2D RID: 3885
[e79("Xpbl_Rig_TakeDrunkGuardToRoom")]
public sealed class avx : dgy
{
	// Token: 0x06004EF3 RID: 20211 RVA: 0x00238444 File Offset: 0x00236644
	public avx()
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow != null && serviceOrThrow.aqu() != null)
		{
			avx.a a = new avx.a();
			a.a = (serviceOrThrow.aqu().v().b() as c5x);
			if (a.a != null)
			{
				a.b = (new ar7(new Guid("4becdc55-f35c-4230-8f5f-87c7b3e10fd5"), a.a.Area).ao() as c5x);
				a.c = (new ar7(new Guid("a6ce68c0-537a-4706-8679-730b6c8ed56f"), a.a.Area).ao() as c5x);
				if (a.b != null)
				{
					base.a(new btm[]
					{
						new ace(new e80(false))
					});
					base.a(new btm[]
					{
						new os(TimeSpan.FromSeconds(1.0))
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
						new dva(null, new Func<e6d, bool>(a.b), null, null, null)
					});
					btm[] array2 = new btm[1];
					int num2 = 0;
					c8s c8s = new c8s();
					c8s.a(0.2f);
					c8s.IsAsync = false;
					array2[num2] = c8s;
					base.a(array2);
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

	// Token: 0x02000F2E RID: 3886
	[CompilerGenerated]
	private new sealed class a
	{
		// Token: 0x06004EF5 RID: 20213 RVA: 0x002385F0 File Offset: 0x002367F0
		internal bool b(e6d A_0)
		{
			a0l.a(this.a, "player_room", true);
			a0l.a(this.b, "drunkEel_room", true);
			if (this.c != null)
			{
				cnb cnb = this.c.GetAspect<bim>() as cnb;
				if (cnb != null && cnb.q())
				{
					cnb.d(false);
				}
				d2b aspect = this.c.GetAspect<d2b>();
				if (aspect != null && !aspect.n())
				{
					aspect.a(true, true);
				}
			}
			return true;
		}

		// Token: 0x06004EF6 RID: 20214 RVA: 0x0023867C File Offset: 0x0023687C
		internal bool a(e6d A_0)
		{
			this.a.GetAspect<j7>().a(this.b.GetAspect<j7>(), false, null, false);
			return true;
		}

		// Token: 0x0400205A RID: 8282
		public c5x a;

		// Token: 0x0400205B RID: 8283
		public c5x b;

		// Token: 0x0400205C RID: 8284
		public c5x c;
	}
}
