using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006FB RID: 1787
[eiz("MCHG")]
[Serializable]
public sealed class b5e : d1k, ISerializable
{
	// Token: 0x06002E51 RID: 11857 RVA: 0x00106DB0 File Offset: 0x00104FB0
	private b5e(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 224)
		{
			this.a = A_0.GetString("MCHG:M");
			this.b = A_0.GetString("MCHG:O");
		}
	}

	// Token: 0x06002E52 RID: 11858 RVA: 0x00106DEC File Offset: 0x00104FEC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MCHG:M", this.a);
		info.AddValue("MCHG:O", this.b);
	}

	// Token: 0x06002E53 RID: 11859 RVA: 0x00106E18 File Offset: 0x00105018
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002E54 RID: 11860 RVA: 0x00106E20 File Offset: 0x00105020
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E55 RID: 11861 RVA: 0x00106E2C File Offset: 0x0010502C
	public string b()
	{
		return this.b;
	}

	// Token: 0x06002E56 RID: 11862 RVA: 0x00106E34 File Offset: 0x00105034
	public void b(string A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E57 RID: 11863 RVA: 0x00106E40 File Offset: 0x00105040
	public b5e()
	{
	}

	// Token: 0x06002E58 RID: 11864 RVA: 0x00106E4C File Offset: 0x0010504C
	public override aw4 a1()
	{
		b5e b5e = new b5e();
		this.rg(b5e);
		return b5e;
	}

	// Token: 0x06002E59 RID: 11865 RVA: 0x00106E68 File Offset: 0x00105068
	protected override cd1 rf(int A_0)
	{
		akk akk = d79.Get<akk>();
		if (akk != null)
		{
			int a_ = y8.a(A_0);
			fv fv = zp.d(a_, this.a);
			fv fv2 = y8.a("Weapons\\Xpbl\\MacheteHandle", null);
			fv fv3 = this.a();
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv fv4 = this.a(A_0);
				fv fv5 = null;
				if (fv4 != null)
				{
					fv4.QualityLevel = y8.a(A_0);
					int a_2 = y8.a(A_0);
					fv5 = zp.b(a_2);
					fv5.QualityLevel = a_2;
				}
				return akk.a(null, new Dictionary<string, coh>
				{
					{
						akk.a,
						fv
					},
					{
						akk.b,
						fv2
					},
					{
						akk.c,
						fv3
					},
					{
						akk.d,
						fv4
					},
					{
						akk.e,
						fv5
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E5A RID: 11866 RVA: 0x00106F8C File Offset: 0x0010518C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		b5e b5e = (b5e)A_0;
		b5e.a = this.a;
		b5e.b = this.b;
	}

	// Token: 0x06002E5B RID: 11867 RVA: 0x00106FB8 File Offset: 0x001051B8
	private fv a()
	{
		string text;
		if (!string.IsNullOrWhiteSpace(this.b))
		{
			text = this.b;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(0);
			itemPoolForQuality.a("StraightMacheteBladeMold", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("CurvedMacheteBladeMold", int.MinValue, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xpbl\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E5C RID: 11868 RVA: 0x0010703C File Offset: 0x0010523C
	private fv a(int A_0)
	{
		if (A_0 >= 3 && zp.a.NextDouble() < 0.15)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("ElectroshockGenerator", int.MinValue, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x040019E2 RID: 6626
	private new string a;

	// Token: 0x040019E3 RID: 6627
	private string b;
}
