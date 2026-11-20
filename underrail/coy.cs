using System;

// Token: 0x02000FE0 RID: 4064
public sealed class coy : esc
{
	// Token: 0x060053B0 RID: 21424 RVA: 0x00251400 File Offset: 0x0024F600
	public coy()
	{
	}

	// Token: 0x060053B1 RID: 21425 RVA: 0x00251408 File Offset: 0x0024F608
	public coy(s0 A_0, e3q A_1, atr A_2, atr A_3)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x00251430 File Offset: 0x0024F630
	public override int d5(bq8 A_0, bq8 A_1)
	{
		if (this.a != null && this.b != null)
		{
			this.a.en(this.b, A_0.get_Item(c49.b) as c5x);
			if (this.c != null)
			{
				this.c.f()["English"] = string.Format("::{0}::", this.a.ek(this.b));
			}
			if (this.d != null)
			{
				this.d.f()["English"] = string.Format("::{0}::", this.a.ep(this.b));
			}
		}
		return 0;
	}

	// Token: 0x0400221C RID: 8732
	private s0 a;

	// Token: 0x0400221D RID: 8733
	private e3q b;

	// Token: 0x0400221E RID: 8734
	private atr c;

	// Token: 0x0400221F RID: 8735
	private atr d;
}
