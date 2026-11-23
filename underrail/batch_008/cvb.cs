using System;
using System.Runtime.Serialization;

// Token: 0x02001B36 RID: 6966
[eiz("TDE")]
[Serializable]
public sealed class cvb : els, ISerializable
{
	// Token: 0x060096AA RID: 38570 RVA: 0x003AE4FC File Offset: 0x003AC6FC
	private cvb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060096AB RID: 38571 RVA: 0x003AE508 File Offset: 0x003AC708
	public cvb(bool A_0) : base("thermodynamicity_" + (A_0 ? "heat" : "cold"), "Термодинамичность: " + (A_0 ? "Огонь" : "Холод"), ci8.c)
	{
		base.Duration = dyi.a * d0u.b;
		base.Icon = "Status.Thermodynamicity_" + (A_0 ? "Heat" : "Cold");
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new eo3(A_0 ? eom.b : eom.c));
	}

	// Token: 0x060096AC RID: 38572 RVA: 0x003AE5C0 File Offset: 0x003AC7C0
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/" + base.Code, new object[]
		{
			Convert.ToInt32(dyi.a((A_0 != null) ? A_0.a() : null) * 100.0)
		});
	}

	// Token: 0x040039F3 RID: 14835
	private new float a;

	// Token: 0x040039F4 RID: 14836
	private float b;
}
