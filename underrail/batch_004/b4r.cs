using System;
using Microsoft.Xna.Framework;

// Token: 0x02001887 RID: 6279
public sealed class b4r : btm
{
	// Token: 0x06008553 RID: 34131 RVA: 0x003760D4 File Offset: 0x003742D4
	public b4r(string A_0, string A_1, Rectangle? A_2) : this(A_0, A_1)
	{
		this.d = A_2;
	}

	// Token: 0x06008554 RID: 34132 RVA: 0x003760E8 File Offset: 0x003742E8
	public b4r(string A_0, string A_1) : base(null)
	{
		this.b = A_1;
		this.c = A_0;
	}

	// Token: 0x06008555 RID: 34133 RVA: 0x00376100 File Offset: 0x00374300
	protected override bool aen(e6d A_0)
	{
		if (this.a == null)
		{
			bcm serviceOrThrow = bpo.GetServiceOrThrow<bcm>();
			if (serviceOrThrow.aau() != null)
			{
				this.a = new pz();
				this.a.a(this.c);
				if (this.d != null)
				{
					this.a.a(this.d.Value);
				}
				this.a.Text = this.b;
				this.a.Gravity = axy.c;
				this.a.b();
				this.a.a(true);
				serviceOrThrow.aau().aox(this.a);
			}
		}
		else if (this.a.f())
		{
			return true;
		}
		return false;
	}

	// Token: 0x04003317 RID: 13079
	public pz a;

	// Token: 0x04003318 RID: 13080
	private string b;

	// Token: 0x04003319 RID: 13081
	private string c;

	// Token: 0x0400331A RID: 13082
	private new Rectangle? d;
}
