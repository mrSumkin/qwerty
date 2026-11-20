using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Items;

// Token: 0x02001372 RID: 4978
[eiz("FCCEHEA")]
[bs6("HFX:firecrackerCapExplosiveHit")]
[Serializable]
public sealed class a50 : cpl, ISerializable
{
	// Token: 0x060070D2 RID: 28882 RVA: 0x002F5E2C File Offset: 0x002F402C
	private a50(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetBoolean("FCCEHEA:B");
	}

	// Token: 0x060070D3 RID: 28883 RVA: 0x002F5E48 File Offset: 0x002F4048
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("FCCEHEA:B", this.a);
	}

	// Token: 0x060070D4 RID: 28884 RVA: 0x002F5E64 File Offset: 0x002F4064
	public a50()
	{
	}

	// Token: 0x060070D5 RID: 28885 RVA: 0x002F5E70 File Offset: 0x002F4070
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.a() == null || base.b() == null || base.b().a8() == null || base.b().a8().Zone == null || base.agu() == null || base.b() == null || base.b().aa() == null)
		{
			return dc4.e;
		}
		if (!base.agw().b)
		{
			return dc4.c;
		}
		if (base.ag2() != null && base.ag2().MaxDurability > 0)
		{
			int num = Convert.ToInt32(((double)base.ag2().MaxDurability * 0.4 + 250.0) * (double)euf.b().ItemDegradationRate);
			base.ag2().Durability = Math.Max(0.0, base.ag2().Durability - (double)num);
		}
		c8d c8d = base.b().aa().Gear.l().Item;
		if (c8d != null && c8d.MaxDurability > 0)
		{
			int num2 = Convert.ToInt32((double)c8d.MaxDurability * 0.3 + 200.0);
			c8d.Durability = Math.Max(0.0, c8d.Durability - (double)num2);
		}
		bool flag;
		if (base.agy().b != null)
		{
			flag = (Enumerable.Sum<csk>(base.agy().b, new Func<csk, int>(a50.a.a.b)) > 0);
		}
		else
		{
			flag = false;
		}
		this.a = flag;
		dm5 dm = new dm5();
		dm.a(base.a().aa().FactionId);
		dm.d("Взрывчатая накладка");
		dm.a(aaj.a(base.agu()));
		dm.d(true);
		dm.s().Add(aaj.b(base.agu()));
		dm.s().Add(aaj.c(base.agu()));
		dm.a(new AmmoType?(AmmoType.HighExplosives));
		dm.c(true);
		dm.a(0.15);
		dm.b(false);
		dm.w = new Action<cwt, amc, float>(this.a);
		dm.x = new Action<cwt, cru, amc, float>(this.a);
		dm.c(null);
		dtb dtb = new dtb();
		dtb.b(false);
		dtb.c(false);
		List<auv> list = dtb.ad();
		c5x a_ = base.b().a8();
		string a_2 = "ExplosionSmall";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		list.Add(new a7j(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false, null));
		dtb.ad().Add(new a4s(new bfq(Guid.NewGuid().ToString(), "HeGrenadeExplode"), null, new ar7(base.b().a8()), null));
		eym.a(dtb, base.b().a8(), (double)aju.a2);
		dtb.ad().Add(new a4s(dm, null, new ar7(base.b().a8()), null));
		dtb.ad().Add(new a27(base.a(), base.b(), true, true, false, true));
		base.b().a8().Zone.ActionManager.g9(dtb, atp.a);
		dz6.a(dtb);
		return dc4.c;
	}

	// Token: 0x060070D6 RID: 28886 RVA: 0x002F6220 File Offset: 0x002F4420
	[dcc("FCCEHEA:mAX")]
	private void a(cwt A_0, cru A_1, amc A_2, float A_3)
	{
		if (base.b() != null && base.b() == A_2 && A_1 != null && !A_1.c && A_1.a != null)
		{
			if (Enumerable.Sum<csk>(A_1.a, new Func<csk, int>(a50.a.a.a)) > 0)
			{
				if (A_2.aa().Passive || A_2.aa().d(CharacterImmunities.Dismantle))
				{
					etm a_ = new etm(new ap9(A_2.aa()), "эффекту разборки");
					bey.a(a_, base.a().aa(), A_2.aa(), A_2);
					a7v.a(a_);
					bmj.a(A_2.a8(), new ba0());
					return;
				}
				bca a_2 = new bca(aaj.d(base.agu()) * d0u.b);
				A_2.aa().StatusEffects.a(a_2, false, false, false);
			}
		}
	}

	// Token: 0x060070D7 RID: 28887 RVA: 0x002F6328 File Offset: 0x002F4528
	[dcc("FCCEHEA:mAA")]
	private void a(cwt A_0, amc A_1, float A_2)
	{
		if (base.b() != null && base.b() == A_1)
		{
			A_0.l = this.a;
		}
	}

	// Token: 0x04002E24 RID: 11812
	private new bool a;

	// Token: 0x02001373 RID: 4979
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x060070DA RID: 28890 RVA: 0x002F6364 File Offset: 0x002F4564
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x060070DB RID: 28891 RVA: 0x002F6370 File Offset: 0x002F4570
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04002E25 RID: 11813
		public static readonly a50.a a = new a50.a();

		// Token: 0x04002E26 RID: 11814
		public static Func<csk, int> b;

		// Token: 0x04002E27 RID: 11815
		public static Func<csk, int> c;
	}
}
