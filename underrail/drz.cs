using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000AFA RID: 2810
[eiz("XPBLPIRGRSJ")]
[Serializable]
public sealed class drz : cze, ISerializable
{
	// Token: 0x0600412F RID: 16687 RVA: 0x0018DE34 File Offset: 0x0018C034
	private drz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004130 RID: 16688 RVA: 0x0018DE40 File Offset: 0x0018C040
	public drz()
	{
	}

	// Token: 0x06004131 RID: 16689 RVA: 0x0018DE4C File Offset: 0x0018C04C
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		aud aud = null;
		if (A_0 != null)
		{
			aud = A_0.Area;
		}
		else if (A_1 != null)
		{
			aud = A_1.Area;
		}
		if (aud != null)
		{
			c5x c5x = new ar7(new Guid("70cbecc6-ead3-4de3-8a86-008f9b3b30d4"), aud).ao() as c5x;
			if (c5x != null && c5x.h.b != null)
			{
				cnk service = bpo.GetService<cnk>();
				string text = "weapons\\xpbl\\salvation-13";
				if (service.aqu() != null && service.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_razor_salvationRefurbished", new bool?(false)).Value)
				{
					text += "_rf";
				}
				cd1 cd = new cd1(ez2.CreateDefinitonProvider<bke>(text));
				if (cd != null)
				{
					AmmoType item = AmmoType.ShotgunShell_6;
					cd.LoadedAmmo.Clear();
					for (int i = 0; i < cd.TypedDefinition.f(); i++)
					{
						cd.LoadedAmmo.Add(item);
					}
					c5x.h.b.aa().Bag.z3(c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].Item, true);
					c5x.h.b.aa().Gear.j()[WeaponKey.Secondary].b(cd);
					cd.CustomProperties[vo.k] = true;
				}
			}
		}
	}
}
