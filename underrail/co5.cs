using System;
using System.Runtime.Serialization;

// Token: 0x02001825 RID: 6181
[eiz("SCOSE")]
[Serializable]
public sealed class co5 : els, ISerializable
{
	// Token: 0x0600839D RID: 33693 RVA: 0x0036EEF0 File Offset: 0x0036D0F0
	private co5(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 688)
		{
			this.b = A_0.GetDouble("SCOSE:M");
		}
	}

	// Token: 0x0600839E RID: 33694 RVA: 0x0036EF1C File Offset: 0x0036D11C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SCOSE:M", this.b);
	}

	// Token: 0x0600839F RID: 33695 RVA: 0x0036EF38 File Offset: 0x0036D138
	public co5(double A_0, int A_1) : base(co5.a, "Вызов перегрузки сканированием", ci8.c)
	{
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.97";
		base.Stacking = axm.b;
		base.Power = Convert.ToInt32(A_0 * 100.0);
		this.b = A_0;
	}

	// Token: 0x060083A0 RID: 33696 RVA: 0x0036EF98 File Offset: 0x0036D198
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/ScanCallOverload", new object[]
		{
			Convert.ToInt32(Math.Round(this.b, 2) * 100.0)
		});
	}

	// Token: 0x0400328D RID: 12941
	public new static readonly string a = "scanCallOverload";

	// Token: 0x0400328E RID: 12942
	public double b;
}
