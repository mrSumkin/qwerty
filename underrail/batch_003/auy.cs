using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F9 RID: 1785
[eiz("GLG")]
[Serializable]
public sealed class auy : d1k, ISerializable
{
	// Token: 0x06002E33 RID: 11827 RVA: 0x001064D4 File Offset: 0x001046D4
	private auy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("GLG:F");
		this.b = (A_0.GetValue("GLG:C", typeof(GrenadeLauncherBarrelType?)) as GrenadeLauncherBarrelType?);
		this.c = (A_0.GetValue("GLG:L", typeof(bool?)) as bool?);
		if (ell.a() >= 671)
		{
			this.d = A_0.GetBoolean("GLG:A");
		}
	}

	// Token: 0x06002E34 RID: 11828 RVA: 0x00106564 File Offset: 0x00104764
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("GLG:F", this.a);
		info.AddValue("GLG:C", this.b);
		info.AddValue("GLG:L", this.c);
		info.AddValue("GLG:A", this.d);
	}

	// Token: 0x06002E35 RID: 11829 RVA: 0x001065C8 File Offset: 0x001047C8
	public string d()
	{
		return this.a;
	}

	// Token: 0x06002E36 RID: 11830 RVA: 0x001065D0 File Offset: 0x001047D0
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E37 RID: 11831 RVA: 0x001065DC File Offset: 0x001047DC
	public GrenadeLauncherBarrelType? c()
	{
		return this.b;
	}

	// Token: 0x06002E38 RID: 11832 RVA: 0x001065E4 File Offset: 0x001047E4
	public void a(GrenadeLauncherBarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E39 RID: 11833 RVA: 0x001065F0 File Offset: 0x001047F0
	public bool? b()
	{
		return this.c;
	}

	// Token: 0x06002E3A RID: 11834 RVA: 0x001065F8 File Offset: 0x001047F8
	public void a(bool? A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06002E3B RID: 11835 RVA: 0x00106604 File Offset: 0x00104804
	public bool a()
	{
		return this.d;
	}

	// Token: 0x06002E3C RID: 11836 RVA: 0x0010660C File Offset: 0x0010480C
	public void a(bool A_0)
	{
		this.d = A_0;
	}

	// Token: 0x06002E3D RID: 11837 RVA: 0x00106618 File Offset: 0x00104818
	public auy()
	{
	}

	// Token: 0x06002E3E RID: 11838 RVA: 0x00106624 File Offset: 0x00104824
	protected override cd1 rf(int A_0)
	{
		eg3 eg = d79.Get<eg3>();
		if (eg == null)
		{
			return null;
		}
		int a_ = y8.a(A_0);
		fv fv = this.b(a_);
		if (fv == null)
		{
			return null;
		}
		GrenadeLauncherBarrelType? primitivePropertyValue = fv.Definition.a7().GetPrimitivePropertyValue<GrenadeLauncherBarrelType>("SupportedBarrelType", null);
		if (primitivePropertyValue == null)
		{
			return null;
		}
		fv fv2 = this.b(a_, primitivePropertyValue.Value);
		if (fv2 == null)
		{
			return null;
		}
		fv.QualityLevel = a_;
		fv fv3 = this.a(a_, primitivePropertyValue.Value);
		if (fv3 == null)
		{
			return null;
		}
		fv fv4 = this.a(A_0);
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary.Add(eg3.a, fv);
		dictionary.Add(eg3.b, fv2);
		dictionary.Add(eg3.c, fv3);
		if (fv4 != null)
		{
			dictionary.Add(eg3.d, fv4);
		}
		return eg.a(null, dictionary).a() as cd1;
	}

	// Token: 0x06002E3F RID: 11839 RVA: 0x00106720 File Offset: 0x00104920
	public override aw4 a1()
	{
		auy auy = new auy();
		this.rg(auy);
		return auy;
	}

	// Token: 0x06002E40 RID: 11840 RVA: 0x0010673C File Offset: 0x0010493C
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		auy auy = A_0 as auy;
		auy.a = this.a;
		auy.b = this.b;
		auy.c = this.c;
		auy.d = this.d;
	}

	// Token: 0x06002E41 RID: 11841 RVA: 0x00106780 File Offset: 0x00104980
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
			if (this.b.GetValueOrDefault() == GrenadeLauncherBarrelType.Caliber_40 || this.b == null)
			{
				itemPoolForQuality.a("GrenadeLauncherFrame1", 0, int.MaxValue, 2);
				itemPoolForQuality.a("GrenadeLauncherFrame2", 50, int.MaxValue, 1);
			}
			GrenadeLauncherBarrelType? grenadeLauncherBarrelType = this.b;
			GrenadeLauncherBarrelType grenadeLauncherBarrelType2 = GrenadeLauncherBarrelType.Caliber_25;
			if ((grenadeLauncherBarrelType.GetValueOrDefault() == grenadeLauncherBarrelType2 & grenadeLauncherBarrelType != null) || this.b == null)
			{
				itemPoolForQuality.a("GrenadeLauncherFrame3", 0, int.MaxValue, 4);
				itemPoolForQuality.a("GrenadeLauncherFrame4", 50, int.MaxValue, 2);
			}
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E42 RID: 11842 RVA: 0x00106874 File Offset: 0x00104A74
	private fv b(int A_0, GrenadeLauncherBarrelType A_1)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (A_1 == GrenadeLauncherBarrelType.Caliber_25)
		{
			if (!this.c.GetValueOrDefault())
			{
				itemPoolForQuality.a("GrenadeLauncherBarrel25", 0, int.MaxValue, 3);
			}
			itemPoolForQuality.a("GrenadeLauncherBarrel25L", 35, int.MaxValue, 1);
		}
		else
		{
			if (!this.c.GetValueOrDefault())
			{
				itemPoolForQuality.a("GrenadeLauncherBarrel40", 0, int.MaxValue, 3);
			}
			itemPoolForQuality.a("GrenadeLauncherBarrel40L", 35, int.MaxValue, 1);
		}
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E43 RID: 11843 RVA: 0x00106928 File Offset: 0x00104B28
	private fv a(int A_0, GrenadeLauncherBarrelType A_1)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (A_1 == GrenadeLauncherBarrelType.Caliber_25)
		{
			itemPoolForQuality.a("GrenadeLauncherBoxMagazine6", 0, int.MaxValue, 6);
			itemPoolForQuality.a("GrenadeLauncherBoxMagazine8", 45, int.MaxValue, 4);
			itemPoolForQuality.a("GrenadeLauncherBoxMagazine10", 90, int.MaxValue, 1);
		}
		else
		{
			itemPoolForQuality.a("GrenadeLauncherRevolverCylinder4", 0, int.MaxValue, 4);
			itemPoolForQuality.a("GrenadeLauncherRevolverCylinder6", 80, int.MaxValue, 1);
		}
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E44 RID: 11844 RVA: 0x001069CC File Offset: 0x00104BCC
	private fv a(int A_0)
	{
		string text = null;
		if (this.d)
		{
			text = "Xphw\\AirburstScope";
		}
		else if (zp.a.NextDouble() < 0.2)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
			itemPoolForQuality.a("Xphw\\AirburstScope", 125, int.MaxValue, 10);
			itemPoolForQuality.a("Xphw\\GrenadeLauncherIronsights", int.MinValue, int.MaxValue, 1);
			itemPoolForQuality.a("Xphw\\GrenadeLauncherScope", 75, int.MaxValue, 5);
			itemPoolForQuality.a("VerticalForegrip", 40, int.MaxValue, 2);
			itemPoolForQuality.a("Bipod", 40, int.MaxValue, 3);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\" + text, null);
		}
		return null;
	}

	// Token: 0x040019DC RID: 6620
	private new string a;

	// Token: 0x040019DD RID: 6621
	private GrenadeLauncherBarrelType? b;

	// Token: 0x040019DE RID: 6622
	private bool? c;

	// Token: 0x040019DF RID: 6623
	private bool d;
}
