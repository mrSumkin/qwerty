using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006E1 RID: 1761
[eiz("G0X")]
[Serializable]
public sealed class xm : y8, ISerializable
{
	// Token: 0x06002D56 RID: 11606 RVA: 0x00102984 File Offset: 0x00100B84
	private xm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("G0X:P");
	}

	// Token: 0x06002D57 RID: 11607 RVA: 0x001029A0 File Offset: 0x00100BA0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("G0X:P", this.a);
	}

	// Token: 0x06002D58 RID: 11608 RVA: 0x001029BC File Offset: 0x00100BBC
	public xm()
	{
	}

	// Token: 0x06002D59 RID: 11609 RVA: 0x001029C4 File Offset: 0x00100BC4
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002D5A RID: 11610 RVA: 0x001029CC File Offset: 0x00100BCC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002D5B RID: 11611 RVA: 0x001029D8 File Offset: 0x00100BD8
	protected override List<coh> a2()
	{
		List<coh> list = new List<coh>();
		c6c c6c = d79.Get<c6c>();
		if (c6c != null)
		{
			int a_ = y8.a(base.i());
			fv fv = y8.a("devices\\ShieldEmitterBase", null);
			fv fv2;
			if (!string.IsNullOrWhiteSpace(this.a))
			{
				fv2 = y8.a("Devices\\" + this.a, null);
			}
			else
			{
				fv2 = this.a(a_);
			}
			int a_2 = y8.a(a_, 15);
			fv fv3 = zp.b(a_2);
			if (fv != null && fv2 != null && fv3 != null)
			{
				fv2.QualityLevel = a_;
				fv3.QualityLevel = a_2;
				fv fv4 = null;
				if (zp.a.NextDouble() < 0.03)
				{
					int a_3 = y8.a(a_, 15);
					fv4 = this.a(a_3);
					if (fv4 != null)
					{
						fv4.QualityLevel = a_3;
					}
				}
				fv fv5 = null;
				if (zp.a.NextDouble() < 0.2)
				{
					int a_4 = y8.a(a_, 15);
					fv5 = this.b(a_4);
					if (fv5 != null)
					{
						fv5.QualityLevel = a_4;
					}
				}
				cgd cgd = c6c.a(null, new Dictionary<string, coh>
				{
					{
						c6c.a,
						fv
					},
					{
						c6c.b,
						fv2
					},
					{
						c6c.c,
						fv3
					},
					{
						c6c.d,
						fv4
					},
					{
						c6c.e,
						fv5
					}
				}).a() as cgd;
				if (cgd != null)
				{
					list.Add(cgd);
				}
			}
		}
		return list;
	}

	// Token: 0x06002D5C RID: 11612 RVA: 0x00102B80 File Offset: 0x00100D80
	public override aw4 a1()
	{
		xm xm = new xm();
		this.rg(xm);
		return xm;
	}

	// Token: 0x06002D5D RID: 11613 RVA: 0x00102B9C File Offset: 0x00100D9C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		((xm)A_0).a = this.a;
	}

	// Token: 0x06002D5E RID: 11614 RVA: 0x00102BBC File Offset: 0x00100DBC
	private fv b(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("CircularWaveAmplifier", int.MinValue, int.MaxValue, 1);
		itemPoolForQuality.a("ShieldCapacitor", int.MinValue, int.MaxValue, 1);
		itemPoolForQuality.a("HighEfficiencyEnergyConverter", int.MinValue, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Devices\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002D5F RID: 11615 RVA: 0x00102C38 File Offset: 0x00100E38
	private fv a(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("LowFrequencyShieldModulator", int.MinValue, int.MaxValue, 1);
		itemPoolForQuality.a("MediumFrequencyShieldModulator", int.MinValue, int.MaxValue, 2);
		itemPoolForQuality.a("HighFrequencyShieldModulator", int.MinValue, int.MaxValue, 2);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Devices\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019AF RID: 6575
	private new string a;
}
