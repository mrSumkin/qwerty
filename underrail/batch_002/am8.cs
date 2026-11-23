using System;
using Microsoft.Xna.Framework;

// Token: 0x020007D2 RID: 2002
public sealed class am8 : btm
{
	// Token: 0x0600322A RID: 12842 RVA: 0x00134DD4 File Offset: 0x00132FD4
	protected override bool b4(e6d A_0)
	{
		this.d = "*";
		this.e = 0;
		this.c = new Vector3(1f, 1f, 1f);
		return base.b4(A_0);
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x00134E0C File Offset: 0x0013300C
	protected override bool aen(e6d A_0)
	{
		double totalMilliseconds = A_0.a().ElapsedGameTime.TotalMilliseconds;
		if (this.d == "*")
		{
			if (this.a(0f, -1f, -1f, totalMilliseconds))
			{
				this.d = "G";
			}
		}
		else if (this.d == "R")
		{
			if (this.a(1f, -1f, -1f, totalMilliseconds))
			{
				this.d = "G";
			}
		}
		else if (this.d == "G")
		{
			if (this.a(-1f, 1f, -1f, totalMilliseconds))
			{
				this.d = "B";
			}
		}
		else if (this.d == "B" && this.a(-1f, -1f, 1f, totalMilliseconds))
		{
			int num = this.e + 1;
			this.e = num;
			if (num >= this.b)
			{
				this.d = "e";
			}
			else
			{
				this.d = "R";
			}
		}
		bpo.GetServiceOrThrow<ps>().and(new Color?(new Color(this.c)));
		return this.d == "e";
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x00134F80 File Offset: 0x00133180
	private bool a(float A_0, float A_1, float A_2, double A_3)
	{
		Vector3 value = this.c;
		this.c.X = d05.b(0.5f, (float)((double)this.c.X + (double)A_0 * 0.001 * A_3), 1f);
		this.c.Y = d05.b(0.5f, (float)((double)this.c.Y + (double)A_1 * 0.001 * A_3), 1f);
		this.c.Z = d05.b(0.5f, (float)((double)this.c.Z + (double)A_2 * 0.001 * A_3), 1f);
		return value == this.c;
	}

	// Token: 0x0600322D RID: 12845 RVA: 0x00135044 File Offset: 0x00133244
	public am8() : base(null)
	{
	}

	// Token: 0x04001AE3 RID: 6883
	private const double a = 0.001;

	// Token: 0x04001AE4 RID: 6884
	public int b = 2;

	// Token: 0x04001AE5 RID: 6885
	private Vector3 c;

	// Token: 0x04001AE6 RID: 6886
	private new string d;

	// Token: 0x04001AE7 RID: 6887
	private new int e;
}
