using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B79 RID: 7033
[dgg("incendiaryLauncherGrenade")]
public sealed class eqh : cwp
{
	// Token: 0x06009875 RID: 39029 RVA: 0x003B7790 File Offset: 0x003B5990
	public override string bt()
	{
		return "茺Зажигательная граната для гранатомёта";
	}

	// Token: 0x06009876 RID: 39030 RVA: 0x003B7798 File Offset: 0x003B5998
	public override string bu()
	{
		return "incendiaryLauncherGrenade";
	}

	// Token: 0x06009877 RID: 39031 RVA: 0x003B77A0 File Offset: 0x003B59A0
	public override cr1 bv()
	{
		return cr1.d;
	}

	// Token: 0x06009878 RID: 39032 RVA: 0x003B77A4 File Offset: 0x003B59A4
	public override int dq()
	{
		return 3;
	}

	// Token: 0x06009879 RID: 39033 RVA: 0x003B77A8 File Offset: 0x003B59A8
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x0600987A RID: 39034 RVA: 0x003B77AC File Offset: 0x003B59AC
	public eqh()
	{
		base.Slots.Add("case", new cgo(new eh0("case.Grenade_25", 92), "25мм корпус гранаты для гранатомёта", false, 3, 0.1f, false, false, null));
		base.Slots.Add("tnt", new cgo(new eh0("tnt", 11), "Тротил", false, 1, 0.1f, false, false, null));
		base.Slots.Add("napalmC", new cgo(new eh0("Component.NapalmC", 78), "Напалм C", false, 2, 0.2f, false, true, null));
	}

	// Token: 0x0600987B RID: 39035 RVA: 0x003B7850 File Offset: 0x003B5A50
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		if (base.b(A_1))
		{
			string path = "ammo\\xphw\\Grenade_25_Incendiary";
			if (ez2.GetItemDefinition<dgr>(path, true) != null)
			{
				return new dng(ez2.CreateDefinitonProvider<dgr>(path));
			}
		}
		return null;
	}
}
