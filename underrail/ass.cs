using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006FF RID: 1791
[eiz("SHG")]
[Serializable]
public sealed class ass : d1k, ISerializable
{
	// Token: 0x06002E75 RID: 11893 RVA: 0x001075A8 File Offset: 0x001057A8
	private ass(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 671)
		{
			this.a = A_0.GetString("SHG:M");
		}
	}

	// Token: 0x06002E76 RID: 11894 RVA: 0x001075D4 File Offset: 0x001057D4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SHG:M", this.a);
	}

	// Token: 0x06002E77 RID: 11895 RVA: 0x001075F0 File Offset: 0x001057F0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002E78 RID: 11896 RVA: 0x001075F8 File Offset: 0x001057F8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E79 RID: 11897 RVA: 0x00107604 File Offset: 0x00105804
	public ass()
	{
	}

	// Token: 0x06002E7A RID: 11898 RVA: 0x00107610 File Offset: 0x00105810
	public override aw4 a1()
	{
		ass ass = new ass();
		this.rg(ass);
		return ass;
	}

	// Token: 0x06002E7B RID: 11899 RVA: 0x0010762C File Offset: 0x0010582C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		ass ass = A_0 as ass;
		if (ass != null)
		{
			ass.a = this.a;
		}
	}

	// Token: 0x06002E7C RID: 11900 RVA: 0x0010765C File Offset: 0x0010585C
	protected override cd1 rf(int A_0)
	{
		bib bib = d79.Get<bib>();
		if (bib != null)
		{
			int a_ = y8.a(A_0);
			fv fv = zp.d(a_, null);
			fv fv2 = y8.a("Weapons\\SledgehammerHandle", null);
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv fv3 = this.a(A_0);
				fv fv4 = null;
				if (fv3 != null)
				{
					fv3.QualityLevel = y8.a(A_0);
					int a_2 = y8.a(A_0);
					fv4 = zp.b(a_2);
					fv4.QualityLevel = a_2;
				}
				return bib.a(null, new Dictionary<string, coh>
				{
					{
						bib.a,
						fv
					},
					{
						bib.b,
						fv2
					},
					{
						bib.c,
						fv3
					},
					{
						bib.d,
						fv4
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E7D RID: 11901 RVA: 0x00107754 File Offset: 0x00105954
	private fv a(int A_0)
	{
		string text = null;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else if (A_0 >= 3 && zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("ElectroshockGenerator", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text == null)
		{
			return null;
		}
		if (text.EndsWith("Spikes"))
		{
			return y8.a("MetalArmorEnhancements\\" + text, null);
		}
		return y8.a("Weapons\\" + text, null);
	}

	// Token: 0x040019E6 RID: 6630
	private new string a;
}
