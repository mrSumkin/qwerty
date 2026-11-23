using System;
using System.Diagnostics;

// Token: 0x020020B8 RID: 8376
[bmq("1.2.0.0_FirearmRefurbishmentSchematics", "1.2.0.0", "up-lw, cc_utility1", true)]
public sealed class aam : fg
{
	// Token: 0x0600C7DC RID: 51164 RVA: 0x00466998 File Offset: 0x00464B98
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			if (dk2.b("xphw"))
			{
				string a_ = "Xphw_SchematicPlaced";
				if (A_1.y8() == "up-lw")
				{
					c5x c5x = new ar7(new Guid("5bb105ae-5ea9-405b-bea2-c86bd761f659"), A_1.n("up-lw")).ao() as c5x;
					if (c5x != null && !c5x.a(a_))
					{
						c7j c7j = c5x.GetAspect<bim>() as c7j;
						if (c7j != null)
						{
							if (c7j.ItemContainer.z2().a("schematics.grenadeLaunchers", 1) == null)
							{
								c7j.ItemContainer.z3(this.a("SchematicsGrenadeLaunchers"), true);
							}
							c5x.b(a_);
						}
					}
				}
				else if (A_1.y8() == "cc_utility1")
				{
					c5x c5x2 = new ar7(new Guid("d203e14a-47b5-4499-aea7-441420254b5d"), A_1.n("cc_utility1")).ao() as c5x;
					if (c5x2 != null && !c5x2.a(a_))
					{
						c7j c7j2 = c5x2.GetAspect<bim>() as c7j;
						if (c7j2 != null)
						{
							if (c7j2.ItemContainer.z2().a("schematics.grenadeLaunchers", 1) == null)
							{
								c7j2.ItemContainer.z3(this.a("SchematicsGrenadeLaunchers"), true);
							}
							c5x2.b(a_);
						}
					}
				}
				return true;
			}
			return false;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x0600C7DD RID: 51165 RVA: 0x00466B30 File Offset: 0x00464D30
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
