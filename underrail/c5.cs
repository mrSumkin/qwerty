using System;

// Token: 0x02001F58 RID: 8024
[ayj("PlaceCryoliquidBlobTrap")]
public sealed class c5 : dg1
{
	// Token: 0x0600BB5D RID: 47965 RVA: 0x004149EC File Offset: 0x00412BEC
	public override string y8()
	{
		return "Place Cryoliquid Blob Trap";
	}

	// Token: 0x0600BB5E RID: 47966 RVA: 0x004149F4 File Offset: 0x00412BF4
	public override string os()
	{
		return "PlaceCryoliquidBlobTrap";
	}

	// Token: 0x0600BB5F RID: 47967 RVA: 0x004149FC File Offset: 0x00412BFC
	public override bool ds()
	{
		return false;
	}

	// Token: 0x0600BB60 RID: 47968 RVA: 0x00414A04 File Offset: 0x00412C04
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		return qv.a("Traps/CryoliquidBlob", new object[]
		{
			c18.i(a_).a(true),
			l4.a(c18.h(a_), false)
		});
	}
}
