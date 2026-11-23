using System;

// Token: 0x0200045C RID: 1116
public abstract class ak7 : adt
{
	// Token: 0x06001D12 RID: 7442 RVA: 0x000A1484 File Offset: 0x0009F684
	public ak7(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x000A14A0 File Offset: 0x0009F6A0
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject == null || this.Subject.a8() == null || this.Subject.a8().k.b == null || this.Subject.a8().i.b == null)
		{
			return ej1.c;
		}
		if (this.a == null)
		{
			return this.a(A_0, A_1, null);
		}
		if (this.a.State == dc4.c)
		{
			this.aff(A_0, A_1);
			return ej1.b;
		}
		if (this.a.State == dc4.e)
		{
			this.afg(A_0, A_1);
			return ej1.c;
		}
		if (this.a.State == dc4.b)
		{
			if (this.e > 0 && (this.h -= A_1) <= 0.0)
			{
				ak1 ak = this.afe(A_0, A_1);
				if (ak != null && this.g != ak)
				{
					this.a.j();
					this.a = null;
					return this.a(A_0, A_1, null);
				}
			}
			return ej1.a;
		}
		return ej1.b;
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x000A15C0 File Offset: 0x0009F7C0
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return base.Parent.acj(A_0, A_1);
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x000A15D0 File Offset: 0x0009F7D0
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.a = null;
		this.g = null;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x000A15E0 File Offset: 0x0009F7E0
	public override void ack()
	{
		if (this.a != null && this.a.State == dc4.b)
		{
			this.a.j();
			this.a = null;
		}
	}

	// Token: 0x06001D17 RID: 7447
	protected abstract ak1 afe(TimeSpan A_0, double A_1);

	// Token: 0x06001D18 RID: 7448 RVA: 0x000A1610 File Offset: 0x0009F810
	protected virtual void afg(TimeSpan A_0, double A_1)
	{
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x000A1614 File Offset: 0x0009F814
	protected virtual void aff(TimeSpan A_0, double A_1)
	{
	}

	// Token: 0x06001D1A RID: 7450 RVA: 0x000A1618 File Offset: 0x0009F818
	private ej1 a(TimeSpan A_0, double A_1, ak1 A_2 = null)
	{
		ak1 ak;
		if (A_2 != null)
		{
			ak = A_2;
		}
		else
		{
			ak = this.afe(A_0, A_1);
		}
		if (ak == null)
		{
			this.afg(A_0, A_1);
			return ej1.c;
		}
		if (this.f == dnw.b)
		{
			this.a = this.Subject.a8().k.b.a(ak, this.b, this.c, this.d);
		}
		else if (this.f == dnw.a)
		{
			this.a = this.Subject.a8().k.b.a(ak, this.b, this.c, this.d, true);
		}
		else
		{
			this.a = this.Subject.a8().k.b.a(ak, this.Subject.a8().h.b.aa().SightRange, this.c, this.d);
		}
		this.g = ak;
		this.h = (double)this.e;
		return ej1.a;
	}

	// Token: 0x0400100F RID: 4111
	private auv a;

	// Token: 0x04001010 RID: 4112
	public new double b;

	// Token: 0x04001011 RID: 4113
	public new int c = 2;

	// Token: 0x04001012 RID: 4114
	public int d = 250;

	// Token: 0x04001013 RID: 4115
	public int e;

	// Token: 0x04001014 RID: 4116
	public dnw f;

	// Token: 0x04001015 RID: 4117
	private ak1 g;

	// Token: 0x04001016 RID: 4118
	private new double h;
}
