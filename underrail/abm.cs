using System;
using System.Runtime.Serialization;

// Token: 0x020019BF RID: 6591
[eiz("BPSIE4")]
[Serializable]
public sealed class abm : bs1
{
	// Token: 0x06008D19 RID: 36121 RVA: 0x00392938 File Offset: 0x00390B38
	private abm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008D1A RID: 36122 RVA: 0x00392944 File Offset: 0x00390B44
	public override string f9()
	{
		return "blackDragonPoison";
	}

	// Token: 0x06008D1B RID: 36123 RVA: 0x0039294C File Offset: 0x00390B4C
	public override string ga()
	{
		return "Яд чёрного дракона";
	}

	// Token: 0x06008D1C RID: 36124 RVA: 0x00392954 File Offset: 0x00390B54
	protected override string gb()
	{
		return "BlackDragonPoison";
	}

	// Token: 0x06008D1D RID: 36125 RVA: 0x0039295C File Offset: 0x00390B5C
	public abm()
	{
		base.RemainingTicks = 3;
	}

	// Token: 0x06008D1E RID: 36126 RVA: 0x0039296C File Offset: 0x00390B6C
	public override string gc(efk A_0)
	{
		return qv.a("SpecialAttacks/BlackDragonPoisonItemEffect_Cap", new object[]
		{
			base.a(),
			l4.a(ezx.g, false)
		});
	}

	// Token: 0x06008D1F RID: 36127 RVA: 0x00392998 File Offset: 0x00390B98
	public override string gd(efk A_0)
	{
		return qv.a("SpecialAttacks/BlackDragonPoisonItemEffect_Applied", new object[]
		{
			l4.a(ezx.g, false)
		});
	}
}
