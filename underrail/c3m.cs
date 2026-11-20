using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F8 RID: 1784
[eiz("LMGG")]
[Serializable]
public sealed class c3m : d1k, ISerializable
{
	// Token: 0x06002E25 RID: 11813 RVA: 0x00106064 File Offset: 0x00104264
	private c3m(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("LMGG:F");
		this.b = (A_0.GetValue("LMGG:C", typeof(BarrelType?)) as BarrelType?);
	}

	// Token: 0x06002E26 RID: 11814 RVA: 0x001060B0 File Offset: 0x001042B0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LMGG:F", this.a);
		info.AddValue("LMGG:C", this.b);
	}

	// Token: 0x06002E27 RID: 11815 RVA: 0x001060E4 File Offset: 0x001042E4
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002E28 RID: 11816 RVA: 0x001060EC File Offset: 0x001042EC
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E29 RID: 11817 RVA: 0x001060F8 File Offset: 0x001042F8
	public BarrelType? a()
	{
		return this.b;
	}

	// Token: 0x06002E2A RID: 11818 RVA: 0x00106100 File Offset: 0x00104300
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E2B RID: 11819 RVA: 0x0010610C File Offset: 0x0010430C
	public c3m()
	{
	}

	// Token: 0x06002E2C RID: 11820 RVA: 0x00106118 File Offset: 0x00104318
	protected override cd1 rf(int A_0)
	{
		y y = d79.Get<y>();
		if (y == null)
		{
			return null;
		}
		int a_ = y8.a(A_0);
		fv fv = this.b(a_);
		if (fv == null)
		{
			return null;
		}
		fv fv2 = this.a(a_, this.b);
		if (fv2 == null)
		{
			return null;
		}
		fv.QualityLevel = a_;
		bool value = fv.TypedDefinition.a7().GetPrimitivePropertyValue<bool>("UsesBeltTypeMagazine", new bool?(false)).Value;
		fv fv3 = this.a(a_, value);
		if (fv3 == null)
		{
			return null;
		}
		fv fv4 = this.a(A_0);
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary.Add(y.a, fv);
		dictionary.Add(y.b, fv2);
		dictionary.Add(y.c, fv3);
		if (fv4 != null)
		{
			dictionary.Add(y.d, fv4);
		}
		return y.a(null, dictionary).a() as cd1;
	}

	// Token: 0x06002E2D RID: 11821 RVA: 0x00106204 File Offset: 0x00104404
	public override aw4 a1()
	{
		c3m c3m = new c3m();
		this.rg(c3m);
		return c3m;
	}

	// Token: 0x06002E2E RID: 11822 RVA: 0x00106220 File Offset: 0x00104420
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		c3m c3m = A_0 as c3m;
		c3m.a = this.a;
		c3m.b = this.b;
	}

	// Token: 0x06002E2F RID: 11823 RVA: 0x0010624C File Offset: 0x0010444C
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
			itemPoolForQuality.a("LmgFrame1", 0, int.MaxValue, 2);
			itemPoolForQuality.a("LmgFrame2", 50, int.MaxValue, 1);
			itemPoolForQuality.a("LmgFrame3", 0, int.MaxValue, 4);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E30 RID: 11824 RVA: 0x001062DC File Offset: 0x001044DC
	private fv a(int A_0, BarrelType? A_1)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (A_1 == null || A_1.GetValueOrDefault() == BarrelType.Caliber_9)
		{
			itemPoolForQuality.a("Barrel9", int.MinValue, int.MaxValue, 2);
		}
		if (A_1 == null || A_1.GetValueOrDefault() == BarrelType.Caliber_44)
		{
			itemPoolForQuality.a("Barrel44", int.MinValue, int.MaxValue, 1);
		}
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E31 RID: 11825 RVA: 0x00106378 File Offset: 0x00104578
	private fv a(int A_0, bool A_1)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (A_1)
		{
			itemPoolForQuality.a("LmgBeltMagazine50", 0, int.MaxValue, 8);
			itemPoolForQuality.a("LmgBeltMagazine65", 45, int.MaxValue, 4);
			itemPoolForQuality.a("LmgBeltMagazine80", 90, int.MaxValue, 1);
		}
		else
		{
			itemPoolForQuality.a("LmgBoxMagazine45", 0, int.MaxValue, 8);
			itemPoolForQuality.a("LmgBoxMagazine55", 40, int.MaxValue, 4);
			itemPoolForQuality.a("LmgBoxMagazine65", 80, int.MaxValue, 1);
		}
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E32 RID: 11826 RVA: 0x00106430 File Offset: 0x00104630
	private fv a(int A_0)
	{
		if (zp.a.NextDouble() < 0.2)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("BarrelCompensator", 70, int.MaxValue, 4);
			itemPoolForQuality.a("MuzzleBrake", 50, int.MaxValue, 4);
			itemPoolForQuality.a("Xphw\\ErgonomicHandle", 0, int.MaxValue, 1);
			itemPoolForQuality.a("Bipod", 0, int.MaxValue, 1);
			string text = itemPoolForQuality.a();
			if (text != null)
			{
				return y8.a("Weapons\\" + text, null);
			}
		}
		return null;
	}

	// Token: 0x040019DA RID: 6618
	private new string a;

	// Token: 0x040019DB RID: 6619
	private BarrelType? b;
}
