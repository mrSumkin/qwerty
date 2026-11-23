using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001B3F RID: 6975
[eiz("AEE")]
[Serializable]
public sealed class e32 : els, ISerializable
{
	// Token: 0x060096D7 RID: 38615 RVA: 0x003AF1E8 File Offset: 0x003AD3E8
	private e32(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetInt32("AEE:PD");
	}

	// Token: 0x060096D8 RID: 38616 RVA: 0x003AF204 File Offset: 0x003AD404
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("AEE:PD", this.b);
	}

	// Token: 0x060096D9 RID: 38617 RVA: 0x003AF220 File Offset: 0x003AD420
	public e32(efk A_0, int A_1, int A_2) : base(e32.a, "Опутывание кислотой", ci8.c)
	{
		this.b = A_2;
		base.Duration = A_1;
		base.TickPeriod = d0u.b;
		base.Icon = "DamageType.Acid";
		base.VisualEffects.Add(new ud(this, "AcidBlobEntanglement"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		cwt cwt = new cwt();
		if (A_0 != null)
		{
			cwt.i = new ap9(A_0);
		}
		cwt.l = true;
		cwt.e = false;
		cwt.r = true;
		cwt.f = new List<csk>
		{
			new csk(DamageType.Acid, A_2)
		};
		cwt.q = false;
		cwt.b = true;
		cwt.v = (dh9.b("element_acidicEntanglement") ?? "опутывание кислотой");
		cwt.ad["IsAcidWeapon"] = true;
		base.StaticEffects.Add(new ap0());
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x060096DA RID: 38618 RVA: 0x003AF330 File Offset: 0x003AD530
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/AcidicEntanglement", new object[]
		{
			this.b
		});
	}

	// Token: 0x04003A07 RID: 14855
	public new static readonly string a = "acidicEntanglement";

	// Token: 0x04003A08 RID: 14856
	private int b;
}
