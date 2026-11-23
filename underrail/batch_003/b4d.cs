using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.References;

// Token: 0x02000356 RID: 854
public class b4d : t7
{
	// Token: 0x06001824 RID: 6180 RVA: 0x0007A1C8 File Offset: 0x000783C8
	protected override cst ip()
	{
		amc amc = new bzv(base.b().c().y6()).g();
		if (amc != null)
		{
			coh coh = base.b().g().aa().Gear.d()[this.a].Item;
			if (coh != null)
			{
				dxw dxw = coh.Definition as dxw;
				if (dxw != null)
				{
					aia aia = Enumerable.FirstOrDefault<aia>(dxw.a2());
					if (aia != null && aia.Value != null && aia.Value != null)
					{
						eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(base.b().g())), coh) as eu7;
						if (eu != null && eu.yw())
						{
							Vector3 vector = amc.a8().aj();
							ak1 ak = amc.a8().Area.b((int)vector.X, (int)vector.Y);
							if (ak == null)
							{
								ak = Enumerable.FirstOrDefault<ak1>(amc.a8().l);
							}
							return cp.b(eu, base.b().g().a8(), ak);
						}
					}
				}
			}
		}
		return null;
	}

	// Token: 0x06001825 RID: 6181 RVA: 0x0007A300 File Offset: 0x00078500
	public new bool a(e1k A_0)
	{
		coh coh = A_0.g().aa().Gear.d()[this.a].Item;
		if (coh != null)
		{
			dxw dxw = coh.Definition as dxw;
			if (dxw != null)
			{
				aia aia = Enumerable.FirstOrDefault<aia>(dxw.a2());
				if (aia != null && aia.Value != null && aia.Value != null)
				{
					eu7 eu = ecf.a(aia.Value, new eru(new EntityAspectReference<amc, amc>(A_0.g())), coh) as eu7;
					return eu != null && eu.yw();
				}
			}
		}
		return false;
	}

	// Token: 0x04000E24 RID: 3620
	public new int a;

	// Token: 0x04000E25 RID: 3621
	public new string b;
}
