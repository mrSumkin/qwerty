using System;
using TimelapseVertigo.Rules.Characters;

// Token: 0x020017A9 RID: 6057
internal class ah1 : ak9
{
	// Token: 0x06008191 RID: 33169 RVA: 0x00368F44 File Offset: 0x00367144
	public override void ft(out d3e[] A_0, out wq[] A_1, out string A_2)
	{
		A_0 = new d3e[]
		{
			new ax6(BaseAbilityEnum.Strength.ToString(), 1),
			new bhi(0.25, cs5.b)
		};
		A_1 = null;
		A_2 = null;
	}

	// Token: 0x06008192 RID: 33170 RVA: 0x00368F8C File Offset: 0x0036718C
	public override string o6()
	{
		return "DrinkPotion";
	}
}
