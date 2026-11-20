using System;
using System.Runtime.Serialization;

// Token: 0x02001A96 RID: 6806
[eiz("CSY")]
[Serializable]
public sealed class ho : els, ISerializable
{
	// Token: 0x060093B8 RID: 37816 RVA: 0x003A3A20 File Offset: 0x003A1C20
	private ho(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("CSY:T", typeof(Guid));
	}

	// Token: 0x060093B9 RID: 37817 RVA: 0x003A3A4C File Offset: 0x003A1C4C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CSY:T", this.a);
	}

	// Token: 0x17000273 RID: 627
	// (get) Token: 0x060093BA RID: 37818 RVA: 0x003A3A6C File Offset: 0x003A1C6C
	// (set) Token: 0x060093BB RID: 37819 RVA: 0x003A3A74 File Offset: 0x003A1C74
	public Guid TargetId
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x060093BC RID: 37820 RVA: 0x003A3A80 File Offset: 0x003A1C80
	public ho(Guid A_0) : base("combo", "Комбо", ci8.b)
	{
		base.Icon = "Status.Combo";
		base.MaxStacks = egq.b;
		base.Duration = d0u.b;
		base.Stacking = axm.b;
		this.a = A_0;
	}

	// Token: 0x060093BD RID: 37821 RVA: 0x003A3AD0 File Offset: 0x003A1CD0
	public override string cb(ll A_0)
	{
		double num = egq.a;
		if (A_0 != null && A_0.a() != null)
		{
			num += (double)A_0.a().GetSpecializationValue<d3x>(true) * d3x.a;
		}
		return qv.a("StatusEffects/Combo", new object[]
		{
			(int)(num * 100.0),
			l4.a(egq.d, false)
		});
	}

	// Token: 0x040038C3 RID: 14531
	private new Guid a;
}
