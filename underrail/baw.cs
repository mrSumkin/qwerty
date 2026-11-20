using System;

// Token: 0x02001F57 RID: 8023
[ayj("PlaceIncendiaryBlobTrap")]
public sealed class baw : dg1
{
	// Token: 0x0600BB58 RID: 47960 RVA: 0x00414988 File Offset: 0x00412B88
	public override string y8()
	{
		return "Place Incendiary Blob Trap";
	}

	// Token: 0x0600BB59 RID: 47961 RVA: 0x00414990 File Offset: 0x00412B90
	public override string os()
	{
		return "PlaceIncendiaryBlobTrap";
	}

	// Token: 0x0600BB5A RID: 47962 RVA: 0x00414998 File Offset: 0x00412B98
	public override bool ds()
	{
		return false;
	}

	// Token: 0x0600BB5B RID: 47963 RVA: 0x0041499C File Offset: 0x00412B9C
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/IncendiaryBlob", new object[]
		{
			c18.g(a_).a(true),
			l4.a(c18.f(a_), false)
		});
	}
}
