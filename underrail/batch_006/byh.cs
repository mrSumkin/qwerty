using System;

// Token: 0x0200045D RID: 1117
public class byh : b64
{
	// Token: 0x06001D1B RID: 7451 RVA: 0x000A1734 File Offset: 0x0009F934
	public byh(string A_0, Func<TimeSpan, double, bool> A_1 = null, Func<TimeSpan, double, cst> A_2 = null, Func<bool, float> A_3 = null, Func<cst> A_4 = null) : base(A_0, A_1, null, A_3, null)
	{
		this.b = A_2;
		this.c = A_4;
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x000A1760 File Offset: 0x0009F960
	public override void mc(TimeSpan A_0, double A_1)
	{
		this.a = null;
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x000A176C File Offset: 0x0009F96C
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.Subject.a8().i.b == null)
		{
			return ej1.c;
		}
		if (this.a == null)
		{
			if (this.b != null)
			{
				this.a = this.b(A_0, A_1);
			}
			if (this.a != null)
			{
				if (this.e)
				{
					this.Subject.a8().i.b.b(this.a, this.d);
				}
				return ej1.a;
			}
			return ej1.c;
		}
		else
		{
			if (this.a.State == dc4.c)
			{
				return ej1.b;
			}
			if (this.a.State == dc4.e || this.a.State == dc4.d)
			{
				return ej1.c;
			}
			return ej1.a;
		}
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x000A1838 File Offset: 0x0009FA38
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return (!this.f && this.a != null && this.a.State == dc4.b) || base.acj(A_0, A_1);
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x000A1870 File Offset: 0x0009FA70
	public override void ack()
	{
		if (this.a != null && this.a.State == dc4.b && (this.a.kh() & m7.k) != m7.k)
		{
			this.a.j();
			this.a = null;
		}
		if (this.c != null)
		{
			cst cst = this.c();
			if (cst != null)
			{
				this.Subject.a8().i.b.b(cst, atp.a);
			}
		}
	}

	// Token: 0x04001017 RID: 4119
	private cst a;

	// Token: 0x04001018 RID: 4120
	private new Func<TimeSpan, double, cst> b;

	// Token: 0x04001019 RID: 4121
	private new Func<cst> c;

	// Token: 0x0400101A RID: 4122
	public atp d;

	// Token: 0x0400101B RID: 4123
	public bool e = true;

	// Token: 0x0400101C RID: 4124
	public bool f = true;
}
