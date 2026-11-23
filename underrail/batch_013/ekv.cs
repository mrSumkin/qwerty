using System;
using System.Runtime.CompilerServices;

// Token: 0x02000311 RID: 785
[apc("suicideBot")]
public sealed class ekv : cqw
{
	// Token: 0x0600168F RID: 5775 RVA: 0x0006EE34 File Offset: 0x0006D034
	public ekv()
	{
		this.a = new ej0();
		this.b = new ej0();
		this.p.a = this.a;
		this.a.a = new Action<ej0>(ekv.a.a.b);
		this.a.a = this.b;
		this.b.a = new Action<ej0>(ekv.a.a.a);
		this.b.a = this.c;
	}

	// Token: 0x04000D2B RID: 3371
	private new ej0 a;

	// Token: 0x04000D2C RID: 3372
	private new ej0 b;

	// Token: 0x02000312 RID: 786
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x0006EF04 File Offset: 0x0006D104
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null && amc.a8() != null && !amc.aa().Dead && A_0.b().g().a8().k.b != null)
			{
				A_0.b().g().a8().k.b.a(amc.a8(), 1.5f, 1, 0);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x0006EF9C File Offset: 0x0006D19C
		internal void a(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null && amc.a8() != null && !amc.aa().Dead)
			{
				blk blk = new bzv(A_0.b().c().y6()).c(amc.a8().qe());
				if (blk.b() && blk.a().f() == cem.d && aw1.b(A_0.b().g().a8(), amc.a8()) < 3.0)
				{
					A_0.b().g().aa().a(null, null, false);
				}
			}
		}

		// Token: 0x04000D2D RID: 3373
		public static readonly ekv.a a = new ekv.a();

		// Token: 0x04000D2E RID: 3374
		public static Action<ej0> b;

		// Token: 0x04000D2F RID: 3375
		public static Action<ej0> c;
	}
}
