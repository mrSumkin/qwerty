using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006E3 RID: 1763
[eiz("G12")]
[Serializable]
public sealed class byo : y8, ISerializable
{
	// Token: 0x06002D6E RID: 11630 RVA: 0x00102FDC File Offset: 0x001011DC
	private byo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G12:M");
	}

	// Token: 0x06002D6F RID: 11631 RVA: 0x00102FF8 File Offset: 0x001011F8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G12:M", this.a);
	}

	// Token: 0x06002D70 RID: 11632 RVA: 0x00103014 File Offset: 0x00101214
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D71 RID: 11633 RVA: 0x0010301C File Offset: 0x0010121C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D72 RID: 11634 RVA: 0x00103028 File Offset: 0x00101228
	public byo()
	{
	}

	// Token: 0x06002D73 RID: 11635 RVA: 0x00103030 File Offset: 0x00101230
	public override aw4 a1()
	{
		byo byo = new byo();
		this.rg(byo);
		return byo;
	}

	// Token: 0x06002D74 RID: 11636 RVA: 0x0010304C File Offset: 0x0010124C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		((byo)A_0).a = this.a;
	}

	// Token: 0x06002D75 RID: 11637 RVA: 0x0010306C File Offset: 0x0010126C
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		b8h b8h = d79.Get<b8h>();
		if (b8h != null)
		{
			int a_ = y8.a(base.i());
			fv fv = y8.a("armors\\PsionicHeadbandFrame", null);
			fv fv2 = this.b(a_);
			if (fv != null && fv2 != null)
			{
				fv2.QualityLevel = a_;
				fv[] array = new fv[2];
				int num = 0;
				while (num < 1 && cuo.a.NextDouble() < 0.1)
				{
					int a_2 = y8.a(a_, 10);
					array[num] = this.a(a_2);
					if (array[num] != null)
					{
						array[num].QualityLevel = a_2;
					}
					num++;
				}
				if (array[0] != null && array[1] != null && array[0].TypedDefinition.i() == array[1].TypedDefinition.i())
				{
					array[1] = null;
				}
				k7 k = b8h.a(null, new Dictionary<string, coh>
				{
					{
						b8h.e,
						fv2
					},
					{
						b8h.d,
						fv
					},
					{
						b8h.f,
						array[0]
					},
					{
						b8h.g,
						array[1]
					}
				}).a() as k7;
				if (k != null)
				{
					list.Add(k);
				}
			}
		}
		return list;
	}

	// Token: 0x06002D76 RID: 11638 RVA: 0x001031F4 File Offset: 0x001013F4
	private fv b(int A_0)
	{
		string text;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("psionicModulator_metathermic", 30, int.MaxValue, 1);
			itemPoolForQuality.a("psionicModulator_psychokinetic", 30, int.MaxValue, 1);
			itemPoolForQuality.a("psionicModulator_thoughtControl", 30, int.MaxValue, 1);
			itemPoolForQuality.a("psionicModulator_universal", 30, int.MaxValue, 1);
			if (dk2.f())
			{
				itemPoolForQuality.a("xpbl\\psionicModulator_temporalManipulation", 30, int.MaxValue, 1);
			}
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Armors\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002D77 RID: 11639 RVA: 0x001032B8 File Offset: 0x001014B8
	private fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("proximalNeuroscopicFilter", 45, int.MaxValue, 1);
		itemPoolForQuality.a("stableNeuralAmplifier", 50, int.MaxValue, 1);
		itemPoolForQuality.a("psionicMufflers", 55, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Armors\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019B4 RID: 6580
	private new string a;
}
