using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x02000702 RID: 1794
[eiz("XBG")]
[Serializable]
public sealed class e3u : d1k, ISerializable
{
	// Token: 0x06002E97 RID: 11927 RVA: 0x0010800C File Offset: 0x0010620C
	private e3u(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 67)
		{
			this.a = A_0.GetString("XBG:B");
		}
	}

	// Token: 0x06002E98 RID: 11928 RVA: 0x00108034 File Offset: 0x00106234
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("XBG:B", this.a);
	}

	// Token: 0x06002E99 RID: 11929 RVA: 0x00108050 File Offset: 0x00106250
	public string a()
	{
		return this.a;
	}

	// Token: 0x06002E9A RID: 11930 RVA: 0x00108058 File Offset: 0x00106258
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E9B RID: 11931 RVA: 0x00108064 File Offset: 0x00106264
	public e3u()
	{
	}

	// Token: 0x06002E9C RID: 11932 RVA: 0x00108070 File Offset: 0x00106270
	protected override cd1 rf(int A_0)
	{
		bg bg = d79.Get<bg>();
		if (bg != null)
		{
			int a_ = y8.a(A_0);
			fv fv = this.b(a_);
			if (fv != null)
			{
				fv.QualityLevel = a_;
				fv fv2 = this.a(A_0);
				fv fv3 = this.a(A_0);
				if (fv2 != null && fv3 != null && fv2.TypedDefinition.i() == fv3.TypedDefinition.i())
				{
					fv3 = null;
				}
				return bg.a(null, new Dictionary<string, coh>
				{
					{
						bg.a,
						fv
					},
					{
						bg.b,
						fv2
					},
					{
						bg.c,
						fv3
					}
				}).a() as cd1;
			}
		}
		return null;
	}

	// Token: 0x06002E9D RID: 11933 RVA: 0x00108128 File Offset: 0x00106328
	public override aw4 a1()
	{
		e3u e3u = new e3u();
		this.rg(e3u);
		return e3u;
	}

	// Token: 0x06002E9E RID: 11934 RVA: 0x00108144 File Offset: 0x00106344
	private fv b(int A_0)
	{
		string text;
		if (!string.IsNullOrWhiteSpace(this.a))
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("CrossbowParts1", 0, int.MaxValue, 1);
			itemPoolForQuality.a("CrossbowParts2", 30, int.MaxValue, 1);
			itemPoolForQuality.a("CrossbowParts3", 40, int.MaxValue, 1);
			itemPoolForQuality.a("CrossbowParts4", 60, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E9F RID: 11935 RVA: 0x001081E8 File Offset: 0x001063E8
	private fv a(int A_0)
	{
		if (A_0 >= 3 && zp.a.NextDouble() < 0.2)
		{
			return y8.a("Weapons\\Scope", null);
		}
		if (A_0 >= 6 && zp.a.NextDouble() < 0.2)
		{
			return y8.a("Weapons\\PneumaticReloader", null);
		}
		return null;
	}

	// Token: 0x040019EB RID: 6635
	private new string a;
}
