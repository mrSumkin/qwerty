using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;

// Token: 0x020003C4 RID: 964
[fe("primeTentacle")]
public class beo : bwv
{
	// Token: 0x06001A25 RID: 6693 RVA: 0x0008CA4C File Offset: 0x0008AC4C
	public override int or()
	{
		return 1000;
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x0008CA54 File Offset: 0x0008AC54
	protected virtual int atx()
	{
		return 10;
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x0008CA58 File Offset: 0x0008AC58
	public beo(bm6 A_0) : base(A_0)
	{
		List<c96> list = new List<c96>();
		list.Add(new byh("comeCloserToPlayer", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(beo.a.a.a), null));
		base.a(list);
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x0008CAC4 File Offset: 0x0008ACC4
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		DateTime? primitivePropertyValue = this.Subject.y6().GetPrimitivePropertyValue<DateTime>("PrimeTentacleInchingCloserCooldownUntil", null);
		if (primitivePropertyValue == null)
		{
			primitivePropertyValue = new DateTime?(DateTime.Now + TimeSpan.FromSeconds(5.0));
			this.Subject.y6()["PrimeTentacleInchingCloserCooldownUntil"] = primitivePropertyValue.Value;
		}
		if (DateTime.Now > primitivePropertyValue.Value)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				if (c5x != null && dan.a(c5x))
				{
					return dan.a(this.Subject, c5x, this.atx()).Count > 0;
				}
			}
		}
		return false;
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x0008CBCC File Offset: 0x0008ADCC
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (c5x != null)
			{
				List<csd> list = dan.a(this.Subject, c5x, this.atx());
				if (list.Count > 0)
				{
					csd csd = list[cuo.a.Next(list.Count)];
					awx awx = new awx(csd.Name);
					awx.a(awx.kh() | (m7.b | m7.k));
					awx.ad().Add(new a4s(new bfq("TentacleDiveIn"), null, new ar7(this.Subject.a8()), null));
					awx.ad().Add(new e4t(base.h(), CharacterState.Custom2, cux.a, 0, null, 1));
					List<auv> list2 = awx.ad();
					ch3 ch = new ch3();
					ch.a(new float?(0f));
					list2.Add(new a4s(ch, null, new ar7(this.Subject.a8()), null));
					List<auv> list3 = awx.ad();
					b16 b = new b16();
					b.a(new int?(0));
					list3.Add(new a4s(b, null, new ar7(this.Subject.a8()), null));
					List<auv> list4 = awx.ad();
					epw epw = new epw();
					epw.a(new CharacterState?(CharacterState.Custom1));
					list4.Add(new a4s(epw, null, new ar7(this.Subject.a8()), null));
					awx.ad().Add(new bm3(500));
					awx.ad().Add(new a8v(this.Subject.a8(), csd.Location));
					awx.ad().Add(new a4s(new akw(), new ar7(this.Subject.a8()), new ar7(c5x), null));
					List<auv> list5 = awx.ad();
					ch3 ch2 = new ch3();
					ch2.a(null);
					list5.Add(new a4s(ch2, null, new ar7(this.Subject.a8()), null));
					awx.ad().Add(new a4s(new bfq("TentacleDiveOut"), null, new ar7(this.Subject.a8()), null));
					awx.ad().Add(new e4t(base.h(), CharacterState.Custom1, cux.a, 0, null, 1));
					List<auv> list6 = awx.ad();
					b16 b2 = new b16();
					b2.a(null);
					list6.Add(new a4s(b2, null, new ar7(this.Subject.a8()), null));
					List<auv> list7 = awx.ad();
					epw epw2 = new epw();
					epw2.a(null);
					list7.Add(new a4s(epw2, null, new ar7(this.Subject.a8()), null));
					this.Subject.y6()["PrimeTentacleInchingCloserCooldownUntil"] = DateTime.Now + TimeSpan.FromSeconds(3.0);
					return awx;
				}
			}
		}
		return null;
	}

	// Token: 0x020003C8 RID: 968
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A38 RID: 6712 RVA: 0x0008D4AC File Offset: 0x0008B6AC
		internal float a(bool A_0)
		{
			if (A_0)
			{
				return float.MaxValue;
			}
			return 2f;
		}

		// Token: 0x04000EBC RID: 3772
		public static readonly beo.a a = new beo.a();

		// Token: 0x04000EBD RID: 3773
		public static Func<bool, float> b;
	}
}
