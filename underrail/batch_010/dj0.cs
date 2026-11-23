using System;
using System.Runtime.CompilerServices;

// Token: 0x02000336 RID: 822
[apc("ch_sarine")]
public sealed class dj0 : esk
{
	// Token: 0x06001763 RID: 5987 RVA: 0x000761A8 File Offset: 0x000743A8
	public dj0()
	{
		this.a = new ej0(new Action<ej0>(dj0.a.a.a));
		this.a.a = this.c;
		this.j.a.Insert(0, new arr(this.a, new Func<e1k, bool>(dj0.a.a.a)));
	}

	// Token: 0x04000DEC RID: 3564
	private new ej0 a;

	// Token: 0x02000337 RID: 823
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001766 RID: 5990 RVA: 0x00076250 File Offset: 0x00074450
		internal void a(ej0 A_0)
		{
			A_0.b().g().aa().PersonalAttitudes.Clear();
			A_0.b().g().aa().FactionId = asp.cv;
			new bzv(A_0.b().c().y6()).e();
			eaq eaq = new eaq();
			eaq.b(asp.a);
			eaq.a(asp.cv);
			eaq.a(global::h.c);
			eaq.a(true);
			eaq.ym(null, null, null);
			A_0.b().g().aa().PersonalAttitudes.Remove(asp.a);
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["npc_ch_sarine_incapacitated"] = true;
				if (serviceOrThrow.aqu().v() != null)
				{
					serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.ct);
					serviceOrThrow.aqu().v().PersonalAttitudes.Remove(asp.cv);
				}
			}
			A_0.b().g().aa().StatusEffects.a(new ab3(0), true, false, false);
			bpo.GetServiceOrThrow<d02>().ahs(true, false);
		}

		// Token: 0x06001767 RID: 5991 RVA: 0x000763A0 File Offset: 0x000745A0
		internal bool a(e1k A_0)
		{
			if (A_0.g().aa().SpecialStates.c || A_0.g().aa().SpecialStates.a)
			{
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("ch_rathoundKingsQueenStarted", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("HathorKingSituationResolved", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_rathoundKingDies", new bool?(false)).Value)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000DED RID: 3565
		public static readonly dj0.a a = new dj0.a();

		// Token: 0x04000DEE RID: 3566
		public static Action<ej0> b;

		// Token: 0x04000DEF RID: 3567
		public static Func<e1k, bool> c;
	}
}
