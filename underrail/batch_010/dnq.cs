using System;
using System.Runtime.Serialization;

// Token: 0x02001AAF RID: 6831
[eiz("PMRAISE")]
[Serializable]
public sealed class dnq : els, ISerializable
{
	// Token: 0x0600942C RID: 37932 RVA: 0x003A5718 File Offset: 0x003A3918
	private dnq(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600942D RID: 37933 RVA: 0x003A5728 File Offset: 0x003A3928
	public dnq() : base(dnq.a, "Смесь кислотой ржавчины", ci8.c)
	{
		base.Duration = dnq.b;
		base.Icon = "Plot.210";
		base.Stacking = axm.b;
		this.ab = "PlayerMutant_RustingAcidInfusion_Applied";
		this.y = "PlayerMutant_RustingAcidInfusion_Expires";
		this.aa = "PlayerMutant_RustingAcidInfusion_Expires";
	}

	// Token: 0x0600942E RID: 37934 RVA: 0x003A5784 File Offset: 0x003A3984
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PlayerMutantRustingAcidInfusion", new object[0]);
	}

	// Token: 0x040038F3 RID: 14579
	public new static string a = "playerMutantRustingAcidInfusion";

	// Token: 0x040038F4 RID: 14580
	private static int b = 300000;
}
