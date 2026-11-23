using System;

// Token: 0x02001F4B RID: 8011
[ayj("PlaceRustingAcidBlobTrap")]
public sealed class c9g : dg1
{
	// Token: 0x0600BB03 RID: 47875 RVA: 0x00413F44 File Offset: 0x00412144
	public override string y8()
	{
		return "Place Rusting Acid Blob Trap";
	}

	// Token: 0x0600BB04 RID: 47876 RVA: 0x00413F4C File Offset: 0x0041214C
	public override string os()
	{
		return "PlaceRustingAcidBlobTrap";
	}

	// Token: 0x0600BB05 RID: 47877 RVA: 0x00413F54 File Offset: 0x00412154
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB06 RID: 47878 RVA: 0x00413F58 File Offset: 0x00412158
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/RustingAcidBlob", new object[]
		{
			c18.j(a_).a(true),
			l4.a(c18.bp, false),
			Convert.ToInt32(d9b.a * 100.0),
			c18.bq,
			ce.c,
			l4.a(ce.b, false),
			ce.a
		});
	}

	// Token: 0x0600BB07 RID: 47879 RVA: 0x00413FF0 File Offset: 0x004121F0
	protected override int d2(cnm A_0)
	{
		return 1;
	}
}
