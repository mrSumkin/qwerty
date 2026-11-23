using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200039B RID: 923
[fe("rnd_Cc_ZonerCustomer")]
public sealed class chm : b5g
{
	// Token: 0x06001976 RID: 6518 RVA: 0x000868C8 File Offset: 0x00084AC8
	public chm(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Turn", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(chm.a.a.a), null));
		base.a(a_, list);
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x00086940 File Offset: 0x00084B40
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk != null && blk.b())
			{
				TimeSpan? timeSpan = new TimeSpan?(base.GetCortexProperty<TimeSpan>("NextRotation", default(TimeSpan)));
				return timeSpan == null || timeSpan.Value <= A_0;
			}
		}
		return false;
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x000869D4 File Offset: 0x00084BD4
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		if (bpo.GetServiceOrThrow<cnk>().aqu() != null && this.Subject.a8().u.b != null)
		{
			c5x c5x = new ar7(new Guid("e4c7d870-a34a-4f79-8b32-a4db8fdfacb0"), this.Subject.a8().Area).ao() as c5x;
			c5x c5x2 = new ar7(new Guid("d5379081-0dfd-4c06-bc30-f06a36ed06ff"), this.Subject.a8().Area).ao() as c5x;
			c5x c5x3 = new ar7(new Guid("db41787b-1871-46d4-9775-661cfec065dd"), this.Subject.a8().Area).ao() as c5x;
			c5x c5x4 = new ar7(new Guid("817d1a52-ec5d-4cf3-bebe-e78cd6d48884"), this.Subject.a8().Area).ao() as c5x;
			c5x c5x5 = new ar7(new Guid("492aad51-258c-4fc0-a715-d914bbae85b1"), this.Subject.a8().Area).ao() as c5x;
			string text = null;
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				text = classPropertyValue.b();
			}
			if (text == null || text == "randomEvent_cc_rsc_pa6")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa1");
				if (c5x != null)
				{
					this.Subject.a8().u.b.a("Мех.", true, null, null);
				}
			}
			else if (text == "randomEvent_cc_rsc_pa1")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa2");
				if (c5x2 != null)
				{
					this.Subject.a8().u.b.a("М-м-м, хорошо, хорошо.", true, null, null);
				}
			}
			else if (text == "randomEvent_cc_rsc_pa2")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa3");
				if (c5x3 != null)
				{
					this.Subject.a8().u.b.a("Старый. С другой стороны, я тоже.", true, null, null);
				}
			}
			else if (text == "randomEvent_cc_rsc_pa3")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa4");
				if (c5x4 != null)
				{
					this.Subject.a8().u.b.a("::Проверяет свой мешочек с монетами. Оттуда вылетает муха.:: Кыш, проклятая моль!", true, null, null);
				}
			}
			else if (text == "randomEvent_cc_rsc_pa4")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa5");
				if (c5x5 != null)
				{
					this.Subject.a8().u.b.a("Сейчас *это*... Я смогу запихать в своооою хибару!", true, null, null);
				}
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_cc_rsc_pa6");
				this.Subject.a8().u.b.a("Трубочисткие камеры. Может быть, тут есть слепая зона...", true, null, null);
			}
			base.a("NextRotation", A_0 + TimeSpan.FromSeconds((double)cuo.a.Next(8, 12)));
		}
		return ej1.b;
	}

	// Token: 0x0200039C RID: 924
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600197B RID: 6523 RVA: 0x00086DD4 File Offset: 0x00084FD4
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000E86 RID: 3718
		public static readonly chm.a a = new chm.a();

		// Token: 0x04000E87 RID: 3719
		public static Func<bool, float> b;
	}
}
