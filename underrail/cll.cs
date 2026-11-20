using System;
using Microsoft.Xna.Framework;

// Token: 0x02000C27 RID: 3111
public sealed class cll : jn
{
	// Token: 0x06004666 RID: 18022 RVA: 0x001D0650 File Offset: 0x001CE850
	public cll() : base("fo_cart", "object\\vehicles\\Fo_HarvestingCart")
	{
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x001D0664 File Offset: 0x001CE864
	public override string b1(cyt A_0)
	{
		string text = A_0.r().GetClassPropertyValue<string>("loc_fo_cartLoc");
		if (string.IsNullOrEmpty(text))
		{
			text = (A_0.r()["loc_fo_cartLoc"] = "crys1");
		}
		return text;
	}

	// Token: 0x06004668 RID: 18024 RVA: 0x001D06A8 File Offset: 0x001CE8A8
	public override void cf(b0b A_0, cyt A_1, string A_2)
	{
		cd0 aspect = A_0.GetAspect<cd0>();
		if (aspect != null)
		{
			string a = A_2.ToLowerInvariant();
			if (a == "crys1")
			{
				aspect.b = new Point(0, 3);
				return;
			}
			if (a == "crys2")
			{
				aspect.b = new Point(0, 3);
				return;
			}
			if (a == "crys3")
			{
				aspect.b = new Point(0, 1);
				return;
			}
			if (a == "crys4")
			{
				aspect.b = new Point(0, 1);
				return;
			}
			if (a == "fo5")
			{
				aspect.b = new Point(0, 1);
				return;
			}
			aspect.b = new Point(0, 3);
		}
	}
}
