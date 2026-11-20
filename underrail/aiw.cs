using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AF9 RID: 6905
[eiz("EASE")]
[Serializable]
public sealed class aiw : els, ISerializable
{
	// Token: 0x06009590 RID: 38288 RVA: 0x003AA9CC File Offset: 0x003A8BCC
	private aiw(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009591 RID: 38289 RVA: 0x003AA9D8 File Offset: 0x003A8BD8
	public aiw(int A_0) : base(aiw.a, "Экзотермическая аура", ci8.b)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.ExothermicAura";
		base.VisualEffects.Add(new ud(this, "Burning"));
		base.Stacking = axm.b;
		base.AppliedAction = "BurningAppliedAction";
		base.ExpiredAction = "BurningExpiresAction";
		base.RemovedAction = "BurningExpiresAction";
		this.w = "B04";
		this.x = "B05";
		this.z = "HCDFHJ";
		this.ad = "ExothermicAura_Heartbeat";
		base.StaticEffects.Add(new cgv(DamageType.Heat, 100.0, 0));
	}

	// Token: 0x06009592 RID: 38290 RVA: 0x003AAA98 File Offset: 0x003A8C98
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/ExothermicAura");
	}

	// Token: 0x04003997 RID: 14743
	public new static readonly string a = "exothermicAura";
}
