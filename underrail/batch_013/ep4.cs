using System;
using System.Runtime.Serialization;

// Token: 0x02001AA8 RID: 6824
[eiz("HLASE")]
[Serializable]
public sealed class ep4 : els, ISerializable
{
	// Token: 0x0600940B RID: 37899 RVA: 0x003A4DA0 File Offset: 0x003A2FA0
	private ep4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600940C RID: 37900 RVA: 0x003A4DAC File Offset: 0x003A2FAC
	public ep4() : base(ep4.a, "Свет налобного фонаря", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Status.87";
		base.TickPeriod = d0u.b;
		base.Stacking = axm.b;
		base.TickPeriod = d0u.b;
		base.StaticEffects.Add(new dpw("Stealth", -10000)
		{
			Priority = int.MaxValue
		});
		this.w = "HLAAJ";
		this.x = "HLARJ";
		this.ab = "HLAAJ";
		this.aa = "HLARJ";
		this.y = "HLARJ";
		this.z = "HLATJ";
		this.ad = "HLAHBJ";
	}

	// Token: 0x0600940D RID: 37901 RVA: 0x003A4E6C File Offset: 0x003A306C
	public override string cb(ll A_0)
	{
		eoj a_ = new eoj(A_0.a(), null, null);
		double num = Math.Round((double)qa.a(a_), 1);
		double num2 = Math.Round(qa.e(a_), 1);
		return qv.a("StatusEffects/HelmetLanternAura", new object[]
		{
			num2,
			num
		});
	}

	// Token: 0x040038E5 RID: 14565
	public new static readonly string a = "helmetLanternAura";
}
