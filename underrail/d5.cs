using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x0200210A RID: 8458
[bmq("1.1.3.0_Xpbl_Cc_Dock_RaySecurityTweaks", "1.1.3.0", "xpbl_cc-dock2", false)]
public sealed class d5 : fg
{
	// Token: 0x0600C861 RID: 51297 RVA: 0x0046A554 File Offset: 0x00468754
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("492aad51-258c-4fc0-a715-d914bbae85b1"), A_1.n("xpbl_cc-dock2")).ao() as c5x;
			if (c5x != null && this.a(c5x) && c5x.Location.Y != 28f)
			{
				c5x.Location = new Vector3(45f, 28f, 0f);
			}
			c5x c5x2 = new ar7(new Guid("db41787b-1871-46d4-9775-661cfec065dd"), A_1.n("xpbl_cc-dock2")).ao() as c5x;
			if (c5x2 != null && this.a(c5x2) && c5x2.Location.Y != 31f)
			{
				c5x2.Location = new Vector3(45f, 31f, 0f);
			}
			c5x c5x3 = new ar7(new Guid("817d1a52-ec5d-4cf3-bebe-e78cd6d48884"), A_1.n("xpbl_cc-dock2")).ao() as c5x;
			if (c5x3 != null && this.a(c5x3) && c5x3.Location.Y != 34f)
			{
				c5x3.Location = new Vector3(45f, 34f, 0f);
			}
			foreach (b0b b0b in A_1.n("xpbl_cc-dock2").Entities)
			{
				c5x c5x4 = (c5x)b0b;
				if (c5x4.y8() == "Security Camera" && c5x4.p.b != null && c5x4.p.b.a[0].a.EndsWith("Camera2"))
				{
					amc aspect = c5x4.GetAspect<amc>();
					if (aspect != null && aspect.aa().BaseSightRange != 10f)
					{
						aspect.aa().BaseSightRange = 10f;
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x0600C862 RID: 51298 RVA: 0x0046A7B4 File Offset: 0x004689B4
	private bool a(c5x A_0)
	{
		wv wv = A_0.GetAspect<bim>() as wv;
		return wv != null && wv.g().l().Contains("coreCity");
	}
}
