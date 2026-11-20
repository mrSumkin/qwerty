using System;

// Token: 0x02001F56 RID: 8022
[ayj("PlaceCorrosiveAcidBlobTrap")]
public sealed class e45 : dg1
{
	// Token: 0x0600BB52 RID: 47954 RVA: 0x004148E0 File Offset: 0x00412AE0
	public override string y8()
	{
		return "Place Corrosive Acid Blob Trap";
	}

	// Token: 0x0600BB53 RID: 47955 RVA: 0x004148E8 File Offset: 0x00412AE8
	public override string os()
	{
		return "PlaceCorrosiveAcidBlobTrap";
	}

	// Token: 0x0600BB54 RID: 47956 RVA: 0x004148F0 File Offset: 0x00412AF0
	public override bool ds()
	{
		return true;
	}

	// Token: 0x0600BB55 RID: 47957 RVA: 0x004148F8 File Offset: 0x00412AF8
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/CorrosiveAcidBlob", new object[]
		{
			c18.k(a_).a(true),
			l4.a(c18.bk, false),
			c18.bl,
			(int)(deu.a * 100.0),
			l4.a(deu.c, false),
			deu.b
		});
	}

	// Token: 0x0600BB56 RID: 47958 RVA: 0x0041497C File Offset: 0x00412B7C
	protected override int d2(cnm A_0)
	{
		return 1;
	}
}
