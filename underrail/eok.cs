using System;
using System.Runtime.Serialization;

// Token: 0x02001B01 RID: 6913
[eiz("DSE1")]
[Serializable]
public sealed class eok : els, ISerializable
{
	// Token: 0x060095B4 RID: 38324 RVA: 0x003AAF24 File Offset: 0x003A9124
	private eok(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095B5 RID: 38325 RVA: 0x003AAF30 File Offset: 0x003A9130
	public eok(int A_0) : base(eok.c, "Дезориентация", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Dazed";
		base.VisualEffects.Add(new ud(this, "Dazed"));
		base.Stacking = axm.b;
		base.StaticEffects.Add(new d9(-eok.a, true, false));
		base.StaticEffects.Add(new ba(-eok.b, false, true, true));
		base.StaticEffects.Add(new i0(-0.3f, false, false, true));
	}

	// Token: 0x060095B6 RID: 38326 RVA: 0x003AAFC8 File Offset: 0x003A91C8
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/Dazed", new object[]
		{
			eok.a,
			eok.b
		});
	}

	// Token: 0x0400399E RID: 14750
	public new static readonly int a = 15;

	// Token: 0x0400399F RID: 14751
	public static readonly int b = 30;

	// Token: 0x040039A0 RID: 14752
	public new static readonly string c = "dazed";
}
