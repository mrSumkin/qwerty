using System;
using System.Collections.Generic;

// Token: 0x02001F75 RID: 8053
[ayj("molotovCocktail")]
public sealed class dyp : ami
{
	// Token: 0x0600BC7A RID: 48250 RVA: 0x004164B8 File Offset: 0x004146B8
	public override string y8()
	{
		return "Бросок коктейля Молотова";
	}

	// Token: 0x0600BC7B RID: 48251 RVA: 0x004164C0 File Offset: 0x004146C0
	public override string os()
	{
		return "molotovCocktail";
	}

	// Token: 0x0600BC7C RID: 48252 RVA: 0x004164C8 File Offset: 0x004146C8
	public override string bo(cnm A_0)
	{
		return string.Empty;
	}

	// Token: 0x0600BC7D RID: 48253 RVA: 0x004164D4 File Offset: 0x004146D4
	public override string bp(cnm A_0)
	{
		int a_ = c18.a(A_0);
		b1j b1j = c18.d();
		b1j b1j2 = c18.b();
		b1j b1j3 = c18.c();
		return qv.a("Grenades/Molotov", new object[]
		{
			c18.e(a_).a(true),
			(int)(c18.v * 100.0),
			(int)(c18.w * 100.0),
			l4.a(c18.x, false),
			(int)(b1j.b * 100.0),
			(int)(b1j.c * 100.0),
			(int)b1j2.b,
			(int)b1j2.c,
			(int)b1j3.b,
			(int)b1j3.c
		});
	}

	// Token: 0x0600BC7E RID: 48254 RVA: 0x004165CC File Offset: 0x004147CC
	public override IList<cfd> bq(cnm A_0, v5 A_1)
	{
		return new List<cfd>
		{
			new cfd(d7f.l, ami.a(A_0), false, false)
		};
	}

	// Token: 0x0600BC7F RID: 48255 RVA: 0x004165EC File Offset: 0x004147EC
	public override IList<string> bi()
	{
		return new List<string>
		{
			d7f.l
		};
	}

	// Token: 0x0600BC80 RID: 48256 RVA: 0x00416600 File Offset: 0x00414800
	protected override int d2(cnm A_0)
	{
		return c18.a();
	}

	// Token: 0x04004405 RID: 17413
	private new const string a = "grenade.molotov";

	// Token: 0x04004406 RID: 17414
	private static readonly int b = 6;
}
