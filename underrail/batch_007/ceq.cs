using System;

// Token: 0x0200045B RID: 1115
public sealed class ceq : ak7
{
	// Token: 0x06001D0E RID: 7438 RVA: 0x000A1414 File Offset: 0x0009F614
	public ceq(string A_0, Func<TimeSpan, double, ak1> A_1 = null) : base(A_0)
	{
		this.d = 500;
		this.a = A_1;
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x000A1430 File Offset: 0x0009F630
	protected override ak1 afe(TimeSpan A_0, double A_1)
	{
		if (this.a != null)
		{
			return this.a(A_0, A_1);
		}
		return null;
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x000A144C File Offset: 0x0009F64C
	protected override void aff(TimeSpan A_0, double A_1)
	{
		if (this.b != null)
		{
			this.b(A_0, A_1);
		}
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x000A1468 File Offset: 0x0009F668
	protected override void afg(TimeSpan A_0, double A_1)
	{
		if (this.c != null)
		{
			this.c(A_0, A_1);
		}
	}

	// Token: 0x0400100C RID: 4108
	public Func<TimeSpan, double, ak1> a;

	// Token: 0x0400100D RID: 4109
	public new Action<TimeSpan, double> b;

	// Token: 0x0400100E RID: 4110
	public new Action<TimeSpan, double> c;
}
