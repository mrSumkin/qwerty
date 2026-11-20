using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;
using TimelapseVertigo.Rules.Items;

// Token: 0x020006F7 RID: 1783
[eiz("MGG")]
[Serializable]
public sealed class e65 : d1k, ISerializable
{
	// Token: 0x06002E16 RID: 11798 RVA: 0x00105BB0 File Offset: 0x00103DB0
	private e65(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("MGG:F");
		this.b = (A_0.GetValue("MGG:C", typeof(BarrelType?)) as BarrelType?);
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x00105BFC File Offset: 0x00103DFC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MGG:F", this.a);
		info.AddValue("MGG:C", this.b);
	}

	// Token: 0x06002E18 RID: 11800 RVA: 0x00105C30 File Offset: 0x00103E30
	public string c()
	{
		return this.a;
	}

	// Token: 0x06002E19 RID: 11801 RVA: 0x00105C38 File Offset: 0x00103E38
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E1A RID: 11802 RVA: 0x00105C44 File Offset: 0x00103E44
	public BarrelType? b()
	{
		return this.b;
	}

	// Token: 0x06002E1B RID: 11803 RVA: 0x00105C4C File Offset: 0x00103E4C
	public void a(BarrelType? A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E1C RID: 11804 RVA: 0x00105C58 File Offset: 0x00103E58
	public e65()
	{
	}

	// Token: 0x06002E1D RID: 11805 RVA: 0x00105C64 File Offset: 0x00103E64
	protected override cd1 rf(int A_0)
	{
		bew bew = d79.Get<bew>();
		if (bew == null)
		{
			return null;
		}
		int a_ = y8.a(A_0);
		fv fv = this.a(a_, this.b);
		if (fv == null)
		{
			return null;
		}
		BarrelType? primitivePropertyValue = fv.TypedDefinition.a7().GetPrimitivePropertyValue<BarrelType>("BarrelType", null);
		if (primitivePropertyValue == null)
		{
			return null;
		}
		fv fv2 = this.a(a_, primitivePropertyValue.Value);
		if (fv2 == null)
		{
			return null;
		}
		fv fv3 = this.a();
		if (fv3 == null)
		{
			return null;
		}
		fv.Stacks = 6;
		fv2.QualityLevel = a_;
		fv fv4 = this.b(a_);
		if (fv4 == null)
		{
			return null;
		}
		fv fv5 = this.a(A_0);
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary.Add(bew.a, fv2);
		dictionary.Add(bew.b, fv3);
		dictionary.Add(bew.c, fv);
		dictionary.Add(bew.d, fv4);
		if (fv5 != null)
		{
			dictionary.Add(bew.f, fv5);
		}
		return bew.a(null, dictionary).a() as cd1;
	}

	// Token: 0x06002E1E RID: 11806 RVA: 0x00105D84 File Offset: 0x00103F84
	public override aw4 a1()
	{
		e65 e = new e65();
		this.rg(e);
		return e;
	}

	// Token: 0x06002E1F RID: 11807 RVA: 0x00105DA0 File Offset: 0x00103FA0
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		e65 e = A_0 as e65;
		e.a = this.a;
		e.b = this.b;
	}

	// Token: 0x06002E20 RID: 11808 RVA: 0x00105DCC File Offset: 0x00103FCC
	private fv a(int A_0, BarrelType A_1)
	{
		string text;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			if (A_1 == BarrelType.Caliber_44)
			{
				itemPoolForQuality.a("MinigunFrame1", 0, int.MaxValue, 4);
				itemPoolForQuality.a("MinigunFrame2", 85, int.MaxValue, 2);
			}
			else
			{
				itemPoolForQuality.a("MinigunFrame3", 0, int.MaxValue, 1);
			}
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E21 RID: 11809 RVA: 0x00105E68 File Offset: 0x00104068
	private fv a()
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(0);
		itemPoolForQuality.a("MinigunMotorJumpstarter1", 0, int.MaxValue, 1);
		itemPoolForQuality.a("MinigunMotorLongGame1", 0, int.MaxValue, 1);
		itemPoolForQuality.a("MinigunMotorSlowStarter1", 0, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E22 RID: 11810 RVA: 0x00105ED8 File Offset: 0x001040D8
	private fv a(int A_0, BarrelType? A_1)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		if (A_1 == null || A_1.GetValueOrDefault() == BarrelType.Caliber_127)
		{
			itemPoolForQuality.a("Barrel127", int.MinValue, int.MaxValue, 1);
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

	// Token: 0x06002E23 RID: 11811 RVA: 0x00105F74 File Offset: 0x00104174
	private fv b(int A_0)
	{
		ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
		itemPoolForQuality.a("LmgBeltMagazine50", 0, int.MaxValue, 8);
		itemPoolForQuality.a("LmgBeltMagazine65", 45, int.MaxValue, 4);
		itemPoolForQuality.a("LmgBeltMagazine80", 90, int.MaxValue, 1);
		string text = itemPoolForQuality.a();
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E24 RID: 11812 RVA: 0x00105FE8 File Offset: 0x001041E8
	private fv a(int A_0)
	{
		if (zp.a.NextDouble() < 0.2)
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(10 + A_0 * 5);
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

	// Token: 0x040019D8 RID: 6616
	private new string a;

	// Token: 0x040019D9 RID: 6617
	private BarrelType? b;
}
