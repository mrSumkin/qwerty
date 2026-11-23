using System;
using System.Runtime.Serialization;

// Token: 0x020019C6 RID: 6598
[eiz("BPSIE2")]
[Serializable]
public sealed class a04 : bs1
{
	// Token: 0x06008D4F RID: 36175 RVA: 0x003930DC File Offset: 0x003912DC
	private a04(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D50 RID: 36176 RVA: 0x003930E8 File Offset: 0x003912E8
	public override string f9()
	{
		return "caveEarPoison";
	}

	// Token: 0x06008D51 RID: 36177 RVA: 0x003930F0 File Offset: 0x003912F0
	public override string ga()
	{
		return "Яд пещерного уха";
	}

	// Token: 0x06008D52 RID: 36178 RVA: 0x003930F8 File Offset: 0x003912F8
	protected override string gb()
	{
		return "CaveEarPoison";
	}

	// Token: 0x06008D53 RID: 36179 RVA: 0x00393100 File Offset: 0x00391300
	public a04()
	{
	}

	// Token: 0x06008D54 RID: 36180 RVA: 0x0039310C File Offset: 0x0039130C
	public override string gc(efk A_0)
	{
		return qv.a("SpecialAttacks/CaveEarPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(ezx.c, false)
		});
	}

	// Token: 0x06008D55 RID: 36181 RVA: 0x00393168 File Offset: 0x00391368
	public override string gd(efk A_0)
	{
		return qv.a("SpecialAttacks/CaveEarPoisonItemEffect_Applied", new object[]
		{
			(int)(ezx.a * 100.0),
			ezx.b,
			l4.a(ezx.c, false)
		});
	}
}
