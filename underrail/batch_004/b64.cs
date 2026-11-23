using System;

// Token: 0x0200045E RID: 1118
public class b64 : adt
{
	// Token: 0x06001D20 RID: 7456 RVA: 0x000A1900 File Offset: 0x0009FB00
	public b64(string A_0, Func<TimeSpan, double, bool> A_1 = null, Func<TimeSpan, double, ej1> A_2 = null, Func<bool, float> A_3 = null, Action A_4 = null) : base(A_0)
	{
		this.a = A_1;
		this.b = A_2;
		this.c = A_3;
		this.d = A_4;
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x000A1928 File Offset: 0x0009FB28
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		if (this.b != null)
		{
			return this.b(A_0, A_1);
		}
		return ej1.b;
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x000A1944 File Offset: 0x0009FB44
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.a == null || this.a(A_0, A_1);
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x000A1960 File Offset: 0x0009FB60
	public override float km(bool A_0)
	{
		if (this.c != null)
		{
			return this.c(A_0);
		}
		return base.km(A_0);
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x000A1984 File Offset: 0x0009FB84
	public override void ack()
	{
		base.ack();
		if (this.d != null)
		{
			this.d();
		}
	}

	// Token: 0x0400101D RID: 4125
	private Func<TimeSpan, double, bool> a;

	// Token: 0x0400101E RID: 4126
	private new Func<TimeSpan, double, ej1> b;

	// Token: 0x0400101F RID: 4127
	private new Func<bool, float> c;

	// Token: 0x04001020 RID: 4128
	private Action d;
}
