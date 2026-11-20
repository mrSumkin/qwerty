using System;
using System.Runtime.Serialization;

// Token: 0x02001A7F RID: 6783
[eiz("ZSMSE")]
[Serializable]
public sealed class ert : els, ISerializable
{
	// Token: 0x0600934C RID: 37708 RVA: 0x003A1D74 File Offset: 0x0039FF74
	private ert(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.c = A_0.GetDouble("ZSMSE:D");
	}

	// Token: 0x0600934D RID: 37709 RVA: 0x003A1D90 File Offset: 0x0039FF90
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ZSMSE:D", this.c);
	}

	// Token: 0x0600934E RID: 37710 RVA: 0x003A1DAC File Offset: 0x0039FFAC
	public ert(double A_0) : base("sweepingMomentum", "Сметающий момент", ci8.c)
	{
		this.c = A_0;
		base.Duration = ert.b * d0u.b;
		base.Icon = "xpbl_Attacks.41";
		base.MaxStacks = ert.a;
		base.Stacking = axm.b;
		base.Power = (int)(this.c * 100.0);
	}

	// Token: 0x0600934F RID: 37711 RVA: 0x003A1E18 File Offset: 0x003A0018
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/SweepingMomentum", new object[]
		{
			Convert.ToInt32(this.c * (double)base.Stacks * 100.0)
		});
	}

	// Token: 0x04003886 RID: 14470
	public new static readonly int a = 5;

	// Token: 0x04003887 RID: 14471
	public static readonly int b = 4;

	// Token: 0x04003888 RID: 14472
	public new double c;
}
