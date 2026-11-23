using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Characters;

// Token: 0x0200043A RID: 1082
[fe("pir_flinger")]
public sealed class baz : b5g
{
	// Token: 0x06001C50 RID: 7248 RVA: 0x00099DB0 File Offset: 0x00097FB0
	public baz(bm6 A_0) : base(A_0)
	{
		int a_ = base.g().Count - 2;
		List<c96> list = new List<c96>();
		list.Add(new byh("CantSeePlayerInCell", new Func<TimeSpan, double, bool>(this.d), new Func<TimeSpan, double, cst>(this.c), new Func<bool, float>(baz.a.a.b), null)
		{
			e = true
		});
		base.a(a_, list);
		int a_2 = base.g().Count - 2;
		List<c96> list2 = new List<c96>();
		list2.Add(new byh("PlayerHasVisibleWeapon", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, cst>(this.a), new Func<bool, float>(baz.a.a.a), null)
		{
			e = true
		});
		base.a(a_2, list2);
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x00099E98 File Offset: 0x00098098
	[CompilerGenerated]
	private bool d(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_playerThrownInJail", new bool?(false)).Value)
		{
			TimeSpan? primitivePropertyValue = serviceOrThrow.aqu().r().GetPrimitivePropertyValue<TimeSpan>("npc_xpbl_pir_flinger_investigateCellIfCannotSeePlayer_nextMovement", null);
			if (this.Subject.a8().Location.X > 9f && this.Subject.a8().Location.Y > 3f)
			{
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				cnb cnb = new EntityAspectReference<cnb, bim>(this.Subject.a8().Area, new Guid("a5d50f06-2c28-4228-a7e4-13df0ff0dae0")).ao();
				if (c5x != null && !base.h().aa().SpecialStates.c && !base.h().aa().SpecialStates.h)
				{
					if (cnb != null)
					{
						cnb.q();
					}
					new a27(base.h(), c5x.h.b, false, false, false, false);
					blk blk = new bzv(this.Subject.y6()).c(c5x.qe());
					if (blk != null && (!blk.b() || blk.a().f() != cem.d) && blk.f() != global::h.a)
					{
						return primitivePropertyValue == null || primitivePropertyValue <= A_0;
					}
					if (primitivePropertyValue == null || primitivePropertyValue <= A_0)
					{
						List<string> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<string>>("RegularPatrolRoute");
						if (classPropertyValue != null)
						{
							this.Subject.y6()[ddq.k] = classPropertyValue;
							this.Subject.y6()["RegularPatrolRoute"] = null;
							this.Subject.y6()[ddq.ay] = null;
						}
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x0009A0F8 File Offset: 0x000982F8
	[CompilerGenerated]
	private new cst c(TimeSpan A_0, double A_1)
	{
		List<string> classPropertyValue = this.Subject.y6().GetClassPropertyValue<List<string>>(ddq.k);
		if (classPropertyValue != null)
		{
			this.Subject.y6()["RegularPatrolRoute"] = classPropertyValue;
			this.Subject.y6()[ddq.k] = null;
		}
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_xpbl_pir_flinger_investigateCellIfCannotSeePlayer_nextMovement"] = A_0 + TimeSpan.FromSeconds(4.0);
			bt4 classPropertyValue2 = this.Subject.y6().GetClassPropertyValue<bt4>(ddq.ay);
			if (classPropertyValue2 == null || classPropertyValue2.b() == "flinger_professor")
			{
				this.Subject.y6()[ddq.ay] = new bt4("flinger_close");
				if (this.Subject.a8().u.b != null)
				{
					this.Subject.a8().u.b.a("Где ты прячешься?", true, null, null);
				}
			}
			else if (classPropertyValue2.b() == "flinger_close")
			{
				this.Subject.y6()[ddq.ay] = new bt4("flinger_insideCell");
				c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
				string str = "ему";
				if (c5x.h.b != null && c5x.h.b.aa().Gender == Gender.Female)
				{
					str = "ей";
				}
				if (this.Subject.a8().u.b != null)
				{
					this.Subject.a8().u.b.a("Клянусь морем - " + str + " удалось сбежать!", true, null, null);
				}
				return new a27(base.h(), c5x.h.b, false, false, false, false);
			}
		}
		return null;
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x0009A32C File Offset: 0x0009852C
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("event_pir_meeting_playerThrownInJail", new bool?(false)).Value && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().b() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			blk blk = new bzv(this.Subject.y6()).c(serviceOrThrow.aqu().v().b().qe());
			if (blk != null && blk.b() && blk.f() != global::h.a && d3k.a(c5x.h.b.aa()))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x0009A414 File Offset: 0x00098614
	[CompilerGenerated]
	private cst a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			c5x c5x = serviceOrThrow.aqu().v().b() as c5x;
			if (this.Subject.a8().u.b != null)
			{
				this.Subject.a8().u.b.a("Эй! Брось это!", true, null, null);
			}
			return new a27(base.h(), c5x.h.b, false, false, false, true);
		}
		return null;
	}

	// Token: 0x0200043B RID: 1083
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001C57 RID: 7255 RVA: 0x0009A4C8 File Offset: 0x000986C8
		internal float b(bool A_0)
		{
			return 3f;
		}

		// Token: 0x06001C58 RID: 7256 RVA: 0x0009A4D0 File Offset: 0x000986D0
		internal float a(bool A_0)
		{
			return 3f;
		}

		// Token: 0x04000FB9 RID: 4025
		public static readonly baz.a a = new baz.a();

		// Token: 0x04000FBA RID: 4026
		public static Func<bool, float> b;

		// Token: 0x04000FBB RID: 4027
		public static Func<bool, float> c;
	}
}
