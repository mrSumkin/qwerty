using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006FE RID: 1790
[eiz("E15")]
[Serializable]
public sealed class dro : d1k, ISerializable
{
	// Token: 0x06002E6C RID: 11884 RVA: 0x00107398 File Offset: 0x00105598
	private dro(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("E15:P");
	}

	// Token: 0x06002E6D RID: 11885 RVA: 0x001073B4 File Offset: 0x001055B4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("E15:P", this.a);
	}

	// Token: 0x06002E6E RID: 11886 RVA: 0x001073D0 File Offset: 0x001055D0
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002E6F RID: 11887 RVA: 0x001073D8 File Offset: 0x001055D8
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E70 RID: 11888 RVA: 0x001073E4 File Offset: 0x001055E4
	public dro()
	{
	}

	// Token: 0x06002E71 RID: 11889 RVA: 0x001073F0 File Offset: 0x001055F0
	public override aw4 a1()
	{
		dro dro = new dro();
		this.rg(dro);
		return dro;
	}

	// Token: 0x06002E72 RID: 11890 RVA: 0x0010740C File Offset: 0x0010560C
	protected override cd1 rf(int A_0)
	{
		cfm cfm = d79.Get<cfm>();
		if (cfm != null)
		{
			int a_ = y8.a(A_0);
			int a_2 = y8.a(A_0);
			fv fv = this.a(a_);
			fv fv2 = y8.a("Weapons\\energyPistolFrame", null);
			fv fv3 = zp.b(a_2);
			if (fv != null && fv.TypedDefinition != null && fv2 != null && fv2.TypedDefinition != null && fv3 != null && fv3.TypedDefinition != null)
			{
				fv.QualityLevel = a_;
				fv3.QualityLevel = a_2;
				return cfm.a(null, new Dictionary<string, coh>
				{
					{
						cfm.c,
						fv3
					},
					{
						cfm.b,
						fv
					},
					{
						cfm.a,
						fv2
					},
					{
						cfm.d,
						null
					},
					{
						cfm.e,
						null
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E73 RID: 11891 RVA: 0x00107500 File Offset: 0x00105700
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		((dro)A_0).a = this.a;
	}

	// Token: 0x06002E74 RID: 11892 RVA: 0x0010751C File Offset: 0x0010571C
	private fv a(int A_0)
	{
		string text;
		if (this.a != null)
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("LaserEmitter", int.MinValue, int.MaxValue, 3);
			if (A_0 >= 45)
			{
				itemPoolForQuality.a("PlasmaDischarger", int.MinValue, int.MaxValue, 1);
			}
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019E5 RID: 6629
	private new string a;
}
