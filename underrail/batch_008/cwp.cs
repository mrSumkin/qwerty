using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B61 RID: 7009
public abstract class cwp
{
	// Token: 0x17000287 RID: 647
	// (get) Token: 0x060097C8 RID: 38856
	public abstract string Name { get; }

	// Token: 0x17000288 RID: 648
	// (get) Token: 0x060097C9 RID: 38857 RVA: 0x003B2478 File Offset: 0x003B0678
	public string LocalizedName
	{
		get
		{
			return qv.b("ItemBlueprints/" + this.TechnicalName + "_Name") ?? this.Name;
		}
	}

	// Token: 0x17000289 RID: 649
	// (get) Token: 0x060097CA RID: 38858
	public abstract string TechnicalName { get; }

	// Token: 0x1700028A RID: 650
	// (get) Token: 0x060097CB RID: 38859 RVA: 0x003B24A4 File Offset: 0x003B06A4
	public virtual int MaxStack
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700028B RID: 651
	// (get) Token: 0x060097CC RID: 38860 RVA: 0x003B24A8 File Offset: 0x003B06A8
	public virtual int BatchSize
	{
		get
		{
			return 1;
		}
	}

	// Token: 0x1700028C RID: 652
	// (get) Token: 0x060097CD RID: 38861 RVA: 0x003B24AC File Offset: 0x003B06AC
	public Dictionary<string, cgo> Slots
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x1700028D RID: 653
	// (get) Token: 0x060097CE RID: 38862
	public abstract cr1 Quality { get; }

	// Token: 0x1700028E RID: 654
	// (get) Token: 0x060097CF RID: 38863 RVA: 0x003B24B4 File Offset: 0x003B06B4
	public virtual bool CanDisassemble
	{
		get
		{
			return false;
		}
	}

	// Token: 0x1700028F RID: 655
	// (get) Token: 0x060097D0 RID: 38864
	public abstract BlueprintCategory Category { get; }

	// Token: 0x060097D1 RID: 38865 RVA: 0x003B24B8 File Offset: 0x003B06B8
	public bool d()
	{
		return this.a != null && this.a.Count != 0;
	}

	// Token: 0x060097D2 RID: 38866 RVA: 0x003B24DC File Offset: 0x003B06DC
	public cfe a(efk A_0, Dictionary<string, coh> A_1)
	{
		if (A_1 == null)
		{
			return null;
		}
		cfe cfe = new cfe();
		cfe.b = this.a(A_1);
		string e;
		List<coh> list = this.a(A_0, A_1, out cfe.d, out cfe.c, out e);
		if (list != null && list.Count > 0)
		{
			cfe.a.AddRange(list);
		}
		cfe.e = e;
		if (cfe.a() != null && cfe.a().Definition != null)
		{
			cfe.a().Durability = (double)cfe.a().MaxDurability;
		}
		return cfe;
	}

	// Token: 0x060097D3 RID: 38867 RVA: 0x003B2574 File Offset: 0x003B0774
	public virtual string xi()
	{
		return qv.b("ItemBlueprints/" + this.TechnicalName);
	}

	// Token: 0x060097D4 RID: 38868 RVA: 0x003B2590 File Offset: 0x003B0790
	protected virtual List<coh> gj(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		List<coh> list = new List<coh>();
		coh coh = this.by(A_0, A_1, out A_2);
		if (coh != null)
		{
			list.Add(coh);
		}
		return list;
	}

	// Token: 0x060097D5 RID: 38869 RVA: 0x003B25BC File Offset: 0x003B07BC
	protected virtual coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		return null;
	}

	// Token: 0x060097D6 RID: 38870 RVA: 0x003B25C4 File Offset: 0x003B07C4
	protected static double a(fv A_0)
	{
		return cwp.a(A_0.QualityLevel);
	}

	// Token: 0x060097D7 RID: 38871 RVA: 0x003B25D4 File Offset: 0x003B07D4
	protected static double a(int A_0)
	{
		return Math.Max(1.0, (double)A_0 - 10.0) / 5.0;
	}

	// Token: 0x060097D8 RID: 38872 RVA: 0x003B25FC File Offset: 0x003B07FC
	protected virtual Dictionary<string, int> dr(string A_0, cgo A_1, coh A_2)
	{
		return this.gk(A_2);
	}

	// Token: 0x060097D9 RID: 38873 RVA: 0x003B2608 File Offset: 0x003B0808
	protected virtual Dictionary<string, int> gk(coh A_0)
	{
		fv fv = A_0 as fv;
		if (fv != null)
		{
			return fv.a();
		}
		return new Dictionary<string, int>();
	}

	// Token: 0x060097DA RID: 38874 RVA: 0x003B2630 File Offset: 0x003B0830
	protected static void a(bk3 A_0, List<string> A_1)
	{
		if (A_1.Count > 0)
		{
			A_1.Sort();
			string text = ".";
			foreach (string str in A_1)
			{
				text += str;
			}
			A_0.f(A_0.a3() + text);
		}
	}

	// Token: 0x060097DB RID: 38875 RVA: 0x003B26B0 File Offset: 0x003B08B0
	protected bool b(Dictionary<string, coh> A_0)
	{
		foreach (KeyValuePair<string, coh> keyValuePair in A_0)
		{
			if (keyValuePair.Value == null || keyValuePair.Value.Definition == null)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060097DC RID: 38876 RVA: 0x003B2724 File Offset: 0x003B0924
	protected static Dictionary<string, int> a(SkillEnum A_0, int A_1)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>(1);
		dictionary[A_0.ToString().a()] = A_1;
		return dictionary;
	}

	// Token: 0x060097DD RID: 38877 RVA: 0x003B2748 File Offset: 0x003B0948
	protected static Dictionary<string, int> a(SkillEnum A_0, int A_1, coh A_2)
	{
		int val = 0;
		fv fv = A_2 as fv;
		if (fv != null)
		{
			Dictionary<string, int> dictionary = fv.a();
			if (dictionary != null)
			{
				dictionary.TryGetValue(A_0.ToString(), out val);
			}
		}
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>(1);
		dictionary2[A_0.ToString().a()] = Math.Min(val, A_1);
		return dictionary2;
	}

	// Token: 0x060097DE RID: 38878 RVA: 0x003B27AC File Offset: 0x003B09AC
	protected static void a(bk3 A_0, params coh[] A_1)
	{
		if (A_0 == null || A_1 == null || A_1.Length == 0)
		{
			return;
		}
		foreach (coh coh in A_1)
		{
			if (coh != null)
			{
				A_0.a((cr1)Math.Max((int)A_0.bc(), (int)coh.Definition.bc()));
			}
		}
	}

	// Token: 0x060097DF RID: 38879 RVA: 0x003B2808 File Offset: 0x003B0A08
	private Dictionary<string, int> a(Dictionary<string, coh> A_0)
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
		foreach (KeyValuePair<string, coh> keyValuePair in A_0)
		{
			cgo cgo;
			this.a.TryGetValue(keyValuePair.Key, out cgo);
			if (cgo != null && keyValuePair.Value != null && keyValuePair.Value.Definition != null && keyValuePair.Value != null)
			{
				foreach (KeyValuePair<string, int> keyValuePair2 in this.dr(keyValuePair.Key, cgo, keyValuePair.Value))
				{
					if (!dictionary.ContainsKey(keyValuePair2.Key))
					{
						dictionary.Add(keyValuePair2.Key, keyValuePair2.Value);
					}
					else
					{
						dictionary[keyValuePair2.Key] = Math.Max(dictionary[keyValuePair2.Key], keyValuePair2.Value);
					}
					if ((cgo.b || cgo.g) && cgo.e > 0f)
					{
						int num;
						dictionary2.TryGetValue(keyValuePair2.Key, out num);
						num += Convert.ToInt32(cgo.e * (float)keyValuePair2.Value);
						dictionary2[keyValuePair2.Key] = num;
					}
				}
			}
		}
		foreach (KeyValuePair<string, int> keyValuePair3 in dictionary2)
		{
			Dictionary<string, int> dictionary3 = dictionary;
			string key = keyValuePair3.Key;
			dictionary3[key] += keyValuePair3.Value;
		}
		return dictionary;
	}

	// Token: 0x060097E0 RID: 38880 RVA: 0x003B2A3C File Offset: 0x003B0C3C
	private List<coh> a(efk A_0, Dictionary<string, coh> A_1, out bool A_2, out Dictionary<string, coh> A_3, out string A_4)
	{
		A_4 = null;
		int num = this.MaxStack;
		foreach (KeyValuePair<string, cgo> keyValuePair in this.Slots)
		{
			coh coh;
			A_1.TryGetValue(keyValuePair.Key, out coh);
			if (coh != null)
			{
				num = Math.Min(num, coh.Stacks / keyValuePair.Value.d);
			}
			else if (!keyValuePair.Value.b)
			{
				num = 0;
				break;
			}
		}
		if (num > 0)
		{
			List<coh> list = this.gj(A_0, A_1, out A_4);
			if (list != null)
			{
				A_2 = (A_4 == null);
				foreach (coh coh2 in list)
				{
					coh2.Stacks *= num * this.BatchSize;
				}
				A_3 = new Dictionary<string, coh>();
				List<coh> list2 = new List<coh>();
				foreach (KeyValuePair<string, cgo> keyValuePair2 in this.Slots)
				{
					coh coh3;
					A_1.TryGetValue(keyValuePair2.Key, out coh3);
					if (coh3 != null)
					{
						if (!keyValuePair2.Value.f)
						{
							coh coh4 = coh3.fy();
							coh4.Stacks = num * keyValuePair2.Value.d;
							list2.Add(coh4);
						}
						int num2 = coh3.Stacks - num * keyValuePair2.Value.d;
						if (num2 > 0)
						{
							coh coh5 = coh3.fy();
							coh5.Stacks = num2;
							A_3[keyValuePair2.Key] = coh5;
						}
					}
				}
				if (this.CanDisassemble && list.Count == 1)
				{
					list[0].Definition.a7()["Components"] = list2;
				}
				return list;
			}
		}
		A_2 = false;
		A_3 = null;
		return null;
	}

	// Token: 0x04003A4D RID: 14925
	private Dictionary<string, cgo> a = new Dictionary<string, cgo>();
}
