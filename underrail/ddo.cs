using System;
using System.Runtime.Serialization;

// Token: 0x02001AA5 RID: 6821
[eiz("BUSS")]
[Serializable]
public sealed class ddo : els, ISerializable
{
	// Token: 0x060093FE RID: 37886 RVA: 0x003A4A34 File Offset: 0x003A2C34
	private ddo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060093FF RID: 37887 RVA: 0x003A4A40 File Offset: 0x003A2C40
	public ddo(int A_0) : base(ddo.a, "За бордюром", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "xpbl_Abilities.22";
		base.MaxStacks = cm6.b;
		base.Stacking = axm.b;
	}

	// Token: 0x06009400 RID: 37888 RVA: 0x003A4A84 File Offset: 0x003A2C84
	public override string cb(ll A_0)
	{
		double num = this.a((A_0 != null) ? A_0.a() : null);
		return qv.a("StatusEffects/BoardedUp", new object[]
		{
			Convert.ToInt32(num * 100.0)
		});
	}

	// Token: 0x06009401 RID: 37889 RVA: 0x003A4AD4 File Offset: 0x003A2CD4
	public double a(efk A_0)
	{
		return cm6.a(A_0) * (double)base.Stacks;
	}

	// Token: 0x040038DF RID: 14559
	public new static readonly string a = "boardedUp";
}
