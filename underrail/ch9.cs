using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020003C5 RID: 965
[fe("rnd_drunk")]
public sealed class ch9 : b5g
{
	// Token: 0x06001A2A RID: 6698 RVA: 0x0008CF04 File Offset: 0x0008B104
	public ch9(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new b64("Roam", new Func<TimeSpan, double, bool>(ch9.a.a.a), new Func<TimeSpan, double, ej1>(this.c), new Func<bool, float>(ch9.a.a.a), null));
		list.Add(new b64("Sing", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(ch9.a.a.b), null));
		base.a(a_, list);
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x0008CFF4 File Offset: 0x0008B1F4
	[CompilerGenerated]
	private new ej1 c(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			string text = null;
			bt4 classPropertyValue = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue != null)
			{
				text = classPropertyValue.b();
			}
			if (text == null || text == "randomEvent_gc_drnk_pa1")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_gc_drnk_pa2");
			}
			else if (text == "randomEvent_gc_drnk_pa2")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_gc_drnk_pa3");
			}
			else if (text == "randomEvent_gc_drnk_pa3")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_gc_drnk_pa4");
			}
			else if (text == "randomEvent_gc_drnk_pa4")
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_gc_drnk_pa5");
			}
			else
			{
				this.Subject.y6()[ddq.ay] = new bt4("randomEvent_gc_drnk_pa1");
			}
			serviceOrThrow.aqu().r()["npc_rnd_drunk_nextRotation"] = A_0 + TimeSpan.FromSeconds(5.0);
		}
		return ej1.b;
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x0008D15C File Offset: 0x0008B35C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk != null && blk.b() && base.GetCortexProperty<TimeSpan>(ch9.a, default(TimeSpan)) <= A_0)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x0008D210 File Offset: 0x0008B410
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		this.Subject.y6()[ch9.a] = A_0 + TimeSpan.FromSeconds(7.0);
		int num = base.GetCortexProperty<int>(ch9.b, 0);
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			serviceOrThrow.aqu().v().b();
			string[] array = new string[]
			{
				"Же-нщина, дорогая, свет моей ж-жизни...",
				"Почему т-ты покинула меня, уф, по-чему УДАРИЛА меня ножом...",
				"Н-нож предательства... в моё сердце \u0097 смертельный укол...",
				"Я ЛЮБИЛ тебя, женщина, а теперь я, уф, в печали... ::Икает:: п... п... пою...",
				"::Он плачет.::",
				"Ты-ты глупее, ч-чем гнутая Р-РЕЛЬСА... паутина у тебя в голове...",
				"Будто ста-ла... стала... сталакалалктит рас-сплющил, да... каждую клетку ::Икает:: мозга!",
				"ПРОКЛЯТЬЕ на тебя!",
				"::Он снова плачет.::",
				"Зачем т-ты р-разорвала мою душу?..",
				"И с-с-спала с другим м-мужчиной, о... заж-жгла СТРАСТИ искру...",
				"Кто этот червь, э... эта бесхребетная КРЫСА? ::Икает::",
				"Я отрежу его пещерного человечка... посмотрим, к-как УБЛЮДКУ эт-то понравится!",
				"::Пьяно и маниакально смеётся.::",
				"Ни-кто не вправе залазить в пещеру м-моей женщины...",
				"...кроме меня! ::Ухмыляется.::",
				"Вот и найди себе д-другую ::Икает:: бабу, э... женщину... или в АД отправлю тебя! А-А-АРА-А-АГХ!",
				"Но... кого мне винить... если не её?..",
				"Она покинула меня... ::Икает:: хо-хотя я думал, мы будем вместе...",
				"...навсегда...",
				"::Он делает ещё глоток из бутылки, теперь опустошая её.::",
				"Же-нщина, дорогая, свет моей, м-м-м, жизни...",
				"Я всё равно люблю тебя... я...",
				"::Его тошнит, и он заблёвывает всю свою одежду.::",
				"О-о-о-о-о, какого хрена?.. Блин...",
				"Ну че пялишься... свиное рыло, ты? А?",
				"О... О... Та-на-на-на... ::Икает::"
			};
			if (this.Subject.a8().u.b != null)
			{
				this.Subject.a8().u.b.a(array[num], true, null, null);
			}
		}
		if (num < 27)
		{
			num++;
		}
		this.Subject.y6()[ch9.b] = num;
		return ej1.b;
	}

	// Token: 0x04000EB6 RID: 3766
	private new static readonly string a = "NextSingTime";

	// Token: 0x04000EB7 RID: 3767
	private new static readonly string b = "SingIndex";

	// Token: 0x020003C6 RID: 966
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A31 RID: 6705 RVA: 0x0008D41C File Offset: 0x0008B61C
		internal bool a(TimeSpan A_0, double A_1)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_rnd_drunk_nextRotation", null);
				return primitivePropertyValue == null || primitivePropertyValue.Value <= A_0;
			}
			return false;
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0008D478 File Offset: 0x0008B678
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0008D480 File Offset: 0x0008B680
		internal float b(bool A_0)
		{
			return 103f;
		}

		// Token: 0x04000EB8 RID: 3768
		public static readonly ch9.a a = new ch9.a();

		// Token: 0x04000EB9 RID: 3769
		public static Func<TimeSpan, double, bool> b;

		// Token: 0x04000EBA RID: 3770
		public static Func<bool, float> c;

		// Token: 0x04000EBB RID: 3771
		public static Func<bool, float> d;
	}
}
