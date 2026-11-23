using System;
using System.Diagnostics;

// Token: 0x020020C4 RID: 8388
[bmq("1.1.5.0_FirearmRefurbishmentSchematics", "1.1.5.0", "lux-lv, up_mall, wbb3, lu-b22u", false)]
public sealed class b3j : fg
{
	// Token: 0x0600C7F2 RID: 51186 RVA: 0x004674D0 File Offset: 0x004656D0
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (A_1.y8() == "up_mall")
			{
				c5x c5x = new ar7(new Guid("6167e678-d8d3-450a-96eb-f72d768ba3e5"), A_1.n("up_mall1")).ao() as c5x;
				if (c5x != null)
				{
					c7j c7j = c5x.GetAspect<bim>() as c7j;
					if (c7j != null && c7j.ItemContainer.z2().a("schematics.riflesShotguns", 1) == null)
					{
						c7j.ItemContainer.z3(this.a("SchematicsRiflesAndShotguns"), true);
					}
				}
			}
			else if (A_1.y8() == "lux-lv")
			{
				c5x c5x2 = new ar7(new Guid("656ffb1b-df65-43b7-9c2f-76c23dfb9774"), A_1.n("lux-lv")).ao() as c5x;
				if (c5x2 != null)
				{
					c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
					if (c7j2 != null && c7j2.ItemContainer.z2().a("schematics.pistolsSmgs", 1) == null)
					{
						c7j2.ItemContainer.z3(this.a("SchematicsPistolsAndSubmachineGuns"), true);
					}
				}
			}
			else if (A_1.y8() == "wbb3")
			{
				c5x c5x3 = new ar7(new Guid("7f49f75c-e3a7-499e-b002-baebe4a69a96"), A_1.n("wbb3")).ao() as c5x;
				if (c5x3 != null)
				{
					c7j c7j3 = c5x3.GetAspect<bim>() as c7j;
					if (c7j3 != null && c7j3.ItemContainer.z2().a("schematics.riflesShotguns", 1) == null)
					{
						c7j3.ItemContainer.z3(this.a("SchematicsRiflesAndShotguns"), true);
					}
				}
			}
			else if (A_1.y8() == "lu-b22u")
			{
				c5x c5x4 = new ar7(new Guid("5020983a-c770-4b18-b90b-1732246717a8"), A_1.n("lu-b22u")).ao() as c5x;
				if (c5x4 != null)
				{
					c7j c7j4 = c5x4.GetAspect<bim>() as c7j;
					if (c7j4 != null && c7j4.ItemContainer.z2().a("schematics.pistolsSmgs", 1) == null)
					{
						c7j4.ItemContainer.z3(this.a("SchematicsPistolsAndSubmachineGuns"), true);
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

	// Token: 0x0600C7F3 RID: 51187 RVA: 0x00467744 File Offset: 0x00465944
	private d48 a(string A_0)
	{
		d48 d = new d48(ez2.CreateDefinitonProvider<dj3>("Plot\\" + A_0));
		if (d != null)
		{
			return d;
		}
		return null;
	}
}
