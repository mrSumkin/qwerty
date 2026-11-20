using System;
using System.Runtime.Serialization;

// Token: 0x02001AAD RID: 6829
[eiz("PSPSE")]
[Serializable]
public sealed class d1 : els, ISerializable
{
	// Token: 0x06009423 RID: 37923 RVA: 0x003A54D8 File Offset: 0x003A36D8
	private d1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetValue("PSPSE:P", typeof(object));
		this.c = A_0.GetDouble("PSPSE:D");
		this.d = (Guid)A_0.GetValue("PSPSE:I", typeof(Guid));
	}

	// Token: 0x06009424 RID: 37924 RVA: 0x003A553C File Offset: 0x003A373C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSPSE:P", this.b);
		info.AddValue("PSPSE:D", this.c);
		info.AddValue("PSPSE:I", this.d);
	}

	// Token: 0x06009425 RID: 37925 RVA: 0x003A558C File Offset: 0x003A378C
	public d1(int A_0, object A_1, double A_2, Guid A_3) : base(d1.a, "Психосоматическая жертва", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.PsychosomaticPredation";
		base.VisualEffects.Add(new ud(this, "PsychosomaticPrey"));
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		this.ag = "PsychosomaticPredation_PreyDied";
		this.z = "PsychosomaticPredation_PreyTick";
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06009426 RID: 37926 RVA: 0x003A5618 File Offset: 0x003A3818
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsychosomaticPrey", new object[]
		{
			Convert.ToInt32(this.c * 100.0)
		});
	}

	// Token: 0x040038ED RID: 14573
	public new static readonly string a = "psychosomaticPrey";

	// Token: 0x040038EE RID: 14574
	public object b;

	// Token: 0x040038EF RID: 14575
	public new double c;

	// Token: 0x040038F0 RID: 14576
	public new Guid d;
}
