using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Common;

// Token: 0x0200100D RID: 4109
public class b3g : ebk
{
	// Token: 0x060054C6 RID: 21702 RVA: 0x002577B4 File Offset: 0x002559B4
	public string x8()
	{
		return "DropItem";
	}

	// Token: 0x060054C7 RID: 21703 RVA: 0x002577BC File Offset: 0x002559BC
	public bool ye(ebk A_0, coh A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return (A_0.x8() == ItemExchangeParty.PlayerInventory.ToString() || A_0.x8() == ItemExchangeParty.PlayerGear.ToString() || A_0.x8() == ItemExchangeParty.OfferedItems.ToString() || A_0.x8() == ItemExchangeParty.CraftingComponent.ToString() || A_0.x8() == ItemExchangeParty.ActiveVehicleTrunk.ToString()) && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().j == cgy.b;
	}

	// Token: 0x060054C8 RID: 21704 RVA: 0x002578B4 File Offset: 0x00255AB4
	public bool yg(ebk A_0)
	{
		return false;
	}

	// Token: 0x060054C9 RID: 21705 RVA: 0x002578B8 File Offset: 0x00255AB8
	public coh yd()
	{
		return null;
	}

	// Token: 0x060054CA RID: 21706 RVA: 0x002578C0 File Offset: 0x00255AC0
	public coh yb(coh A_0, bool A_1 = false)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (A_0 != null && serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null && serviceOrThrow.aqu().v().b().j == cgy.b)
		{
			Vector3 vector = serviceOrThrow.aqu().v().b().aj();
			ak1 a_ = serviceOrThrow.aqu().v().b().Area.b((int)vector.X, (int)vector.Y);
			bool flag = false;
			string a_2;
			if (aw1.d(a_))
			{
				a_2 = "FlotsomLootCrateBase";
				flag = true;
			}
			else
			{
				a_2 = "DroppedItem";
			}
			c5x c5x = et5.a(serviceOrThrow.aqu().v().b(), a_2, new List<coh>
			{
				A_0
			}, false, false, false, null);
			a7v.a(new aub(A_0));
			if (flag && c5x != null && c5x.p.b != null && c5x.p.b.a.Count < 2)
			{
				etz etz = c5x.p.b.a[0] as etz;
				if (etz != null)
				{
					if (etz.f() == null)
					{
						etz.c(new int?(cuo.a.Next()));
					}
					foreach (KeyValuePair<string, float> keyValuePair in boj.a(a_, false))
					{
						etz etz2 = new etz(c5x);
						etz2.a = "Objects\\Containers\\FlotsamWave" + keyValuePair.Key;
						etz2.a(true);
						etz2.b(1);
						etz2.d(200);
						etz2.c(8);
						etz2.d = new float?(keyValuePair.Value);
						etz2.b = etz.b;
						etz2.c(etz.f());
						c5x.p.b.a(etz2);
					}
				}
			}
		}
		return null;
	}

	// Token: 0x060054CB RID: 21707 RVA: 0x00257B18 File Offset: 0x00255D18
	public void yc(coh A_0, int A_1, int A_2)
	{
	}

	// Token: 0x060054CC RID: 21708 RVA: 0x00257B1C File Offset: 0x00255D1C
	public coh yx()
	{
		return null;
	}

	// Token: 0x060054CD RID: 21709 RVA: 0x00257B20 File Offset: 0x00255D20
	public bool yy()
	{
		return false;
	}
}
