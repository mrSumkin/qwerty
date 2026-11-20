using System;
using System.Diagnostics;
using Microsoft.Xna.Framework;

// Token: 0x020021A8 RID: 8616
[bmq("1.0.1.14_GMSVents", "1.0.1.14", "GammaCompound3", false)]
public sealed class clk : fg
{
	// Token: 0x0600C9A4 RID: 51620 RVA: 0x0047539C File Offset: 0x0047359C
	public bool b5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = new ar7(new Guid("dc08d59c-07e2-49b3-bdd5-3d83c070b460"), A_1.n("GammaCompound3-Ventilation")).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("0e568aa5-986c-460d-a112-0c3e4d3bc09a"), A_1.n("GammaCompound3-Ventilation")).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("6e638cb4-03a6-4b1a-bd76-dad9d54e7053"), A_1.n("GammaCompound3-Ventilation")).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("3b3c28ed-bc8b-4055-81d6-52d3c0d68cb0"), A_1.n("GammaCompound3-Ventilation")).ao() as c5x;
			if (c5x != null && c5x.y8() != "Ventilation Shaft")
			{
				c5x.q("Ventilation Shaft");
				ddp ddp = c5x.GetAspect<bim>() as ddp;
				if (ddp != null)
				{
					ddp.b(20);
					ddp.a(8);
				}
			}
			if (c5x2 != null && c5x2.y8() != "Jammed Ventilation Shaft")
			{
				c5x2.q("Jammed Ventilation Shaft");
				ddp ddp2 = c5x2.GetAspect<bim>() as ddp;
				if (ddp2 != null)
				{
					ddp2.b(999);
					ddp2.a(999);
				}
			}
			if (c5x3 != null)
			{
				c5x3.Location = new Vector3(9.15f, 4.7f, 0.1f);
				c5x3.ah();
			}
			if (c5x4 != null)
			{
				c5x4.Location = new Vector3(8.7f, 6.15f, 0.1f);
				c5x4.ah();
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
