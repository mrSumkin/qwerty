using System;
using System.Runtime.Serialization;

// Token: 0x02001A20 RID: 6688
[eiz("M91")]
[Serializable]
public sealed class caz : d91, ISerializable, em0
{
	// Token: 0x060090D0 RID: 37072 RVA: 0x0039B800 File Offset: 0x00399A00
	private caz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090D1 RID: 37073 RVA: 0x0039B80C File Offset: 0x00399A0C
	public caz()
	{
	}

	// Token: 0x060090D2 RID: 37074 RVA: 0x0039B814 File Offset: 0x00399A14
	public caz(double A_0) : base(A_0)
	{
	}

	// Token: 0x060090D3 RID: 37075 RVA: 0x0039B820 File Offset: 0x00399A20
	public override bool ae5()
	{
		return base.b() > 0.0;
	}

	// Token: 0x060090D4 RID: 37076 RVA: 0x0039B838 File Offset: 0x00399A38
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null)
		{
			nw nw = A_0.a().Defense;
			nw.b(nw.aj() + base.b());
		}
	}

	// Token: 0x060090D5 RID: 37077 RVA: 0x0039B878 File Offset: 0x00399A78
	public override d3e b3()
	{
		caz caz = new caz();
		this.xx(caz);
		return caz;
	}

	// Token: 0x060090D6 RID: 37078 RVA: 0x0039B894 File Offset: 0x00399A94
	public override string b2()
	{
		if (base.b() > 0.0)
		{
			return qv.a("StaticEffects/ModifyArmorPenalty_Increased", new object[]
			{
				base.b() * 100.0
			});
		}
		return qv.a("StaticEffects/ModifyArmorPenalty_Decreased", new object[]
		{
			Math.Abs(base.b()) * 100.0
		});
	}
}
