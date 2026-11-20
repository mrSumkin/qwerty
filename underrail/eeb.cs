using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020020CB RID: 8395
[bmq("1.1.5.0_Jye2_ImportLayer", "1.1.5.0", "jye2", true)]
public sealed class eeb : t0
{
	// Token: 0x0600C7FF RID: 51199 RVA: 0x00467ED0 File Offset: 0x004660D0
	public eeb() : base("jye2", 2)
	{
	}

	// Token: 0x0600C800 RID: 51200 RVA: 0x00467EE0 File Offset: 0x004660E0
	public override bool b5(cyt A_0, c1a A_1)
	{
		base.b5(A_0, A_1);
		try
		{
			c5x c5x = new ar7(new Guid("c6478982-a053-4a3f-b237-7b922feb9400"), A_1.n("jye2")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("1261667c-421f-41e3-b7f6-73d056da5ede"), A_1.n("jye2")).ao() as c5x;
			if (c5x != null)
			{
				c5x.Location = new Vector3(11.22f, 14f, 0.35f);
				c5x.ah();
			}
			if (c5x2 != null)
			{
				c5x2.Location = new Vector3(11f, 13.21f, 0.15f);
				c5x2.ah();
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}
