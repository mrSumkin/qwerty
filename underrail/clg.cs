using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000446 RID: 1094
[fe("le_docDefibrillation")]
public sealed class clg : b5g
{
	// Token: 0x06001C79 RID: 7289 RVA: 0x0009B184 File Offset: 0x00099384
	public clg(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("Defibrillate", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(clg.a.a.a), new Func<cst>(this.a)));
		base.a(a_, list);
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x0009B208 File Offset: 0x00099408
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
		if (classPropertyValue != null && this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat && aw1.a(this.Subject.a8(), classPropertyValue, true))
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				if (serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xpbl_le_woundedSecTropper_died", new bool?(false)).Value)
				{
					this.Subject.y6().RemoveProperty(ddq.w);
					this.Subject.b("humanSoldier");
					return false;
				}
				TimeSpan? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<TimeSpan>("nextDefib", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
		}
		return false;
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x0009B330 File Offset: 0x00099530
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		c5x c5x = new ar7(new Guid("23fc14b7-3815-4d82-a520-4bb2b061bad0"), this.Subject.a8().Area).ao() as c5x;
		TimeSpan? timeSpan = new TimeSpan?(A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(6, 10)));
		ekk ekk = new ekk();
		ekk.a()["nextDefib"] = timeSpan;
		int a_ = 80;
		if (c5x != null)
		{
			awx awx = new awx();
			awx.a(awx.kh() | m7.b);
			List<auv> list = awx.ad();
			bfq bfq = new bfq(Guid.NewGuid().ToString(), "DefibrillatorCharge");
			bfq.a(0.4f);
			list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new bm3(100));
			List<auv> list2 = awx.ad();
			egx egx = new egx();
			egx.a("Убирайтесь!");
			egx.b(true);
			list2.Add(new a4s(egx, new ar7(this.Subject.a8()), null, null));
			awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom2)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new b16(new int?(1)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(2)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(3)), null, new ar7(this.Subject.a8()), null));
			List<auv> list3 = awx.ad();
			bfq bfq2 = new bfq(Guid.NewGuid().ToString(), "DefibrillatorShock");
			bfq2.a(0.8f);
			list3.Add(new a4s(bfq2, null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new rp(7), null, new ar7(c5x), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(4)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new rp(6), null, new ar7(c5x), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(5)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new rp(5), null, new ar7(c5x), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(6)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new rp(6), null, new ar7(c5x), null));
			awx.ad().Add(new bm3(a_));
			awx.ad().Add(new a4s(new b16(new int?(7)), null, new ar7(this.Subject.a8()), null));
			awx.ad().Add(new a4s(new rp(7), null, new ar7(c5x), null));
			awx.ad().Add(new a4s(ekk, null, new ar7(this.Subject.a8()), null));
			return awx;
		}
		return null;
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x0009B72C File Offset: 0x0009992C
	[CompilerGenerated]
	private cst a()
	{
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		awx.b(false);
		awx.c(false);
		awx.ad().Add(new a4s(new epw(null), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new b16(null), null, new ar7(this.Subject.a8()), null));
		return awx;
	}

	// Token: 0x02000447 RID: 1095
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C7F RID: 7295 RVA: 0x0009B7D0 File Offset: 0x000999D0
		internal float a(bool A_0)
		{
			return 0.75f;
		}

		// Token: 0x04000FC7 RID: 4039
		public static readonly clg.a a = new clg.a();

		// Token: 0x04000FC8 RID: 4040
		public static Func<bool, float> b;
	}
}
