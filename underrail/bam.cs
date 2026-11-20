using System;
using TimelapseVertigo.Common.Settings;

// Token: 0x02002023 RID: 8227
public sealed class bam : pm
{
	// Token: 0x0600C2C2 RID: 49858 RVA: 0x00436888 File Offset: 0x00434A88
	public sealed override float wf()
	{
		return this.a;
	}

	// Token: 0x0600C2C3 RID: 49859 RVA: 0x00436890 File Offset: 0x00434A90
	public sealed override void wg(float A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C2C4 RID: 49860 RVA: 0x0043689C File Offset: 0x00434A9C
	public sealed override float wh()
	{
		return this.b;
	}

	// Token: 0x0600C2C5 RID: 49861 RVA: 0x004368A4 File Offset: 0x00434AA4
	public sealed override void wi(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x0600C2C6 RID: 49862 RVA: 0x004368B0 File Offset: 0x00434AB0
	public sealed override float wj()
	{
		return this.c;
	}

	// Token: 0x0600C2C7 RID: 49863 RVA: 0x004368B8 File Offset: 0x00434AB8
	public sealed override void wk(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600C2C8 RID: 49864 RVA: 0x004368C4 File Offset: 0x00434AC4
	public bam()
	{
		wj wj = global::wj.a();
		if (wj.d != UiSize.Classic)
		{
			base.a(wj.f);
			this.e = wj.bs;
			this.f = new esj?(wj.bt);
		}
	}

	// Token: 0x0400468C RID: 18060
	private new float a;

	// Token: 0x0400468D RID: 18061
	private new float b = 100f;

	// Token: 0x0400468E RID: 18062
	private new float c = 50f;
}
