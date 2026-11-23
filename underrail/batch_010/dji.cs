using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020003DB RID: 987
[fe("fo_olivia")]
public sealed class dji : b5g
{
	// Token: 0x06001A6E RID: 6766 RVA: 0x0008E96C File Offset: 0x0008CB6C
	public dji(bm6 A_0) : base(A_0)
	{
		c96[] array = new c96[1];
		array[0] = new b64("Explode", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(dji.a.a.a), null);
		base.a(array);
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x0008E9D4 File Offset: 0x0008CBD4
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return base.GetGlobalProperty<bool>("loc_fom1_chemistryBoom", false) && !base.GetGlobalProperty<bool>("loc_fom1_oliviaExplodes", false) && aw1.a(this.Subject.a8(), new bt4("olivia_patrol1"), true) && this.Subject.a8().h.b.af() == CharacterState.Operating;
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0008EA48 File Offset: 0x0008CC48
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		c5x c5x = new ar7(new Guid("19303c84-3ea3-452c-ac3a-ffc7884bd402"), this.Subject.a8().Area).ao() as c5x;
		if (c5x != null)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null)
			{
				serviceOrThrow.aqu().r()["loc_fom1_oliviaExplodes"] = true;
				serviceOrThrow.aqu().r()["npc_fo_olivia_murdered"] = true;
				serviceOrThrow.aqu().r()["npc_fo_olivia_exploded"] = true;
				dm5 dm = new dm5();
				dm.s().Add(new a1q(DamageType.Mechanical, 100, 200));
				dm.s().Add(new a1q(DamageType.Heat, 100, 200));
				dm.c(true);
				dm.ym(null, c5x, null);
			}
		}
		return ej1.b;
	}

	// Token: 0x020003DC RID: 988
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A73 RID: 6771 RVA: 0x0008EB40 File Offset: 0x0008CD40
		internal float a(bool A_0)
		{
			return 1000f;
		}

		// Token: 0x04000ED1 RID: 3793
		public static readonly dji.a a = new dji.a();

		// Token: 0x04000ED2 RID: 3794
		public static Func<bool, float> b;
	}
}
