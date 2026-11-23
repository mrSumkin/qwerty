using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using Ouroboros.Core.Logging;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001753 RID: 5971
[eiz("LWA")]
[Serializable]
public sealed class nh : a6k
{
	// Token: 0x06008094 RID: 32916 RVA: 0x00364E5C File Offset: 0x0036305C
	private nh(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (nh.a)A_0.GetValue("LWA:C", typeof(nh.a));
		this.b = A_0.GetBoolean("LWA:R");
		this.c = A_0.GetInt32("LWA:A");
		if (ell.a() >= 123)
		{
			this.d = A_0.GetBoolean("LWA:S");
		}
	}

	// Token: 0x06008095 RID: 32917 RVA: 0x00364ED0 File Offset: 0x003630D0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("LWA:C", this.a);
		info.AddValue("LWA:R", this.b);
		info.AddValue("LWA:A", this.c);
		info.AddValue("LWA:S", this.d);
	}

	// Token: 0x06008096 RID: 32918 RVA: 0x00364F30 File Offset: 0x00363130
	public nh(nh.a A_0, bool A_1, int A_2, bool A_3 = false)
	{
		this.a = A_0;
		this.b = A_1;
		this.c = A_2;
		this.d = A_3;
	}

	// Token: 0x06008097 RID: 32919 RVA: 0x00364F58 File Offset: 0x00363158
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().j != cgy.b || base.vg().q().h.b == null || base.vg().q().h.b.aa().Dead)
		{
			return dc4.e;
		}
		cd1 cd;
		if (this.a == nh.a.a)
		{
			cd = base.vg().q().h.b.aa().Offense.u();
		}
		else if (this.a == nh.a.c)
		{
			cd = (base.vg().e().b9() as cd1);
		}
		else
		{
			cd = (this.fm() as cd1);
		}
		if (cd == null || cd.TypedDefinition.f() == 0)
		{
			return dc4.e;
		}
		dng dng;
		if (this.a != nh.a.c)
		{
			dng = (base.vg().e().b9() as dng);
			if (dng == null)
			{
				return dc4.e;
			}
		}
		else
		{
			dng = null;
		}
		if (dng != null && eub.g(dng.TypedDefinition.b()) != cd.TypedDefinition.ak())
		{
			this.a(dng, cd);
			return dc4.e;
		}
		int num = 0;
		if (this.b)
		{
			foreach (KeyValuePair<AmmoType, int> keyValuePair in eub.d(cd))
			{
				if (dng != null && keyValuePair.Key == dng.TypedDefinition.b())
				{
					num = keyValuePair.Value;
				}
				else
				{
					this.a(base.vg().q().h.b.aa(), keyValuePair.Key, keyValuePair.Value);
				}
			}
			cd.LoadedAmmo.Clear();
		}
		if (this.c > 0)
		{
			int num2 = Math.Min(this.c, cd.TypedDefinition.f() - cd.LoadedAmmo.Count);
			if (num > 0)
			{
				num2 -= num;
				cd.LoadedAmmo.AddRange(eub.a(dng.TypedDefinition.b(), num));
			}
			if (num2 <= 0)
			{
				this.a(cd);
				return dc4.e;
			}
			while (dng != null)
			{
				if (num2 <= 0)
				{
					break;
				}
				int num3 = Math.Min(dng.Stacks, num2);
				num2 -= num3;
				dng.Stacks -= num3;
				cd.LoadedAmmo.AddRange(eub.a(dng.TypedDefinition.b(), num3));
				if (dng.Stacks == 0)
				{
					base.vg().q().h.b.aa().Bag.z5(dng);
					if (this.d && num2 > 0)
					{
						dng = (Enumerable.FirstOrDefault<coh>(base.vg().e().b8().Bag.b(dng.Definition.a5())) as dng);
					}
					else
					{
						dng = null;
					}
				}
				else
				{
					base.vg().q().h.b.aa().bl();
				}
			}
			if (this.c != 1)
			{
				bmj.a(base.vg().q(), new e5x("Перезаряжено", Color.White, cd.TypedDefinition.a3(), false));
				vr a_ = new vr(new ap9(base.vg().q().h.b.aa()), null, "{0} перезаряжает {2}.", null, cd);
				bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
				a7v.a(a_);
			}
		}
		string text = eub.a(cd, this.c, this.b);
		if (text != null)
		{
			base.vg().q().c().a("reloading", text, 1f, c9z.a, false, false);
		}
		return dc4.c;
	}

	// Token: 0x06008098 RID: 32920 RVA: 0x003653A8 File Offset: 0x003635A8
	private void a(cd1 A_0)
	{
		bmj.a(base.vg().q(), new e5x("Магазин полон", adi.l, A_0.TypedDefinition.a3(), false));
	}

	// Token: 0x06008099 RID: 32921 RVA: 0x003653E0 File Offset: 0x003635E0
	private void a(dng A_0, cd1 A_1)
	{
		bmj.a(base.vg().q(), new e5x("Неподходящий тип патронов", adi.l, A_0.TypedDefinition.a3(), false));
		vr a_ = new vr(new ap9(base.vg().q().h.b.aa()), null, "{0} пытается зарядить не тот тип патронов в {2}. Стыд-позор!", new Color?(adi.l), A_1);
		bey.a(a_, base.vg().q().h.b.aa(), base.vg().q().h.b);
		a7v.a(a_);
	}

	// Token: 0x0600809A RID: 32922 RVA: 0x00365488 File Offset: 0x00363688
	private void a(efk A_0, AmmoType A_1, int A_2)
	{
		string path;
		if (eub.b(A_1) || eub.a(A_1))
		{
			path = "Ammo\\Xphw\\" + A_1.ToString();
		}
		else if (eub.c(A_1) || A_1 == AmmoType.Vial_Acid_Rusting)
		{
			path = "Ammo\\Xpbl\\" + A_1.ToString();
		}
		else
		{
			path = "Ammo\\" + A_1.ToString();
		}
		bit bit = ez2.CreateDefinitonProvider<dgr>(path);
		if (bit == null || bit.wl() == null)
		{
			dux.b(LogSeverity.Error, "Failed to unload ammo. Error creating definition provider for ammo type: {0}", new object[]
			{
				A_1.ToString()
			});
			return;
		}
		dng dng = new dng(bit);
		dng.Stacks = A_2;
		A_0.Bag.z3(dng, true);
	}

	// Token: 0x0400324C RID: 12876
	private new nh.a a;

	// Token: 0x0400324D RID: 12877
	private bool b;

	// Token: 0x0400324E RID: 12878
	private int c;

	// Token: 0x0400324F RID: 12879
	private bool d;

	// Token: 0x02001754 RID: 5972
	[eiz("eTW")]
	[Serializable]
	public new enum a
	{
		// Token: 0x04003251 RID: 12881
		a,
		// Token: 0x04003252 RID: 12882
		b,
		// Token: 0x04003253 RID: 12883
		c
	}
}
