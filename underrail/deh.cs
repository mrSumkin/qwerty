using System;
using System.Runtime.CompilerServices;
using TimelapseVertigo.Playfield.Locale;
using TimelapseVertigo.Rules.Combat;

// Token: 0x020003D9 RID: 985
[fe("fo_nicolas")]
public sealed class deh : b5g
{
	// Token: 0x06001A68 RID: 6760 RVA: 0x0008E754 File Offset: 0x0008C954
	public deh(bm6 A_0) : base(A_0)
	{
		c96[] array = new c96[1];
		array[0] = new b64("Electrocute", new Func<TimeSpan, double, bool>(this.b), new Func<TimeSpan, double, ej1>(this.a), new Func<bool, float>(deh.a.a.a), null);
		base.a(array);
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x0008E7BC File Offset: 0x0008C9BC
	[CompilerGenerated]
	private bool b(TimeSpan A_0, double A_1)
	{
		return base.GetGlobalProperty<bool>("loc_fo4_consoleSabotaged", false) && !base.GetGlobalProperty<bool>("npc_fo_nicolas_electrocuted", false) && aw1.a(this.Subject.a8(), new bt4("nicolas_patrol1"), true) && this.Subject.a8().h.b.af() == CharacterState.Operating;
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x0008E830 File Offset: 0x0008CA30
	[CompilerGenerated]
	private ej1 a(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["npc_fo_nicolas_murdered"] = true;
			serviceOrThrow.aqu().r()["npc_fo_nicolas_electrocuted"] = true;
			boj.a(this.Subject.a8(), "Electricity", int.MaxValue, 300.0, true, true, null, null, null, null, false);
			new bfq(Guid.NewGuid().ToString(), "Electroshock").ym(null, this.Subject.a8(), null);
			cwt cwt = new cwt();
			cwt.f.Add(new csk(DamageType.Electricity, 1000));
			cwt.b = true;
			cwt.v = "Электрошок";
			base.h().aa().Defense.a(cwt);
		}
		return ej1.b;
	}

	// Token: 0x020003DA RID: 986
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x06001A6D RID: 6765 RVA: 0x0008E960 File Offset: 0x0008CB60
		internal float a(bool A_0)
		{
			return 1000f;
		}

		// Token: 0x04000ECF RID: 3791
		public static readonly deh.a a = new deh.a();

		// Token: 0x04000ED0 RID: 3792
		public static Func<bool, float> b;
	}
}
