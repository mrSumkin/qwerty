using System;
using System.Runtime.Serialization;

// Token: 0x02001A88 RID: 6792
[eiz("GISE")]
[Serializable]
public sealed class bd9 : els, ISerializable
{
	// Token: 0x06009378 RID: 37752 RVA: 0x003A2890 File Offset: 0x003A0A90
	private bd9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009379 RID: 37753 RVA: 0x003A289C File Offset: 0x003A0A9C
	public bd9() : base(bd9.a, "Противоракетная система с лазерным охлаждением", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.130";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "ColdLaserInterception"));
	}

	// Token: 0x0600937A RID: 37754 RVA: 0x003A28EC File Offset: 0x003A0AEC
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/ColdLaserInterception");
	}

	// Token: 0x040038A4 RID: 14500
	public new static readonly string a = "coldLaserInterception";

	// Token: 0x040038A5 RID: 14501
	[NonSerialized]
	public TimeSpan b;
}
