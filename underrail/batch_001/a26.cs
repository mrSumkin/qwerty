using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001BCC RID: 7116
[dgg("recycleItem")]
public sealed class a26 : cwp
{
	// Token: 0x06009ACC RID: 39628 RVA: 0x003C582C File Offset: 0x003C3A2C
	public override string bt()
	{
		return "范Утилизировать предмет";
	}

	// Token: 0x06009ACD RID: 39629 RVA: 0x003C5834 File Offset: 0x003C3A34
	public override string bu()
	{
		return "recycleItem";
	}

	// Token: 0x06009ACE RID: 39630 RVA: 0x003C583C File Offset: 0x003C3A3C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009ACF RID: 39631 RVA: 0x003C5840 File Offset: 0x003C3A40
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009AD0 RID: 39632 RVA: 0x003C5844 File Offset: 0x003C3A44
	public a26()
	{
		base.Slots.Add("primaryTarget", new cgo(new e00(58), "Перерабатываемый предмет", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009AD1 RID: 39633 RVA: 0x003C5884 File Offset: 0x003C3A84
	protected override List<coh> gj(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		List<coh> list = new List<coh>();
		A_2 = null;
		coh coh = A_1.SafeGet("primaryTarget", null);
		if (coh != null && coh.Definition != null && !coh.Definition.a9() && coh.MaxDurability > 0)
		{
			if (coh.Durability < 10.0)
			{
				A_2 = "Этот предмет слишком изношен чтобы быть утилизированным.";
				return null;
			}
			int num = (int)(coh.Durability / 10.0);
			bool flag = false;
			if (num > 0)
			{
				num += (int)Math.Floor((double)(coh.MaxDurability / 10) * 0.05);
				string arg;
				switch (coh.Definition.ay())
				{
				default:
					arg = "MetalScraps";
					break;
				case ItemRepairCategory.Fabric:
					flag = true;
					arg = "FabricScraps";
					break;
				case ItemRepairCategory.Electronic:
					arg = "ElectronicScraps";
					break;
				}
				bit bit = ez2.CreateDefinitonProvider<a1k>(string.Format("Components\\Scraps\\{0}", arg));
				if (bit != null)
				{
					num = d05.a(1, (int)(coh.SingleItemWeight / bit.wl().a4() * 0.85), num);
					list.Add(new fv(bit)
					{
						Stacks = num
					});
					if (flag)
					{
						int a_ = Math.Max(1, num / 20);
						bit bit2 = ez2.CreateDefinitonProvider<a1k>("Components\\Scraps\\DirtyRag");
						if (bit2 != null)
						{
							list.Add(new fv(bit2)
							{
								Stacks = a_
							});
						}
					}
				}
			}
		}
		return list;
	}

	// Token: 0x06009AD2 RID: 39634 RVA: 0x003C59FC File Offset: 0x003C3BFC
	protected override Dictionary<string, int> gk(coh A_0)
	{
		string key;
		switch (A_0.Definition.ay())
		{
		default:
			key = "Mechanics";
			break;
		case ItemRepairCategory.Fabric:
			key = "Tailoring";
			break;
		case ItemRepairCategory.Electronic:
			key = "Electronics";
			break;
		}
		int value;
		if (A_0.Definition.a8() > 0)
		{
			value = (int)(5.0 + (double)A_0.Definition.a8() * 3.5);
		}
		else
		{
			value = 10;
		}
		return new Dictionary<string, int>
		{
			{
				key,
				value
			}
		};
	}

	// Token: 0x04003B24 RID: 15140
	private new const string a = "primaryTarget";

	// Token: 0x04003B25 RID: 15141
	private new const int b = 10;
}
