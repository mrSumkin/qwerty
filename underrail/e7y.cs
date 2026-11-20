using System;

// Token: 0x02000462 RID: 1122
public sealed class e7y : ak7
{
	// Token: 0x06001D31 RID: 7473 RVA: 0x000A1E48 File Offset: 0x000A0048
	public e7y(string A_0) : base(A_0)
	{
		this.d = 500;
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x000A1E78 File Offset: 0x000A0078
	public override bool acj(TimeSpan A_0, double A_1)
	{
		TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("NextIdleMoveTime", null);
		return primitivePropertyValue == null || primitivePropertyValue.Value < A_0;
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x000A1EC0 File Offset: 0x000A00C0
	protected override ak1 afe(TimeSpan A_0, double A_1)
	{
		int value = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.bn, new int?(this.b)).Value;
		int value2 = this.Subject.y6().GetPrimitivePropertyValue<int>(ddq.bo, new int?(this.c)).Value;
		return g8.a(this.Subject, value, value2);
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x000A1F2C File Offset: 0x000A012C
	protected override void afg(TimeSpan A_0, double A_1)
	{
		this.a(A_0);
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x000A1F38 File Offset: 0x000A0138
	protected override void aff(TimeSpan A_0, double A_1)
	{
		this.a(A_0);
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x000A1F44 File Offset: 0x000A0144
	private void a(TimeSpan A_0)
	{
		this.Subject.y6()["NextIdleMoveTime"] = A_0 + TimeSpan.FromMilliseconds((double)this.a * (0.5 + cuo.a.NextDouble()));
	}

	// Token: 0x0400102B RID: 4139
	public int a = 4000;

	// Token: 0x0400102C RID: 4140
	public new int b = 3;

	// Token: 0x0400102D RID: 4141
	public new int c = 3;
}
