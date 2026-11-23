using System;
using Microsoft.Xna.Framework.Audio;

// Token: 0x02000071 RID: 113
public sealed class cvi
{
	// Token: 0x06000225 RID: 549 RVA: 0x0000B440 File Offset: 0x00009640
	public d6c b()
	{
		return this.a;
	}

	// Token: 0x06000226 RID: 550 RVA: 0x0000B448 File Offset: 0x00009648
	public SoundEffectInstance f()
	{
		return this.b;
	}

	// Token: 0x06000227 RID: 551 RVA: 0x0000B450 File Offset: 0x00009650
	public bool e()
	{
		return this.b != null;
	}

	// Token: 0x06000228 RID: 552 RVA: 0x0000B45C File Offset: 0x0000965C
	public float c()
	{
		return this.c;
	}

	// Token: 0x06000229 RID: 553 RVA: 0x0000B464 File Offset: 0x00009664
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x0600022A RID: 554 RVA: 0x0000B470 File Offset: 0x00009670
	public bool g()
	{
		return this.d;
	}

	// Token: 0x0600022B RID: 555 RVA: 0x0000B478 File Offset: 0x00009678
	public c9z d()
	{
		return this.e;
	}

	// Token: 0x0600022C RID: 556 RVA: 0x0000B484 File Offset: 0x00009684
	internal cvi(d6c A_0, float A_1, c9z A_2, bool A_3)
	{
		this.c = A_1;
		this.e = A_2;
		this.d = A_3;
		this.a = A_0;
		this.a.d();
		this.b = this.a.e().CreateInstance();
		this.b.IsLooped = A_3;
		dd7 serviceOrThrow = bpo.GetServiceOrThrow<dd7>();
		this.a(serviceOrThrow as b6d);
	}

	// Token: 0x0600022D RID: 557 RVA: 0x0000B4F8 File Offset: 0x000096F8
	public void a(b6d A_0)
	{
		if (this.b != null)
		{
			this.b(A_0);
		}
	}

	// Token: 0x0600022E RID: 558 RVA: 0x0000B50C File Offset: 0x0000970C
	public void a()
	{
		if (this.b.State != SoundState.Stopped)
		{
			this.b.Stop();
		}
		this.b.Dispose();
		this.b = null;
	}

	// Token: 0x0600022F RID: 559 RVA: 0x0000B540 File Offset: 0x00009740
	internal void b(b6d A_0)
	{
		float num = this.c * A_0.ads()[this.e] * this.a.a().e();
		if (num != this.b.Volume)
		{
			this.b.Volume = num;
		}
	}

	// Token: 0x0400038D RID: 909
	private d6c a;

	// Token: 0x0400038E RID: 910
	private SoundEffectInstance b;

	// Token: 0x0400038F RID: 911
	private float c;

	// Token: 0x04000390 RID: 912
	private bool d;

	// Token: 0x04000391 RID: 913
	private c9z e;
}
