using System;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Space;

// Token: 0x0200045F RID: 1119
public sealed class cnp : ak7
{
	// Token: 0x06001D25 RID: 7461 RVA: 0x000A19A4 File Offset: 0x0009FBA4
	public cnp(string A_0) : base(A_0)
	{
		this.d = 500;
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x000A19BC File Offset: 0x0009FBBC
	protected override ak1 afe(TimeSpan A_0, double A_1)
	{
		bt4 bt = null;
		if (this.a == null)
		{
			if (!string.IsNullOrEmpty(this.b))
			{
				bt = this.Subject.y6().GetClassPropertyValue<bt4>(this.b);
			}
		}
		else
		{
			bt = this.a;
		}
		if (bt != null)
		{
			aud aud;
			Vector3 a_;
			HorizontalDirection horizontalDirection;
			bt.a(this.Subject.a8().Zone, out aud, out a_, out horizontalDirection);
			if (aud != null)
			{
				return aud.a(a_.a());
			}
		}
		return null;
	}

	// Token: 0x04001021 RID: 4129
	public bt4 a;

	// Token: 0x04001022 RID: 4130
	public new string b;
}
