using System;
using Ouroboros.Common.Data;

// Token: 0x02000215 RID: 533
internal class dew
{
	// Token: 0x06000EEE RID: 3822 RVA: 0x0003E824 File Offset: 0x0003CA24
	public dew(er0 A_0)
	{
		this.a = A_0;
		this.c = A_0.ag.b.a;
	}

	// Token: 0x06000EEF RID: 3823 RVA: 0x0003E860 File Offset: 0x0003CA60
	public br a()
	{
		if (this.b.a() == 0)
		{
			return null;
		}
		br br = this.b.b();
		this.c[this.a.a(br.d.b), br.d.a.X, br.d.a.Y] = null;
		return br;
	}

	// Token: 0x06000EF0 RID: 3824 RVA: 0x0003E8D0 File Offset: 0x0003CAD0
	public void a(br A_0)
	{
		this.b.a(A_0);
		this.c[this.a.a(A_0.d.b), A_0.d.a.X, A_0.d.a.Y] = A_0;
	}

	// Token: 0x06000EF1 RID: 3825 RVA: 0x0003E92C File Offset: 0x0003CB2C
	public void b(br A_0)
	{
		int num = this.b.b(A_0);
		if (num == -1)
		{
			this.b.a(A_0);
			return;
		}
		this.b.e(num);
	}

	// Token: 0x06000EF2 RID: 3826 RVA: 0x0003E968 File Offset: 0x0003CB68
	public br a(ee4 A_0)
	{
		if (A_0.a.X >= 0 && A_0.a.Y >= 0)
		{
			return this.c[this.a.a(A_0.b), A_0.a.X, A_0.a.Y];
		}
		return null;
	}

	// Token: 0x040008F0 RID: 2288
	private er0 a;

	// Token: 0x040008F1 RID: 2289
	private BinaryHeap<br> b = new BinaryHeap<br>(false, null, 128);

	// Token: 0x040008F2 RID: 2290
	private br[,,] c;
}
