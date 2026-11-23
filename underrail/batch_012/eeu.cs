using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x02000434 RID: 1076
[fe("superSeaWyrm")]
public sealed class eeu : am2
{
	// Token: 0x06001C39 RID: 7225 RVA: 0x00098FAC File Offset: 0x000971AC
	public eeu(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 1;
		List<c96> list = new List<c96>();
		list.Add(new byh("DiveOut", new Func<TimeSpan, double, bool>(this.f), new Func<TimeSpan, double, cst>(this.e), new Func<bool, float>(eeu.a.a.b), null)
		{
			e = true
		});
		list.Add(new byh("Feeding", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(eeu.a.a.a), null)
		{
			e = true
		});
		list.Add(new byh("DiveIn", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(eeu.a.a.c), null)
		{
			e = true
		});
		base.a(a_, list);
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x000990D0 File Offset: 0x000972D0
	private void a()
	{
		if (!this.Subject.a8().h.b.aa().SpecialAbilities.a(typeof(e5b)))
		{
			this.Subject.a8().h.b.aa().SpecialAbilities.b(dgk.Get<e5b>());
		}
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("Regenerating", new bool?(false)).Value)
		{
			this.Subject.y6().RemoveProperty("Regenerating");
		}
		if (this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay) != null)
		{
			this.Subject.y6().RemoveProperty(ddq.ay);
		}
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x000991A8 File Offset: 0x000973A8
	[CompilerGenerated]
	private bool f(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("Regenerating", new bool?(false)).Value)
		{
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null && this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat)
			{
				return aw1.a(this.Subject.a8(), classPropertyValue, false) && this.Subject.a8().h.b.ap != null;
			}
		}
		return false;
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x0009927C File Offset: 0x0009747C
	[CompilerGenerated]
	private cst e(TimeSpan A_0, double A_1)
	{
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | (m7.b | m7.k));
		awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveOut"), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom2, dz6.b(80), 0, null, 1));
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Custom5, dz6.b(80), 0, null, 1));
		awx.ad().Add(new a4s(new epw(null), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new dr5(new Vector3(this.Subject.a8().Size.X, this.Subject.a8().Size.Y, bu3.a(this.Subject.a8().h.b))), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new duh(this.Subject.a8().h.b, new string[]
		{
			ewc.a
		}));
		awx.ad().Add(new amd(this.Subject.a8().h.b, new els[]
		{
			new aw3(0)
		}));
		return awx;
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x00099448 File Offset: 0x00097648
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		if (this.Subject.y6().GetPrimitivePropertyValue<bool>("Regenerating", new bool?(false)).Value && this.Subject.a8().h.b.aa().Defense.q().zo() < this.Subject.a8().h.b.aa().Defense.q().zm() * 0.8f)
		{
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null && this.Subject.a8().h.b.aa().IsInControl && !this.Subject.a8().h.b.aa().IsInCombat)
			{
				if (aw1.a(this.Subject.a8(), classPropertyValue, false))
				{
					TimeSpan? timeSpan = new TimeSpan?(base.GetCortexProperty<TimeSpan>("NextBite", default(TimeSpan)));
					return timeSpan == null || timeSpan <= A_0;
				}
				this.a();
			}
			return false;
		}
		this.a();
		return false;
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x000995B0 File Offset: 0x000977B0
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		int num = cuo.a.Next(4);
		string[] array = new string[]
		{
			"FleshStab",
			"FleshStab2",
			"FleshStab3",
			"Rend"
		};
		awx awx = new awx();
		awx.a(awx.kh() | m7.b);
		awx.ad().Add(new e4t(this.Subject.a8().h.b, CharacterState.Attack1, cux.m, 0, null, 1));
		List<auv> list = awx.ad();
		bfq bfq = new bfq(Guid.NewGuid().ToString(), array[num]);
		bfq.a(0.4f);
		list.Add(new a4s(bfq, null, new ar7(this.Subject.a8()), null));
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null)
		{
			this.Subject.y6()["NextBite"] = A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(3, 6));
			float num2 = 0.13f + (float)cuo.a.NextDouble() * 0.1f;
			int a_ = (int)(this.Subject.a8().h.b.aa().Defense.q().zm() * num2);
			this.Subject.a8().h.b.aa().Defense.a(a_, null, null, true, false, false, null);
			if (this.Subject.a8().h.b.aa().Defense.q().zo() >= this.Subject.a8().h.b.aa().Defense.q().zm() * 0.85f)
			{
				this.a();
			}
		}
		return awx;
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x000997A8 File Offset: 0x000979A8
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		if (!this.Subject.y6().GetPrimitivePropertyValue<bool>("Regenerating", new bool?(false)).Value)
		{
			amc amc = base.h();
			return !amc.aa().IsInCombat && amc.ap == null;
		}
		return false;
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x00099808 File Offset: 0x00097A08
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		awx awx = new awx();
		awx awx2 = awx;
		awx2.a(awx2.kh() | (m7.b | m7.k));
		awx.ad().Add(new a4s(new bfq("xpbl_SeaSerpentDiveIn"), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a7j(this.Subject.a8(), bu3.b(base.h()), 1, double.MaxValue, false, false, null, null, null, null, false, null));
		awx.ad().Add(new e4t(base.h(), CharacterState.Custom4, 80, 0, null, 1));
		awx.ad().Add(new e4t(base.h(), CharacterState.Custom3, 80, 0, null, 1));
		awx.ad().Add(new a4s(new epw(new CharacterState?(CharacterState.Custom1)), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new a4s(new dr5(new Vector3(this.Subject.a8().Size.X, this.Subject.a8().Size.Y, 0.2f)), null, new ar7(this.Subject.a8()), null));
		awx.ad().Add(new duh(base.h(), new string[]
		{
			bk9.a
		}));
		awx.ad().Add(new duh(base.h(), new string[]
		{
			aw3.a
		}));
		awx.ad().Add(new amd(base.h(), new els[]
		{
			new ewc(0)
		}));
		return awx;
	}

	// Token: 0x02000435 RID: 1077
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C43 RID: 7235 RVA: 0x00099A10 File Offset: 0x00097C10
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001C44 RID: 7236 RVA: 0x00099A18 File Offset: 0x00097C18
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00099A20 File Offset: 0x00097C20
		internal float c(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000FAD RID: 4013
		public static readonly eeu.a a = new eeu.a();

		// Token: 0x04000FAE RID: 4014
		public static Func<bool, float> b;

		// Token: 0x04000FAF RID: 4015
		public static Func<bool, float> c;

		// Token: 0x04000FB0 RID: 4016
		public static Func<bool, float> d;
	}
}
