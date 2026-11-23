using System;
using System.Collections.Generic;

// Token: 0x02001F08 RID: 7944
[ayj("Compass")]
public sealed class a1c : cx6
{
	// Token: 0x0600B657 RID: 46679 RVA: 0x0040B01C File Offset: 0x0040921C
	public override string y8()
	{
		return "Компас";
	}

	// Token: 0x0600B658 RID: 46680 RVA: 0x0040B024 File Offset: 0x00409224
	public override string os()
	{
		return "Compass";
	}

	// Token: 0x0600B659 RID: 46681 RVA: 0x0040B02C File Offset: 0x0040922C
	public override ci8 bg()
	{
		return ci8.a;
	}

	// Token: 0x0600B65A RID: 46682 RVA: 0x0040B030 File Offset: 0x00409230
	public override int bh()
	{
		return int.MinValue;
	}

	// Token: 0x0600B65B RID: 46683 RVA: 0x0040B038 File Offset: 0x00409238
	public override v5 c2()
	{
		return v5.b;
	}

	// Token: 0x0600B65C RID: 46684 RVA: 0x0040B03C File Offset: 0x0040923C
	public override string bm(cnm A_0)
	{
		return null;
	}

	// Token: 0x0600B65D RID: 46685 RVA: 0x0040B040 File Offset: 0x00409240
	public override string bo(cnm A_0)
	{
		return qv.b("Items\\Utilities/Compass");
	}

	// Token: 0x0600B65E RID: 46686 RVA: 0x0040B04C File Offset: 0x0040924C
	public override string bp(cnm A_0)
	{
		return this.bo(A_0);
	}

	// Token: 0x0600B65F RID: 46687 RVA: 0x0040B058 File Offset: 0x00409258
	public override List<els> j8(cnm A_0)
	{
		if (A_0 != null)
		{
			A_0.b9();
		}
		return new List<els>
		{
			new d3t()
		};
	}

	// Token: 0x0600B660 RID: 46688 RVA: 0x0040B078 File Offset: 0x00409278
	protected override int hi(cnm A_0)
	{
		return 0;
	}
}
