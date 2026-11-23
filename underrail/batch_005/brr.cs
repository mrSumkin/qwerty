using System;
using System.Runtime.Serialization;

// Token: 0x02001AAB RID: 6827
[eiz("PSPSE2")]
[Serializable]
public sealed class brr : els, ISerializable
{
	// Token: 0x06009418 RID: 37912 RVA: 0x003A520C File Offset: 0x003A340C
	private brr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (Guid)A_0.GetValue("PSPSE2:I", typeof(Guid));
	}

	// Token: 0x06009419 RID: 37913 RVA: 0x003A5238 File Offset: 0x003A3438
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSPSE2:I", this.a);
	}

	// Token: 0x0600941A RID: 37914 RVA: 0x003A525C File Offset: 0x003A345C
	public brr(int A_0, Guid A_1) : base(brr.b, "Психосоматический хищник", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.PsychosomaticPredationPredator";
		base.MaxStacks = 1;
		base.Stacking = axm.a;
		this.a = A_1;
		this.z = "PsychosomaticPredation_PredatorTick";
	}

	// Token: 0x0600941B RID: 37915 RVA: 0x003A52B8 File Offset: 0x003A34B8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsychosomaticPredator", new object[]
		{
			Convert.ToInt32(dfd.h * 100.0)
		});
	}

	// Token: 0x040038E9 RID: 14569
	public new Guid a;

	// Token: 0x040038EA RID: 14570
	public static readonly string b = "psychosomaticPredator";
}
