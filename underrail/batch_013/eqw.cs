using System;
using Microsoft.Xna.Framework;

// Token: 0x02002032 RID: 8242
public sealed class eqw : eb1
{
	// Token: 0x0600C30A RID: 49930 RVA: 0x00437CF0 File Offset: 0x00435EF0
	public override av zc()
	{
		return this.a;
	}

	// Token: 0x0600C30B RID: 49931 RVA: 0x00437CF8 File Offset: 0x00435EF8
	public override bool aj9()
	{
		return true;
	}

	// Token: 0x0600C30C RID: 49932 RVA: 0x00437CFC File Offset: 0x00435EFC
	public eqw(ao4 A_0) : this(A_0, eb1.a, bj8.a)
	{
	}

	// Token: 0x0600C30D RID: 49933 RVA: 0x00437D10 File Offset: 0x00435F10
	public eqw(ao4 A_0, esj A_1, esj A_2) : base(A_1, A_2)
	{
		this.b = A_0;
		base.c(bo1.ae);
		base.e(epu.a);
		base.h(epu.a);
		base.Color = epu.a;
		base.g(epu.a);
		base.f(epu.a);
		base.a(epu.a);
		base.d(epu.a);
		base.a(0);
		base.c(epu.a);
		base.b(epu.a);
		base.a(new Color?(new Color(95, 95, 95)));
		base.c(true);
	}

	// Token: 0x0600C30E RID: 49934 RVA: 0x00437DC0 File Offset: 0x00435FC0
	public override bool iq(e08 A_0)
	{
		return false;
	}

	// Token: 0x0600C30F RID: 49935 RVA: 0x00437DC4 File Offset: 0x00435FC4
	protected override void zh(av A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0600C310 RID: 49936 RVA: 0x00437DD0 File Offset: 0x00435FD0
	protected override Rectangle? auf()
	{
		if (this.b != null)
		{
			Point point = this.b.at();
			return new Rectangle?(new Rectangle(point.X, point.Y, this.b.Size.c, this.b.Size.d));
		}
		return base.auf();
	}

	// Token: 0x040046C5 RID: 18117
	private new av a;

	// Token: 0x040046C6 RID: 18118
	private new ao4 b;
}
