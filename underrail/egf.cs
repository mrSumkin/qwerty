using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AA7 RID: 6823
[eiz("CDRSE")]
[Serializable]
public sealed class egf : els, ISerializable
{
	// Token: 0x06009408 RID: 37896 RVA: 0x003A4CC8 File Offset: 0x003A2EC8
	private egf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009409 RID: 37897 RVA: 0x003A4CD4 File Offset: 0x003A2ED4
	public egf(int A_0, int A_1) : base("cutsceneDamageResistanceStatusEffect", "Устойчивость к урону иногоплана", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Misc.0";
		base.Stacking = axm.b;
		base.Power = A_1;
		base.Silent = true;
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new cgv(a_, (double)base.Power, 0));
		}
	}

	// Token: 0x0600940A RID: 37898 RVA: 0x003A4D8C File Offset: 0x003A2F8C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/CutsceneDamageResistance", new object[0]);
	}
}
