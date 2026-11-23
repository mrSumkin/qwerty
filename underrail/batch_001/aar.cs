using System;

// Token: 0x02000FB9 RID: 4025
public sealed class aar : dnh
{
	// Token: 0x06005276 RID: 21110 RVA: 0x0024DE2C File Offset: 0x0024C02C
	public s0 a()
	{
		return this.a;
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x0024DE34 File Offset: 0x0024C034
	public void a(s0 A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x0024DE40 File Offset: 0x0024C040
	public e3q b()
	{
		return this.b;
	}

	// Token: 0x06005279 RID: 21113 RVA: 0x0024DE48 File Offset: 0x0024C048
	public void a(e3q A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600527A RID: 21114 RVA: 0x0024DE54 File Offset: 0x0024C054
	public aar()
	{
	}

	// Token: 0x0600527B RID: 21115 RVA: 0x0024DE5C File Offset: 0x0024C05C
	public aar(s0 A_0, e3q A_1)
	{
		this.a = A_0;
		this.b = A_1;
	}

	// Token: 0x0600527C RID: 21116 RVA: 0x0024DE74 File Offset: 0x0024C074
	public override bool cw(bq8 A_0, bq8 A_1)
	{
		return this.a != null && this.b != null && !this.a.em(this.b);
	}

	// Token: 0x040021C9 RID: 8649
	private s0 a;

	// Token: 0x040021CA RID: 8650
	private e3q b;
}
