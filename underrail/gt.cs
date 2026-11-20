using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001BB4 RID: 7092
[dgg("disassembleItem")]
public sealed class gt : cwp
{
	// Token: 0x06009A1F RID: 39455 RVA: 0x003C058C File Offset: 0x003BE78C
	public override string bt()
	{
		return "茂Разобрать предмет";
	}

	// Token: 0x06009A20 RID: 39456 RVA: 0x003C0594 File Offset: 0x003BE794
	public override string bu()
	{
		return "disassembleItem";
	}

	// Token: 0x06009A21 RID: 39457 RVA: 0x003C059C File Offset: 0x003BE79C
	public override cr1 bv()
	{
		return cr1.b;
	}

	// Token: 0x06009A22 RID: 39458 RVA: 0x003C05A0 File Offset: 0x003BE7A0
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Processing;
	}

	// Token: 0x06009A23 RID: 39459 RVA: 0x003C05A4 File Offset: 0x003BE7A4
	public gt()
	{
		base.Slots.Add("primaryTarget", new cgo(new cq9(58), "Предмет, который возможно разобрать", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009A24 RID: 39460 RVA: 0x003C05E4 File Offset: 0x003BE7E4
	protected override List<coh> gj(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		coh coh = A_1.SafeGet("primaryTarget", null);
		if (coh != null && coh.Definition != null)
		{
			List<coh> classPropertyValue = coh.Definition.a7().GetClassPropertyValue<List<coh>>("Components");
			if (classPropertyValue != null && classPropertyValue.Count > 0)
			{
				List<coh> list = new List<coh>();
				foreach (coh coh2 in classPropertyValue)
				{
					coh coh3 = coh2.fy();
					fv fv = coh3 as fv;
					if (fv != null)
					{
						if (fv.QualityLevel > 1)
						{
							double num = 0.0;
							if (A_0 != null)
							{
								num = (double)A_0.GetSpecializationValue<ddf>(true) * ddf.a;
							}
							fv.QualityLevel = (int)((double)fv.QualityLevel * (e88.a + num));
						}
						list.Add(fv);
					}
					else
					{
						list.Add(coh3);
					}
				}
				return list;
			}
			A_2 = "Этот предмет нельзя разобрать";
		}
		return null;
	}

	// Token: 0x06009A25 RID: 39461 RVA: 0x003C0700 File Offset: 0x003BE900
	protected override Dictionary<string, int> gk(coh A_0)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		if (A_0 != null && A_0.Definition != null)
		{
			foreach (coh a_ in A_0.Definition.a7().GetClassPropertyValue<List<coh>>("Components"))
			{
				foreach (KeyValuePair<string, int> keyValuePair in base.gk(a_))
				{
					int val;
					dictionary.TryGetValue(keyValuePair.Key, out val);
					dictionary[keyValuePair.Key] = Math.Max(val, keyValuePair.Value);
				}
			}
		}
		return dictionary;
	}

	// Token: 0x04003ADE RID: 15070
	private new const string a = "primaryTarget";
}
