using System;
using System.Runtime.Serialization;

// Token: 0x02001ADB RID: 6875
[eiz("SGSE")]
[Serializable]
public sealed class ar3 : els, ISerializable
{
	// Token: 0x060094FD RID: 38141 RVA: 0x003A84F8 File Offset: 0x003A66F8
	private ar3(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("SGSE:C");
		this.c = A_0.GetInt32("SGSE:A");
	}

	// Token: 0x060094FE RID: 38142 RVA: 0x003A8524 File Offset: 0x003A6724
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SGSE:C", this.b);
		info.AddValue("SGSE:A", this.c);
	}

	// Token: 0x060094FF RID: 38143 RVA: 0x003A8554 File Offset: 0x003A6754
	public ar3(int A_0, double A_1, int A_2) : base(ar3.a, "Защита копьём", ci8.b)
	{
		this.b = A_1;
		this.c = A_2;
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Status.120";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.Power = (int)((double)A_2 * A_1);
	}

	// Token: 0x06009500 RID: 38144 RVA: 0x003A85B8 File Offset: 0x003A67B8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SpearGuard", new object[]
		{
			(int)(this.b * 100.0),
			this.c
		});
	}

	// Token: 0x0400395D RID: 14685
	public new static readonly string a = "spearGuard";

	// Token: 0x0400395E RID: 14686
	public double b;

	// Token: 0x0400395F RID: 14687
	public new int c;
}
