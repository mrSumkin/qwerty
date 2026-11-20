using System;
using System.Runtime.Serialization;

// Token: 0x02001B45 RID: 6981
[eiz("FSE")]
[Serializable]
public sealed class a2 : els, ISerializable
{
	// Token: 0x060096F8 RID: 38648 RVA: 0x003AFA80 File Offset: 0x003ADC80
	private a2(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 395)
		{
			this.b = (A_0.GetValue("FSE:CBS", typeof(double?)) as double?);
			return;
		}
		if (A_0.GetBoolean("FSE:CBS"))
		{
			this.b = new double?(co4.b);
		}
	}

	// Token: 0x060096F9 RID: 38649 RVA: 0x003AFAEC File Offset: 0x003ADCEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FSE:CBS", this.b);
	}

	// Token: 0x17000282 RID: 642
	// (get) Token: 0x060096FA RID: 38650 RVA: 0x003AFB0C File Offset: 0x003ADD0C
	public double? ShatteringThreshold
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x060096FB RID: 38651 RVA: 0x003AFB18 File Offset: 0x003ADD18
	public a2(int A_0, double? A_1 = null) : base(a2.a, "Заморозка", ci8.c)
	{
		this.b = A_1;
		base.Duration = A_0;
		base.TickPeriod = 0;
		base.Icon = "Psi.Cryostasis";
		base.VisualEffects.Add(new ud(this, "IceBlock"));
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax2());
		base.StaticEffects.Add(new cz9());
	}

	// Token: 0x060096FC RID: 38652 RVA: 0x003AFB94 File Offset: 0x003ADD94
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/Frozen");
	}

	// Token: 0x04003A16 RID: 14870
	public new static readonly string a = "frozen";

	// Token: 0x04003A17 RID: 14871
	private double? b;
}
