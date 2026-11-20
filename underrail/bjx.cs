using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BDD RID: 7133
[dgg("extractToxin")]
public sealed class bjx : cwp
{
	// Token: 0x06009B48 RID: 39752 RVA: 0x003CA388 File Offset: 0x003C8588
	public override string bt()
	{
		return "莬Извлечь жидкость";
	}

	// Token: 0x06009B49 RID: 39753 RVA: 0x003CA390 File Offset: 0x003C8590
	public override string bu()
	{
		return "extractToxin";
	}

	// Token: 0x06009B4A RID: 39754 RVA: 0x003CA398 File Offset: 0x003C8598
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009B4B RID: 39755 RVA: 0x003CA39C File Offset: 0x003C859C
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009B4C RID: 39756 RVA: 0x003CA3A0 File Offset: 0x003C85A0
	public bjx()
	{
		base.Slots.Add(bjx.a, new cgo(new c6s(new ms[]
		{
			ms.ap,
			ms.be
		}, 32), "Орган или животное", false, 1, 0.1f, false, false, null));
		base.Slots.Add(bjx.b, new cgo(new c6s(new ms[]
		{
			ms.f,
			ms.bf
		}, 5), "Ампула или лабораторный стакан", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009B4D RID: 39757 RVA: 0x003CA428 File Offset: 0x003C8628
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		fv fv = A_1.SafeGet(bjx.a, null);
		fv fv2 = A_1.SafeGet(bjx.b, null);
		if (fv != null && fv2 != null && fv.TypedDefinition != null && fv2.TypedDefinition != null)
		{
			string classPropertyValue = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Product");
			if (!string.IsNullOrEmpty(classPropertyValue))
			{
				string path = "components\\chemicals\\" + classPropertyValue;
				if (ez2.GetItemDefinition<a1k>(path, true) != null)
				{
					string str = fv.TypedDefinition.a7().GetClassPropertyValue<string>("Container") ?? "ampule";
					if (string.Equals(str, fv2.TypedDefinition.a5(), StringComparison.OrdinalIgnoreCase))
					{
						return new fv(ez2.CreateDefinitonProvider<a1k>(path));
					}
					a1k itemDefinition = ez2.GetItemDefinition<a1k>("components\\medical\\" + str, true);
					if (itemDefinition != null)
					{
						A_2 = string.Format("Неподходящий контейнер. Требуется {0}.", itemDefinition.az());
					}
					else
					{
						A_2 = "Неподходящий контейнер.";
					}
				}
				else
				{
					A_2 = "Нельзя ничего извлечь из этого.";
				}
			}
			else
			{
				A_2 = "Нельзя ничего извлечь из этого.";
			}
		}
		return null;
	}

	// Token: 0x04003B61 RID: 15201
	public new static readonly string a = "gland";

	// Token: 0x04003B62 RID: 15202
	public new static readonly string b = "ampule";
}
