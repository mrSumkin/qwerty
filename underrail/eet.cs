using System;
using Microsoft.Xna.Framework.Graphics;

// Token: 0x02001888 RID: 6280
public sealed class eet : btm
{
	// Token: 0x06008556 RID: 34134 RVA: 0x003761CC File Offset: 0x003743CC
	protected override bool b4(e6d A_0)
	{
		this.a = 0;
		bpo.GetServiceOrThrow<bef>().lc();
		return false;
	}

	// Token: 0x06008557 RID: 34135 RVA: 0x003761E4 File Offset: 0x003743E4
	protected override bool aen(e6d A_0)
	{
		this.a++;
		int num = this.a + 1;
		this.a = num;
		if (num > 100)
		{
			return true;
		}
		if (this.b != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().a(this.b);
			}
			return true;
		}
		Texture2D texture2D = bpo.GetServiceOrThrow<bef>().ld();
		if (texture2D != null)
		{
			this.b = texture2D;
		}
		return false;
	}

	// Token: 0x06008558 RID: 34136 RVA: 0x00376264 File Offset: 0x00374464
	public eet() : base(null)
	{
	}

	// Token: 0x0400331B RID: 13083
	private int a;

	// Token: 0x0400331C RID: 13084
	private Texture2D b;
}
