using System;
using System.Collections.Generic;
using TimelapseVertigo.Rules.Crafting;

// Token: 0x02001B8B RID: 7051
[dgg("broadheadBolt")]
public sealed class d7u : cwp
{
	// Token: 0x060098FF RID: 39167 RVA: 0x003BB434 File Offset: 0x003B9634
	public override string bt()
	{
		return "莄Болт с широким наконечником";
	}

	// Token: 0x06009900 RID: 39168 RVA: 0x003BB43C File Offset: 0x003B963C
	public override string bu()
	{
		return "broadheadBolt";
	}

	// Token: 0x06009901 RID: 39169 RVA: 0x003BB444 File Offset: 0x003B9644
	public override cr1 bv()
	{
		return cr1.c;
	}

	// Token: 0x06009902 RID: 39170 RVA: 0x003BB448 File Offset: 0x003B9648
	public override BlueprintCategory bx()
	{
		return BlueprintCategory.Ammo;
	}

	// Token: 0x06009903 RID: 39171 RVA: 0x003BB450 File Offset: 0x003B9650
	public d7u()
	{
		base.Slots.Add(d7u.a, new cgo(new eh0("Ammo.Bolt", 33), "Болт", false, 1, 0.1f, false, false, null));
		base.Slots.Add(d7u.b, new cgo(new eh0("broadheadBoltTip", 95), "Широкий наконечник болта", false, 1, 0.1f, false, false, null));
	}

	// Token: 0x06009904 RID: 39172 RVA: 0x003BB4C4 File Offset: 0x003B96C4
	protected override coh by(efk A_0, Dictionary<string, coh> A_1, out string A_2)
	{
		A_2 = null;
		dng dng = A_1.SafeGet(d7u.a, null);
		fv fv = A_1.SafeGet(d7u.b, null);
		if (dng != null && dng.TypedDefinition != null && fv != null && fv.TypedDefinition != null)
		{
			string path = "ammo\\xpbl\\BroadheadBolt";
			if (ez2.GetItemDefinition<cdk>(path, true) != null)
			{
				return new acz(ez2.CreateDefinitonProvider<cdk>(path));
			}
		}
		return null;
	}

	// Token: 0x04003AA9 RID: 15017
	public new static readonly string a = "bolt";

	// Token: 0x04003AAA RID: 15018
	public new static readonly string b = "broadheadBoltTip";
}
