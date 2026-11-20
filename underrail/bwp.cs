using System;
using System.Runtime.Serialization;

// Token: 0x02000FAF RID: 4015
[eiz("ESMSE")]
[Serializable]
public sealed class bwp : els, ISerializable
{
	// Token: 0x06005219 RID: 21017 RVA: 0x0024CC14 File Offset: 0x0024AE14
	private bwp(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600521A RID: 21018 RVA: 0x0024CC24 File Offset: 0x0024AE24
	public bwp() : base(bwp.a, "Усиление энергетического щита", ci8.b)
	{
		base.Duration = 0;
		base.Icon = "Xpbl_Abilities.30";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ak5(null, aqd.a));
		base.TickPeriod = d0u.b;
		this.z = "EnergyShieldEmpowerment_Tick";
		base.VisualEffects.Add(new ud(this, "EnergyShieldEmpowerment"));
	}

	// Token: 0x0600521B RID: 21019 RVA: 0x0024CCA8 File Offset: 0x0024AEA8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/EnergyShieldEmpowerment", new object[]
		{
			aqd.f,
			Convert.ToInt32(aqd.a * 100.0)
		});
	}

	// Token: 0x04002198 RID: 8600
	public new static readonly string a = "energyShieldEmpowerment";
}
