using System;

// Token: 0x02001F5C RID: 8028
[ayj("PlaceAcidBlobTrap")]
public sealed class b2c : dg1
{
	// Token: 0x0600BB6F RID: 47983 RVA: 0x00414D34 File Offset: 0x00412F34
	public override string y8()
	{
		return "Place Acid Blob Trap";
	}

	// Token: 0x0600BB70 RID: 47984 RVA: 0x00414D3C File Offset: 0x00412F3C
	public override string os()
	{
		return "PlaceAcidBlobTrap";
	}

	// Token: 0x0600BB71 RID: 47985 RVA: 0x00414D44 File Offset: 0x00412F44
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB72 RID: 47986 RVA: 0x00414D4C File Offset: 0x00412F4C
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/AcidBlob", new object[]
		{
			c18.l(a_).a(true),
			l4.a(c18.bg, false)
		});
	}

	// Token: 0x0600BB73 RID: 47987 RVA: 0x00414D90 File Offset: 0x00412F90
	protected override int d2(cnm A_0)
	{
		return 1;
	}
}
