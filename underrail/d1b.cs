using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Generators;

// Token: 0x020006F6 RID: 1782
[eiz("RKLG")]
[Serializable]
public sealed class d1b : d1k, ISerializable
{
	// Token: 0x06002E09 RID: 11785 RVA: 0x001058BC File Offset: 0x00103ABC
	private d1b(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("RKLG:F");
		this.b = A_0.GetBoolean("RKLG:A");
	}

	// Token: 0x06002E0A RID: 11786 RVA: 0x001058E8 File Offset: 0x00103AE8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("RKLG:F", this.a);
		info.AddValue("RKLG:A", this.b);
	}

	// Token: 0x06002E0B RID: 11787 RVA: 0x00105914 File Offset: 0x00103B14
	public string b()
	{
		return this.a;
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x0010591C File Offset: 0x00103B1C
	public void a(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x00105928 File Offset: 0x00103B28
	public bool a()
	{
		return this.b;
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x00105930 File Offset: 0x00103B30
	public void a(bool A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06002E0F RID: 11791 RVA: 0x0010593C File Offset: 0x00103B3C
	public d1b()
	{
	}

	// Token: 0x06002E10 RID: 11792 RVA: 0x00105948 File Offset: 0x00103B48
	protected override cd1 rf(int A_0)
	{
		a6q a6q = d79.Get<a6q>();
		if (a6q == null)
		{
			return null;
		}
		int a_ = y8.a(A_0);
		fv fv = this.c(a_);
		if (fv == null)
		{
			return null;
		}
		fv fv2 = this.b(a_);
		if (fv2 == null)
		{
			return null;
		}
		fv.QualityLevel = a_;
		fv fv3 = this.a(A_0);
		Dictionary<string, coh> dictionary = new Dictionary<string, coh>();
		dictionary.Add(a6q.a, fv);
		dictionary.Add(a6q.b, fv2);
		if (fv3 != null)
		{
			dictionary.Add(a6q.c, fv3);
		}
		return a6q.a(null, dictionary).a() as cd1;
	}

	// Token: 0x06002E11 RID: 11793 RVA: 0x001059E4 File Offset: 0x00103BE4
	public override aw4 a1()
	{
		d1b d1b = new d1b();
		this.rg(d1b);
		return d1b;
	}

	// Token: 0x06002E12 RID: 11794 RVA: 0x00105A00 File Offset: 0x00103C00
	protected override void rg(y8 A_0)
	{
		base.rg(A_0);
		d1b d1b = A_0 as d1b;
		d1b.a = this.a;
		d1b.b = this.b;
	}

	// Token: 0x06002E13 RID: 11795 RVA: 0x00105A2C File Offset: 0x00103C2C
	private fv c(int A_0)
	{
		string text;
		if (!string.IsNullOrEmpty(this.a))
		{
			text = this.a;
		}
		else
		{
			ItemPoolForQuality<string> itemPoolForQuality = new ItemPoolForQuality<string>(A_0);
			itemPoolForQuality.a("RocketLauncherFrame1", 0, int.MaxValue, 3);
			itemPoolForQuality.a("RocketLauncherFrame2", 50, int.MaxValue, 1);
			itemPoolForQuality.a("RocketLauncherFrame3", 0, int.MaxValue, 1);
			text = itemPoolForQuality.a();
		}
		if (text != null)
		{
			return y8.a("Weapons\\Xphw\\" + text, null);
		}
		return null;
	}

	// Token: 0x06002E14 RID: 11796 RVA: 0x00105ABC File Offset: 0x00103CBC
	private fv b(int A_0)
	{
		return y8.a("Weapons\\Xphw\\RocketLauncherFiringMechanism1", null);
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x00105ADC File Offset: 0x00103CDC
	private fv a(int A_0)
	{
		string text = null;
		if (this.b)
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

	// Token: 0x040019D6 RID: 6614
	private new string a;

	// Token: 0x040019D7 RID: 6615
	private bool b;
}
