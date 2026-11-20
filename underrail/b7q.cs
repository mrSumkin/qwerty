using System;
using System.Runtime.CompilerServices;

// Token: 0x02000327 RID: 807
[apc("iceRemnant")]
public sealed class b7q : esk
{
	// Token: 0x0600172E RID: 5934 RVA: 0x00073E4C File Offset: 0x0007204C
	public override bool ef()
	{
		return false;
	}

	// Token: 0x0600172F RID: 5935 RVA: 0x00073E54 File Offset: 0x00072054
	public b7q()
	{
		this.h.c = 3;
		this.h.d = 0;
		this.h.a = this.c;
		this.a = new ej0();
		this.b = new ej0();
		this.p.a = this.a;
		this.a.a = new Action<ej0>(b7q.a.a.b);
		this.a.a = this.b;
		this.b.a = new Action<ej0>(b7q.a.a.a);
		this.b.a = this.c;
	}

	// Token: 0x04000DC5 RID: 3525
	private new ej0 a;

	// Token: 0x04000DC6 RID: 3526
	private new ej0 b;

	// Token: 0x02000328 RID: 808
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001732 RID: 5938 RVA: 0x00073F4C File Offset: 0x0007214C
		internal void b(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null && amc.a8() != null && !amc.aa().Dead && A_0.b().g().a8().k.b != null)
			{
				A_0.b().g().a8().k.b.a(amc.a8(), 1.5f, 1, 0);
			}
		}

		// Token: 0x06001733 RID: 5939 RVA: 0x00073FE4 File Offset: 0x000721E4
		internal void a(ej0 A_0)
		{
			amc amc = new bzv(A_0.b().c().y6()).g();
			if (amc != null && amc.a8() != null && !amc.aa().Dead)
			{
				blk blk = new bzv(A_0.b().c().y6()).c(amc.a8().qe());
				if (blk.b() && blk.a().f() == cem.d && aw1.b(A_0.b().g().a8(), amc.a8()) < 2.0)
				{
					A_0.b().g().aa().a(null, null, false);
					A_0.b().g().a8().an();
				}
			}
		}

		// Token: 0x04000DC7 RID: 3527
		public static readonly b7q.a a = new b7q.a();

		// Token: 0x04000DC8 RID: 3528
		public static Action<ej0> b;

		// Token: 0x04000DC9 RID: 3529
		public static Action<ej0> c;
	}
}
