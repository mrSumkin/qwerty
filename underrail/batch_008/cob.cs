using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006FA RID: 1786
[eiz("SG5")]
[Serializable]
public sealed class cob : d1k, ISerializable
{
	// Token: 0x06002E45 RID: 11845 RVA: 0x00106AA0 File Offset: 0x00104CA0
	private cob(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("SG5:F");
		if (ell.a() >= 408)
		{
			this.b = (A_0.GetValue("SG5:C", typeof(bool?)) as bool?);
		}
	}

	// Token: 0x06002E46 RID: 11846 RVA: 0x00106AFC File Offset: 0x00104CFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("SG5:F", this.a);
		info.AddValue("SG5:C", this.b);
	}

	// Token: 0x06002E47 RID: 11847 RVA: 0x00106B30 File Offset: 0x00104D30
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002E48 RID: 11848 RVA: 0x00106B38 File Offset: 0x00104D38
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E49 RID: 11849 RVA: 0x00106B44 File Offset: 0x00104D44
	public bool? a()
	{
		return this.b;
	}

	// Token: 0x06002E4A RID: 11850 RVA: 0x00106B4C File Offset: 0x00104D4C
	public void a(bool? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E4B RID: 11851 RVA: 0x00106B58 File Offset: 0x00104D58
	public cob()
	{
	}

	// Token: 0x06002E4C RID: 11852 RVA: 0x00106B64 File Offset: 0x00104D64
	protected override cd1 rf(int A_0)
	{
		dmq dmq = d79.Get<dmq>();
		if (dmq != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.b(a_);
			if (fv != null)
			{
				fv fv2 = this.a(a_);
				if (fv2 != null)
				{
					fv.QualityLevel = a_;
					return dmq.a(null, new Dictionary<string, coh>
					{
						{
							dmq.a,
							fv
						},
						{
							dmq.b,
							fv2
						}
					}).a() as cd1;
				}
			}
		}
		return null;
	}

	// Token: 0x06002E4D RID: 11853 RVA: 0x00106BE0 File Offset: 0x00104DE0
	public override aw4 a1()
	{
		cob cob = new cob();
		this.rg(cob);
		return cob;
	}

	// Token: 0x06002E4E RID: 11854 RVA: 0x00106BFC File Offset: 0x00104DFC
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		cob cob = A_0 as cob;
		cob.a = this.a;
		cob.b = this.b;
	}

	// Token: 0x06002E4F RID: 11855 RVA: 0x00106C28 File Offset: 0x00104E28
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
			if (this.b.GetValueOrDefault())
			{
				itemPoolForQuality.a("CombatShotgunFrame1", 0, int.MaxValue, 1);
				itemPoolForQuality.a("CombatShotgunFrame2", 55, int.MaxValue, 1);
			}
			else
			{
				bool? flag = this.b;
				bool flag2 = false;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					itemPoolForQuality.a("ShotgunFrame1", 0, int.MaxValue, 1);
					itemPoolForQuality.a("ShotgunFrame2", 45, int.MaxValue, 1);
				}
				else
				{
					itemPoolForQuality.a("ShotgunFrame1", 0, int.MaxValue, 3);
					itemPoolForQuality.a("ShotgunFrame2", 45, int.MaxValue, 3);
					itemPoolForQuality.a("CombatShotgunFrame1", 35, int.MaxValue, 1);
					itemPoolForQuality.a("CombatShotgunFrame2", 55, int.MaxValue, 1);
				}
			}
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xpbl\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E50 RID: 11856 RVA: 0x00106D50 File Offset: 0x00104F50
	private fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("LongShotgunBarrel", 0, int.MaxValue, 3);
		itemPoolForQuality.a("ShortShotgunBarrel", 0, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xpbl\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019E0 RID: 6624
	private new string a;

	// Token: 0x040019E1 RID: 6625
	private bool? b;
}
